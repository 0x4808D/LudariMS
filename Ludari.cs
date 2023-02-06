using IniParser;
using PeNet;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace LudariMS
{
    public class ServerEntry
    {
        public string Name;
        public string Ip;
        public bool IsOnline;
    }

    internal static class Ludari
    {
        public static readonly string APP_VERSION = "1.0.0";
        public static string ClientPath = "";

        public static List<ServerEntry> servers = new();

        public static bool IsPatched = false;
        public static bool BGMEnabled = false;

        public static MainWindow? app;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            LoadConfig();

            app = new();

            Task.Run(() =>
            {
                Parallel.ForEach(servers, x =>
                {
                    var ip = x.Ip.Split(':')[0].Trim();
                    var port = x.Ip.Split(":")[1];
                    var isOnline = PingHost(ip, Int32.Parse(port));
                    x.IsOnline = isOnline;
                });

                app.UpdateServerList();
            });

            Application.Run(app);
        }

        static void LoadConfig()
        {
            ClientPath = Properties.Settings.Default.GamePath;

            BGMEnabled = Properties.Settings.Default.BGMEnabled;

            // Load Server List
            var serverList = Properties.Settings.Default.Servers;

            if (serverList is not null)
            {
                foreach (var server in serverList)
                {
                    var split = server.Split(",");
                    ServerEntry entry = new()
                    {
                        Name = split[0],
                        Ip = split[1],
                        IsOnline = false,
                    };
                    servers.Add(entry);
                }
            }

            if (File.Exists($"{ClientPath}/Maple2.dll"))
            {
                IsPatched = true;
            }
        }

        public static void PatchGameFiles()
        {
            if (ClientPath is null || ClientPath.Length == 0)
            {
                MessageBox.Show("Please select an install directory", "LudariMS");
                return;
            }

            RemovePatchedFiles();

            File.Copy("./Maple2.dll", $"{ClientPath}/Maple2.dll", true);
            File.Copy($"{ClientPath}/NxCharacter.dll", $"{ClientPath}/NxCharacter.dll.bak", true);

            var nxCharacterDLL = new PeFile($"{ClientPath}/NxCharacter.dll");
            nxCharacterDLL.AddImport("Maple2.dll", "_DllMain@12");
            File.WriteAllBytes($"{ClientPath}/NxCharacter.dll", nxCharacterDLL.RawFile.ToArray());

            IsPatched = true;
            Properties.Settings.Default.LastPatchTime = (int) DateTimeOffset.Now.ToUnixTimeSeconds();
            Properties.Settings.Default.Save();
        }

        public static void RemovePatchedFiles()
        {
            var maple2Path = $"{ClientPath}/Maple2.dll";
            var maple2IniPath = $"{ClientPath}/maple2.ini";
            var nxCharacterPath = $"{ClientPath}/NxCharacter.dll";

            if (File.Exists(maple2Path))
            {
                File.Delete(maple2Path);
            }

            if (File.Exists(maple2IniPath))
            {
                File.Delete(maple2IniPath);
            }

            if (File.Exists(nxCharacterPath + ".bak"))
            {
                File.Copy($"{ClientPath}/NxCharacter.dll.bak", $"{ClientPath}/NxCharacter.dll", true);
                File.Delete(nxCharacterPath + ".bak");
            }
            IsPatched = false;
        }

        public static void LaunchClient(string selectedIp, string selectedPort)
        {
            if (!IsPatched)
            {
                MessageBox.Show("Please run the patcher before launching.", "LudariMS");
                return;
            }

            var parser = new FileIniDataParser();
            var config = parser.ReadFile("./maple2.ini");

            config["default"]["host"] = selectedIp;
            config["default"]["port"] = selectedPort;

            parser.WriteFile($"{ClientPath}/maple2.ini", config, new UTF8Encoding(false));

            Process.Start($"{ClientPath}/MapleStory2.exe");
        }

        public static void SetClientPath(string clientPath)
        {
            if (IsPatched)
            {
                RemovePatchedFiles();
            }

            ClientPath = clientPath;

            Properties.Settings.Default.GamePath = clientPath;
            Properties.Settings.Default.Save();
        }

        static void SaveServerList()
        {
            StringCollection serverStrings = new StringCollection();

            foreach (var server in servers)
            {
                serverStrings.Add($"{server.Name},{server.Ip}");
            }

            Properties.Settings.Default.Servers = serverStrings;
            Properties.Settings.Default.Save();
            app.UpdateServerList();
        }

        public static void AddServerEntry(string name, string ip)
        {
            var addr = ip.Split(':')[0];
            var port = ip.Split(":")[1];
            var isOnline = PingHost(addr, Int32.Parse(port));
            ServerEntry entry = new()
            {
                Name = name,
                Ip = ip,
                IsOnline = isOnline,
            };
            servers.Add(entry);

            SaveServerList();
        }

        public static void RemoveServerEntry(string name)
        {
            servers.Remove(servers.Find(e => e.Name.Equals(name)));
            SaveServerList();
        }

        public static bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber))
                {
                    client.Close();
                    return true;
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
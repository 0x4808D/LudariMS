using System.Diagnostics;
using System.Drawing.Imaging;

using WMPLib;

namespace LudariMS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = $"LudariMS {Ludari.APP_VERSION}";

            this.loginButton.Enabled = false;
            this.serverList.FullRowSelect = true;
            this.serverList.OwnerDraw = true;
            setLVBack(this.serverList, 155);
            this.serverList.DrawSubItem += new DrawListViewSubItemEventHandler(lv_DrawSubItem);
            this.serverList.DrawItem += new DrawListViewItemEventHandler(lv_DrawItem);

            if (Ludari.ClientPath.Length > 0)
            {
                this.clientPath.Text = Ludari.ClientPath;
            }

            if (Ludari.IsPatched)
            {
                this.patchButton.Enabled = false;
                this.unpatchLink.Enabled = true;
            }

            if (Ludari.BGMEnabled)
            {
                WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

                wplayer.URL = $"./bgm.mp3";
                wplayer.settings.volume = 5;
                wplayer.controls.play();

                wplayer.settings.setMode("loop", true);
            }

            UpdateServerList();
        }

        private void ClientPath_Changed(object sender, EventArgs e) { }

        private void Login_Clicked(object sender, EventArgs e)
        {
            var selectedServer = this.serverList.SelectedItems[0].SubItems[3];
            var ip = selectedServer.Text.Split(':')[0];
            var port = selectedServer.Text.Split(":")[1];
            Ludari.LaunchClient(ip, port);
        }

        private void ClientPathLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var ms2ExePath = this.openFileDialog1.FileName;
            // Remove MapleStory2.exe from the name
            this.clientPath.Text = ms2ExePath[..^16];
            Ludari.SetClientPath(this.clientPath.Text);
        }

        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.serverList.SelectedItems.Count == 0)
            {
                this.loginButton.Enabled = false;
                return;
            }

            this.loginButton.Enabled = true;
        }

        public void UpdateServerList()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => {
                    UpdateServerList();
                }));
                return;
            }

            this.serverList.Items.Clear();
            var servers = Ludari.servers;
            foreach (var server in servers)
            {
                var listItem = new ListViewItem();
                listItem.UseItemStyleForSubItems = false;
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = server.IsOnline ? "Online" : "Offline",
                    ForeColor = server.IsOnline ? Color.Green : Color.Red,
                });
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = server.Name,
                });
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = server.Ip,
                });

                this.serverList.Items.Add(listItem);
            }
        }

        void setLVBack(ListView lv, int alpha)
        {
            Point p1 = lv.Parent.PointToScreen(lv.Location);
            Point p2 = lv.PointToScreen(Point.Empty);
            p2.Offset(-p1.X, -p1.Y);
            if (lv.BackgroundImage != null) lv.BackgroundImage.Dispose();
            lv.Hide();
            Bitmap bmp = new Bitmap(lv.Parent.Width, lv.Parent.Height);
            lv.Parent.DrawToBitmap(bmp, lv.Parent.ClientRectangle);
            Rectangle r = lv.Bounds;
            r.Offset(p2.X, p2.Y);
            bmp = bmp.Clone(r, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            using (SolidBrush br = new SolidBrush(Color.FromArgb(alpha, lv.BackColor)))
            {
                g.FillRectangle(br, lv.ClientRectangle);
            }
            lv.BackgroundImage = bmp;
            lv.Show();
        }

        private void lv_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            int textOffset = 1;

            ListView listView = (ListView)sender;

            // Check if e.Item is selected and the ListView has a focus.
            if (e.Item.Selected)
            {
                TextFormatFlags align;
                switch (listView.Columns[e.ColumnIndex].TextAlign)
                {
                    case HorizontalAlignment.Right:
                        align = TextFormatFlags.Right;
                        textOffset = 2;
                        break;
                    case HorizontalAlignment.Center:
                        align = TextFormatFlags.HorizontalCenter;
                        break;
                    default:
                        align = TextFormatFlags.Left;
                        break;
                }
                Rectangle rowBounds = e.SubItem.Bounds;
                Rectangle labelBounds = e.Item.GetBounds(ItemBoundsPortion.Label);
                int leftMargin = labelBounds.Left - textOffset;
                Rectangle bounds = new Rectangle(rowBounds.Left + leftMargin, rowBounds.Top, e.ColumnIndex == 0 ? labelBounds.Width : (rowBounds.Width - leftMargin - textOffset), rowBounds.Height);
                SolidBrush br = new SolidBrush(Color.FromArgb(128, Color.Black));
                e.Graphics.FillRectangle(br, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, listView.Font, bounds, e.SubItem.ForeColor,
                    align | TextFormatFlags.SingleLine | TextFormatFlags.GlyphOverhangPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.WordEllipsis);
            }
            else
                e.DrawDefault = true;
        }

        private void lv_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            Ludari.PatchGameFiles();
            this.patchButton.Enabled = false;
            this.unpatchLink.Enabled = true;
        }

        private void unpatchLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ludari.RemovePatchedFiles();
            this.patchButton.Enabled = true;
            this.unpatchLink.Enabled = false;
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://github.com/0x4808D/",
                UseShellExecute = true,
            });
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://discord.gg/mABkFFhBuU",
                UseShellExecute = true,
            });
        }

        private void maple2Button_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://mapleme.me/docs/setup/prerequisites",
                UseShellExecute = true,
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddServerForm form = new();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.serverList.SelectedItems.Count == 0)
            {
                return;
            }

            var selected = this.serverList.SelectedItems[0];
            var result = MessageBox.Show("Are you sure you want to remove this server?", "LudariMS", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedServer = this.serverList.SelectedItems[0].SubItems[2].Text;
                Ludari.RemoveServerEntry(selectedServer);
            }
        }
    }
}
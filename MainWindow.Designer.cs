namespace LudariMS
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Item 1", System.Drawing.Color.White, System.Drawing.SystemColors.Desktop, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Offline", System.Drawing.Color.Red, System.Drawing.Color.Black, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "LudariMS"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "play.ludarims2.com:20001")}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Item 2", System.Drawing.Color.White, System.Drawing.SystemColors.Desktop, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Online", System.Drawing.Color.ForestGreen, System.Drawing.Color.Black, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Local"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "localhost:20001")}, -1);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.unpatchLink = new System.Windows.Forms.LinkLabel();
            this.patchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.ListView();
            this.spacer = new System.Windows.Forms.ColumnHeader();
            this.isOnline = new System.Windows.Forms.ColumnHeader();
            this.serverName = new System.Windows.Forms.ColumnHeader();
            this.serverIp = new System.Windows.Forms.ColumnHeader();
            this.clientPathLink = new System.Windows.Forms.LinkLabel();
            this.clientPath = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.githubButton = new System.Windows.Forms.Button();
            this.discordButton = new System.Windows.Forms.Button();
            this.maple2Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.unpatchLink);
            this.splitContainer1.Panel1.Controls.Add(this.patchButton);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.serverList);
            this.splitContainer1.Panel1.Controls.Add(this.clientPathLink);
            this.splitContainer1.Panel1.Controls.Add(this.clientPath);
            this.splitContainer1.Panel1.Controls.Add(this.loginButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 1174;
            this.splitContainer1.TabIndex = 0;
            // 
            // unpatchLink
            // 
            this.unpatchLink.AutoSize = true;
            this.unpatchLink.Location = new System.Drawing.Point(872, 628);
            this.unpatchLink.Name = "unpatchLink";
            this.unpatchLink.Size = new System.Drawing.Size(94, 15);
            this.unpatchLink.TabIndex = 7;
            this.unpatchLink.TabStop = true;
            this.unpatchLink.Text = "Remove Patches";
            this.unpatchLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.unpatchLink_LinkClicked);
            // 
            // patchButton
            // 
            this.patchButton.BackColor = System.Drawing.Color.Gold;
            this.patchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patchButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.patchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton.Location = new System.Drawing.Point(872, 564);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(273, 55);
            this.patchButton.TabIndex = 6;
            this.patchButton.Text = "Patch";
            this.patchButton.UseVisualStyleBackColor = false;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(32, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 35);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(279, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(320, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serverList
            // 
            this.serverList.BackColor = System.Drawing.Color.Black;
            this.serverList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.spacer,
            this.isOnline,
            this.serverName,
            this.serverIp});
            this.serverList.ForeColor = System.Drawing.Color.White;
            this.serverList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.UseItemStyleForSubItems = false;
            this.serverList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.serverList.Location = new System.Drawing.Point(32, 363);
            this.serverList.MultiSelect = false;
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(355, 185);
            this.serverList.TabIndex = 3;
            this.serverList.UseCompatibleStateImageBehavior = false;
            this.serverList.View = System.Windows.Forms.View.Details;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // spacer
            // 
            this.spacer.Width = 0;
            // 
            // isOnline
            // 
            this.isOnline.Text = "Online";
            this.isOnline.Width = 50;
            // 
            // serverName
            // 
            this.serverName.Text = "Name";
            this.serverName.Width = 125;
            // 
            // serverIp
            // 
            this.serverIp.Text = "IP";
            this.serverIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.serverIp.Width = 180;
            // 
            // clientPathLink
            // 
            this.clientPathLink.AutoSize = true;
            this.clientPathLink.Location = new System.Drawing.Point(32, 651);
            this.clientPathLink.Name = "clientPathLink";
            this.clientPathLink.Size = new System.Drawing.Size(157, 15);
            this.clientPathLink.TabIndex = 2;
            this.clientPathLink.TabStop = true;
            this.clientPathLink.Text = "Change MS2 Install Location";
            this.clientPathLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClientPathLink_Clicked);
            // 
            // clientPath
            // 
            this.clientPath.Enabled = false;
            this.clientPath.Location = new System.Drawing.Point(32, 625);
            this.clientPath.Name = "clientPath";
            this.clientPath.Size = new System.Drawing.Size(355, 23);
            this.clientPath.TabIndex = 1;
            this.clientPath.Text = "<none>";
            this.clientPath.TextChanged += new System.EventHandler(this.ClientPath_Changed);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gold;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(32, 564);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(355, 55);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Launch";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.Login_Clicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.githubButton);
            this.flowLayoutPanel1.Controls.Add(this.discordButton);
            this.flowLayoutPanel1.Controls.Add(this.maple2Button);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(79, 636);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // githubButton
            // 
            this.githubButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("githubButton.BackgroundImage")));
            this.githubButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.githubButton.FlatAppearance.BorderSize = 0;
            this.githubButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.githubButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.githubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubButton.Location = new System.Drawing.Point(3, 3);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(74, 68);
            this.githubButton.TabIndex = 0;
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // discordButton
            // 
            this.discordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discordButton.BackgroundImage")));
            this.discordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.discordButton.FlatAppearance.BorderSize = 0;
            this.discordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.discordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.discordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordButton.Location = new System.Drawing.Point(3, 77);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(74, 68);
            this.discordButton.TabIndex = 1;
            this.discordButton.UseVisualStyleBackColor = true;
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // maple2Button
            // 
            this.maple2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maple2Button.BackgroundImage")));
            this.maple2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maple2Button.FlatAppearance.BorderSize = 0;
            this.maple2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.maple2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.maple2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maple2Button.Location = new System.Drawing.Point(3, 151);
            this.maple2Button.Name = "maple2Button";
            this.maple2Button.Size = new System.Drawing.Size(74, 68);
            this.maple2Button.TabIndex = 2;
            this.maple2Button.UseVisualStyleBackColor = true;
            this.maple2Button.Click += new System.EventHandler(this.maple2Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MapleStory2.exe";
            this.openFileDialog1.Filter = "MapleStory2.exe|MapleStory2.exe";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.Window_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox clientPath;
        private Button loginButton;
        private LinkLabel clientPathLink;
        private OpenFileDialog openFileDialog1;
        private ListView serverList;
        private ColumnHeader spacer;
        private ColumnHeader isOnline;
        private ColumnHeader serverName;
        private ColumnHeader serverIp;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button githubButton;
        private Button discordButton;
        private Button maple2Button;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private LinkLabel unpatchLink;
        private Button patchButton;
    }
}
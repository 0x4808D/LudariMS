namespace LudariMS
{
    partial class AddServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addServer = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(12, 27);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(328, 23);
            this.nameInput.TabIndex = 1;
            // 
            // ipInput
            // 
            this.ipInput.Location = new System.Drawing.Point(12, 80);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(222, 23);
            this.ipInput.TabIndex = 2;
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(240, 80);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(100, 23);
            this.portInput.TabIndex = 3;
            this.portInput.Text = "20001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addServer
            // 
            this.addServer.BackColor = System.Drawing.SystemColors.Control;
            this.addServer.Location = new System.Drawing.Point(12, 124);
            this.addServer.Name = "addServer";
            this.addServer.Size = new System.Drawing.Size(100, 33);
            this.addServer.TabIndex = 6;
            this.addServer.Text = "Add Server";
            this.addServer.UseVisualStyleBackColor = false;
            this.addServer.Click += new System.EventHandler(this.addServer_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(240, 124);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 33);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 169);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.ipInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddServerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameInput;
        private TextBox ipInput;
        private TextBox portInput;
        private Label label2;
        private Label label3;
        private Button addServer;
        private Button cancel;
    }
}
namespace NotizenApp
{
    partial class Info
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.active = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeNav = new System.Windows.Forms.Button();
            this.InfoNav = new System.Windows.Forms.Button();
            this.AddNav = new System.Windows.Forms.Button();
            this.DeleteNav = new System.Windows.Forms.Button();
            this.EditNav = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimalizeApp = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HyperLinkGit = new System.Windows.Forms.LinkLabel();
            this.ClassDiagram = new System.Windows.Forms.LinkLabel();
            this.currentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.active);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.HomeNav);
            this.panel1.Controls.Add(this.InfoNav);
            this.panel1.Controls.Add(this.AddNav);
            this.panel1.Controls.Add(this.DeleteNav);
            this.panel1.Controls.Add(this.EditNav);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 686);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // active
            // 
            this.active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.active.Location = new System.Drawing.Point(3, 491);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(24, 69);
            this.active.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 131);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // HomeNav
            // 
            this.HomeNav.FlatAppearance.BorderSize = 0;
            this.HomeNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeNav.ForeColor = System.Drawing.Color.White;
            this.HomeNav.Location = new System.Drawing.Point(-1, 191);
            this.HomeNav.Name = "HomeNav";
            this.HomeNav.Size = new System.Drawing.Size(316, 69);
            this.HomeNav.TabIndex = 14;
            this.HomeNav.Text = "Home";
            this.HomeNav.UseVisualStyleBackColor = true;
            this.HomeNav.Click += new System.EventHandler(this.HomeNav_Click);
            // 
            // InfoNav
            // 
            this.InfoNav.FlatAppearance.BorderSize = 0;
            this.InfoNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.InfoNav.ForeColor = System.Drawing.Color.White;
            this.InfoNav.Location = new System.Drawing.Point(-3, 491);
            this.InfoNav.Name = "InfoNav";
            this.InfoNav.Size = new System.Drawing.Size(316, 69);
            this.InfoNav.TabIndex = 18;
            this.InfoNav.Text = "Info\'s";
            this.InfoNav.UseVisualStyleBackColor = true;
            // 
            // AddNav
            // 
            this.AddNav.FlatAppearance.BorderSize = 0;
            this.AddNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddNav.ForeColor = System.Drawing.Color.White;
            this.AddNav.Location = new System.Drawing.Point(-3, 266);
            this.AddNav.Name = "AddNav";
            this.AddNav.Size = new System.Drawing.Size(316, 69);
            this.AddNav.TabIndex = 15;
            this.AddNav.Text = "Hinzufügen";
            this.AddNav.UseVisualStyleBackColor = true;
            this.AddNav.Click += new System.EventHandler(this.AddNav_Click);
            // 
            // DeleteNav
            // 
            this.DeleteNav.FlatAppearance.BorderSize = 0;
            this.DeleteNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeleteNav.ForeColor = System.Drawing.Color.White;
            this.DeleteNav.Location = new System.Drawing.Point(-3, 416);
            this.DeleteNav.Name = "DeleteNav";
            this.DeleteNav.Size = new System.Drawing.Size(316, 69);
            this.DeleteNav.TabIndex = 17;
            this.DeleteNav.Text = "Löschen";
            this.DeleteNav.UseVisualStyleBackColor = true;
            this.DeleteNav.Click += new System.EventHandler(this.DeleteNav_Click);
            // 
            // EditNav
            // 
            this.EditNav.FlatAppearance.BorderSize = 0;
            this.EditNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EditNav.ForeColor = System.Drawing.Color.White;
            this.EditNav.Location = new System.Drawing.Point(-3, 341);
            this.EditNav.Name = "EditNav";
            this.EditNav.Size = new System.Drawing.Size(316, 69);
            this.EditNav.TabIndex = 16;
            this.EditNav.Text = "Bearbeiten";
            this.EditNav.UseVisualStyleBackColor = true;
            this.EditNav.Click += new System.EventHandler(this.EditNav_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.MinimalizeApp);
            this.panel2.Controls.Add(this.CloseApp);
            this.panel2.Location = new System.Drawing.Point(311, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 64);
            this.panel2.TabIndex = 1;
            // 
            // MinimalizeApp
            // 
            this.MinimalizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.MinimalizeApp.FlatAppearance.BorderSize = 0;
            this.MinimalizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimalizeApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimalizeApp.Location = new System.Drawing.Point(1014, -1);
            this.MinimalizeApp.Name = "MinimalizeApp";
            this.MinimalizeApp.Size = new System.Drawing.Size(76, 64);
            this.MinimalizeApp.TabIndex = 15;
            this.MinimalizeApp.Text = "-";
            this.MinimalizeApp.UseVisualStyleBackColor = false;
            this.MinimalizeApp.Click += new System.EventHandler(this.MinimalizeApp_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseApp.Location = new System.Drawing.Point(1087, -1);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(76, 64);
            this.CloseApp.TabIndex = 14;
            this.CloseApp.Text = "X";
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1156, 350);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // HyperLinkGit
            // 
            this.HyperLinkGit.AutoSize = true;
            this.HyperLinkGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.HyperLinkGit.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HyperLinkGit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.HyperLinkGit.LinkColor = System.Drawing.Color.White;
            this.HyperLinkGit.Location = new System.Drawing.Point(319, 623);
            this.HyperLinkGit.Name = "HyperLinkGit";
            this.HyperLinkGit.Padding = new System.Windows.Forms.Padding(5);
            this.HyperLinkGit.Size = new System.Drawing.Size(89, 35);
            this.HyperLinkGit.TabIndex = 4;
            this.HyperLinkGit.TabStop = true;
            this.HyperLinkGit.Text = "GitHub";
            this.HyperLinkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HyperLinkGit_LinkClicked);
            // 
            // ClassDiagram
            // 
            this.ClassDiagram.AutoSize = true;
            this.ClassDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.ClassDiagram.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassDiagram.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ClassDiagram.LinkColor = System.Drawing.Color.White;
            this.ClassDiagram.Location = new System.Drawing.Point(414, 623);
            this.ClassDiagram.Name = "ClassDiagram";
            this.ClassDiagram.Padding = new System.Windows.Forms.Padding(5);
            this.ClassDiagram.Size = new System.Drawing.Size(194, 35);
            this.ClassDiagram.TabIndex = 5;
            this.ClassDiagram.TabStop = true;
            this.ClassDiagram.Text = "Klassendiagramm";
            this.ClassDiagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClassDiagram_LinkClicked);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentTime.ForeColor = System.Drawing.Color.White;
            this.currentTime.Location = new System.Drawing.Point(1222, 152);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(125, 24);
            this.currentTime.TabIndex = 7;
            this.currentTime.Text = "currentTime";
            this.currentTime.Click += new System.EventHandler(this.currentTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1472, 676);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.ClassDiagram);
            this.Controls.Add(this.HyperLinkGit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel active;
        private PictureBox pictureBox1;
        private Button HomeNav;
        private Button InfoNav;
        private Button AddNav;
        private Button DeleteNav;
        private Button EditNav;
        private Button MinimalizeApp;
        private Button CloseApp;
        private Label label1;
        private LinkLabel HyperLinkGit;
        private LinkLabel ClassDiagram;
        private Label currentTime;
        private System.Windows.Forms.Timer timer1;
    }
}
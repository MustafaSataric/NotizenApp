namespace NotizenApp
{
    partial class Navbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navbar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.active = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoNav = new System.Windows.Forms.Button();
            this.DeleteNav = new System.Windows.Forms.Button();
            this.EditNav = new System.Windows.Forms.Button();
            this.AddNav = new System.Windows.Forms.Button();
            this.HomeNav = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimalizeApp = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.childPanel = new System.Windows.Forms.Panel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.childPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.active);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.InfoNav);
            this.panel1.Controls.Add(this.DeleteNav);
            this.panel1.Controls.Add(this.EditNav);
            this.panel1.Controls.Add(this.AddNav);
            this.panel1.Controls.Add(this.HomeNav);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 686);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // active
            // 
            this.active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.active.Location = new System.Drawing.Point(-1, 191);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(24, 69);
            this.active.TabIndex = 13;
            this.active.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 131);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // InfoNav
            // 
            this.InfoNav.FlatAppearance.BorderSize = 0;
            this.InfoNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.InfoNav.ForeColor = System.Drawing.Color.White;
            this.InfoNav.Location = new System.Drawing.Point(0, 491);
            this.InfoNav.Name = "InfoNav";
            this.InfoNav.Size = new System.Drawing.Size(316, 69);
            this.InfoNav.TabIndex = 11;
            this.InfoNav.Text = "Info\'s";
            this.InfoNav.UseVisualStyleBackColor = true;
            this.InfoNav.Click += new System.EventHandler(this.InfoNav_Click);
            // 
            // DeleteNav
            // 
            this.DeleteNav.FlatAppearance.BorderSize = 0;
            this.DeleteNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeleteNav.ForeColor = System.Drawing.Color.White;
            this.DeleteNav.Location = new System.Drawing.Point(0, 416);
            this.DeleteNav.Name = "DeleteNav";
            this.DeleteNav.Size = new System.Drawing.Size(316, 69);
            this.DeleteNav.TabIndex = 10;
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
            this.EditNav.Location = new System.Drawing.Point(0, 341);
            this.EditNav.Name = "EditNav";
            this.EditNav.Size = new System.Drawing.Size(316, 69);
            this.EditNav.TabIndex = 9;
            this.EditNav.Text = "Bearbeiten";
            this.EditNav.UseVisualStyleBackColor = true;
            this.EditNav.Click += new System.EventHandler(this.EditNav_Click);
            // 
            // AddNav
            // 
            this.AddNav.FlatAppearance.BorderSize = 0;
            this.AddNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddNav.ForeColor = System.Drawing.Color.White;
            this.AddNav.Location = new System.Drawing.Point(0, 266);
            this.AddNav.Name = "AddNav";
            this.AddNav.Size = new System.Drawing.Size(316, 69);
            this.AddNav.TabIndex = 8;
            this.AddNav.Text = "Hinzufügen";
            this.AddNav.UseVisualStyleBackColor = true;
            this.AddNav.Click += new System.EventHandler(this.AddNav_Click);
            // 
            // HomeNav
            // 
            this.HomeNav.FlatAppearance.BorderSize = 0;
            this.HomeNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeNav.ForeColor = System.Drawing.Color.White;
            this.HomeNav.Location = new System.Drawing.Point(0, 191);
            this.HomeNav.Name = "HomeNav";
            this.HomeNav.Size = new System.Drawing.Size(316, 69);
            this.HomeNav.TabIndex = 7;
            this.HomeNav.Text = "Home";
            this.HomeNav.UseVisualStyleBackColor = true;
            this.HomeNav.Click += new System.EventHandler(this.HomeNav_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.MinimalizeApp);
            this.panel2.Controls.Add(this.CloseApp);
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 64);
            this.panel2.TabIndex = 7;
            // 
            // MinimalizeApp
            // 
            this.MinimalizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.MinimalizeApp.FlatAppearance.BorderSize = 0;
            this.MinimalizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimalizeApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimalizeApp.Location = new System.Drawing.Point(1010, 0);
            this.MinimalizeApp.Name = "MinimalizeApp";
            this.MinimalizeApp.Size = new System.Drawing.Size(76, 64);
            this.MinimalizeApp.TabIndex = 13;
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
            this.CloseApp.Location = new System.Drawing.Point(1083, 0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(76, 64);
            this.CloseApp.TabIndex = 12;
            this.CloseApp.Text = "X";
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // childPanel
            // 
            this.childPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.childPanel.Controls.Add(this.currentTimeLabel);
            this.childPanel.Controls.Add(this.label1);
            this.childPanel.Location = new System.Drawing.Point(320, 59);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(1159, 627);
            this.childPanel.TabIndex = 8;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(828, 8);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(68, 25);
            this.currentTimeLabel.TabIndex = 1;
            this.currentTimeLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1043, 550);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // Navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 676);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Navbar";
            this.Text = "Navbar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.childPanel.ResumeLayout(false);
            this.childPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel active;
        private PictureBox pictureBox1;
        private Button InfoNav;
        private Button DeleteNav;
        private Button EditNav;
        private Button AddNav;
        private Button HomeNav;
        private Panel panel2;
        private Button MinimalizeApp;
        private Button CloseApp;
        private Panel childPanel;
        private Label label1;
        private Label currentTimeLabel;
        private System.Windows.Forms.Timer currentTime;
    }
}
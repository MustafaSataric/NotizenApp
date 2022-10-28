namespace NotizenApp
{
    partial class AddEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Thema = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.InfoNav = new System.Windows.Forms.Button();
            this.DeleteNav = new System.Windows.Forms.Button();
            this.EditNav = new System.Windows.Forms.Button();
            this.AddNav = new System.Windows.Forms.Button();
            this.HomeNav = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimalizeApp = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNote
            // 
            this.AddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.AddNote.FlatAppearance.BorderSize = 0;
            this.AddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNote.ForeColor = System.Drawing.Color.White;
            this.AddNote.Location = new System.Drawing.Point(350, 580);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(249, 53);
            this.AddNote.TabIndex = 0;
            this.AddNote.Text = "Notiz hinzufügen";
            this.AddNote.UseVisualStyleBackColor = false;
            this.AddNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // Thema
            // 
            this.Thema.AutoSize = true;
            this.Thema.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thema.ForeColor = System.Drawing.Color.White;
            this.Thema.Location = new System.Drawing.Point(350, 163);
            this.Thema.Name = "Thema";
            this.Thema.Size = new System.Drawing.Size(97, 29);
            this.Thema.TabIndex = 2;
            this.Thema.Text = "Thema:";
            this.Thema.Click += new System.EventHandler(this.Thema_Click);
            // 
            // topic
            // 
            this.topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topic.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topic.ForeColor = System.Drawing.Color.White;
            this.topic.Location = new System.Drawing.Point(350, 195);
            this.topic.Margin = new System.Windows.Forms.Padding(6);
            this.topic.MinimumSize = new System.Drawing.Size(0, 29);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(1050, 29);
            this.topic.TabIndex = 3;
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.note.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.note.ForeColor = System.Drawing.Color.White;
            this.note.Location = new System.Drawing.Point(350, 264);
            this.note.MinimumSize = new System.Drawing.Size(553, 310);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(1050, 310);
            this.note.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(350, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notiz:";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentTime.ForeColor = System.Drawing.Color.White;
            this.currentTime.Location = new System.Drawing.Point(1187, 163);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(125, 24);
            this.currentTime.TabIndex = 6;
            this.currentTime.Text = "currentTime";
            this.currentTime.Click += new System.EventHandler(this.currentTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.InfoNav);
            this.panel1.Controls.Add(this.DeleteNav);
            this.panel1.Controls.Add(this.EditNav);
            this.panel1.Controls.Add(this.AddNav);
            this.panel1.Controls.Add(this.HomeNav);
            this.panel1.Location = new System.Drawing.Point(-23, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 686);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NotizenApp.Properties.Resources.th1;
            this.pictureBox1.Location = new System.Drawing.Point(106, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 139);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.panel3.Location = new System.Drawing.Point(19, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 72);
            this.panel3.TabIndex = 13;
            // 
            // InfoNav
            // 
            this.InfoNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.InfoNav.FlatAppearance.BorderSize = 0;
            this.InfoNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.InfoNav.ForeColor = System.Drawing.Color.White;
            this.InfoNav.Location = new System.Drawing.Point(19, 491);
            this.InfoNav.Name = "InfoNav";
            this.InfoNav.Size = new System.Drawing.Size(297, 69);
            this.InfoNav.TabIndex = 12;
            this.InfoNav.Text = "Info\'s";
            this.InfoNav.UseVisualStyleBackColor = false;
            // 
            // DeleteNav
            // 
            this.DeleteNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.DeleteNav.FlatAppearance.BorderSize = 0;
            this.DeleteNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeleteNav.ForeColor = System.Drawing.Color.White;
            this.DeleteNav.Location = new System.Drawing.Point(19, 416);
            this.DeleteNav.Name = "DeleteNav";
            this.DeleteNav.Size = new System.Drawing.Size(297, 69);
            this.DeleteNav.TabIndex = 11;
            this.DeleteNav.Text = "Löschen";
            this.DeleteNav.UseVisualStyleBackColor = false;
            this.DeleteNav.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditNav
            // 
            this.EditNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.EditNav.FlatAppearance.BorderSize = 0;
            this.EditNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EditNav.ForeColor = System.Drawing.Color.White;
            this.EditNav.Location = new System.Drawing.Point(19, 341);
            this.EditNav.Name = "EditNav";
            this.EditNav.Size = new System.Drawing.Size(297, 69);
            this.EditNav.TabIndex = 10;
            this.EditNav.Text = "Bearbeiten";
            this.EditNav.UseVisualStyleBackColor = false;
            this.EditNav.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddNav
            // 
            this.AddNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.AddNav.FlatAppearance.BorderSize = 0;
            this.AddNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddNav.ForeColor = System.Drawing.Color.White;
            this.AddNav.Location = new System.Drawing.Point(19, 266);
            this.AddNav.Name = "AddNav";
            this.AddNav.Size = new System.Drawing.Size(297, 69);
            this.AddNav.TabIndex = 9;
            this.AddNav.Text = "Hinzufügen";
            this.AddNav.UseVisualStyleBackColor = false;
            // 
            // HomeNav
            // 
            this.HomeNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.HomeNav.FlatAppearance.BorderSize = 0;
            this.HomeNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeNav.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeNav.ForeColor = System.Drawing.Color.White;
            this.HomeNav.Location = new System.Drawing.Point(19, 191);
            this.HomeNav.Name = "HomeNav";
            this.HomeNav.Size = new System.Drawing.Size(297, 69);
            this.HomeNav.TabIndex = 8;
            this.HomeNav.Text = "Home";
            this.HomeNav.UseVisualStyleBackColor = false;
            this.HomeNav.Click += new System.EventHandler(this.HomeNav_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.MinimalizeApp);
            this.panel2.Controls.Add(this.CloseApp);
            this.panel2.Location = new System.Drawing.Point(292, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 64);
            this.panel2.TabIndex = 8;
            // 
            // MinimalizeApp
            // 
            this.MinimalizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.MinimalizeApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimalizeApp.FlatAppearance.BorderSize = 0;
            this.MinimalizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimalizeApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimalizeApp.Location = new System.Drawing.Point(1034, 0);
            this.MinimalizeApp.Name = "MinimalizeApp";
            this.MinimalizeApp.Size = new System.Drawing.Size(74, 64);
            this.MinimalizeApp.TabIndex = 1;
            this.MinimalizeApp.Text = "-";
            this.MinimalizeApp.UseVisualStyleBackColor = false;
            this.MinimalizeApp.Click += new System.EventHandler(this.button7_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.CloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseApp.Location = new System.Drawing.Point(1108, 0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(74, 64);
            this.CloseApp.TabIndex = 0;
            this.CloseApp.Text = "X";
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.button6_Click);
            // 
            // AddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1472, 676);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.Thema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEntry";
            this.Text = "Notizen-App © Mustafa Sataric";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddNote;
        private Label label1;
        private Label Thema;
        private TextBox topic;
        private TextBox note;
        private Label label2;
        private Label currentTime;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Button InfoNav;
        private Button DeleteNav;
        private Button EditNav;
        private Button AddNav;
        private Button HomeNav;
        private Panel panel2;
        private Button CloseApp;
        private Button MinimalizeApp;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}
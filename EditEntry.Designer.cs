namespace NotizenApp
{
    partial class EditEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEntry));
            this.allNotes = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.ChangeNote = new System.Windows.Forms.Button();
            this.DeleteNote = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // allNotes
            // 
            this.allNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.allNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allNotes.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allNotes.ForeColor = System.Drawing.Color.White;
            this.allNotes.FormattingEnabled = true;
            this.allNotes.ItemHeight = 25;
            this.allNotes.Location = new System.Drawing.Point(327, 148);
            this.allNotes.Name = "allNotes";
            this.allNotes.Size = new System.Drawing.Size(523, 475);
            this.allNotes.TabIndex = 0;
            this.allNotes.SelectedIndexChanged += new System.EventHandler(this.allNotes_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(856, 148);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(581, 26);
            this.title.TabIndex = 1;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Note.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Note.ForeColor = System.Drawing.Color.White;
            this.Note.Location = new System.Drawing.Point(856, 218);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(581, 350);
            this.Note.TabIndex = 2;
            this.Note.TextChanged += new System.EventHandler(this.note_TextChanged);
            // 
            // ChangeNote
            // 
            this.ChangeNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ChangeNote.FlatAppearance.BorderSize = 0;
            this.ChangeNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeNote.ForeColor = System.Drawing.Color.White;
            this.ChangeNote.Location = new System.Drawing.Point(856, 574);
            this.ChangeNote.Name = "ChangeNote";
            this.ChangeNote.Size = new System.Drawing.Size(171, 49);
            this.ChangeNote.TabIndex = 3;
            this.ChangeNote.Text = "Bearbeiten";
            this.ChangeNote.UseVisualStyleBackColor = false;
            this.ChangeNote.Click += new System.EventHandler(this.changeNote_Click);
            // 
            // DeleteNote
            // 
            this.DeleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.DeleteNote.FlatAppearance.BorderSize = 0;
            this.DeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteNote.ForeColor = System.Drawing.Color.White;
            this.DeleteNote.Location = new System.Drawing.Point(1033, 574);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(171, 49);
            this.DeleteNote.TabIndex = 4;
            this.DeleteNote.Text = "Löschen";
            this.DeleteNote.UseVisualStyleBackColor = false;
            this.DeleteNote.Click += new System.EventHandler(this.delete_Click);
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
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 686);
            this.panel1.TabIndex = 5;
            // 
            // active
            // 
            this.active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.active.Location = new System.Drawing.Point(3, 191);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(24, 69);
            this.active.TabIndex = 13;
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
            this.DeleteNav.Click += new System.EventHandler(this.button4_Click);
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
            this.EditNav.Click += new System.EventHandler(this.button3_Click);
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
            this.AddNav.Click += new System.EventHandler(this.button2_Click);
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
            this.panel2.Location = new System.Drawing.Point(316, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 64);
            this.panel2.TabIndex = 6;
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
            this.CloseApp.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thema:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(467, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Notiz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(597, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(856, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thema:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(856, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Notiz:";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentTime.ForeColor = System.Drawing.Color.White;
            this.currentTime.Location = new System.Drawing.Point(1221, 116);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(81, 24);
            this.currentTime.TabIndex = 12;
            this.currentTime.Text = "Thema:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1472, 676);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteNote);
            this.Controls.Add(this.ChangeNote);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.title);
            this.Controls.Add(this.allNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditEntry";
            this.Text = "Abrufen";
            this.Load += new System.EventHandler(this.Abrufen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox allNotes;
        private TextBox title;
        private TextBox Note;
        private Button ChangeNote;
        private Button DeleteNote;
        private Panel panel1;
        private Panel panel2;
        private Button HomeNav;
        private PictureBox pictureBox1;
        private Button InfoNav;
        private Button DeleteNav;
        private Button EditNav;
        private Button AddNav;
        private Button MinimalizeApp;
        private Button CloseApp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label currentTime;
        private System.Windows.Forms.Timer timer1;
        private Panel active;
    }
}
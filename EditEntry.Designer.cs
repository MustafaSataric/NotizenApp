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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
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
            this.allNotes.Location = new System.Drawing.Point(21, 56);
            this.allNotes.Name = "allNotes";
            this.allNotes.Size = new System.Drawing.Size(523, 525);
            this.allNotes.TabIndex = 0;
            this.allNotes.SelectedIndexChanged += new System.EventHandler(this.allNotes_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(550, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(581, 26);
            this.title.TabIndex = 1;
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Note.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Note.ForeColor = System.Drawing.Color.White;
            this.Note.Location = new System.Drawing.Point(550, 115);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(581, 411);
            this.Note.TabIndex = 2;
            // 
            // ChangeNote
            // 
            this.ChangeNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ChangeNote.FlatAppearance.BorderSize = 0;
            this.ChangeNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeNote.ForeColor = System.Drawing.Color.White;
            this.ChangeNote.Location = new System.Drawing.Point(550, 532);
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
            this.DeleteNote.Location = new System.Drawing.Point(727, 532);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(171, 49);
            this.DeleteNote.TabIndex = 4;
            this.DeleteNote.Text = "Löschen";
            this.DeleteNote.UseVisualStyleBackColor = false;
            this.DeleteNote.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 24);
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
            this.label3.Location = new System.Drawing.Point(327, 24);
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
            this.label4.Location = new System.Drawing.Point(550, 24);
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
            this.label5.Location = new System.Drawing.Point(550, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Notiz:";
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(828, 24);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(68, 25);
            this.currentTimeLabel.TabIndex = 12;
            this.currentTimeLabel.Text = "label6";
            // 
            // EditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1158, 588);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox allNotes;
        private TextBox title;
        private TextBox Note;
        private Button ChangeNote;
        private Button DeleteNote;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer currentTime;
        private Label currentTimeLabel;
    }
}
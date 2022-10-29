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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEntry));
            this.AddNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Thema = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNote
            // 
            this.AddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.AddNote.FlatAppearance.BorderSize = 0;
            this.AddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNote.ForeColor = System.Drawing.Color.White;
            this.AddNote.Location = new System.Drawing.Point(12, 455);
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
            this.Thema.Location = new System.Drawing.Point(12, 28);
            this.Thema.Name = "Thema";
            this.Thema.Size = new System.Drawing.Size(97, 29);
            this.Thema.TabIndex = 2;
            this.Thema.Text = "Thema:";
            // 
            // topic
            // 
            this.topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topic.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topic.ForeColor = System.Drawing.Color.White;
            this.topic.Location = new System.Drawing.Point(15, 63);
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
            this.note.Location = new System.Drawing.Point(15, 139);
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
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notiz:";
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(828, 8);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(68, 25);
            this.currentTimeLabel.TabIndex = 6;
            this.currentTimeLabel.Text = "label3";
            // 
            // AddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1099, 541);
            this.ControlBox = false;
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.Thema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEntry";
            this.Text = "Notizen-App © Mustafa Sataric";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Timer currentTime;
        private Label currentTimeLabel;
    }
}
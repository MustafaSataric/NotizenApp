namespace NotizenApp
{
    partial class Show
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
            this.allNotes = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // allNotes
            // 
            this.allNotes.FormattingEnabled = true;
            this.allNotes.ItemHeight = 25;
            this.allNotes.Location = new System.Drawing.Point(86, 25);
            this.allNotes.Name = "allNotes";
            this.allNotes.Size = new System.Drawing.Size(581, 354);
            this.allNotes.TabIndex = 0;
            this.allNotes.SelectedIndexChanged += new System.EventHandler(this.allNotes_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(86, 451);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(581, 31);
            this.title.TabIndex = 1;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(86, 508);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(581, 191);
            this.note.TabIndex = 2;
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 766);
            this.Controls.Add(this.note);
            this.Controls.Add(this.title);
            this.Controls.Add(this.allNotes);
            this.Name = "Show";
            this.Text = "Abrufen";
            this.Load += new System.EventHandler(this.Abrufen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox allNotes;
        private TextBox title;
        private TextBox note;
    }
}
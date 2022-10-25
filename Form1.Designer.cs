namespace NotizenApp
{
    partial class Form1
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
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Thema = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(25, 447);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(184, 34);
            this.add.TabIndex = 0;
            this.add.Text = "Notiz hinzufügen";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
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
            this.Thema.Location = new System.Drawing.Point(30, 32);
            this.Thema.Name = "Thema";
            this.Thema.Size = new System.Drawing.Size(69, 25);
            this.Thema.TabIndex = 2;
            this.Thema.Text = "Thema:";
            this.Thema.Click += new System.EventHandler(this.Thema_Click);
            // 
            // topic
            // 
            this.topic.Location = new System.Drawing.Point(25, 60);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(553, 31);
            this.topic.TabIndex = 3;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(25, 131);
            this.note.MinimumSize = new System.Drawing.Size(553, 310);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(553, 310);
            this.note.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notiz:";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(473, 18);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(105, 25);
            this.currentTime.TabIndex = 6;
            this.currentTime.Text = "currentTime";
            this.currentTime.Click += new System.EventHandler(this.currentTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 564);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.Thema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Notizen-App © Mustafa Sataric";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add;
        private Label label1;
        private Label Thema;
        private TextBox topic;
        private TextBox note;
        private Label label2;
        private Label currentTime;
        private System.Windows.Forms.Timer timer1;
    }
}
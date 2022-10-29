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
            this.label1 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.openGitHub = new System.Windows.Forms.Button();
            this.OpenDiagram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1124, 350);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
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
            this.currentTimeLabel.Text = "label2";
            // 
            // openGitHub
            // 
            this.openGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.openGitHub.FlatAppearance.BorderSize = 0;
            this.openGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGitHub.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openGitHub.ForeColor = System.Drawing.Color.White;
            this.openGitHub.Location = new System.Drawing.Point(12, 564);
            this.openGitHub.Name = "openGitHub";
            this.openGitHub.Size = new System.Drawing.Size(89, 34);
            this.openGitHub.TabIndex = 7;
            this.openGitHub.Text = "GitHub";
            this.openGitHub.UseVisualStyleBackColor = false;
            this.openGitHub.Click += new System.EventHandler(this.openGitHub_Click);
            // 
            // OpenDiagram
            // 
            this.OpenDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.OpenDiagram.FlatAppearance.BorderSize = 0;
            this.OpenDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDiagram.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenDiagram.ForeColor = System.Drawing.Color.White;
            this.OpenDiagram.Location = new System.Drawing.Point(107, 564);
            this.OpenDiagram.Name = "OpenDiagram";
            this.OpenDiagram.Size = new System.Drawing.Size(194, 34);
            this.OpenDiagram.TabIndex = 8;
            this.OpenDiagram.Text = "Klassendiagramm";
            this.OpenDiagram.UseVisualStyleBackColor = false;
            this.OpenDiagram.Click += new System.EventHandler(this.OpenDiagram_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1221, 610);
            this.Controls.Add(this.OpenDiagram);
            this.Controls.Add(this.openGitHub);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer currentTime;
        private Label currentTimeLabel;
        private Button openGitHub;
        private Button OpenDiagram;
    }
}
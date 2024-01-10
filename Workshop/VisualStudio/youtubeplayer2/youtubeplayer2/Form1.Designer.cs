
namespace youtubeplayer2
{
    partial class Form1
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
            this.textVDOLink = new System.Windows.Forms.TextBox();
            this.bntPlay = new System.Windows.Forms.Button();
            this.webVDO = new System.Windows.Forms.WebBrowser();
            this.VDOLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textVDOLink
            // 
            this.textVDOLink.Location = new System.Drawing.Point(107, 31);
            this.textVDOLink.Name = "textVDOLink";
            this.textVDOLink.Size = new System.Drawing.Size(550, 20);
            this.textVDOLink.TabIndex = 0;
            // 
            // bntPlay
            // 
            this.bntPlay.Location = new System.Drawing.Point(684, 29);
            this.bntPlay.Name = "bntPlay";
            this.bntPlay.Size = new System.Drawing.Size(75, 23);
            this.bntPlay.TabIndex = 1;
            this.bntPlay.Text = "Play";
            this.bntPlay.UseVisualStyleBackColor = true;
            this.bntPlay.Click += new System.EventHandler(this.bntPlay_Click);
            // 
            // webVDO
            // 
            this.webVDO.Location = new System.Drawing.Point(37, 68);
            this.webVDO.MinimumSize = new System.Drawing.Size(20, 20);
            this.webVDO.Name = "webVDO";
            this.webVDO.Size = new System.Drawing.Size(733, 342);
            this.webVDO.TabIndex = 2;
            // 
            // VDOLink
            // 
            this.VDOLink.AutoSize = true;
            this.VDOLink.Location = new System.Drawing.Point(48, 34);
            this.VDOLink.Name = "VDOLink";
            this.VDOLink.Size = new System.Drawing.Size(53, 13);
            this.VDOLink.TabIndex = 3;
            this.VDOLink.Text = "VDO Link";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VDOLink);
            this.Controls.Add(this.webVDO);
            this.Controls.Add(this.bntPlay);
            this.Controls.Add(this.textVDOLink);
            this.Name = "Form1";
            this.Text = "YoutubePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textVDOLink;
        private System.Windows.Forms.Button bntPlay;
        private System.Windows.Forms.WebBrowser webVDO;
        private System.Windows.Forms.Label VDOLink;
    }
}


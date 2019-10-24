namespace _Separina
{
    partial class Chek
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
            this.rtbChk = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbChk
            // 
            this.rtbChk.Location = new System.Drawing.Point(12, 24);
            this.rtbChk.Name = "rtbChk";
            this.rtbChk.Size = new System.Drawing.Size(293, 296);
            this.rtbChk.TabIndex = 0;
            this.rtbChk.Text = "";
            this.rtbChk.TextChanged += new System.EventHandler(this.rtbChk_TextChanged);
            // 
            // Chek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 558);
            this.Controls.Add(this.rtbChk);
            this.Name = "Chek";
            this.Text = "Chek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chek_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbChk;
    }
}
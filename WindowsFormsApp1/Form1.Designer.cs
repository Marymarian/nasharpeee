namespace WindowsFormsApp1
{
    partial class Separina
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTemplates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTemplates
            // 
            this.cbTemplates.FormattingEnabled = true;
            this.cbTemplates.Location = new System.Drawing.Point(20, 63);
            this.cbTemplates.Name = "cbTemplates";
            this.cbTemplates.Size = new System.Drawing.Size(245, 21);
            this.cbTemplates.TabIndex = 0;
            this.cbTemplates.SelectedIndexChanged += new System.EventHandler(this.cbTemplates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список шаблонов";
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Options.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tabletka;
            this.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Options.Location = new System.Drawing.Point(304, 90);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(59, 50);
            this.Options.TabIndex = 20;
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlay.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Play1;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Location = new System.Drawing.Point(304, 52);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbTemplates
            // 
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.Location = new System.Drawing.Point(20, 144);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(245, 186);
            this.lbTemplates.TabIndex = 21;
            this.lbTemplates.SelectedIndexChanged += new System.EventHandler(this.lbTemplates_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Правила вставки";
            // 
            // Separina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTemplates);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTemplates);
            this.Name = "Separina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.Label label2;
    }
}


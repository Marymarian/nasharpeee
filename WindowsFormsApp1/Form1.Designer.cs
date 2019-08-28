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
            this.rtbTemplate = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btInsertTemplate = new System.Windows.Forms.Button();
            this.tbTemplateName = new System.Windows.Forms.TextBox();
            this.tbTemplateSeparator = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTemplates
            // 
            this.cbTemplates.FormattingEnabled = true;
            this.cbTemplates.Location = new System.Drawing.Point(50, 63);
            this.cbTemplates.Name = "cbTemplates";
            this.cbTemplates.Size = new System.Drawing.Size(245, 21);
            this.cbTemplates.TabIndex = 0;
            this.cbTemplates.SelectedIndexChanged += new System.EventHandler(this.cbTemplates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список шаблонов";
            // 
            // rtbTemplate
            // 
            this.rtbTemplate.Location = new System.Drawing.Point(50, 198);
            this.rtbTemplate.Name = "rtbTemplate";
            this.rtbTemplate.Size = new System.Drawing.Size(344, 88);
            this.rtbTemplate.TabIndex = 13;
            this.rtbTemplate.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Шаблон";
            // 
            // btInsertTemplate
            // 
            this.btInsertTemplate.Location = new System.Drawing.Point(319, 288);
            this.btInsertTemplate.Name = "btInsertTemplate";
            this.btInsertTemplate.Size = new System.Drawing.Size(75, 23);
            this.btInsertTemplate.TabIndex = 15;
            this.btInsertTemplate.Text = "Добавить";
            this.btInsertTemplate.UseVisualStyleBackColor = true;
            this.btInsertTemplate.Click += new System.EventHandler(this.btInsertTemplate_Click);
            // 
            // tbTemplateName
            // 
            this.tbTemplateName.Location = new System.Drawing.Point(50, 159);
            this.tbTemplateName.Name = "tbTemplateName";
            this.tbTemplateName.Size = new System.Drawing.Size(124, 20);
            this.tbTemplateName.TabIndex = 16;
            // 
            // tbTemplateSeparator
            // 
            this.tbTemplateSeparator.Location = new System.Drawing.Point(195, 159);
            this.tbTemplateSeparator.Name = "tbTemplateSeparator";
            this.tbTemplateSeparator.Size = new System.Drawing.Size(100, 20);
            this.tbTemplateSeparator.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Название шаблона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Разделитель";
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Play1;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Location = new System.Drawing.Point(327, 44);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Separina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTemplateSeparator);
            this.Controls.Add(this.tbTemplateName);
            this.Controls.Add(this.btInsertTemplate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTemplates);
            this.Name = "Separina";
            this.Text = "Separina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbTemplate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btInsertTemplate;
        private System.Windows.Forms.TextBox tbTemplateName;
        private System.Windows.Forms.TextBox tbTemplateSeparator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPlay;
    }
}


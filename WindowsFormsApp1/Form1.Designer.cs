namespace WindowsFormsApp1
{
    partial class Form1
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.YO = new System.Windows.Forms.Button();
            this.rtbTemplate = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btInsertTemplate = new System.Windows.Forms.Button();
            this.tbTemplateName = new System.Windows.Forms.TextBox();
            this.tbTemplateSeparator = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(482, 73);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(230, 20);
            this.TB1.TabIndex = 2;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(482, 125);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(229, 20);
            this.TB2.TabIndex = 3;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(482, 171);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(227, 20);
            this.TB3.TabIndex = 4;
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(482, 239);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(136, 20);
            this.TB4.TabIndex = 5;
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(482, 281);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(136, 20);
            this.TB5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // YO
            // 
            this.YO.Location = new System.Drawing.Point(482, 371);
            this.YO.Name = "YO";
            this.YO.Size = new System.Drawing.Size(91, 50);
            this.YO.TabIndex = 12;
            this.YO.Text = "YO";
            this.YO.UseVisualStyleBackColor = true;
            this.YO.Click += new System.EventHandler(this.YO_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTemplateSeparator);
            this.Controls.Add(this.tbTemplateName);
            this.Controls.Add(this.btInsertTemplate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbTemplate);
            this.Controls.Add(this.YO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTemplates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button YO;
        private System.Windows.Forms.RichTextBox rtbTemplate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btInsertTemplate;
        private System.Windows.Forms.TextBox tbTemplateName;
        private System.Windows.Forms.TextBox tbTemplateSeparator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}


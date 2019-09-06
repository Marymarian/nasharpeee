namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTemplateSeparator = new System.Windows.Forms.TextBox();
            this.tbTemplateName = new System.Windows.Forms.TextBox();
            this.btInsertTemplate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbTemplate = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Разделитель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, -55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Название шаблона";
            // 
            // tbTemplateSeparator
            // 
            this.tbTemplateSeparator.Location = new System.Drawing.Point(273, 19);
            this.tbTemplateSeparator.Name = "tbTemplateSeparator";
            this.tbTemplateSeparator.Size = new System.Drawing.Size(100, 20);
            this.tbTemplateSeparator.TabIndex = 1;
            // 
            // tbTemplateName
            // 
            this.tbTemplateName.Location = new System.Drawing.Point(64, 19);
            this.tbTemplateName.Name = "tbTemplateName";
            this.tbTemplateName.Size = new System.Drawing.Size(124, 20);
            this.tbTemplateName.TabIndex = 0;
            // 
            // btInsertTemplate
            // 
            this.btInsertTemplate.Location = new System.Drawing.Point(298, 104);
            this.btInsertTemplate.Name = "btInsertTemplate";
            this.btInsertTemplate.Size = new System.Drawing.Size(75, 23);
            this.btInsertTemplate.TabIndex = 3;
            this.btInsertTemplate.Text = "Добавить";
            this.btInsertTemplate.UseVisualStyleBackColor = true;
            this.btInsertTemplate.Click += new System.EventHandler(this.btInsertTemplate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Шаблон";
            // 
            // rtbTemplate
            // 
            this.rtbTemplate.Location = new System.Drawing.Point(15, 45);
            this.rtbTemplate.Name = "rtbTemplate";
            this.rtbTemplate.Size = new System.Drawing.Size(358, 53);
            this.rtbTemplate.TabIndex = 2;
            this.rtbTemplate.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbTemplate);
            this.groupBox1.Controls.Add(this.tbTemplateSeparator);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btInsertTemplate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbTemplateName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(-3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание правила вставки данных в форму";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 140);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTemplateSeparator;
        private System.Windows.Forms.TextBox tbTemplateName;
        private System.Windows.Forms.Button btInsertTemplate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbTemplate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
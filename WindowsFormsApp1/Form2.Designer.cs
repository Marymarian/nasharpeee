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
            this.tbDataTemplName = new System.Windows.Forms.TextBox();
            this.btCreateDateTemplate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 25);
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
            this.tbTemplateSeparator.Location = new System.Drawing.Point(259, 39);
            this.tbTemplateSeparator.Name = "tbTemplateSeparator";
            this.tbTemplateSeparator.Size = new System.Drawing.Size(100, 20);
            this.tbTemplateSeparator.TabIndex = 2;
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
            this.btInsertTemplate.Location = new System.Drawing.Point(284, 104);
            this.btInsertTemplate.Name = "btInsertTemplate";
            this.btInsertTemplate.Size = new System.Drawing.Size(75, 23);
            this.btInsertTemplate.TabIndex = 2;
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
            this.rtbTemplate.Size = new System.Drawing.Size(344, 53);
            this.rtbTemplate.TabIndex = 1;
            this.rtbTemplate.Text = "";
            // 
            // tbDataTemplName
            // 
            this.tbDataTemplName.Location = new System.Drawing.Point(15, 39);
            this.tbDataTemplName.Name = "tbDataTemplName";
            this.tbDataTemplName.Size = new System.Drawing.Size(238, 20);
            this.tbDataTemplName.TabIndex = 1;
            // 
            // btCreateDateTemplate
            // 
            this.btCreateDateTemplate.Location = new System.Drawing.Point(284, 65);
            this.btCreateDateTemplate.Name = "btCreateDateTemplate";
            this.btCreateDateTemplate.Size = new System.Drawing.Size(75, 23);
            this.btCreateDateTemplate.TabIndex = 3;
            this.btCreateDateTemplate.Text = "Создать";
            this.btCreateDateTemplate.UseVisualStyleBackColor = true;
            this.btCreateDateTemplate.Click += new System.EventHandler(this.btCreateDateTemplate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbTemplate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btInsertTemplate);
            this.groupBox1.Controls.Add(this.tbTemplateName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(-3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание правила вставки данных в форму";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTemplateSeparator);
            this.groupBox2.Controls.Add(this.tbDataTemplName);
            this.groupBox2.Controls.Add(this.btCreateDateTemplate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(-3, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание шаблона разбора данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Название";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox tbDataTemplName;
        private System.Windows.Forms.Button btCreateDateTemplate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}
namespace _Separina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Separina));
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.NotifyTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.clbTemplates = new System.Windows.Forms.CheckedListBox();
            this.chek = new System.Windows.Forms.Button();
            this.instruction = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTemplates
            // 
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.Location = new System.Drawing.Point(5, 52);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(245, 186);
            this.lbTemplates.TabIndex = 21;
            this.lbTemplates.SelectedIndexChanged += new System.EventHandler(this.lbTemplates_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Правила вставки";
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.Location = new System.Drawing.Point(2, 9);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(0, 13);
            this.labVersion.TabIndex = 23;
            // 
            // NotifyTray
            // 
            this.NotifyTray.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyTray.Icon")));
            this.NotifyTray.Text = "Ваша Сепарина :)";
            this.NotifyTray.Visible = true;
            // 
            // clbTemplates
            // 
            this.clbTemplates.FormattingEnabled = true;
            this.clbTemplates.Location = new System.Drawing.Point(5, 51);
            this.clbTemplates.Name = "clbTemplates";
            this.clbTemplates.Size = new System.Drawing.Size(245, 184);
            this.clbTemplates.TabIndex = 24;
            this.clbTemplates.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbTemplates_ItemCheck);
            this.clbTemplates.SelectedIndexChanged += new System.EventHandler(this.clbTemplates_SelectedIndexChanged);
            // 
            // chek
            // 
            this.chek.BackgroundImage = global::_Separina.Properties.Resources.проверка;
            this.chek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chek.Location = new System.Drawing.Point(195, 244);
            this.chek.Name = "chek";
            this.chek.Size = new System.Drawing.Size(55, 68);
            this.chek.TabIndex = 26;
            this.chek.UseVisualStyleBackColor = true;
            this.chek.Click += new System.EventHandler(this.chek_Click);
            // 
            // instruction
            // 
            this.instruction.BackgroundImage = global::_Separina.Properties.Resources.вопрос;
            this.instruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.instruction.Location = new System.Drawing.Point(135, 244);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(54, 68);
            this.instruction.TabIndex = 25;
            this.instruction.UseVisualStyleBackColor = true;
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Options.BackgroundImage = global::_Separina.Properties.Resources.окна;
            this.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Options.Location = new System.Drawing.Point(68, 244);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(51, 68);
            this.Options.TabIndex = 20;
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlay.BackgroundImage = global::_Separina.Properties.Resources.Play2;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(5, 244);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 68);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Separina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 324);
            this.Controls.Add(this.chek);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.clbTemplates);
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTemplates);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Separina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labVersion;
        private System.Windows.Forms.NotifyIcon NotifyTray;
        private System.Windows.Forms.CheckedListBox clbTemplates;
        private System.Windows.Forms.Button instruction;
        private System.Windows.Forms.Button chek;
    }
}


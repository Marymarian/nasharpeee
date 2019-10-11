namespace Separina
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
            this.Options = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.NotifyTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.clbTemplates = new System.Windows.Forms.CheckedListBox();
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
            // Options
            // 
            this.Options.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Options.BackgroundImage = global::Separina.Properties.Resources.icons8_настройка_вида_50;
            this.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Options.Location = new System.Drawing.Point(43, 244);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(32, 32);
            this.Options.TabIndex = 20;
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlay.BackgroundImage = global::Separina.Properties.Resources.Play1;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Location = new System.Drawing.Point(5, 244);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
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
            // 
            // Separina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 324);
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
    }
}


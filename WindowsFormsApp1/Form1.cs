using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Separina
{
    public partial class Separina : Form
    {
        public Separina()
        {
            InitializeComponent();
        }

        KeyBoardHook Hooker = new KeyBoardHook();
        Rules rules = new Rules();
        
        private void YO_Click(object sender, EventArgs e)
        {
            //Если в буфере обмен содержится текст
            if (Clipboard.ContainsText() == true)
            {
                //Извлекаем (точнее копируем) его и сохраняем в переменную
                string strT = Clipboard.GetText();
                string[] PromArr = strT.Split('>');
                //do
                    
                //    TB1.Text = [0];
                //while (strT == "\n");
                ////Выводим показываем сообщение с текстом, скопированным из буфера обмена
                //MessageBox.Show(this, strT, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
            }
        
            else
            {
                //Выводим сообщение о том, что в буфере обмена нет текста
                MessageBox.Show(this, "В буфере обмена нет текста", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                labVersion.Text = "ver." + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch
            {
                labVersion.Text = "ver.?.?.?.?";
            }
            Clipboard.SetText ("Пётр||Валентир|01.12.89|М");
            rules = Rules.Deserialise;
            lbTemplates.Items.AddRange(rules.templates.ToArray());            
            
        }
        public Template set_newtemplate
        {
            set { lbTemplates.Items.Add(value); }
        }
        public List<Template> update_template
            {
            set
            { lbTemplates.Items.Clear();
                lbTemplates.Items.AddRange(value.ToArray());
            }

            }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hooker.Unhook();
        }
        

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Hooker.Play)
            {                                 
                Hooker.Unhook();
                btnPlay.BackgroundImage = Properties.Resources.Play1;
            }
            else
            {
                if (Hooker.template == null)
                {
                    MessageBox.Show("Не выбрано правило!", "ОЙ!");
                    return;
                }                
                Hooker.SetHook();
                btnPlay.BackgroundImage = Properties.Resources.Stop1;
            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 options = new Form2();
            options.rules = rules;
            options.Owner = this; 
            options.Show();
            options.Activate(); 

            
        }

        private void lbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTemplates.SelectedItem == null)
                return;
            Template template = (Template)lbTemplates.SelectedItem;
            Hooker.template = template;
        }
    }
}

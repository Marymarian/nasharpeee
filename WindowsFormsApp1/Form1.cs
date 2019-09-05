using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Separina : Form
    {
        public Separina()
        {
            InitializeComponent();
        }

        KeyBoardHook Hooker = new KeyBoardHook();
        Rules rules = new Rules();
        DataParse dataTemplates = new DataParse();

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
            Clipboard.SetText ("Пётр>Сергеевич>Валентир>01.12.89>М");
            rules = Rules.Deserialise;
            lbTemplates.Items.AddRange(rules.templates.ToArray());
            dataTemplates = DataParse.Deserialise;
            cbTemplates.Items.AddRange(dataTemplates.templates.ToArray());
            
        }
        public Template set_newtemplate
        {
            set { lbTemplates.Items.Add(value); }
        }
        public DataSeparateTemplate set_NewDataTemplate
        {
            set { cbTemplates.Items.Add(value); }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hooker.Unhook();
        }

       

        private void cbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemplates.SelectedItem == null)
                return;
            Template template = (Template)cbTemplates.SelectedItem;
            Hooker.template = template;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Hooker.Play)
            {
                Hooker.Unhook();
                btnPlay.BackgroundImage = WindowsFormsApp1.Properties.Resources.Play1;
            }
            else
            {
                Hooker.SetHook();
                btnPlay.BackgroundImage = WindowsFormsApp1.Properties.Resources.Stop1;
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

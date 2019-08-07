using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Clipboard.SetText ("Пётр>Сергеевич>Валентир>01.12.89>М>Северная верфь");
            rules = Rules.Deserialise;
            cbTemplates.Items.AddRange(rules.templates.ToArray());
            Hooker.SetHook();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hooker.Unhook();
        }

        private void btInsertTemplate_Click(object sender, EventArgs e)
        {
            if(tbTemplateName.Text.Trim().Length>0 && tbTemplateSeparator.Text.Length>0)
                if (rtbTemplate.Text.Trim().Length > 0)
                {
                    Template template = new Template();
                    template.Name = tbTemplateName.Text.Trim();
                    template.Separator = tbTemplateSeparator.Text;
                    template.TemplateRow = rtbTemplate.Text;
                    string[] Parts = template.TemplateRow.Split(new string[] {template.Separator},StringSplitOptions.None);
                    template.Rule = new List<string>(Parts);
                    rules.templates.Add(template);
                    cbTemplates.Items.Add(template);
                    Rules.Serialise(rules);
                }
        }
    }
}

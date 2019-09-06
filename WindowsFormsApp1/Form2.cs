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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Rules rules { get; set; }
        public DataParse DataTemplate { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btInsertTemplate_Click(object sender, EventArgs e)
        {
            if (tbTemplateName.Text.Trim().Length > 0 )
                if (rtbTemplate.Text.Trim().Length > 0)
                {
                    Template template = new Template();
                    template.Name = tbTemplateName.Text.Trim();
                    template.TemplateRow = rtbTemplate.Text;
                    template.Separator = "<";
                    string[] Parts = template.TemplateRow.Split(new string[] { template.Separator }, StringSplitOptions.None);
                    template.Rule = new List<string>(Parts);
                    rules.templates.Add(template);
                    ((Separina)Owner).set_newtemplate = template;
                    Rules.Serialise(rules);
                }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void btCreateDateTemplate_Click(object sender, EventArgs e)
        {
            string Name = tbDataTemplName.Text.Trim();
            string Separator = tbTemplateSeparator.Text;
            if (Name.Length>0 && Separator.Length > 0)
            {
                DataSeparateTemplate NewOne = new DataSeparateTemplate(Name,Separator);
                DataTemplate.templates.Add(NewOne);
                ((Separina)Owner).set_NewDataTemplate = NewOne;
                DataParse.Serialise(DataTemplate);
            }
        }
    }
}

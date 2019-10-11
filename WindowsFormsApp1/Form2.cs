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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Rules rules { get; set; }
        private static string NewItem = "Новый шаблон";
        bool indicator = true;
        bool Indicator
        {
            get { return indicator; }
            set
            {
                indicator = value;
                if (value)
                {
                    btInsertTemplate.Text = "Добавить";
                }
                else
                {
                    btInsertTemplate.Text = "Обновить";
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            fillShablons();
        }

        private void fillShablons()
        {
            cbShablons.Items.Clear();
            cbShablons.Items.Add(NewItem);
            cbShablons.Items.AddRange(rules.templates.ToArray());
            cbShablons.SelectedIndex = 0;
        }

        private void btInsertTemplate_Click(object sender, EventArgs e)
        {
            if (tbTemplateName.Text.Trim().Length > 0 )
                if (rtbTemplate.Text.Trim().Length > 0)
                {
                    if (Indicator)
                    {
                        Template template = new Template();
                        template.Name = tbTemplateName.Text.Trim();
                        template.TemplateRow = rtbTemplate.Text;
                        template.Separator = tbTemplateSeparator.Text;
                        string[] Parts = template.TemplateRow.Split(new string[] { ">","<" }, StringSplitOptions.None);
                        template.Rule = new List<string>(Parts);
                        rules.templates.Add(template);
                        ((Separina)Owner).set_newtemplate = template;
                        Rules.Serialise(rules);
                    }
                    else
                    {
                     Template temp = (Template)cbShablons.SelectedItem;
                        temp.Name = tbTemplateName.Text.Trim();
                        temp.TemplateRow = rtbTemplate.Text;
                        temp.Separator = tbTemplateSeparator.Text;
                        string[] Parts = temp.TemplateRow.Split(new string[] { ">","<" }, StringSplitOptions.None);
                        temp.Rule= new List<string>(Parts);
                        ((Separina)Owner).update_template = rules.templates;
                        Rules.Serialise(rules);
                    }
                }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbShablons.SelectedItem != null && cbShablons.SelectedIndex != 0)
            {
                rules.templates.RemoveAt(cbShablons.SelectedIndex - 1);
                fillShablons();
                Rules.Serialise(rules);
                ((Separina)Owner).update_template = rules.templates;
            }
        }

        private void cbShablons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShablons.SelectedItem is Template)
            {
                Template temp = (Template)cbShablons.SelectedItem;
                Indicator = false;
                tbTemplateName.Text = temp.Name;
                tbTemplateSeparator.Text = temp.Separator;
                rtbTemplate.Text = temp.TemplateRow;
            }
            else
                Indicator = true;
        }
    }
}

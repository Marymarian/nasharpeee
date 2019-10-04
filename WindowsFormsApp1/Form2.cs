﻿using System;
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
        private void Form2_Load(object sender, EventArgs e)
        {
            fillShablons();
        }

        private void fillShablons()
        {
            cbShablons.Items.Clear();
            cbShablons.Items.Add("Новый шаблон");
            cbShablons.Items.AddRange(rules.templates.ToArray());
            cbShablons.SelectedIndex = 0;
        }

        private void btInsertTemplate_Click(object sender, EventArgs e)
        {
            if (tbTemplateName.Text.Trim().Length > 0 )
                if (rtbTemplate.Text.Trim().Length > 0)
                {
                    Template template = new Template();
                    template.Name = tbTemplateName.Text.Trim();
                    template.TemplateRow = rtbTemplate.Text;
                    template.Separator = tbTemplateSeparator.Text;
                    string[] Parts = template.TemplateRow.Split(new string[] { ">" }, StringSplitOptions.None);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbShablons.SelectedItem != null && cbShablons.SelectedIndex != 0)
            {
                rules.templates.RemoveAt(cbShablons.SelectedIndex - 1);
                fillShablons();
                Rules.Serialise(rules);
            }
        }
    }
}

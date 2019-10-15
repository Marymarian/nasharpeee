using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace _Separina
{
    public partial class Separina : Form
    {
        public Separina()
        {
            InitializeComponent();
            NotifyTray.Visible = false;
            NotifyTray.MouseClick += NotifyTray_MouseDoubleClick;
            Resize += Separina_Resize;

        }

        private void Separina_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                NotifyTray.Visible = true;
            }
        }

        private void NotifyTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            NotifyTray.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        KeyBoardHook Hooker = new KeyBoardHook();
        Rules rules = new Rules();

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
            
            rules = Rules.Deserialise;
            lbTemplates.Items.AddRange(rules.templates.ToArray());
            clbTemplates.Items.AddRange(rules.templates.ToArray());
        }
        
        public Template set_newtemplate
        {
            set
            {
                lbTemplates.Items.Add(value);
                clbTemplates.Items.Add(value);
            }
        }
        public List<Template> update_template
        {
            set
            {
                lbTemplates.Items.Clear();
                lbTemplates.Items.AddRange(value.ToArray());
                clbTemplates.Items.Clear();
                clbTemplates.Items.AddRange(value.ToArray());
            }

        }

        public void Fill_clb()
        {
            foreach (Template Templ in rules.templates)
            {
                if (Templ.VIPRule)
                    clbTemplates.Items.Insert(0, Templ);
                else
                    clbTemplates.Items.Add(Templ);
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
                btnPlay.BackgroundImage = Properties.Resources.Play2;
            }
            else
            {
                if (Hooker.template== null)
                {
                    MessageBox.Show("Не выбрано правило!", "ОЙ!");
                    return;
                }
                Hooker.SetHook();
                btnPlay.BackgroundImage = Properties.Resources.стоп;
                Hooker.MainForm = this;
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

        private void clbTemplates_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            rules.templates[e.Index].VIPRule = e.NewValue == CheckState.Checked;
            Rules.Serialise(rules);
        }

        private void clbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbTemplates.SelectedItem == null)
                return;
            Template template = (Template)clbTemplates.SelectedItem;
            Hooker.template = template;
        }

        private void instruction_Click(object sender, EventArgs e)
        {
            Hide();
            instruction ins = new instruction();
            ins.Owner = this;
            ins.Show();
            ins.Activate();
        }

        private void chek_Click(object sender, EventArgs e)
        {
            Hide();
            Chek chek = new Chek();
            chek.Owner = this;
            chek.Show();
            chek.Activate();
        }
    }
}

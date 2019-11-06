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
    public partial class Chek : Form
    {
        public Chek()
        {
            InitializeComponent();
        }

        private void Chek_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        public string TemplateTest(string Data, Template template)
        {
            StringBuilder Result = new StringBuilder();
            string[] DataParts = Data.Split(new string[] { template.Separator }, StringSplitOptions.None);
            int Index = 0;
            Result.Append(DataParts[Index - 1]);
            return Result.ToString();
        }
        //rtbChk.Text = TemplateTest(string Data, List<string> Rule);

    }

}

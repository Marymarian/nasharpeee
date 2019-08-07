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

        private void YO_Click(object sender, EventArgs e)
        {
            //Если в буфере обмен содержится текст
            if (Clipboard.ContainsText() == true)
            {
                //Извлекаем (точнее копируем) его и сохраняем в переменную
                string strT = Clipboard.GetText();
                do
                    
                    TB1.Text = strT.Split('>')[0];
                while (strT == "\n");
                ////Выводим показываем сообщение с текстом, скопированным из буфера обмена
                //MessageBox.Show(this, strT, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
            }
        
            else
            {
                //Выводим сообщение о том, что в буфере обмена нет текста
                MessageBox.Show(this, "В буфере обмена нет текста", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

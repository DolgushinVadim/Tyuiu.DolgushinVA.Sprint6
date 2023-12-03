using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DolgushinVA.Sprint6.Task0.V8.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_DVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_DVA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_DVA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Oшибкa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_DVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_DVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выволнил студент группы ИИП6-23-3 Долгушин Вадим", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

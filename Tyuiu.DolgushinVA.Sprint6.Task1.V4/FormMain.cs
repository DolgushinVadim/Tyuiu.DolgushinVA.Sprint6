using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DolgushinVA.Sprint6.Task1.V4.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_DVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_DVA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DVA.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_DVA.Text = "";
                textBoxResult_DVA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_DVA.AppendText("|     x     |    f(x)   |" + Environment.NewLine);
                textBoxResult_DVA.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    int currentStep = startStep + i;
                    string strLine = String.Format("|{0,5:d}      |  {1,6:f2}   | ", currentStep, valueArray[i]);
                    textBoxResult_DVA.AppendText(strLine + Environment.NewLine);
                }

                textBoxResult_DVA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИП6-23-3 Долгушин Вадим Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

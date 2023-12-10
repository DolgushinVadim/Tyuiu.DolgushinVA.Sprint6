using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.DolgushinVA.Sprint6.Task6.V18.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonDone_DVA_Click(object sender, EventArgs e)
        {
            textBoxResult_DVA.Text = ds.CollectTextFromFile(openFilePath);
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DVA.ShowDialog();
            openFilePath = openFileDialogTask_DVA.FileName;
            textBoxLoadFromFile_DVA.Text = File.ReadAllText(openFilePath);
            groupBoxDataInput_DVA.Text = groupBoxDataInput_DVA.Text + " " + openFileDialogTask_DVA.FileName;
            buttonDone_DVA.Enabled = true;
        }
    }
}

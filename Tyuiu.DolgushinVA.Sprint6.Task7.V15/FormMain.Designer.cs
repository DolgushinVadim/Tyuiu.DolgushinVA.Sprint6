
namespace Tyuiu.DolgushinVA.Sprint6.Task7.V15
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_DVA = new System.Windows.Forms.Panel();
            this.buttonHelp_DVA = new System.Windows.Forms.Button();
            this.buttonSaveFile_DVA = new System.Windows.Forms.Button();
            this.buttonDone_DVA = new System.Windows.Forms.Button();
            this.buttonOpenFile_DVA = new System.Windows.Forms.Button();
            this.groupBoxTask_DVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DVA = new System.Windows.Forms.TextBox();
            this.panelLeft_DVA = new System.Windows.Forms.Panel();
            this.groupBoxDataInput_DVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_DVA = new System.Windows.Forms.DataGridView();
            this.panelRight_DVA = new System.Windows.Forms.Panel();
            this.groupBoxDataOutput_DVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_DVA = new System.Windows.Forms.DataGridView();
            this.splitter_DVA = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_DVA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_DVA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_DVA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_DVA.SuspendLayout();
            this.groupBoxTask_DVA.SuspendLayout();
            this.panelLeft_DVA.SuspendLayout();
            this.groupBoxDataInput_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DVA)).BeginInit();
            this.panelRight_DVA.SuspendLayout();
            this.groupBoxDataOutput_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_DVA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_DVA
            // 
            this.panelTop_DVA.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop_DVA.Controls.Add(this.buttonHelp_DVA);
            this.panelTop_DVA.Controls.Add(this.buttonSaveFile_DVA);
            this.panelTop_DVA.Controls.Add(this.buttonDone_DVA);
            this.panelTop_DVA.Controls.Add(this.buttonOpenFile_DVA);
            this.panelTop_DVA.Controls.Add(this.groupBoxTask_DVA);
            this.panelTop_DVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_DVA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_DVA.Name = "panelTop_DVA";
            this.panelTop_DVA.Size = new System.Drawing.Size(1390, 194);
            this.panelTop_DVA.TabIndex = 0;
            // 
            // buttonHelp_DVA
            // 
            this.buttonHelp_DVA.Image = global::Tyuiu.DolgushinVA.Sprint6.Task7.V15.Properties.Resources.help;
            this.buttonHelp_DVA.Location = new System.Drawing.Point(454, 12);
            this.buttonHelp_DVA.Name = "buttonHelp_DVA";
            this.buttonHelp_DVA.Size = new System.Drawing.Size(115, 80);
            this.buttonHelp_DVA.TabIndex = 4;
            this.toolTipButton_DVA.SetToolTip(this.buttonHelp_DVA, "Справка");
            this.buttonHelp_DVA.UseVisualStyleBackColor = true;
            this.buttonHelp_DVA.Click += new System.EventHandler(this.buttonHelp_DVA_Click);
            // 
            // buttonSaveFile_DVA
            // 
            this.buttonSaveFile_DVA.Enabled = false;
            this.buttonSaveFile_DVA.Image = global::Tyuiu.DolgushinVA.Sprint6.Task7.V15.Properties.Resources.page_save;
            this.buttonSaveFile_DVA.Location = new System.Drawing.Point(305, 12);
            this.buttonSaveFile_DVA.Name = "buttonSaveFile_DVA";
            this.buttonSaveFile_DVA.Size = new System.Drawing.Size(115, 80);
            this.buttonSaveFile_DVA.TabIndex = 3;
            this.toolTipButton_DVA.SetToolTip(this.buttonSaveFile_DVA, "Сохранить файл");
            this.buttonSaveFile_DVA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_DVA.Click += new System.EventHandler(this.buttonSaveFile_DVA_Click);
            // 
            // buttonDone_DVA
            // 
            this.buttonDone_DVA.Enabled = false;
            this.buttonDone_DVA.Image = global::Tyuiu.DolgushinVA.Sprint6.Task7.V15.Properties.Resources.application_go;
            this.buttonDone_DVA.Location = new System.Drawing.Point(158, 12);
            this.buttonDone_DVA.Name = "buttonDone_DVA";
            this.buttonDone_DVA.Size = new System.Drawing.Size(115, 80);
            this.buttonDone_DVA.TabIndex = 2;
            this.toolTipButton_DVA.SetToolTip(this.buttonDone_DVA, "Выполнить");
            this.buttonDone_DVA.UseVisualStyleBackColor = true;
            this.buttonDone_DVA.Click += new System.EventHandler(this.buttonDone_DVA_Click);
            // 
            // buttonOpenFile_DVA
            // 
            this.buttonOpenFile_DVA.Image = global::Tyuiu.DolgushinVA.Sprint6.Task7.V15.Properties.Resources.folder_page;
            this.buttonOpenFile_DVA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_DVA.Name = "buttonOpenFile_DVA";
            this.buttonOpenFile_DVA.Size = new System.Drawing.Size(115, 80);
            this.buttonOpenFile_DVA.TabIndex = 1;
            this.toolTipButton_DVA.SetToolTip(this.buttonOpenFile_DVA, "Открыть файл");
            this.buttonOpenFile_DVA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DVA.Click += new System.EventHandler(this.buttonOpenFile_DVA_Click);
            // 
            // groupBoxTask_DVA
            // 
            this.groupBoxTask_DVA.Controls.Add(this.textBoxTask_DVA);
            this.groupBoxTask_DVA.Location = new System.Drawing.Point(12, 89);
            this.groupBoxTask_DVA.Name = "groupBoxTask_DVA";
            this.groupBoxTask_DVA.Size = new System.Drawing.Size(1378, 87);
            this.groupBoxTask_DVA.TabIndex = 0;
            this.groupBoxTask_DVA.TabStop = false;
            this.groupBoxTask_DVA.Text = "Условие:";
            // 
            // textBoxTask_DVA
            // 
            this.textBoxTask_DVA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTask_DVA.Location = new System.Drawing.Point(3, 15);
            this.textBoxTask_DVA.Multiline = true;
            this.textBoxTask_DVA.Name = "textBoxTask_DVA";
            this.textBoxTask_DVA.ReadOnly = true;
            this.textBoxTask_DVA.Size = new System.Drawing.Size(1372, 69);
            this.textBoxTask_DVA.TabIndex = 0;
            this.textBoxTask_DVA.Text = resources.GetString("textBoxTask_DVA.Text");
            // 
            // panelLeft_DVA
            // 
            this.panelLeft_DVA.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_DVA.Controls.Add(this.groupBoxDataInput_DVA);
            this.panelLeft_DVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_DVA.Location = new System.Drawing.Point(0, 194);
            this.panelLeft_DVA.Name = "panelLeft_DVA";
            this.panelLeft_DVA.Size = new System.Drawing.Size(1017, 404);
            this.panelLeft_DVA.TabIndex = 1;
            // 
            // groupBoxDataInput_DVA
            // 
            this.groupBoxDataInput_DVA.Controls.Add(this.dataGridViewInMatrix_DVA);
            this.groupBoxDataInput_DVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxDataInput_DVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataInput_DVA.Name = "groupBoxDataInput_DVA";
            this.groupBoxDataInput_DVA.Size = new System.Drawing.Size(1017, 404);
            this.groupBoxDataInput_DVA.TabIndex = 0;
            this.groupBoxDataInput_DVA.TabStop = false;
            this.groupBoxDataInput_DVA.Text = "Ввод данных:";
            // 
            // dataGridViewInMatrix_DVA
            // 
            this.dataGridViewInMatrix_DVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_DVA.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_DVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInMatrix_DVA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInMatrix_DVA.Name = "dataGridViewInMatrix_DVA";
            this.dataGridViewInMatrix_DVA.RowHeadersVisible = false;
            this.dataGridViewInMatrix_DVA.RowHeadersWidth = 51;
            this.dataGridViewInMatrix_DVA.RowTemplate.Height = 24;
            this.dataGridViewInMatrix_DVA.Size = new System.Drawing.Size(1011, 383);
            this.dataGridViewInMatrix_DVA.TabIndex = 0;
            // 
            // panelRight_DVA
            // 
            this.panelRight_DVA.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight_DVA.Controls.Add(this.groupBoxDataOutput_DVA);
            this.panelRight_DVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_DVA.Location = new System.Drawing.Point(1017, 194);
            this.panelRight_DVA.Name = "panelRight_DVA";
            this.panelRight_DVA.Size = new System.Drawing.Size(373, 404);
            this.panelRight_DVA.TabIndex = 2;
            // 
            // groupBoxDataOutput_DVA
            // 
            this.groupBoxDataOutput_DVA.Controls.Add(this.dataGridViewOutMatrix_DVA);
            this.groupBoxDataOutput_DVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOutput_DVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOutput_DVA.Name = "groupBoxDataOutput_DVA";
            this.groupBoxDataOutput_DVA.Size = new System.Drawing.Size(373, 404);
            this.groupBoxDataOutput_DVA.TabIndex = 0;
            this.groupBoxDataOutput_DVA.TabStop = false;
            this.groupBoxDataOutput_DVA.Text = "Вывод данных:";
            // 
            // dataGridViewOutMatrix_DVA
            // 
            this.dataGridViewOutMatrix_DVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_DVA.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_DVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_DVA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutMatrix_DVA.Name = "dataGridViewOutMatrix_DVA";
            this.dataGridViewOutMatrix_DVA.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_DVA.RowHeadersWidth = 51;
            this.dataGridViewOutMatrix_DVA.RowTemplate.Height = 24;
            this.dataGridViewOutMatrix_DVA.Size = new System.Drawing.Size(367, 383);
            this.dataGridViewOutMatrix_DVA.TabIndex = 0;
            // 
            // splitter_DVA
            // 
            this.splitter_DVA.Location = new System.Drawing.Point(1017, 194);
            this.splitter_DVA.Name = "splitter_DVA";
            this.splitter_DVA.Size = new System.Drawing.Size(10, 404);
            this.splitter_DVA.TabIndex = 3;
            this.splitter_DVA.TabStop = false;
            // 
            // openFileDialogTask_DVA
            // 
            this.openFileDialogTask_DVA.FileName = "openFileDialog1";
            // 
            // toolTipButton_DVA
            // 
            this.toolTipButton_DVA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_DVA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 598);
            this.Controls.Add(this.splitter_DVA);
            this.Controls.Add(this.panelRight_DVA);
            this.Controls.Add(this.panelLeft_DVA);
            this.Controls.Add(this.panelTop_DVA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 15 | Долгушин В. А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.PerformLayout();
            this.panelLeft_DVA.ResumeLayout(false);
            this.groupBoxDataInput_DVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DVA)).EndInit();
            this.panelRight_DVA.ResumeLayout(false);
            this.groupBoxDataOutput_DVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_DVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_DVA;
        private System.Windows.Forms.Panel panelLeft_DVA;
        private System.Windows.Forms.Panel panelRight_DVA;
        private System.Windows.Forms.Splitter splitter_DVA;
        private System.Windows.Forms.GroupBox groupBoxTask_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_DVA;
        private System.Windows.Forms.TextBox textBoxTask_DVA;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_DVA;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_DVA;
        private System.Windows.Forms.Button buttonSaveFile_DVA;
        private System.Windows.Forms.Button buttonDone_DVA;
        private System.Windows.Forms.Button buttonOpenFile_DVA;
        private System.Windows.Forms.Button buttonHelp_DVA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DVA;
        private System.Windows.Forms.ToolTip toolTipButton_DVA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_DVA;
    }
}


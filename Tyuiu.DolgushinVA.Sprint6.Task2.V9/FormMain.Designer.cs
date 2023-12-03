
namespace Tyuiu.DolgushinVA.Sprint6.Task2.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_DVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxDataInput_DVA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_DVA = new System.Windows.Forms.Label();
            this.textBoxStopStep_DVA = new System.Windows.Forms.TextBox();
            this.labelStartStep_DVA = new System.Windows.Forms.Label();
            this.textBoxStartStep_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutput_DVA = new System.Windows.Forms.GroupBox();
            this.chartFunction_DVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_DVA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_DVA = new System.Windows.Forms.Label();
            this.buttonDone_DVA = new System.Windows.Forms.Button();
            this.buttonHelp_DVA = new System.Windows.Forms.Button();
            this.pictureBoxFormula_DVA = new System.Windows.Forms.PictureBox();
            this.groupBoxTask_DVA.SuspendLayout();
            this.groupBoxDataInput_DVA.SuspendLayout();
            this.groupBoxDataOutput_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DVA
            // 
            this.groupBoxTask_DVA.Controls.Add(this.pictureBoxFormula_DVA);
            this.groupBoxTask_DVA.Controls.Add(this.textBoxTask_DVA);
            this.groupBoxTask_DVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DVA.Name = "groupBoxTask_DVA";
            this.groupBoxTask_DVA.Size = new System.Drawing.Size(553, 344);
            this.groupBoxTask_DVA.TabIndex = 0;
            this.groupBoxTask_DVA.TabStop = false;
            this.groupBoxTask_DVA.Text = "Условие:";
            // 
            // textBoxTask_DVA
            // 
            this.textBoxTask_DVA.Location = new System.Drawing.Point(0, 21);
            this.textBoxTask_DVA.Multiline = true;
            this.textBoxTask_DVA.Name = "textBoxTask_DVA";
            this.textBoxTask_DVA.ReadOnly = true;
            this.textBoxTask_DVA.Size = new System.Drawing.Size(547, 323);
            this.textBoxTask_DVA.TabIndex = 0;
            this.textBoxTask_DVA.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // groupBoxDataInput_DVA
            // 
            this.groupBoxDataInput_DVA.Controls.Add(this.labelStopStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.textBoxStopStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.labelStartStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.textBoxStartStep_DVA);
            this.groupBoxDataInput_DVA.Location = new System.Drawing.Point(12, 362);
            this.groupBoxDataInput_DVA.Name = "groupBoxDataInput_DVA";
            this.groupBoxDataInput_DVA.Size = new System.Drawing.Size(271, 76);
            this.groupBoxDataInput_DVA.TabIndex = 1;
            this.groupBoxDataInput_DVA.TabStop = false;
            this.groupBoxDataInput_DVA.Text = "Ввод данных:";
            // 
            // labelStopStep_DVA
            // 
            this.labelStopStep_DVA.AutoSize = true;
            this.labelStopStep_DVA.Location = new System.Drawing.Point(140, 28);
            this.labelStopStep_DVA.Name = "labelStopStep_DVA";
            this.labelStopStep_DVA.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_DVA.TabIndex = 2;
            this.labelStopStep_DVA.Text = "Конец шага:";
            // 
            // textBoxStopStep_DVA
            // 
            this.textBoxStopStep_DVA.Location = new System.Drawing.Point(143, 48);
            this.textBoxStopStep_DVA.Name = "textBoxStopStep_DVA";
            this.textBoxStopStep_DVA.Size = new System.Drawing.Size(122, 22);
            this.textBoxStopStep_DVA.TabIndex = 1;
            // 
            // labelStartStep_DVA
            // 
            this.labelStartStep_DVA.AutoSize = true;
            this.labelStartStep_DVA.Location = new System.Drawing.Point(0, 28);
            this.labelStartStep_DVA.Name = "labelStartStep_DVA";
            this.labelStartStep_DVA.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_DVA.TabIndex = 1;
            this.labelStartStep_DVA.Text = "Старт шага:";
            // 
            // textBoxStartStep_DVA
            // 
            this.textBoxStartStep_DVA.Location = new System.Drawing.Point(0, 48);
            this.textBoxStartStep_DVA.Name = "textBoxStartStep_DVA";
            this.textBoxStartStep_DVA.Size = new System.Drawing.Size(120, 22);
            this.textBoxStartStep_DVA.TabIndex = 2;
            // 
            // groupBoxDataOutput_DVA
            // 
            this.groupBoxDataOutput_DVA.Controls.Add(this.chartFunction_DVA);
            this.groupBoxDataOutput_DVA.Controls.Add(this.dataGridViewFunction_DVA);
            this.groupBoxDataOutput_DVA.Controls.Add(this.labelResult_DVA);
            this.groupBoxDataOutput_DVA.Location = new System.Drawing.Point(571, 12);
            this.groupBoxDataOutput_DVA.Name = "groupBoxDataOutput_DVA";
            this.groupBoxDataOutput_DVA.Size = new System.Drawing.Size(734, 426);
            this.groupBoxDataOutput_DVA.TabIndex = 2;
            this.groupBoxDataOutput_DVA.TabStop = false;
            this.groupBoxDataOutput_DVA.Text = "Вывод данных:";
            // 
            // chartFunction_DVA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_DVA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_DVA.Legends.Add(legend3);
            this.chartFunction_DVA.Location = new System.Drawing.Point(183, 41);
            this.chartFunction_DVA.Name = "chartFunction_DVA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_DVA.Series.Add(series3);
            this.chartFunction_DVA.Size = new System.Drawing.Size(539, 394);
            this.chartFunction_DVA.TabIndex = 2;
            this.chartFunction_DVA.Text = "chart1";
            // 
            // dataGridViewFunction_DVA
            // 
            this.dataGridViewFunction_DVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_DVA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_DVA.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewFunction_DVA.Name = "dataGridViewFunction_DVA";
            this.dataGridViewFunction_DVA.RowHeadersVisible = false;
            this.dataGridViewFunction_DVA.RowHeadersWidth = 51;
            this.dataGridViewFunction_DVA.RowTemplate.Height = 24;
            this.dataGridViewFunction_DVA.Size = new System.Drawing.Size(160, 379);
            this.dataGridViewFunction_DVA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 60;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 60;
            // 
            // labelResult_DVA
            // 
            this.labelResult_DVA.AutoSize = true;
            this.labelResult_DVA.Location = new System.Drawing.Point(6, 21);
            this.labelResult_DVA.Name = "labelResult_DVA";
            this.labelResult_DVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_DVA.TabIndex = 0;
            this.labelResult_DVA.Text = "Результат:";
            // 
            // buttonDone_DVA
            // 
            this.buttonDone_DVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DVA.Location = new System.Drawing.Point(423, 380);
            this.buttonDone_DVA.Name = "buttonDone_DVA";
            this.buttonDone_DVA.Size = new System.Drawing.Size(142, 58);
            this.buttonDone_DVA.TabIndex = 3;
            this.buttonDone_DVA.Text = "Выполнить";
            this.buttonDone_DVA.UseVisualStyleBackColor = false;
            this.buttonDone_DVA.Click += new System.EventHandler(this.buttonDone_DVA_Click);
            // 
            // buttonHelp_DVA
            // 
            this.buttonHelp_DVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_DVA.Location = new System.Drawing.Point(302, 380);
            this.buttonHelp_DVA.Name = "buttonHelp_DVA";
            this.buttonHelp_DVA.Size = new System.Drawing.Size(106, 59);
            this.buttonHelp_DVA.TabIndex = 4;
            this.buttonHelp_DVA.Text = "Справка";
            this.buttonHelp_DVA.UseVisualStyleBackColor = false;
            this.buttonHelp_DVA.Click += new System.EventHandler(this.buttonHelp_DVA_Click);
            // 
            // pictureBoxFormula_DVA
            // 
            this.pictureBoxFormula_DVA.Image = global::Tyuiu.DolgushinVA.Sprint6.Task2.V9.Properties.Resources.FormulaTask2;
            this.pictureBoxFormula_DVA.Location = new System.Drawing.Point(3, 58);
            this.pictureBoxFormula_DVA.Name = "pictureBoxFormula_DVA";
            this.pictureBoxFormula_DVA.Size = new System.Drawing.Size(259, 65);
            this.pictureBoxFormula_DVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_DVA.TabIndex = 1;
            this.pictureBoxFormula_DVA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 450);
            this.Controls.Add(this.buttonHelp_DVA);
            this.Controls.Add(this.buttonDone_DVA);
            this.Controls.Add(this.groupBoxDataOutput_DVA);
            this.Controls.Add(this.groupBoxDataInput_DVA);
            this.Controls.Add(this.groupBoxTask_DVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 9 | Долгушин В. А.";
            this.groupBoxTask_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.PerformLayout();
            this.groupBoxDataInput_DVA.ResumeLayout(false);
            this.groupBoxDataInput_DVA.PerformLayout();
            this.groupBoxDataOutput_DVA.ResumeLayout(false);
            this.groupBoxDataOutput_DVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_DVA;
        private System.Windows.Forms.Button buttonDone_DVA;
        private System.Windows.Forms.Button buttonHelp_DVA;
        private System.Windows.Forms.TextBox textBoxTask_DVA;
        private System.Windows.Forms.TextBox textBoxStopStep_DVA;
        private System.Windows.Forms.TextBox textBoxStartStep_DVA;
        private System.Windows.Forms.Label labelStopStep_DVA;
        private System.Windows.Forms.Label labelStartStep_DVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DVA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_DVA;
        private System.Windows.Forms.Label labelResult_DVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.PictureBox pictureBoxFormula_DVA;
    }
}



namespace Tyuiu.DolgushinVA.Sprint6.Task1.V4
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
            this.groupBoxTask_DVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DVA = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDataOutPut_DVA = new System.Windows.Forms.GroupBox();
            this.labelResult_DVA = new System.Windows.Forms.Label();
            this.textBoxResult_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxDataInput_DVA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_DVA = new System.Windows.Forms.Label();
            this.labelStartStep_DVA = new System.Windows.Forms.Label();
            this.textBoxStopStep_DVA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_DVA = new System.Windows.Forms.TextBox();
            this.buttonDone_DVA = new System.Windows.Forms.Button();
            this.buttonHelp_DVA = new System.Windows.Forms.Button();
            this.pictureBoxFormula_DVA = new System.Windows.Forms.PictureBox();
            this.groupBoxTask_DVA.SuspendLayout();
            this.groupBoxDataOutPut_DVA.SuspendLayout();
            this.groupBoxDataInput_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DVA
            // 
            this.groupBoxTask_DVA.Controls.Add(this.pictureBoxFormula_DVA);
            this.groupBoxTask_DVA.Controls.Add(this.textBoxTask_DVA);
            this.groupBoxTask_DVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DVA.Name = "groupBoxTask_DVA";
            this.groupBoxTask_DVA.Size = new System.Drawing.Size(733, 357);
            this.groupBoxTask_DVA.TabIndex = 0;
            this.groupBoxTask_DVA.TabStop = false;
            this.groupBoxTask_DVA.Text = "Условие";
            // 
            // textBoxTask_DVA
            // 
            this.textBoxTask_DVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_DVA.Multiline = true;
            this.textBoxTask_DVA.Name = "textBoxTask_DVA";
            this.textBoxTask_DVA.ReadOnly = true;
            this.textBoxTask_DVA.Size = new System.Drawing.Size(721, 330);
            this.textBoxTask_DVA.TabIndex = 0;
            this.textBoxTask_DVA.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в таблицу.";
            // 
            // groupBoxDataOutPut_DVA
            // 
            this.groupBoxDataOutPut_DVA.Controls.Add(this.labelResult_DVA);
            this.groupBoxDataOutPut_DVA.Controls.Add(this.textBoxResult_DVA);
            this.groupBoxDataOutPut_DVA.Location = new System.Drawing.Point(751, 12);
            this.groupBoxDataOutPut_DVA.Name = "groupBoxDataOutPut_DVA";
            this.groupBoxDataOutPut_DVA.Size = new System.Drawing.Size(309, 426);
            this.groupBoxDataOutPut_DVA.TabIndex = 1;
            this.groupBoxDataOutPut_DVA.TabStop = false;
            this.groupBoxDataOutPut_DVA.Text = "Вывод данных:";
            // 
            // labelResult_DVA
            // 
            this.labelResult_DVA.AutoSize = true;
            this.labelResult_DVA.Location = new System.Drawing.Point(6, 24);
            this.labelResult_DVA.Name = "labelResult_DVA";
            this.labelResult_DVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_DVA.TabIndex = 1;
            this.labelResult_DVA.Text = "Результат:";
            // 
            // textBoxResult_DVA
            // 
            this.textBoxResult_DVA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_DVA.Location = new System.Drawing.Point(6, 49);
            this.textBoxResult_DVA.Multiline = true;
            this.textBoxResult_DVA.Name = "textBoxResult_DVA";
            this.textBoxResult_DVA.ReadOnly = true;
            this.textBoxResult_DVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_DVA.Size = new System.Drawing.Size(297, 371);
            this.textBoxResult_DVA.TabIndex = 0;
            // 
            // groupBoxDataInput_DVA
            // 
            this.groupBoxDataInput_DVA.Controls.Add(this.labelStopStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.labelStartStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.textBoxStopStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.textBoxStartStep_DVA);
            this.groupBoxDataInput_DVA.Location = new System.Drawing.Point(12, 370);
            this.groupBoxDataInput_DVA.Name = "groupBoxDataInput_DVA";
            this.groupBoxDataInput_DVA.Size = new System.Drawing.Size(425, 68);
            this.groupBoxDataInput_DVA.TabIndex = 2;
            this.groupBoxDataInput_DVA.TabStop = false;
            this.groupBoxDataInput_DVA.Text = "Ввод данных:";
            // 
            // labelStopStep_DVA
            // 
            this.labelStopStep_DVA.AutoSize = true;
            this.labelStopStep_DVA.Location = new System.Drawing.Point(234, 20);
            this.labelStopStep_DVA.Name = "labelStopStep_DVA";
            this.labelStopStep_DVA.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_DVA.TabIndex = 3;
            this.labelStopStep_DVA.Text = "Конец шага:";
            // 
            // labelStartStep_DVA
            // 
            this.labelStartStep_DVA.AutoSize = true;
            this.labelStartStep_DVA.Location = new System.Drawing.Point(6, 20);
            this.labelStartStep_DVA.Name = "labelStartStep_DVA";
            this.labelStartStep_DVA.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_DVA.TabIndex = 2;
            this.labelStartStep_DVA.Text = "Старт шага:";
            // 
            // textBoxStopStep_DVA
            // 
            this.textBoxStopStep_DVA.Location = new System.Drawing.Point(237, 40);
            this.textBoxStopStep_DVA.Name = "textBoxStopStep_DVA";
            this.textBoxStopStep_DVA.Size = new System.Drawing.Size(182, 22);
            this.textBoxStopStep_DVA.TabIndex = 1;
            // 
            // textBoxStartStep_DVA
            // 
            this.textBoxStartStep_DVA.Location = new System.Drawing.Point(6, 40);
            this.textBoxStartStep_DVA.Name = "textBoxStartStep_DVA";
            this.textBoxStartStep_DVA.Size = new System.Drawing.Size(178, 22);
            this.textBoxStartStep_DVA.TabIndex = 0;
            this.textBoxStartStep_DVA.Tag = "";
            // 
            // buttonDone_DVA
            // 
            this.buttonDone_DVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DVA.Location = new System.Drawing.Point(596, 375);
            this.buttonDone_DVA.Name = "buttonDone_DVA";
            this.buttonDone_DVA.Size = new System.Drawing.Size(143, 63);
            this.buttonDone_DVA.TabIndex = 3;
            this.buttonDone_DVA.Text = "Выполнить";
            this.buttonDone_DVA.UseVisualStyleBackColor = false;
            this.buttonDone_DVA.Click += new System.EventHandler(this.buttonDone_DVA_Click);
            // 
            // buttonHelp_DVA
            // 
            this.buttonHelp_DVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_DVA.Location = new System.Drawing.Point(468, 375);
            this.buttonHelp_DVA.Name = "buttonHelp_DVA";
            this.buttonHelp_DVA.Size = new System.Drawing.Size(113, 63);
            this.buttonHelp_DVA.TabIndex = 4;
            this.buttonHelp_DVA.Text = "Справка";
            this.buttonHelp_DVA.UseVisualStyleBackColor = false;
            this.buttonHelp_DVA.Click += new System.EventHandler(this.buttonHelp_DVA_Click);
            // 
            // pictureBoxFormula_DVA
            // 
            this.pictureBoxFormula_DVA.Image = global::Tyuiu.DolgushinVA.Sprint6.Task1.V4.Properties.Resources.FormulaTask1;
            this.pictureBoxFormula_DVA.Location = new System.Drawing.Point(9, 59);
            this.pictureBoxFormula_DVA.Name = "pictureBoxFormula_DVA";
            this.pictureBoxFormula_DVA.Size = new System.Drawing.Size(364, 53);
            this.pictureBoxFormula_DVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_DVA.TabIndex = 1;
            this.pictureBoxFormula_DVA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.buttonHelp_DVA);
            this.Controls.Add(this.buttonDone_DVA);
            this.Controls.Add(this.groupBoxDataInput_DVA);
            this.Controls.Add(this.groupBoxDataOutPut_DVA);
            this.Controls.Add(this.groupBoxTask_DVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 4 | Долгушин В. А.";
            this.groupBoxTask_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.PerformLayout();
            this.groupBoxDataOutPut_DVA.ResumeLayout(false);
            this.groupBoxDataOutPut_DVA.PerformLayout();
            this.groupBoxDataInput_DVA.ResumeLayout(false);
            this.groupBoxDataInput_DVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_DVA;
        private System.Windows.Forms.Button buttonDone_DVA;
        private System.Windows.Forms.Button buttonHelp_DVA;
        private System.Windows.Forms.TextBox textBoxTask_DVA;
        private System.Windows.Forms.Label labelResult_DVA;
        private System.Windows.Forms.TextBox textBoxResult_DVA;
        private System.Windows.Forms.Label labelStopStep_DVA;
        private System.Windows.Forms.Label labelStartStep_DVA;
        private System.Windows.Forms.TextBox textBoxStopStep_DVA;
        private System.Windows.Forms.TextBox textBoxStartStep_DVA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_DVA;
    }
}


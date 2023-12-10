
namespace Tyuiu.DolgushinVA.Sprint6.Task6.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxInfo_DVA = new System.Windows.Forms.GroupBox();
            this.buttonOk_DVA = new System.Windows.Forms.Button();
            this.labelInfo_DVA = new System.Windows.Forms.Label();
            this.groupBoxInfo_DVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo_DVA
            // 
            this.groupBoxInfo_DVA.Controls.Add(this.labelInfo_DVA);
            this.groupBoxInfo_DVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo_DVA.Name = "groupBoxInfo_DVA";
            this.groupBoxInfo_DVA.Size = new System.Drawing.Size(411, 190);
            this.groupBoxInfo_DVA.TabIndex = 0;
            this.groupBoxInfo_DVA.TabStop = false;
            // 
            // buttonOk_DVA
            // 
            this.buttonOk_DVA.Location = new System.Drawing.Point(331, 208);
            this.buttonOk_DVA.Name = "buttonOk_DVA";
            this.buttonOk_DVA.Size = new System.Drawing.Size(92, 29);
            this.buttonOk_DVA.TabIndex = 1;
            this.buttonOk_DVA.Text = "Ok";
            this.buttonOk_DVA.UseVisualStyleBackColor = true;
            this.buttonOk_DVA.Click += new System.EventHandler(this.buttonOk_DVA_Click);
            // 
            // labelInfo_DVA
            // 
            this.labelInfo_DVA.AutoSize = true;
            this.labelInfo_DVA.Location = new System.Drawing.Point(6, 18);
            this.labelInfo_DVA.Name = "labelInfo_DVA";
            this.labelInfo_DVA.Size = new System.Drawing.Size(357, 153);
            this.labelInfo_DVA.TabIndex = 2;
            this.labelInfo_DVA.Text = resources.GetString("labelInfo_DVA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 240);
            this.Controls.Add(this.groupBoxInfo_DVA);
            this.Controls.Add(this.buttonOk_DVA);
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.groupBoxInfo_DVA.ResumeLayout(false);
            this.groupBoxInfo_DVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_DVA;
        private System.Windows.Forms.Button buttonOk_DVA;
        private System.Windows.Forms.Label labelInfo_DVA;
    }
}
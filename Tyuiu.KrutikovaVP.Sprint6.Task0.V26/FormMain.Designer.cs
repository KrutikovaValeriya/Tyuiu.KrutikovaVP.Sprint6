namespace Tyuiu.KrutikovaVP.Sprint6.Task0.V26
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxConditionsTask_KVP = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KVP = new System.Windows.Forms.PictureBox();
            this.textBoxTask_KVP = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_KVP = new System.Windows.Forms.GroupBox();
            this.labelVarX_KVP = new System.Windows.Forms.Label();
            this.textBoxVarX_KVP = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_KVP = new System.Windows.Forms.GroupBox();
            this.labelResult_KVP = new System.Windows.Forms.Label();
            this.textBoxResult_KVP = new System.Windows.Forms.TextBox();
            this.buttonDone_KVP = new System.Windows.Forms.Button();
            this.buttonInfo_KVP = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxConditionsTask_KVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KVP)).BeginInit();
            this.groupBoxInPutData_KVP.SuspendLayout();
            this.groupBoxOutPutData_KVP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConditionsTask_KVP
            // 
            this.groupBoxConditionsTask_KVP.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxConditionsTask_KVP.Controls.Add(this.pictureBoxFormula_KVP);
            this.groupBoxConditionsTask_KVP.Controls.Add(this.textBoxTask_KVP);
            this.groupBoxConditionsTask_KVP.Location = new System.Drawing.Point(25, 34);
            this.groupBoxConditionsTask_KVP.Name = "groupBoxConditionsTask_KVP";
            this.groupBoxConditionsTask_KVP.Size = new System.Drawing.Size(468, 129);
            this.groupBoxConditionsTask_KVP.TabIndex = 0;
            this.groupBoxConditionsTask_KVP.TabStop = false;
            this.groupBoxConditionsTask_KVP.Text = "Условие";
            // 
            // pictureBoxFormula_KVP
            // 
            this.pictureBoxFormula_KVP.ErrorImage = null;
            this.pictureBoxFormula_KVP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KVP.Image")));
            this.pictureBoxFormula_KVP.InitialImage = null;
            this.pictureBoxFormula_KVP.Location = new System.Drawing.Point(321, 19);
            this.pictureBoxFormula_KVP.Name = "pictureBoxFormula_KVP";
            this.pictureBoxFormula_KVP.Size = new System.Drawing.Size(131, 60);
            this.pictureBoxFormula_KVP.TabIndex = 1;
            this.pictureBoxFormula_KVP.TabStop = false;
            // 
            // textBoxTask_KVP
            // 
            this.textBoxTask_KVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KVP.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_KVP.Multiline = true;
            this.textBoxTask_KVP.Name = "textBoxTask_KVP";
            this.textBoxTask_KVP.ReadOnly = true;
            this.textBoxTask_KVP.Size = new System.Drawing.Size(318, 104);
            this.textBoxTask_KVP.TabIndex = 0;
            this.textBoxTask_KVP.TabStop = false;
            this.textBoxTask_KVP.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPutData_KVP
            // 
            this.groupBoxInPutData_KVP.Controls.Add(this.labelVarX_KVP);
            this.groupBoxInPutData_KVP.Controls.Add(this.textBoxVarX_KVP);
            this.groupBoxInPutData_KVP.Location = new System.Drawing.Point(25, 169);
            this.groupBoxInPutData_KVP.Name = "groupBoxInPutData_KVP";
            this.groupBoxInPutData_KVP.Size = new System.Drawing.Size(275, 100);
            this.groupBoxInPutData_KVP.TabIndex = 1;
            this.groupBoxInPutData_KVP.TabStop = false;
            this.groupBoxInPutData_KVP.Text = "Ввод данных";
            // 
            // labelVarX_KVP
            // 
            this.labelVarX_KVP.AutoSize = true;
            this.labelVarX_KVP.Location = new System.Drawing.Point(24, 37);
            this.labelVarX_KVP.Name = "labelVarX_KVP";
            this.labelVarX_KVP.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_KVP.TabIndex = 1;
            this.labelVarX_KVP.Text = "Переменная X:";
            // 
            // textBoxVarX_KVP
            // 
            this.textBoxVarX_KVP.Location = new System.Drawing.Point(17, 53);
            this.textBoxVarX_KVP.Name = "textBoxVarX_KVP";
            this.textBoxVarX_KVP.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_KVP.TabIndex = 0;
            this.textBoxVarX_KVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KVP_KeyPress);
            // 
            // groupBoxOutPutData_KVP
            // 
            this.groupBoxOutPutData_KVP.Controls.Add(this.labelResult_KVP);
            this.groupBoxOutPutData_KVP.Controls.Add(this.textBoxResult_KVP);
            this.groupBoxOutPutData_KVP.Location = new System.Drawing.Point(306, 169);
            this.groupBoxOutPutData_KVP.Name = "groupBoxOutPutData_KVP";
            this.groupBoxOutPutData_KVP.Size = new System.Drawing.Size(187, 100);
            this.groupBoxOutPutData_KVP.TabIndex = 2;
            this.groupBoxOutPutData_KVP.TabStop = false;
            this.groupBoxOutPutData_KVP.Text = "Ввывод данных";
            // 
            // labelResult_KVP
            // 
            this.labelResult_KVP.AutoSize = true;
            this.labelResult_KVP.Location = new System.Drawing.Point(18, 37);
            this.labelResult_KVP.Name = "labelResult_KVP";
            this.labelResult_KVP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KVP.TabIndex = 1;
            this.labelResult_KVP.Text = "Результат:";
            // 
            // textBoxResult_KVP
            // 
            this.textBoxResult_KVP.Location = new System.Drawing.Point(21, 53);
            this.textBoxResult_KVP.Name = "textBoxResult_KVP";
            this.textBoxResult_KVP.ReadOnly = true;
            this.textBoxResult_KVP.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_KVP.TabIndex = 0;
            // 
            // buttonDone_KVP
            // 
            this.buttonDone_KVP.Location = new System.Drawing.Point(355, 275);
            this.buttonDone_KVP.Name = "buttonDone_KVP";
            this.buttonDone_KVP.Size = new System.Drawing.Size(138, 35);
            this.buttonDone_KVP.TabIndex = 3;
            this.buttonDone_KVP.Text = "Выполнить";
            this.buttonDone_KVP.UseVisualStyleBackColor = true;
            this.buttonDone_KVP.Click += new System.EventHandler(this.buttonDone_KVP_Click);
            // 
            // buttonInfo_KVP
            // 
            this.buttonInfo_KVP.Location = new System.Drawing.Point(306, 275);
            this.buttonInfo_KVP.Name = "buttonInfo_KVP";
            this.buttonInfo_KVP.Size = new System.Drawing.Size(43, 35);
            this.buttonInfo_KVP.TabIndex = 4;
            this.buttonInfo_KVP.Text = "?";
            this.buttonInfo_KVP.UseVisualStyleBackColor = true;
            this.buttonInfo_KVP.Click += new System.EventHandler(this.buttonInfo_KVP_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 322);
            this.Controls.Add(this.buttonInfo_KVP);
            this.Controls.Add(this.buttonDone_KVP);
            this.Controls.Add(this.groupBoxOutPutData_KVP);
            this.Controls.Add(this.groupBoxInPutData_KVP);
            this.Controls.Add(this.groupBoxConditionsTask_KVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Крутикова В. П.";
            this.groupBoxConditionsTask_KVP.ResumeLayout(false);
            this.groupBoxConditionsTask_KVP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KVP)).EndInit();
            this.groupBoxInPutData_KVP.ResumeLayout(false);
            this.groupBoxInPutData_KVP.PerformLayout();
            this.groupBoxOutPutData_KVP.ResumeLayout(false);
            this.groupBoxOutPutData_KVP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditionsTask_KVP;
        private System.Windows.Forms.GroupBox groupBoxInPutData_KVP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KVP;
        private System.Windows.Forms.Label labelVarX_KVP;
        private System.Windows.Forms.TextBox textBoxVarX_KVP;
        private System.Windows.Forms.Label labelResult_KVP;
        private System.Windows.Forms.TextBox textBoxResult_KVP;
        private System.Windows.Forms.Button buttonDone_KVP;
        private System.Windows.Forms.Button buttonInfo_KVP;
        private System.Windows.Forms.TextBox textBoxTask_KVP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KVP;
    }
}


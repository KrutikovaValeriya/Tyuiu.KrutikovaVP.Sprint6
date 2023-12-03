namespace Tyuiu.KrutikovaVP.Sprint6.Task1.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxConditionTask_KVP = new System.Windows.Forms.GroupBox();
            this.textBox_ConditionTask_KVP = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_KVP = new System.Windows.Forms.GroupBox();
            this.labelVarStopStep_KVP = new System.Windows.Forms.Label();
            this.labelVarStartStep_KVP = new System.Windows.Forms.Label();
            this.textBoxVarStopStep_KVP = new System.Windows.Forms.TextBox();
            this.textBoxVarStartStep_KVP = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_KVP = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KVP = new System.Windows.Forms.TextBox();
            this.labelResult_KVP = new System.Windows.Forms.Label();
            this.buttonDone_KVP = new System.Windows.Forms.Button();
            this.buttonInfo_KVP = new System.Windows.Forms.Button();
            this.groupBoxConditionTask_KVP.SuspendLayout();
            this.groupBoxInPutData_KVP.SuspendLayout();
            this.groupBoxOutPutData_KVP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConditionTask_KVP
            // 
            this.groupBoxConditionTask_KVP.Controls.Add(this.textBox_ConditionTask_KVP);
            this.groupBoxConditionTask_KVP.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConditionTask_KVP.Name = "groupBoxConditionTask_KVP";
            this.groupBoxConditionTask_KVP.Size = new System.Drawing.Size(486, 202);
            this.groupBoxConditionTask_KVP.TabIndex = 0;
            this.groupBoxConditionTask_KVP.TabStop = false;
            this.groupBoxConditionTask_KVP.Text = "Условие";
            // 
            // textBox_ConditionTask_KVP
            // 
            this.textBox_ConditionTask_KVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConditionTask_KVP.Location = new System.Drawing.Point(6, 19);
            this.textBox_ConditionTask_KVP.Multiline = true;
            this.textBox_ConditionTask_KVP.Name = "textBox_ConditionTask_KVP";
            this.textBox_ConditionTask_KVP.ReadOnly = true;
            this.textBox_ConditionTask_KVP.Size = new System.Drawing.Size(474, 104);
            this.textBox_ConditionTask_KVP.TabIndex = 0;
            this.textBox_ConditionTask_KVP.Text = resources.GetString("textBox_ConditionTask_KVP.Text");
            // 
            // groupBoxInPutData_KVP
            // 
            this.groupBoxInPutData_KVP.Controls.Add(this.labelVarStopStep_KVP);
            this.groupBoxInPutData_KVP.Controls.Add(this.labelVarStartStep_KVP);
            this.groupBoxInPutData_KVP.Controls.Add(this.textBoxVarStopStep_KVP);
            this.groupBoxInPutData_KVP.Controls.Add(this.textBoxVarStartStep_KVP);
            this.groupBoxInPutData_KVP.Location = new System.Drawing.Point(12, 214);
            this.groupBoxInPutData_KVP.Name = "groupBoxInPutData_KVP";
            this.groupBoxInPutData_KVP.Size = new System.Drawing.Size(254, 72);
            this.groupBoxInPutData_KVP.TabIndex = 1;
            this.groupBoxInPutData_KVP.TabStop = false;
            this.groupBoxInPutData_KVP.Text = "Ввод данных";
            // 
            // labelVarStopStep_KVP
            // 
            this.labelVarStopStep_KVP.AutoSize = true;
            this.labelVarStopStep_KVP.Location = new System.Drawing.Point(122, 21);
            this.labelVarStopStep_KVP.Name = "labelVarStopStep_KVP";
            this.labelVarStopStep_KVP.Size = new System.Drawing.Size(70, 13);
            this.labelVarStopStep_KVP.TabIndex = 1;
            this.labelVarStopStep_KVP.Text = "Конец щага:";
            // 
            // labelVarStartStep_KVP
            // 
            this.labelVarStartStep_KVP.AutoSize = true;
            this.labelVarStartStep_KVP.Location = new System.Drawing.Point(6, 21);
            this.labelVarStartStep_KVP.Name = "labelVarStartStep_KVP";
            this.labelVarStartStep_KVP.Size = new System.Drawing.Size(67, 13);
            this.labelVarStartStep_KVP.TabIndex = 1;
            this.labelVarStartStep_KVP.Text = "Старт шага:";
            // 
            // textBoxVarStopStep_KVP
            // 
            this.textBoxVarStopStep_KVP.Location = new System.Drawing.Point(125, 37);
            this.textBoxVarStopStep_KVP.Name = "textBoxVarStopStep_KVP";
            this.textBoxVarStopStep_KVP.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStopStep_KVP.TabIndex = 0;
            this.textBoxVarStopStep_KVP.Text = "5";
            // 
            // textBoxVarStartStep_KVP
            // 
            this.textBoxVarStartStep_KVP.Location = new System.Drawing.Point(6, 37);
            this.textBoxVarStartStep_KVP.Name = "textBoxVarStartStep_KVP";
            this.textBoxVarStartStep_KVP.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStartStep_KVP.TabIndex = 0;
            this.textBoxVarStartStep_KVP.Text = "-5";
            // 
            // groupBoxOutPutData_KVP
            // 
            this.groupBoxOutPutData_KVP.Controls.Add(this.labelResult_KVP);
            this.groupBoxOutPutData_KVP.Controls.Add(this.textBoxResult_KVP);
            this.groupBoxOutPutData_KVP.Location = new System.Drawing.Point(504, 12);
            this.groupBoxOutPutData_KVP.Name = "groupBoxOutPutData_KVP";
            this.groupBoxOutPutData_KVP.Size = new System.Drawing.Size(218, 274);
            this.groupBoxOutPutData_KVP.TabIndex = 2;
            this.groupBoxOutPutData_KVP.TabStop = false;
            this.groupBoxOutPutData_KVP.Text = "Вывод данных";
            // 
            // textBoxResult_KVP
            // 
            this.textBoxResult_KVP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KVP.Location = new System.Drawing.Point(6, 35);
            this.textBoxResult_KVP.Multiline = true;
            this.textBoxResult_KVP.Name = "textBoxResult_KVP";
            this.textBoxResult_KVP.ReadOnly = true;
            this.textBoxResult_KVP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KVP.Size = new System.Drawing.Size(206, 233);
            this.textBoxResult_KVP.TabIndex = 0;
            // 
            // labelResult_KVP
            // 
            this.labelResult_KVP.AutoSize = true;
            this.labelResult_KVP.Location = new System.Drawing.Point(6, 19);
            this.labelResult_KVP.Name = "labelResult_KVP";
            this.labelResult_KVP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KVP.TabIndex = 1;
            this.labelResult_KVP.Text = "Результат:";
            // 
            // buttonDone_KVP
            // 
            this.buttonDone_KVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_KVP.Location = new System.Drawing.Point(373, 220);
            this.buttonDone_KVP.Name = "buttonDone_KVP";
            this.buttonDone_KVP.Size = new System.Drawing.Size(125, 66);
            this.buttonDone_KVP.TabIndex = 3;
            this.buttonDone_KVP.Text = "Выполнить";
            this.buttonDone_KVP.UseVisualStyleBackColor = false;
            this.buttonDone_KVP.Click += new System.EventHandler(this.buttonDone_KVP_Click);
            // 
            // buttonInfo_KVP
            // 
            this.buttonInfo_KVP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonInfo_KVP.Location = new System.Drawing.Point(283, 220);
            this.buttonInfo_KVP.Name = "buttonInfo_KVP";
            this.buttonInfo_KVP.Size = new System.Drawing.Size(81, 66);
            this.buttonInfo_KVP.TabIndex = 4;
            this.buttonInfo_KVP.Text = "Справка";
            this.buttonInfo_KVP.UseVisualStyleBackColor = false;
            this.buttonInfo_KVP.Click += new System.EventHandler(this.buttonInfo_KVP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 293);
            this.Controls.Add(this.buttonInfo_KVP);
            this.Controls.Add(this.buttonDone_KVP);
            this.Controls.Add(this.groupBoxOutPutData_KVP);
            this.Controls.Add(this.groupBoxInPutData_KVP);
            this.Controls.Add(this.groupBoxConditionTask_KVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 15 | Крутикова В. П.";
            this.groupBoxConditionTask_KVP.ResumeLayout(false);
            this.groupBoxConditionTask_KVP.PerformLayout();
            this.groupBoxInPutData_KVP.ResumeLayout(false);
            this.groupBoxInPutData_KVP.PerformLayout();
            this.groupBoxOutPutData_KVP.ResumeLayout(false);
            this.groupBoxOutPutData_KVP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditionTask_KVP;
        private System.Windows.Forms.TextBox textBox_ConditionTask_KVP;
        private System.Windows.Forms.GroupBox groupBoxInPutData_KVP;
        private System.Windows.Forms.Label labelVarStopStep_KVP;
        private System.Windows.Forms.Label labelVarStartStep_KVP;
        private System.Windows.Forms.TextBox textBoxVarStopStep_KVP;
        private System.Windows.Forms.TextBox textBoxVarStartStep_KVP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KVP;
        private System.Windows.Forms.Label labelResult_KVP;
        private System.Windows.Forms.TextBox textBoxResult_KVP;
        private System.Windows.Forms.Button buttonDone_KVP;
        private System.Windows.Forms.Button buttonInfo_KVP;
    }
}


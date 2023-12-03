namespace Tyuiu.KrutikovaVP.Sprint6.Task2.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ConditionTask_KVP = new System.Windows.Forms.GroupBox();
            this.textBoxConditionTask_KVP = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_KVP = new System.Windows.Forms.GroupBox();
            this.labelStartStep_KVP = new System.Windows.Forms.Label();
            this.labelStopStep_KVP = new System.Windows.Forms.Label();
            this.textBoxStopStep_KVP = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KVP = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_KVP = new System.Windows.Forms.GroupBox();
            this.chartFunction_KVP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_KVP = new System.Windows.Forms.DataGridView();
            this.varX_KVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarY_KVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_KVP = new System.Windows.Forms.Button();
            this.buttonInfo_KVP = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ConditionTask_KVP.SuspendLayout();
            this.groupBoxInPutData_KVP.SuspendLayout();
            this.groupBoxOutPutData_KVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KVP)).BeginInit();
            this.SuspendLayout();
            // 
            // ConditionTask_KVP
            // 
            this.ConditionTask_KVP.Controls.Add(this.textBoxConditionTask_KVP);
            this.ConditionTask_KVP.Location = new System.Drawing.Point(12, 12);
            this.ConditionTask_KVP.Name = "ConditionTask_KVP";
            this.ConditionTask_KVP.Size = new System.Drawing.Size(458, 218);
            this.ConditionTask_KVP.TabIndex = 0;
            this.ConditionTask_KVP.TabStop = false;
            this.ConditionTask_KVP.Text = "Условие";
            // 
            // textBoxConditionTask_KVP
            // 
            this.textBoxConditionTask_KVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConditionTask_KVP.Location = new System.Drawing.Point(6, 19);
            this.textBoxConditionTask_KVP.Multiline = true;
            this.textBoxConditionTask_KVP.Name = "textBoxConditionTask_KVP";
            this.textBoxConditionTask_KVP.ReadOnly = true;
            this.textBoxConditionTask_KVP.Size = new System.Drawing.Size(412, 128);
            this.textBoxConditionTask_KVP.TabIndex = 0;
            this.textBoxConditionTask_KVP.Text = resources.GetString("textBoxConditionTask_KVP.Text");
            // 
            // groupBoxInPutData_KVP
            // 
            this.groupBoxInPutData_KVP.Controls.Add(this.labelStartStep_KVP);
            this.groupBoxInPutData_KVP.Controls.Add(this.labelStopStep_KVP);
            this.groupBoxInPutData_KVP.Controls.Add(this.textBoxStopStep_KVP);
            this.groupBoxInPutData_KVP.Controls.Add(this.textBoxStartStep_KVP);
            this.groupBoxInPutData_KVP.Location = new System.Drawing.Point(12, 236);
            this.groupBoxInPutData_KVP.Name = "groupBoxInPutData_KVP";
            this.groupBoxInPutData_KVP.Size = new System.Drawing.Size(228, 73);
            this.groupBoxInPutData_KVP.TabIndex = 1;
            this.groupBoxInPutData_KVP.TabStop = false;
            this.groupBoxInPutData_KVP.Text = "Ввод данных";
            // 
            // labelStartStep_KVP
            // 
            this.labelStartStep_KVP.AutoSize = true;
            this.labelStartStep_KVP.Location = new System.Drawing.Point(6, 23);
            this.labelStartStep_KVP.Name = "labelStartStep_KVP";
            this.labelStartStep_KVP.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_KVP.TabIndex = 1;
            this.labelStartStep_KVP.Text = "Старт шага:";
            // 
            // labelStopStep_KVP
            // 
            this.labelStopStep_KVP.AutoSize = true;
            this.labelStopStep_KVP.Location = new System.Drawing.Point(119, 23);
            this.labelStopStep_KVP.Name = "labelStopStep_KVP";
            this.labelStopStep_KVP.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_KVP.TabIndex = 1;
            this.labelStopStep_KVP.Text = "Конец шага:";
            // 
            // textBoxStopStep_KVP
            // 
            this.textBoxStopStep_KVP.Location = new System.Drawing.Point(122, 39);
            this.textBoxStopStep_KVP.Name = "textBoxStopStep_KVP";
            this.textBoxStopStep_KVP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_KVP.TabIndex = 0;
            this.textBoxStopStep_KVP.Text = "5";
            // 
            // textBoxStartStep_KVP
            // 
            this.textBoxStartStep_KVP.Location = new System.Drawing.Point(6, 39);
            this.textBoxStartStep_KVP.Name = "textBoxStartStep_KVP";
            this.textBoxStartStep_KVP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_KVP.TabIndex = 0;
            this.textBoxStartStep_KVP.Text = "-5";
            // 
            // groupBoxOutPutData_KVP
            // 
            this.groupBoxOutPutData_KVP.Controls.Add(this.chartFunction_KVP);
            this.groupBoxOutPutData_KVP.Controls.Add(this.dataGridViewFunction_KVP);
            this.groupBoxOutPutData_KVP.Location = new System.Drawing.Point(476, 12);
            this.groupBoxOutPutData_KVP.Name = "groupBoxOutPutData_KVP";
            this.groupBoxOutPutData_KVP.Size = new System.Drawing.Size(499, 297);
            this.groupBoxOutPutData_KVP.TabIndex = 2;
            this.groupBoxOutPutData_KVP.TabStop = false;
            this.groupBoxOutPutData_KVP.Text = "Вывод данных:";
            // 
            // chartFunction_KVP
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_KVP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_KVP.Legends.Add(legend2);
            this.chartFunction_KVP.Location = new System.Drawing.Point(132, 30);
            this.chartFunction_KVP.Name = "chartFunction_KVP";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_KVP.Series.Add(series2);
            this.chartFunction_KVP.Size = new System.Drawing.Size(360, 261);
            this.chartFunction_KVP.TabIndex = 2;
            // 
            // dataGridViewFunction_KVP
            // 
            this.dataGridViewFunction_KVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KVP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varX_KVP,
            this.VarY_KVP});
            this.dataGridViewFunction_KVP.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewFunction_KVP.Name = "dataGridViewFunction_KVP";
            this.dataGridViewFunction_KVP.RowHeadersVisible = false;
            this.dataGridViewFunction_KVP.Size = new System.Drawing.Size(120, 261);
            this.dataGridViewFunction_KVP.TabIndex = 1;
            // 
            // varX_KVP
            // 
            this.varX_KVP.HeaderText = "X";
            this.varX_KVP.Name = "varX_KVP";
            this.varX_KVP.Width = 50;
            // 
            // VarY_KVP
            // 
            this.VarY_KVP.HeaderText = "F(x)";
            this.VarY_KVP.Name = "VarY_KVP";
            this.VarY_KVP.Width = 50;
            // 
            // buttonDone_KVP
            // 
            this.buttonDone_KVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_KVP.Location = new System.Drawing.Point(342, 236);
            this.buttonDone_KVP.Name = "buttonDone_KVP";
            this.buttonDone_KVP.Size = new System.Drawing.Size(128, 73);
            this.buttonDone_KVP.TabIndex = 3;
            this.buttonDone_KVP.Text = "Выполнить";
            this.buttonDone_KVP.UseVisualStyleBackColor = false;
            this.buttonDone_KVP.Click += new System.EventHandler(this.buttonDone_KVP_Click);
            this.buttonDone_KVP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KVP_MouseDown);
            this.buttonDone_KVP.MouseEnter += new System.EventHandler(this.buttonDone_KVP_MouseEnter);
            this.buttonDone_KVP.MouseLeave += new System.EventHandler(this.buttonDone_KVP_MouseLeave);
            // 
            // buttonInfo_KVP
            // 
            this.buttonInfo_KVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonInfo_KVP.Location = new System.Drawing.Point(259, 236);
            this.buttonInfo_KVP.Name = "buttonInfo_KVP";
            this.buttonInfo_KVP.Size = new System.Drawing.Size(77, 73);
            this.buttonInfo_KVP.TabIndex = 4;
            this.buttonInfo_KVP.Text = "Справка";
            this.buttonInfo_KVP.UseVisualStyleBackColor = false;
            this.buttonInfo_KVP.Click += new System.EventHandler(this.buttonInfo_KVP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 322);
            this.Controls.Add(this.buttonInfo_KVP);
            this.Controls.Add(this.buttonDone_KVP);
            this.Controls.Add(this.groupBoxOutPutData_KVP);
            this.Controls.Add(this.groupBoxInPutData_KVP);
            this.Controls.Add(this.ConditionTask_KVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 10 | Крутикова В. П.";
            this.ConditionTask_KVP.ResumeLayout(false);
            this.ConditionTask_KVP.PerformLayout();
            this.groupBoxInPutData_KVP.ResumeLayout(false);
            this.groupBoxInPutData_KVP.PerformLayout();
            this.groupBoxOutPutData_KVP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConditionTask_KVP;
        private System.Windows.Forms.TextBox textBoxConditionTask_KVP;
        private System.Windows.Forms.GroupBox groupBoxInPutData_KVP;
        private System.Windows.Forms.Label labelStartStep_KVP;
        private System.Windows.Forms.Label labelStopStep_KVP;
        private System.Windows.Forms.TextBox textBoxStopStep_KVP;
        private System.Windows.Forms.TextBox textBoxStartStep_KVP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KVP;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn varX_KVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarY_KVP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KVP;
        private System.Windows.Forms.Button buttonDone_KVP;
        private System.Windows.Forms.Button buttonInfo_KVP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


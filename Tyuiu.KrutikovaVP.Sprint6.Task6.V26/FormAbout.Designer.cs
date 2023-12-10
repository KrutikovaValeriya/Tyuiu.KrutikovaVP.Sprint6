namespace Tyuiu.KrutikovaVP.Sprint6.Task6.V26
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
            this.pictureBoxOfMe_KVP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClick_KVP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfMe_KVP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOfMe_KVP
            // 
            this.pictureBoxOfMe_KVP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOfMe_KVP.Image")));
            this.pictureBoxOfMe_KVP.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOfMe_KVP.Name = "pictureBoxOfMe_KVP";
            this.pictureBoxOfMe_KVP.Size = new System.Drawing.Size(98, 132);
            this.pictureBoxOfMe_KVP.TabIndex = 0;
            this.pictureBoxOfMe_KVP.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonClick_KVP
            // 
            this.buttonClick_KVP.Location = new System.Drawing.Point(325, 135);
            this.buttonClick_KVP.Name = "buttonClick_KVP";
            this.buttonClick_KVP.Size = new System.Drawing.Size(75, 23);
            this.buttonClick_KVP.TabIndex = 2;
            this.buttonClick_KVP.Text = "Ок";
            this.buttonClick_KVP.UseVisualStyleBackColor = true;
            this.buttonClick_KVP.Click += new System.EventHandler(this.buttonClick_KVP_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 166);
            this.Controls.Add(this.buttonClick_KVP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOfMe_KVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfMe_KVP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOfMe_KVP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClick_KVP;
    }
}
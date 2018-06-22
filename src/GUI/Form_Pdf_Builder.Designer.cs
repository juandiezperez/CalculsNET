namespace CalcNet
{
    partial class Form_Pdf_Builder
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_DocumentTitle = new System.Windows.Forms.TextBox();
            this.TB_DownRight = new System.Windows.Forms.TextBox();
            this.TB_DownLeft = new System.Windows.Forms.TextBox();
            this.BTN_Generate_PDF = new System.Windows.Forms.Button();
            this.TB_UpperLeft = new System.Windows.Forms.TextBox();
            this.TB_UpperRight = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_DocumentTitle);
            this.groupBox2.Controls.Add(this.TB_DownRight);
            this.groupBox2.Controls.Add(this.TB_DownLeft);
            this.groupBox2.Controls.Add(this.BTN_Generate_PDF);
            this.groupBox2.Controls.Add(this.TB_UpperLeft);
            this.groupBox2.Controls.Add(this.TB_UpperRight);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 520);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // TB_DocumentTitle
            // 
            this.TB_DocumentTitle.Location = new System.Drawing.Point(104, 54);
            this.TB_DocumentTitle.Name = "TB_DocumentTitle";
            this.TB_DocumentTitle.Size = new System.Drawing.Size(220, 20);
            this.TB_DocumentTitle.TabIndex = 7;
            this.TB_DocumentTitle.Text = "Titre à définir";
            this.TB_DocumentTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_DownRight
            // 
            this.TB_DownRight.Enabled = false;
            this.TB_DownRight.Location = new System.Drawing.Point(322, 494);
            this.TB_DownRight.Name = "TB_DownRight";
            this.TB_DownRight.Size = new System.Drawing.Size(100, 20);
            this.TB_DownRight.TabIndex = 6;
            this.TB_DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_DownLeft
            // 
            this.TB_DownLeft.Enabled = false;
            this.TB_DownLeft.Location = new System.Drawing.Point(6, 494);
            this.TB_DownLeft.Name = "TB_DownLeft";
            this.TB_DownLeft.Size = new System.Drawing.Size(100, 20);
            this.TB_DownLeft.TabIndex = 5;
            // 
            // BTN_Generate_PDF
            // 
            this.BTN_Generate_PDF.Location = new System.Drawing.Point(6, 103);
            this.BTN_Generate_PDF.Name = "BTN_Generate_PDF";
            this.BTN_Generate_PDF.Size = new System.Drawing.Size(407, 360);
            this.BTN_Generate_PDF.TabIndex = 2;
            this.BTN_Generate_PDF.Text = "PDF";
            this.BTN_Generate_PDF.UseVisualStyleBackColor = true;
            this.BTN_Generate_PDF.Click += new System.EventHandler(this.BTN_Generate_PDF_Click);
            // 
            // TB_UpperLeft
            // 
            this.TB_UpperLeft.Location = new System.Drawing.Point(6, 19);
            this.TB_UpperLeft.Name = "TB_UpperLeft";
            this.TB_UpperLeft.Size = new System.Drawing.Size(100, 20);
            this.TB_UpperLeft.TabIndex = 3;
            this.TB_UpperLeft.Text = "N. Dannoy";
            // 
            // TB_UpperRight
            // 
            this.TB_UpperRight.Location = new System.Drawing.Point(322, 19);
            this.TB_UpperRight.Name = "TB_UpperRight";
            this.TB_UpperRight.Size = new System.Drawing.Size(100, 20);
            this.TB_UpperRight.TabIndex = 4;
            this.TB_UpperRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_Pdf_Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 535);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_Pdf_Builder";
            this.Text = "Form_Pdf_Builder";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_DocumentTitle;
        private System.Windows.Forms.TextBox TB_DownRight;
        private System.Windows.Forms.TextBox TB_DownLeft;
        private System.Windows.Forms.Button BTN_Generate_PDF;
        private System.Windows.Forms.TextBox TB_UpperLeft;
        private System.Windows.Forms.TextBox TB_UpperRight;
    }
}
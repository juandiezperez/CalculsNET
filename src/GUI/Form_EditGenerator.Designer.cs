namespace CalcNet
{
    partial class Form_EditGenerator
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
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Operation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.CB_Selection_Randomized = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Selection_Count = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_ElipsisPosition = new System.Windows.Forms.ComboBox();
            this.uC_RangeEditorResult = new CalcNet.UC_RangeEditor();
            this.uC_RangeEditorRight = new CalcNet.UC_RangeEditor();
            this.uC_RangeEditorLeft = new CalcNet.UC_RangeEditor();
            this.SuspendLayout();
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(48, 10);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(429, 20);
            this.TB_Name.TabIndex = 0;
            this.TB_Name.TextChanged += new System.EventHandler(this.uC_RangeEditor_Validated);
            this.TB_Name.Validated += new System.EventHandler(this.uC_RangeEditor_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // CB_Operation
            // 
            this.CB_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Operation.FormattingEnabled = true;
            this.CB_Operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CB_Operation.Location = new System.Drawing.Point(141, 48);
            this.CB_Operation.Name = "CB_Operation";
            this.CB_Operation.Size = new System.Drawing.Size(60, 26);
            this.CB_Operation.TabIndex = 8;
            this.CB_Operation.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Location = new System.Drawing.Point(13, 156);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(82, 13);
            this.LBL_Status.TabIndex = 13;
            this.LBL_Status.Text = "-------------------------";
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(399, 151);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 14;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(318, 151);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 15;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // CB_Selection_Randomized
            // 
            this.CB_Selection_Randomized.AutoSize = true;
            this.CB_Selection_Randomized.Location = new System.Drawing.Point(257, 124);
            this.CB_Selection_Randomized.Name = "CB_Selection_Randomized";
            this.CB_Selection_Randomized.Size = new System.Drawing.Size(95, 17);
            this.CB_Selection_Randomized.TabIndex = 16;
            this.CB_Selection_Randomized.Text = "Ordre aléatoire";
            this.CB_Selection_Randomized.UseVisualStyleBackColor = true;
            this.CB_Selection_Randomized.CheckedChanged += new System.EventHandler(this.uC_RangeEditor_Validated);
            this.CB_Selection_Randomized.TextChanged += new System.EventHandler(this.uC_RangeEditor_Validated);
            this.CB_Selection_Randomized.Validated += new System.EventHandler(this.uC_RangeEditor_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Selection";
            // 
            // TB_Selection_Count
            // 
            this.TB_Selection_Count.Location = new System.Drawing.Point(100, 121);
            this.TB_Selection_Count.MaxLength = 5;
            this.TB_Selection_Count.Name = "TB_Selection_Count";
            this.TB_Selection_Count.Size = new System.Drawing.Size(82, 20);
            this.TB_Selection_Count.TabIndex = 19;
            this.TB_Selection_Count.Text = "5";
            this.TB_Selection_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_Selection_Count.TextChanged += new System.EventHandler(this.uC_RangeEditor_Validated);
            this.TB_Selection_Count.Validated += new System.EventHandler(this.uC_RangeEditor_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Elipse";
            // 
            // CB_ElipsisPosition
            // 
            this.CB_ElipsisPosition.FormattingEnabled = true;
            this.CB_ElipsisPosition.Location = new System.Drawing.Point(100, 94);
            this.CB_ElipsisPosition.Name = "CB_ElipsisPosition";
            this.CB_ElipsisPosition.Size = new System.Drawing.Size(82, 21);
            this.CB_ElipsisPosition.TabIndex = 21;
            this.CB_ElipsisPosition.TextChanged += new System.EventHandler(this.uC_RangeEditor_Validated);
            this.CB_ElipsisPosition.Validated += new System.EventHandler(this.uC_RangeEditor_Validated);
            // 
            // uC_RangeEditorResult
            // 
            this.uC_RangeEditorResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_RangeEditorResult.Location = new System.Drawing.Point(358, 48);
            this.uC_RangeEditorResult.Name = "uC_RangeEditorResult";
            this.uC_RangeEditorResult.Size = new System.Drawing.Size(119, 27);
            this.uC_RangeEditorResult.TabIndex = 11;
            this.uC_RangeEditorResult.Validated += new System.EventHandler(this.uC_RangeEditor_Validated);
            // 
            // uC_RangeEditorRight
            // 
            this.uC_RangeEditorRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_RangeEditorRight.Location = new System.Drawing.Point(208, 48);
            this.uC_RangeEditorRight.Name = "uC_RangeEditorRight";
            this.uC_RangeEditorRight.Size = new System.Drawing.Size(119, 27);
            this.uC_RangeEditorRight.TabIndex = 10;
            this.uC_RangeEditorRight.Validated += new System.EventHandler(this.uC_RangeEditor_Validated);
            // 
            // uC_RangeEditorLeft
            // 
            this.uC_RangeEditorLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_RangeEditorLeft.Location = new System.Drawing.Point(16, 48);
            this.uC_RangeEditorLeft.Name = "uC_RangeEditorLeft";
            this.uC_RangeEditorLeft.Size = new System.Drawing.Size(119, 27);
            this.uC_RangeEditorLeft.TabIndex = 9;
            this.uC_RangeEditorLeft.Validated += new System.EventHandler(this.uC_RangeEditor_Validated);
            // 
            // Form_EditGenerator
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 188);
            this.Controls.Add(this.CB_ElipsisPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Selection_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Selection_Randomized);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uC_RangeEditorResult);
            this.Controls.Add(this.uC_RangeEditorRight);
            this.Controls.Add(this.uC_RangeEditorLeft);
            this.Controls.Add(this.CB_Operation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Name);
            this.Name = "Form_EditGenerator";
            this.Text = "Form_EditGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Operation;
        private UC_RangeEditor uC_RangeEditorLeft;
        private UC_RangeEditor uC_RangeEditorRight;
        private UC_RangeEditor uC_RangeEditorResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.CheckBox CB_Selection_Randomized;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Selection_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_ElipsisPosition;
    }
}
namespace CalcNet
{
    partial class FormMainWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Build_Pdf = new System.Windows.Forms.Button();
            this.BTN_Delete_Selection = new System.Windows.Forms.Button();
            this.BTN_Add_Generator = new System.Windows.Forms.Button();
            this.LV_Generators = new System.Windows.Forms.ListView();
            this.Col_Enable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LeftTerm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Operation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_RightTerm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Equals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Solutions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Selection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Randomized = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Elipsis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Edit);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Build_Pdf);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Delete_Selection);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Add_Generator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LV_Generators);
            this.splitContainer1.Size = new System.Drawing.Size(727, 394);
            this.splitContainer1.TabIndex = 0;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Edit.Location = new System.Drawing.Point(93, 12);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(86, 28);
            this.BTN_Edit.TabIndex = 3;
            this.BTN_Edit.Text = "Modifier";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Build_Pdf
            // 
            this.BTN_Build_Pdf.Location = new System.Drawing.Point(640, 12);
            this.BTN_Build_Pdf.Name = "BTN_Build_Pdf";
            this.BTN_Build_Pdf.Size = new System.Drawing.Size(75, 28);
            this.BTN_Build_Pdf.TabIndex = 2;
            this.BTN_Build_Pdf.Text = "PDF";
            this.BTN_Build_Pdf.UseVisualStyleBackColor = true;
            this.BTN_Build_Pdf.Click += new System.EventHandler(this.BTN_Build_Pdf_Click);
            // 
            // BTN_Delete_Selection
            // 
            this.BTN_Delete_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete_Selection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Delete_Selection.Location = new System.Drawing.Point(185, 12);
            this.BTN_Delete_Selection.Name = "BTN_Delete_Selection";
            this.BTN_Delete_Selection.Size = new System.Drawing.Size(86, 28);
            this.BTN_Delete_Selection.TabIndex = 1;
            this.BTN_Delete_Selection.Text = "Supprimer";
            this.BTN_Delete_Selection.UseVisualStyleBackColor = true;
            this.BTN_Delete_Selection.Click += new System.EventHandler(this.BTN_Delete_Selection_Click);
            // 
            // BTN_Add_Generator
            // 
            this.BTN_Add_Generator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Generator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Add_Generator.Location = new System.Drawing.Point(12, 12);
            this.BTN_Add_Generator.Name = "BTN_Add_Generator";
            this.BTN_Add_Generator.Size = new System.Drawing.Size(75, 28);
            this.BTN_Add_Generator.TabIndex = 0;
            this.BTN_Add_Generator.Text = "Ajouter";
            this.BTN_Add_Generator.UseVisualStyleBackColor = true;
            this.BTN_Add_Generator.Click += new System.EventHandler(this.BTN_Add_Generator_Click);
            // 
            // LV_Generators
            // 
            this.LV_Generators.CheckBoxes = true;
            this.LV_Generators.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Enable,
            this.Col_Name,
            this.Col_LeftTerm,
            this.Col_Operation,
            this.Col_RightTerm,
            this.Col_Equals,
            this.Col_Result,
            this.Col_Solutions,
            this.Col_Selection,
            this.Col_Randomized,
            this.Col_Elipsis});
            this.LV_Generators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Generators.FullRowSelect = true;
            this.LV_Generators.Location = new System.Drawing.Point(0, 0);
            this.LV_Generators.Name = "LV_Generators";
            this.LV_Generators.Size = new System.Drawing.Size(727, 340);
            this.LV_Generators.TabIndex = 0;
            this.LV_Generators.UseCompatibleStateImageBehavior = false;
            this.LV_Generators.View = System.Windows.Forms.View.Details;
            // 
            // Col_Enable
            // 
            this.Col_Enable.Text = "Enable";
            // 
            // Col_Name
            // 
            this.Col_Name.Text = "Nom";
            this.Col_Name.Width = 120;
            // 
            // Col_LeftTerm
            // 
            this.Col_LeftTerm.Text = "Gauche";
            this.Col_LeftTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_Operation
            // 
            this.Col_Operation.Text = "Opération";
            this.Col_Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_RightTerm
            // 
            this.Col_RightTerm.Text = "Droite";
            this.Col_RightTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_Equals
            // 
            this.Col_Equals.Text = "=";
            this.Col_Equals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_Result
            // 
            this.Col_Result.Text = "Résdultat";
            this.Col_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_Solutions
            // 
            this.Col_Solutions.Text = "Solutions";
            this.Col_Solutions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Col_Selection
            // 
            this.Col_Selection.Text = "Sélection";
            this.Col_Selection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Col_Randomized
            // 
            this.Col_Randomized.Text = "Aléatoire";
            this.Col_Randomized.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_Elipsis
            // 
            this.Col_Elipsis.Text = "Elipse";
            this.Col_Elipsis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 394);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMainWindow";
            this.Text = "FormMainWindow";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BTN_Build_Pdf;
        private System.Windows.Forms.Button BTN_Delete_Selection;
        private System.Windows.Forms.Button BTN_Add_Generator;
        private System.Windows.Forms.ListView LV_Generators;
        private System.Windows.Forms.ColumnHeader Col_Name;
        private System.Windows.Forms.ColumnHeader Col_LeftTerm;
        private System.Windows.Forms.ColumnHeader Col_Enable;
        private System.Windows.Forms.ColumnHeader Col_Operation;
        private System.Windows.Forms.ColumnHeader Col_RightTerm;
        private System.Windows.Forms.ColumnHeader Col_Equals;
        private System.Windows.Forms.ColumnHeader Col_Result;
        private System.Windows.Forms.ColumnHeader Col_Solutions;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.ColumnHeader Col_Selection;
        private System.Windows.Forms.ColumnHeader Col_Randomized;
        private System.Windows.Forms.ColumnHeader Col_Elipsis;
    }
}
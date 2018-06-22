namespace CalcNet
{
    partial class UC_EquationGenerator
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_LeftMin = new System.Windows.Forms.TextBox();
            this.TB_LeftMax = new System.Windows.Forms.TextBox();
            this.TB_RightMax = new System.Windows.Forms.TextBox();
            this.TB_RightMin = new System.Windows.Forms.TextBox();
            this.TB_ResMax = new System.Windows.Forms.TextBox();
            this.TB_ResMin = new System.Windows.Forms.TextBox();
            this.LB_Equals = new System.Windows.Forms.Label();
            this.CB_Operation = new System.Windows.Forms.ComboBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.CB_Enable = new System.Windows.Forms.CheckBox();
            this.LBL_Solutions = new System.Windows.Forms.Label();
            this.CB_Randomize = new System.Windows.Forms.CheckBox();
            this.TB_FilterLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_LeftMin
            // 
            this.TB_LeftMin.Location = new System.Drawing.Point(213, 2);
            this.TB_LeftMin.MaxLength = 5;
            this.TB_LeftMin.Name = "TB_LeftMin";
            this.TB_LeftMin.Size = new System.Drawing.Size(40, 20);
            this.TB_LeftMin.TabIndex = 2;
            this.TB_LeftMin.Text = "1";
            this.TB_LeftMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_LeftMin.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // TB_LeftMax
            // 
            this.TB_LeftMax.Location = new System.Drawing.Point(262, 2);
            this.TB_LeftMax.MaxLength = 5;
            this.TB_LeftMax.Name = "TB_LeftMax";
            this.TB_LeftMax.Size = new System.Drawing.Size(40, 20);
            this.TB_LeftMax.TabIndex = 3;
            this.TB_LeftMax.Text = "9";
            this.TB_LeftMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_LeftMax.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // TB_RightMax
            // 
            this.TB_RightMax.Location = new System.Drawing.Point(441, 3);
            this.TB_RightMax.MaxLength = 5;
            this.TB_RightMax.Name = "TB_RightMax";
            this.TB_RightMax.Size = new System.Drawing.Size(40, 20);
            this.TB_RightMax.TabIndex = 6;
            this.TB_RightMax.Text = "9";
            this.TB_RightMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_RightMax.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // TB_RightMin
            // 
            this.TB_RightMin.Location = new System.Drawing.Point(392, 3);
            this.TB_RightMin.MaxLength = 5;
            this.TB_RightMin.Name = "TB_RightMin";
            this.TB_RightMin.Size = new System.Drawing.Size(40, 20);
            this.TB_RightMin.TabIndex = 5;
            this.TB_RightMin.Text = "1";
            this.TB_RightMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_RightMin.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // TB_ResMax
            // 
            this.TB_ResMax.Location = new System.Drawing.Point(577, 4);
            this.TB_ResMax.MaxLength = 5;
            this.TB_ResMax.Name = "TB_ResMax";
            this.TB_ResMax.Size = new System.Drawing.Size(40, 20);
            this.TB_ResMax.TabIndex = 8;
            this.TB_ResMax.Text = "9";
            this.TB_ResMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResMax.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // TB_ResMin
            // 
            this.TB_ResMin.Location = new System.Drawing.Point(528, 4);
            this.TB_ResMin.MaxLength = 5;
            this.TB_ResMin.Name = "TB_ResMin";
            this.TB_ResMin.Size = new System.Drawing.Size(40, 20);
            this.TB_ResMin.TabIndex = 7;
            this.TB_ResMin.Text = "1";
            this.TB_ResMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResMin.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // LB_Equals
            // 
            this.LB_Equals.AutoSize = true;
            this.LB_Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Equals.Location = new System.Drawing.Point(503, 5);
            this.LB_Equals.Name = "LB_Equals";
            this.LB_Equals.Size = new System.Drawing.Size(15, 16);
            this.LB_Equals.TabIndex = 7;
            this.LB_Equals.Text = "=";
            // 
            // CB_Operation
            // 
            this.CB_Operation.FormattingEnabled = true;
            this.CB_Operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CB_Operation.Location = new System.Drawing.Point(314, 2);
            this.CB_Operation.Name = "CB_Operation";
            this.CB_Operation.Size = new System.Drawing.Size(60, 21);
            this.CB_Operation.TabIndex = 4;
            this.CB_Operation.Text = "+";
            this.CB_Operation.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(3, 2);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(192, 20);
            this.TB_Name.TabIndex = 1;
            this.TB_Name.Text = "Ceci est un titre";
            this.TB_Name.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // CB_Enable
            // 
            this.CB_Enable.AutoSize = true;
            this.CB_Enable.Location = new System.Drawing.Point(999, 8);
            this.CB_Enable.Name = "CB_Enable";
            this.CB_Enable.Size = new System.Drawing.Size(15, 14);
            this.CB_Enable.TabIndex = 0;
            this.CB_Enable.UseVisualStyleBackColor = true;
            this.CB_Enable.TextChanged += new System.EventHandler(this.Something_Changed);
            // 
            // LBL_Solutions
            // 
            this.LBL_Solutions.Location = new System.Drawing.Point(623, 4);
            this.LBL_Solutions.Name = "LBL_Solutions";
            this.LBL_Solutions.Size = new System.Drawing.Size(130, 20);
            this.LBL_Solutions.TabIndex = 8;
            this.LBL_Solutions.Text = "--";
            this.LBL_Solutions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Randomize
            // 
            this.CB_Randomize.AutoSize = true;
            this.CB_Randomize.Location = new System.Drawing.Point(849, 5);
            this.CB_Randomize.Name = "CB_Randomize";
            this.CB_Randomize.Size = new System.Drawing.Size(47, 17);
            this.CB_Randomize.TabIndex = 9;
            this.CB_Randomize.Text = "Aléa";
            this.CB_Randomize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_Randomize.UseVisualStyleBackColor = true;
            // 
            // TB_FilterLimit
            // 
            this.TB_FilterLimit.Location = new System.Drawing.Point(902, 5);
            this.TB_FilterLimit.MaxLength = 5;
            this.TB_FilterLimit.Name = "TB_FilterLimit";
            this.TB_FilterLimit.Size = new System.Drawing.Size(43, 20);
            this.TB_FilterLimit.TabIndex = 10;
            this.TB_FilterLimit.Text = "99999";
            this.TB_FilterLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_EquationGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_FilterLimit);
            this.Controls.Add(this.CB_Randomize);
            this.Controls.Add(this.LBL_Solutions);
            this.Controls.Add(this.CB_Enable);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.CB_Operation);
            this.Controls.Add(this.LB_Equals);
            this.Controls.Add(this.TB_ResMax);
            this.Controls.Add(this.TB_ResMin);
            this.Controls.Add(this.TB_RightMax);
            this.Controls.Add(this.TB_RightMin);
            this.Controls.Add(this.TB_LeftMax);
            this.Controls.Add(this.TB_LeftMin);
            this.Name = "UC_EquationGenerator";
            this.Size = new System.Drawing.Size(1017, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_LeftMin;
        private System.Windows.Forms.TextBox TB_LeftMax;
        private System.Windows.Forms.TextBox TB_RightMax;
        private System.Windows.Forms.TextBox TB_RightMin;
        private System.Windows.Forms.TextBox TB_ResMax;
        private System.Windows.Forms.TextBox TB_ResMin;
        private System.Windows.Forms.Label LB_Equals;
        private System.Windows.Forms.ComboBox CB_Operation;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.CheckBox CB_Enable;
        private System.Windows.Forms.Label LBL_Solutions;
        private System.Windows.Forms.CheckBox CB_Randomize;
        private System.Windows.Forms.TextBox TB_FilterLimit;
    }
}

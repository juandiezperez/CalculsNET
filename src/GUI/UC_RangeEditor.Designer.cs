namespace CalcNet
{
    partial class UC_RangeEditor
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
            this.TB_Min = new System.Windows.Forms.TextBox();
            this.TB_Max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Min
            // 
            this.TB_Min.Location = new System.Drawing.Point(3, 3);
            this.TB_Min.MaxLength = 5;
            this.TB_Min.Name = "TB_Min";
            this.TB_Min.Size = new System.Drawing.Size(40, 20);
            this.TB_Min.TabIndex = 3;
            this.TB_Min.Text = "1";
            this.TB_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Min.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Min.Enter += new System.EventHandler(this.TB_TextChanged);
            this.TB_Min.Leave += new System.EventHandler(this.TB_TextChanged);
            // 
            // TB_Max
            // 
            this.TB_Max.Location = new System.Drawing.Point(73, 3);
            this.TB_Max.MaxLength = 5;
            this.TB_Max.Name = "TB_Max";
            this.TB_Max.Size = new System.Drawing.Size(40, 20);
            this.TB_Max.TabIndex = 4;
            this.TB_Max.Text = "9";
            this.TB_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Max.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Max.Enter += new System.EventHandler(this.TB_TextChanged);
            this.TB_Max.Leave += new System.EventHandler(this.TB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "à";
            // 
            // UC_RangeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Max);
            this.Controls.Add(this.TB_Min);
            this.Name = "UC_RangeEditor";
            this.Size = new System.Drawing.Size(119, 27);
            this.Load += new System.EventHandler(this.UC_RangeEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TB_Min;
        public System.Windows.Forms.TextBox TB_Max;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcNet
{
    public partial class Form_Pdf_Builder : Form
    {
        public Form_Pdf_Builder()
        {
            InitializeComponent();

            TB_UpperLeft.Text = "N. Dannoy";
            TB_UpperRight.Text = string.Empty;
            TB_DownLeft.Text = DateTime.Now.ToString("d");
            TB_DownRight.Text = "Page x/y";
        }

        public List<EquationGenerator> Generators;

        private void BTN_Generate_PDF_Click(object sender, EventArgs e)
        {
            PdfBuilder pdf_builder = new PdfBuilder();

            pdf_builder.HeaderLeft = TB_UpperLeft.Text;
            pdf_builder.HeaderRight = TB_UpperRight.Text;
            pdf_builder.FooterLeft = TB_DownLeft.Text;
            pdf_builder.Title = TB_DocumentTitle.Text;
            pdf_builder.Start();

            foreach (EquationGenerator gen in Generators)
                pdf_builder.AddEquations(gen);

            DateTime t = DateTime.Now;
            string fname = string.Empty;
            fname += "coucou";
            fname += "---";
            fname += string.Format("{0:D4}-{1:D2}-{2:D2}", t.Year, t.Month, t.Day);
            fname += "---";
            fname += string.Format("{0:D2}-{1:D2}-{2:D2}", t.Hour, t.Minute, t.Second);
            fname += ".pdf";

            pdf_builder.Save(fname);


        }
    }
}

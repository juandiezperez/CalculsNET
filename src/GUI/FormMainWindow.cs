using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalcNet
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();

            this.Text = "Calc-NET 1.0";
        }

        private void update_lvi (ListViewItem item, EquationGenerator generator)
        {
            item.SubItems.Clear() ;

            item.SubItems.Add ( generator.Name);
            item.SubItems.Add ( generator.LeftRange.ToString() );
            item.SubItems.Add ( Tools.OperationChar(generator.Operation) );
            item.SubItems.Add ( generator.RightRange.ToString() );
            item.SubItems.Add ( Tools.EqualChar );
            item.SubItems.Add ( generator.ResultRange.ToString() );
            item.SubItems.Add ( String.Format("{0}", generator.Solutions.Count) );
            item.SubItems.Add ( String.Format("{0}", generator.Selection.Count));
            item.SubItems.Add ( String.Format("{0}", generator.Selection_Randomized ? "OUI" : "") );
            item.SubItems.Add ( String.Format("{0}", generator.ElipsisPosition ));

            item.Tag = generator;
        }

        private ListViewItem create_lvi (EquationGenerator generator)
        {
            ListViewItem item = new ListViewItem ();
            update_lvi (item, generator);
            return item;
        }

        private int new_sequential_number = 1;

        private void BTN_Add_Generator_Click(object sender, EventArgs e)
        {
            EquationGenerator new_generator = new EquationGenerator();
            new_generator.Name = String.Format("Générateur {0}", new_sequential_number++);
            Form_EditGenerator form_edit_generator = new Form_EditGenerator(new_generator);
            DialogResult dialog_result = form_edit_generator.ShowDialog();
            if (dialog_result == DialogResult.OK)
            {
                ListViewItem lvi = create_lvi ( form_edit_generator.Generator );
                LV_Generators.Items.Add(lvi);
            }
        }

        private void BTN_Delete_Selection_Click(object sender, EventArgs e)
        {
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            if (LV_Generators.SelectedItems.Count == 1)
            {
                ListViewItem item = LV_Generators.SelectedItems[0];
                EquationGenerator existing_generator = item.Tag as EquationGenerator;

                Form_EditGenerator form_edit_generator = new Form_EditGenerator (existing_generator);
                DialogResult dialog_result = form_edit_generator.ShowDialog();
                if (dialog_result == DialogResult.OK)
                {
                    update_lvi(item, form_edit_generator.Generator);
                }
            }
        }

        private void BTN_Build_Pdf_Click(object sender, EventArgs e)
        {
            List<EquationGenerator> gens = new List<EquationGenerator>();
            foreach (ListViewItem item in LV_Generators.Items)
            {
                EquationGenerator gen = item.Tag as EquationGenerator;
                if (gen != null)
                    gens.Add(gen);
            }

            Form_Pdf_Builder form_pdf_builder = new Form_Pdf_Builder();
            form_pdf_builder.Generators = gens;
            form_pdf_builder.ShowDialog();
        }
    }
}


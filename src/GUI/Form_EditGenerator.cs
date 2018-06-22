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
    public partial class Form_EditGenerator : Form
    {
        public EquationGenerator Generator { get; private set; }

        public Form_EditGenerator(EquationGenerator a_generator)
        {
            InitializeComponent();

            foreach (OperationEnum e in Enum.GetValues(typeof(OperationEnum)))
                CB_Operation.Items.Add ( Tools.OperationChar (e) );

            foreach (ElipsisPositionEnum e in Enum.GetValues (typeof (ElipsisPositionEnum)))
                CB_ElipsisPosition.Items.Add (e);

            uC_RangeEditorLeft.OnChanged += SomethingChanged;
            uC_RangeEditorRight.OnChanged += SomethingChanged;
            uC_RangeEditorResult.OnChanged += SomethingChanged;

            TB_Name.Text = a_generator.Name;
            uC_RangeEditorLeft.TB_Min.Text = a_generator.LeftRange.Min.ToString();
            uC_RangeEditorLeft.TB_Max.Text = a_generator.LeftRange.Max.ToString();
            uC_RangeEditorRight.TB_Min.Text = a_generator.RightRange.Min.ToString();
            uC_RangeEditorRight.TB_Max.Text = a_generator.RightRange.Max.ToString();
            uC_RangeEditorResult.TB_Min.Text = a_generator.ResultRange.Min.ToString();
            uC_RangeEditorResult.TB_Max.Text = a_generator.ResultRange.Max.ToString();
            CB_Operation.Text = Tools.OperationChar(a_generator.Operation);
            CB_Selection_Randomized.Checked = a_generator.Selection_Randomized;
            TB_Selection_Count.Text = a_generator.Selection_Limit.ToString();
            CB_ElipsisPosition.SelectedItem = a_generator.ElipsisPosition;
            fetch_all_fields();
        }

        private void uC_RangeEditor_Validated(object sender, EventArgs e)
        {
            fetch_all_fields();
        }

        public void SomethingChanged (string sender)
        {
            Log.Debug("EditGenerator.SomethingChanged ({0})", sender);
            fetch_all_fields();
        }

        public bool IsValid { get; private set; }

        private void fetch_all_fields ()
        {
            IsValid = true;
            if ( (IsValid) && ( ! uC_RangeEditorLeft.IsValid) )
            {
                LBL_Status.Text = "Gauche :" + uC_RangeEditorLeft.ErrorText;
                IsValid = false;
            }
            if ( (IsValid) && ( ! uC_RangeEditorRight.IsValid) )
            {
                LBL_Status.Text = "Droite :" + uC_RangeEditorRight.ErrorText;
                IsValid = false;
            }
            if ( (IsValid) && ( ! uC_RangeEditorResult.IsValid) )
            {
                LBL_Status.Text = "Resultat :" + uC_RangeEditorResult.ErrorText;
                IsValid = false;
            }
            if (IsValid)
            {
                Generator = new EquationGenerator(
                    new Range(uC_RangeEditorLeft.Min, uC_RangeEditorLeft.Max),
                    Tools.StringToOperation(CB_Operation.Text),
                    new Range(uC_RangeEditorRight.Min, uC_RangeEditorRight.Max),
                    new Range(uC_RangeEditorResult.Min, uC_RangeEditorResult.Max));
                Generator.Name = TB_Name.Text;
                Generator.Selection_Randomized = CB_Selection_Randomized.Checked;
                Generator.Selection_Limit = int.Parse(TB_Selection_Count.Text);
                if (CB_ElipsisPosition.SelectedItem != null)
                    Generator.ElipsisPosition = (ElipsisPositionEnum) CB_ElipsisPosition.SelectedItem;
                LBL_Status.Text = Generator.SolutionsText;
            }

            Log.Debug("EditGenerator.fetch_all : {0,6} {1}", IsValid, LBL_Status.Text);
            BTN_Ok.Enabled = IsValid;
        }
    }
}

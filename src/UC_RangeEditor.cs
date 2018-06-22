using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcNet
{
    public partial class UC_RangeEditor : UserControl
    {
        public int Min = 1;
        public int Max = 1;
        public bool IsValid { get; private set; }
        public string ErrorText { get; private set; }

        public UC_RangeEditor()
        {
            InitializeComponent();
            TB_TextChanged(null, null);
        }

        private void UC_RangeEditor_Load(object sender, EventArgs e)
        {
            fetch_all_fields();
        }
        private void TB_TextChanged(object sender, EventArgs e)
        {
            fetch_all_fields();
        }

        public delegate void ChangeHandler (string sender);
        public event ChangeHandler OnChanged;



        private void fetch_all_fields()
        {
            IsValid = true;

            if ((IsValid) && (!int.TryParse(TB_Min.Text, out Min)))
            {
                ErrorText = String.Format("'{0}' n'est pas un nombre !", TB_Min.Text);
                IsValid = false;
            }
            if ((IsValid) && (!int.TryParse(TB_Max.Text, out Max)))
            {
                ErrorText = String.Format("'{0}' n'est pas un nombre !", TB_Max.Text);
                IsValid = false;
            }
            if ((IsValid) && (Min >= Max))
            {
                ErrorText = String.Format("min({0}) >= max({1}) !", Min, Max);
                IsValid = false;
            }

            if (IsValid)
            {
                ErrorText = "OK";
            }
            if (OnChanged != null)
                OnChanged.Invoke (String.Format("UC_RangeEditor '{0}' to '{1}'", TB_Min.Text, TB_Max.Text));
        }

    }
}


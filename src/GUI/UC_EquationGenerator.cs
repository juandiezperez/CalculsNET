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
    public partial class UC_EquationGenerator : UserControl
    {
        public EquationGenerator Generator { get; private set; }

        public UC_EquationGenerator()
        {
            InitializeComponent();

            rebuild_params();
        }

        private void rebuild_params ()
        {
            GeneratorParameters g_params = new GeneratorParameters();

            g_params.Enable = CB_Enable.Enabled;
            bool ok = true;

            ok = ok && int.TryParse(TB_LeftMin.Text, out g_params.LeftMin);
            ok = ok && int.TryParse(TB_LeftMax.Text, out g_params.LeftMax);
            ok = ok && int.TryParse(TB_RightMin.Text, out g_params.RightMin);
            ok = ok && int.TryParse(TB_RightMax.Text, out g_params.RightMax);
            ok = ok && int.TryParse(TB_ResMin.Text, out g_params.ResultMin);
            ok = ok && int.TryParse(TB_ResMax.Text, out g_params.ResultMax);
            g_params.Operation = Tools.StringToOperation(CB_Operation.Text);

            if (ok)
            {

                Generator = new EquationGenerator(
                    new Range(g_params.LeftMin, g_params.LeftMax),
                    g_params.Operation,
                    new Range(g_params.RightMin, g_params.RightMax),
                    new Range(g_params.ResultMin, g_params.ResultMax));
                Generator.Name = TB_Name.Text;
                int items_before_filter = Generator.Solutions.Count;
                //Generator.build_selection(CB_Randomize.Enabled, int.Parse(TB_FilterLimit.Text));

                LBL_Solutions.Text = String.Format("{0} solutions", items_before_filter);
            }
        }

        private void Something_Changed(object sender, EventArgs e)
        {
            rebuild_params();
        }
    }
}

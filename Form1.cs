using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_OREoptimize
{
    public partial class Form1 : Form
    {
        ORECalculate ore_calculate = new ORECalculate(false);

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateMineral_Click(object sender, EventArgs e)
        {
            ore_calculate.UpdateOREPrice(buyPriceButton.Checked);
            ore_calculate.SetOREData(float.Parse(ratio_input.Text));
            optimize_output.Text = ore_calculate.Calculate(
                int.Parse(a_input.Text),
                int.Parse(b_input.Text),
                int.Parse(c_input.Text),
                int.Parse(d_input.Text),
                int.Parse(e_input.Text),
                int.Parse(f_input.Text),
                int.Parse(g_input.Text),
                int.Parse(h_input.Text));
        }
    }
}

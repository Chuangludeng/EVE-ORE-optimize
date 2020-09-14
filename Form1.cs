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
                int.Parse(a_input.Text.Replace(",", "")),
                int.Parse(b_input.Text.Replace(",", "")),
                int.Parse(c_input.Text.Replace(",", "")),
                int.Parse(d_input.Text.Replace(",", "")),
                int.Parse(e_input.Text.Replace(",", "")),
                int.Parse(f_input.Text.Replace(",", "")),
                int.Parse(g_input.Text.Replace(",", "")),
                int.Parse(h_input.Text.Replace(",", "")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = Clipboard.GetText().Split('\t');

            if (data.Length != 8)
                return;

            a_input.Text = data[0].Trim().Replace(",", "");
            b_input.Text = data[1].Trim().Replace(",", "");
            c_input.Text = data[2].Trim().Replace(",", "");
            d_input.Text = data[3].Trim().Replace(",", "");
            e_input.Text = data[4].Trim().Replace(",", "");
            f_input.Text = data[5].Trim().Replace(",", "");
            g_input.Text = data[6].Trim().Replace(",", "");
            h_input.Text = data[7].Trim().Replace(",", "");
        }
    }
}

using Microsoft.SolverFoundation.Common;
using Microsoft.SolverFoundation.Solvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_OREoptimize
{
    public class ORECalculate
    {
        public OREDictionary oreDictionary;

        SimplexSolver solver;

        bool useFullORE = false;

        int a, b, c, d, e, f, g, h, cost;

        public ORECalculate(bool usefullORE)
        {
            useFullORE = usefullORE;

            oreDictionary = new OREDictionary();

            solver = new SimplexSolver();

            foreach (var kv in oreDictionary.ORE_Dictionary)
            {
                if(usefullORE || kv.Value.isMain)
                {
                    int id = 0;
                    solver.AddVariable(kv.Key, out id);
                    solver.SetBounds(id, 0, Rational.PositiveInfinity);
                    kv.Value.id = id;
                }     
            }

            solver.AddRow("a", out a);
            solver.AddRow("b", out b);
            solver.AddRow("c", out c);
            solver.AddRow("d", out d);
            solver.AddRow("e", out e);
            solver.AddRow("f", out f);
            solver.AddRow("g", out g);
            solver.AddRow("h", out h);

            solver.AddRow("cost", out cost);

            solver.AddGoal(cost, 1, true);

        }

        public void UpdateOREPrice(bool isBuyPrice)
        {
            foreach (var kv in oreDictionary.ORE_Dictionary)
            {
                if (useFullORE || kv.Value.isMain)
                {
                    var price = PriceService.GetPrice(kv.Value.typeID);
                    if (isBuyPrice)
                        kv.Value.price = (int)price.buy.max;
                    else
                        kv.Value.price = (int)price.sell.min;
                }
            }
        }

        public void SetOREData(float ratio)
        {
            foreach (var kv in oreDictionary.ORE_Dictionary)
            {
                if (useFullORE || kv.Value.isMain)
                {
                    kv.Value.ratio = ratio;

                    solver.SetCoefficient(a, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["三钛合金"]));
                    solver.SetCoefficient(b, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["类晶体胶矿"]));
                    solver.SetCoefficient(c, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["类银超金属"]));
                    solver.SetCoefficient(d, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["同位聚合体"]));
                    solver.SetCoefficient(e, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["超星诺克石"]));
                    solver.SetCoefficient(f, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["晶状石英岩"]));
                    solver.SetCoefficient(g, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["超噬矿"]));
                    solver.SetCoefficient(h, kv.Value.id, Math.Round(kv.Value.ratio * kv.Value.mineral["莫尔石"]));

                    solver.SetCoefficient(cost, kv.Value.id, kv.Value.price);
                }
            }
        }

        public string Calculate(
            int a_need,
            int b_need,
            int c_need,
            int d_need,
            int e_need,
            int f_need,
            int g_need,
            int h_need)
        {
            solver.SetBounds(a, a_need, Rational.PositiveInfinity);
            solver.SetBounds(b, b_need, Rational.PositiveInfinity);
            solver.SetBounds(c, c_need, Rational.PositiveInfinity);
            solver.SetBounds(d, d_need, Rational.PositiveInfinity);
            solver.SetBounds(e, e_need, Rational.PositiveInfinity);
            solver.SetBounds(f, f_need, Rational.PositiveInfinity);
            solver.SetBounds(g, g_need, Rational.PositiveInfinity);
            solver.SetBounds(h, h_need, Rational.PositiveInfinity);

            solver.Solve(new SimplexSolverParams());

            StringBuilder output = new StringBuilder();

            int total_a = 0, total_b = 0, total_c = 0, total_d = 0, total_e = 0, total_f = 0, total_g = 0, total_h = 0;

            foreach (var kv in oreDictionary.ORE_Dictionary)
            {
                if (useFullORE || kv.Value.isMain)
                {
                    output.Append($"矿物名称：{kv.Key},矿价：{MoneyFormat(kv.Value.price)}\r\n");
                }
            }

            output.Append("\r\n");

            foreach (var kv in oreDictionary.ORE_Dictionary)
            {
                int number = (int)Math.Ceiling(solver.GetValue(kv.Value.id).ToDouble());
                if (number != 0)
                {
                    output.Append($"矿物名称：{kv.Key},购买总量：{MoneyFormat(number)},总金额：{MoneyFormat(number * kv.Value.price)}\r\n");
                    total_a += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["三钛合金"]) * number;
                    total_b += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["类晶体胶矿"]) * number;
                    total_c += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["类银超金属"]) * number;
                    total_d += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["同位聚合体"]) * number;
                    total_e += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["超星诺克石"]) * number;
                    total_f += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["晶状石英岩"]) * number;
                    total_g += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["超噬矿"]) * number;
                    total_h += (int)Math.Round(kv.Value.ratio * kv.Value.mineral["莫尔石"]) * number;
                }
            }

            output.Append("\r\n");

            output.Append($"三钛合金，需求：{MoneyFormat(a_need)}，化矿：{MoneyFormat(total_a)},结余 ：{MoneyFormat(total_a - a_need)}\r\n");
            output.Append($"类晶体胶矿，需求：{MoneyFormat(b_need)}，化矿：{MoneyFormat(total_b)},结余 ：{MoneyFormat(total_b - b_need)}\r\n");
            output.Append($"类银超金属，需求：{MoneyFormat(c_need)}，化矿：{MoneyFormat(total_c)},结余 ：{MoneyFormat(total_c - c_need)}\r\n");
            output.Append($"同位聚合体，需求：{MoneyFormat(d_need)}，化矿：{MoneyFormat(total_d)},结余 ：{MoneyFormat(total_d - d_need)}\r\n");
            output.Append($"超星诺克石，需求：{MoneyFormat(e_need)}，化矿：{MoneyFormat(total_e)},结余 ：{MoneyFormat(total_e - e_need)}\r\n");
            output.Append($"晶状石英岩，需求：{MoneyFormat(f_need)}，化矿：{MoneyFormat(total_f)},结余 ：{MoneyFormat(total_f - f_need)}\r\n");
            output.Append($"超噬矿，需求：{MoneyFormat(g_need)}，化矿：{MoneyFormat(total_g)},结余 ：{MoneyFormat(total_g - g_need)}\r\n");
            output.Append($"莫尔石，需求：{MoneyFormat(h_need)}，化矿：{MoneyFormat(total_h)},结余 ：{MoneyFormat(total_h - h_need)}\r\n");

            output.Append($"总金额：{MoneyFormat((int)solver.GetValue(cost).ToDouble())}\r\n");

           return output.ToString();
        }

        static string AmountFormat(int 数量)
        {
            return 数量.ToString("N0");
        }

        static string MoneyFormat(long 金额)
        {
            return $"{(金额).ToString("N0")}";
        }
    }
}

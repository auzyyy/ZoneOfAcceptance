using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoneOfAcceptanceCalc
{
    public partial class Form1 : Form
    {
        private double expectedValue = 0;
        private double acceptance = .5;
        private double errorAcceptance = 0;
        private double[] values;
        private int trials = 0;
        private double probability = 0.0;

        public Form1()
        {
            InitializeComponent();

            // Debugging n shit
            textBox_Trials.Text = "84";
            textBox_Probability.Text = "1/6";
            textBox_ErrorAcceptance.Text = ".05";
        }

        private void button_GenerateValues_Click(object sender, EventArgs e)
        {
            trials = GetTrialCount();
            probability = GetFairProbability();
            expectedValue = trials * probability;
            listView_generatedValues.Items.Clear();
            values = new double[trials + 1];
            if (trials >= 0 && probability >= 0)
            {
                DisplayValues(trials, probability);
            }
            panel_ZoneAcceptanceInfo.Visible = true;
        }

        private void InitZoneAcceptanceInfoPanel()
        {
            panel_ZoneAcceptanceInfo.Visible = true;
            label_Sum.Text = "";
            label_ValueRange.Text = "";
            textBox_ErrorAcceptance.Text = "";
        }

        private void DisplayValues(int trials, double probability)
        {
            for (int i = 0; i <= trials; i++)
            {
                values[i] = GetProbability(trials, i, probability, 1 - probability);
                string itemString = i + "      " + values[i];
                //string itemString = i + "      " + GetProbability(trials, i, probability, 1-probability);
                listView_generatedValues.Items.Add(itemString);
            }

        }

        private double GetProbability(int n, int k, double p, double q)
        {
            return GetChooseValue(n, k) * Math.Pow(p, k) * Math.Pow(q, n - k);
        }

        #region textbox getters with errors
        private double GetErrorAcceptance()
        {
            try
            {
                errorAcceptance = double.Parse(textBox_ErrorAcceptance.Text);
            }
            catch (FormatException)
            {
                DisplayError("Please enter a valid number for error acceptance. Enter 5 for 5%");
                return -1;
            }
            return errorAcceptance;
        }

        private int GetTrialCount()
        {
            int trials = 0;
            try
            {
                trials = int.Parse(textBox_Trials.Text);
            }
            catch (FormatException)
            {
                DisplayError("Please enter a valid number for trials");
                return -1;
            }
            return trials;
        }

        private double GetFairProbability()
        {
            double probability = 0;
            try
            {
                string[] parts = textBox_Probability.Text.Split('/');
                if (parts.Length > 1)
                {
                    for (int i = 0; i < parts.Length; i++)
                    {
                        if ((i + 1) < (parts.Length))
                        {
                            double numerator = double.Parse(parts[i]); ;
                            double denominator = double.Parse(parts[i + 1]);
                            parts[i + 1] = (numerator / denominator) + "";
                        }
                    }
                }
                probability = double.Parse(parts[parts.Length - 1]);
            }
            catch (FormatException)
            {
                DisplayError("Please enter a valid number for probability");
                return -1;
            }
            return probability;
        }
#endregion

        private void DisplayError(string message)
        {
            label_Error.Text = message;
        }

        private double GetChooseValue(double left, double right)
        {
            return Factorial(left)/(Factorial(right) * Factorial(left-right));
        }

        private double Factorial(double num)
        {
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        }

        private void button_FindZoneAcceptance_Click(object sender, EventArgs e)
        {
            acceptance = GetErrorAcceptance();
            if (acceptance > 0)
            {
                /// Find all other rows that can be added within the range
                #region Range Logic

                double occuranceSum = 0;
                int upIndex = 0;
                int downIndex = 0;

                List<int> toHighlight = new List<int>();
                Color colorExpVal = Color.FromName("Green");
                Color c = Color.FromName("SlateBlue");

                upIndex = (int)expectedValue + 1;
                listView_generatedValues.Items[(int)expectedValue].BackColor = colorExpVal;

                if (Math.Round(expectedValue,2) == (int)expectedValue)
                {
                    Console.WriteLine("Equals");
                    occuranceSum = values[(int)expectedValue];
                }
                else
                {
                    Console.WriteLine("not equals");
                    occuranceSum = values[(int)expectedValue] + values[upIndex];
                    listView_generatedValues.Items[upIndex].BackColor = colorExpVal;
                    upIndex++;
                }
                downIndex = (int)expectedValue - 1;

                double maxLimit = 1 - errorAcceptance;  // .95

                while(occuranceSum < maxLimit)
                {
                    occuranceSum += values[upIndex] + values[downIndex];
                    toHighlight.Add(upIndex);
                    toHighlight.Add(downIndex);
                    upIndex++;
                    downIndex--;
                }
                label_ValueRange.Text = (downIndex + 1) + " - " + (upIndex - 1);
                label_Sum.Text = occuranceSum + "";
                label_expVal.Text = Math.Round(expectedValue,2) + "";

                // Set Highlighted Color
                // http://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx
                foreach (int x in toHighlight)
                {
                    listView_generatedValues.Items[x].BackColor = c;
                }

                // now highliight that shit and be down with this gayness
                //listView_generatedValues.get
                #endregion
            }
            else {/* blow the fuck up */ }
                
        }

        private bool isEven(double x)
        {
            // return true unless tenths is >= .5
            int whole = (int)x;
            double remainder = x - whole;
            Console.WriteLine("remainder: " + remainder);
            return remainder < .5;
        }

        private double doubleTruncate(double x, int toDecimal)
        {
            toDecimal = (int) Math.Pow(10, toDecimal);
            // 2.123456789 trun to 2.12345
            int trunc = (int) x * toDecimal;
            return trunc / toDecimal;
        }

    }
}

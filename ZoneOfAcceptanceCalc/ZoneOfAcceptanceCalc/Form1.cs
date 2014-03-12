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

        public Form1()
        {
            InitializeComponent();
        }

        private void button_GenerateValues_Click(object sender, EventArgs e)
        {
            int trials = GetTrialCount();
            double probability = GetFairProbability();
            expectedValue = trials * probability;
            listView_generatedValues.Items.Clear();
            if (trials >= 0 && probability >= 0)
            {
                DisplayValues(trials, probability);
            }
        }

        private void DisplayValues(int trials, double probability)
        {
            for (int i = 0; i <= trials; i++)
            {
                string itemString = i + "      " + Math.Round(GetProbability(trials, i, probability, 1-probability),6);
                listView_generatedValues.Items.Add(itemString);
            }

        }

        private double GetProbability(int n, int k, double p, double q)
        {
            return GetChooseValue(n, k) * Math.Pow(p, k) * Math.Pow(q, n - k);
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
    }
}

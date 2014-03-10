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
            if (trials >= 0 && probability >= 0)
            {
                DisplayValues(trials, probability);
            }
        }

        private void DisplayValues(int trials, double probability)
        {
            for (int i = 0; i < trials; i++)
            {

            }

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
    }
}

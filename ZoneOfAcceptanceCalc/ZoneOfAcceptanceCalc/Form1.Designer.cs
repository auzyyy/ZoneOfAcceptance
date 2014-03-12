namespace ZoneOfAcceptanceCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Trials = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Probability = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_GenerateValues = new System.Windows.Forms.Button();
            this.label_Error = new System.Windows.Forms.Label();
            this.listView_generatedValues = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBox_Trials
            // 
            this.textBox_Trials.Location = new System.Drawing.Point(98, 9);
            this.textBox_Trials.Name = "textBox_Trials";
            this.textBox_Trials.Size = new System.Drawing.Size(100, 20);
            this.textBox_Trials.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of trials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fair probability";
            // 
            // textBox_Probability
            // 
            this.textBox_Probability.Location = new System.Drawing.Point(98, 35);
            this.textBox_Probability.Name = "textBox_Probability";
            this.textBox_Probability.Size = new System.Drawing.Size(100, 20);
            this.textBox_Probability.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note: This application assumes fair probability of all outcomes";
            // 
            // button_GenerateValues
            // 
            this.button_GenerateValues.Location = new System.Drawing.Point(63, 74);
            this.button_GenerateValues.Name = "button_GenerateValues";
            this.button_GenerateValues.Size = new System.Drawing.Size(98, 23);
            this.button_GenerateValues.TabIndex = 6;
            this.button_GenerateValues.Text = "Generate Values";
            this.button_GenerateValues.UseVisualStyleBackColor = true;
            this.button_GenerateValues.Click += new System.EventHandler(this.button_GenerateValues_Click);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(12, 531);
            this.label_Error.MaximumSize = new System.Drawing.Size(200, 0);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 13);
            this.label_Error.TabIndex = 7;
            // 
            // listView_generatedValues
            // 
            this.listView_generatedValues.Location = new System.Drawing.Point(418, 9);
            this.listView_generatedValues.Name = "listView_generatedValues";
            this.listView_generatedValues.Size = new System.Drawing.Size(215, 580);
            this.listView_generatedValues.TabIndex = 9;
            this.listView_generatedValues.UseCompatibleStateImageBehavior = false;
            this.listView_generatedValues.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 614);
            this.Controls.Add(this.listView_generatedValues);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.button_GenerateValues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Probability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Trials);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Trials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Probability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_GenerateValues;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.ListView listView_generatedValues;
    }
}


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
            this.panel_ZoneAcceptanceInfo = new System.Windows.Forms.Panel();
            this.label_Sum = new System.Windows.Forms.Label();
            this.label_ValueRange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_FindZoneAcceptance = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ErrorAcceptance = new System.Windows.Forms.TextBox();
            this.label_expVal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_ZoneAcceptanceInfo.SuspendLayout();
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
            this.listView_generatedValues.Location = new System.Drawing.Point(204, 9);
            this.listView_generatedValues.Name = "listView_generatedValues";
            this.listView_generatedValues.Size = new System.Drawing.Size(621, 580);
            this.listView_generatedValues.TabIndex = 9;
            this.listView_generatedValues.UseCompatibleStateImageBehavior = false;
            this.listView_generatedValues.View = System.Windows.Forms.View.List;
            // 
            // panel_ZoneAcceptanceInfo
            // 
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label_expVal);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label9);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label_Sum);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label_ValueRange);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label7);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label6);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.button_FindZoneAcceptance);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label5);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.label4);
            this.panel_ZoneAcceptanceInfo.Controls.Add(this.textBox_ErrorAcceptance);
            this.panel_ZoneAcceptanceInfo.Location = new System.Drawing.Point(5, 103);
            this.panel_ZoneAcceptanceInfo.Name = "panel_ZoneAcceptanceInfo";
            this.panel_ZoneAcceptanceInfo.Size = new System.Drawing.Size(193, 206);
            this.panel_ZoneAcceptanceInfo.TabIndex = 10;
            this.panel_ZoneAcceptanceInfo.Visible = false;
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.Location = new System.Drawing.Point(88, 104);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(27, 13);
            this.label_Sum.TabIndex = 16;
            this.label_Sum.Text = "N/A";
            // 
            // label_ValueRange
            // 
            this.label_ValueRange.AutoSize = true;
            this.label_ValueRange.Location = new System.Drawing.Point(88, 91);
            this.label_ValueRange.Name = "label_ValueRange";
            this.label_ValueRange.Size = new System.Drawing.Size(27, 13);
            this.label_ValueRange.TabIndex = 15;
            this.label_ValueRange.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sum: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Value Range: ";
            // 
            // button_FindZoneAcceptance
            // 
            this.button_FindZoneAcceptance.Location = new System.Drawing.Point(26, 180);
            this.button_FindZoneAcceptance.Name = "button_FindZoneAcceptance";
            this.button_FindZoneAcceptance.Size = new System.Drawing.Size(139, 23);
            this.button_FindZoneAcceptance.TabIndex = 11;
            this.button_FindZoneAcceptance.Text = "Find Zone of Acceptance";
            this.button_FindZoneAcceptance.UseVisualStyleBackColor = true;
            this.button_FindZoneAcceptance.Click += new System.EventHandler(this.button_FindZoneAcceptance_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Error acceptance";
            // 
            // textBox_ErrorAcceptance
            // 
            this.textBox_ErrorAcceptance.Location = new System.Drawing.Point(102, 31);
            this.textBox_ErrorAcceptance.Name = "textBox_ErrorAcceptance";
            this.textBox_ErrorAcceptance.Size = new System.Drawing.Size(86, 20);
            this.textBox_ErrorAcceptance.TabIndex = 11;
            // 
            // label_expVal
            // 
            this.label_expVal.AutoSize = true;
            this.label_expVal.Location = new System.Drawing.Point(88, 117);
            this.label_expVal.Name = "label_expVal";
            this.label_expVal.Size = new System.Drawing.Size(27, 13);
            this.label_expVal.TabIndex = 18;
            this.label_expVal.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Expected Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 614);
            this.Controls.Add(this.panel_ZoneAcceptanceInfo);
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
            this.panel_ZoneAcceptanceInfo.ResumeLayout(false);
            this.panel_ZoneAcceptanceInfo.PerformLayout();
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
        private System.Windows.Forms.Panel panel_ZoneAcceptanceInfo;
        private System.Windows.Forms.TextBox textBox_ErrorAcceptance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_FindZoneAcceptance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Sum;
        private System.Windows.Forms.Label label_ValueRange;
        private System.Windows.Forms.Label label_expVal;
        private System.Windows.Forms.Label label9;
    }
}


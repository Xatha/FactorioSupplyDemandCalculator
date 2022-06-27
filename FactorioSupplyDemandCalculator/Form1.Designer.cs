namespace FactorioSupplyDemandCalculatorUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfProductionFactoriesTBox = new System.Windows.Forms.TextBox();
            this.numberOfDemandingFactoriesTBox = new System.Windows.Forms.TextBox();
            this.demandRateTBox = new System.Windows.Forms.TextBox();
            this.productionRateTBox = new System.Windows.Forms.TextBox();
            this.resultsTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ValueLabelTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of producing factories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of demanding factories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 235);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 81);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Producing factories are factories that produces goods.\r\nDemanding factories are f" +
    "actories that uses goods from the producing factories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Production rate (s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Demand rate (s)";
            // 
            // numberOfProductionFactoriesTBox
            // 
            this.numberOfProductionFactoriesTBox.Location = new System.Drawing.Point(12, 27);
            this.numberOfProductionFactoriesTBox.Name = "numberOfProductionFactoriesTBox";
            this.numberOfProductionFactoriesTBox.Size = new System.Drawing.Size(171, 23);
            this.numberOfProductionFactoriesTBox.TabIndex = 6;
            this.numberOfProductionFactoriesTBox.TextChanged += new System.EventHandler(this.numberOfProductionFactoriesTBox_TextChanged);
            // 
            // numberOfDemandingFactoriesTBox
            // 
            this.numberOfDemandingFactoriesTBox.Location = new System.Drawing.Point(12, 84);
            this.numberOfDemandingFactoriesTBox.Name = "numberOfDemandingFactoriesTBox";
            this.numberOfDemandingFactoriesTBox.Size = new System.Drawing.Size(171, 23);
            this.numberOfDemandingFactoriesTBox.TabIndex = 7;
            this.numberOfDemandingFactoriesTBox.TextChanged += new System.EventHandler(this.numberOfDemandingFactoriesTBox_TextChanged);
            // 
            // demandRateTBox
            // 
            this.demandRateTBox.Location = new System.Drawing.Point(199, 84);
            this.demandRateTBox.Name = "demandRateTBox";
            this.demandRateTBox.Size = new System.Drawing.Size(100, 23);
            this.demandRateTBox.TabIndex = 8;
            this.demandRateTBox.TextChanged += new System.EventHandler(this.demandRateTBox_TextChanged);
            // 
            // productionRateTBox
            // 
            this.productionRateTBox.Location = new System.Drawing.Point(199, 27);
            this.productionRateTBox.Name = "productionRateTBox";
            this.productionRateTBox.Size = new System.Drawing.Size(100, 23);
            this.productionRateTBox.TabIndex = 9;
            this.productionRateTBox.TextChanged += new System.EventHandler(this.productionRateTBox_TextChanged);
            // 
            // resultsTBox
            // 
            this.resultsTBox.Location = new System.Drawing.Point(99, 134);
            this.resultsTBox.Name = "resultsTBox";
            this.resultsTBox.Size = new System.Drawing.Size(205, 23);
            this.resultsTBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(224, 163);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ValueLabelTBox
            // 
            this.ValueLabelTBox.Enabled = false;
            this.ValueLabelTBox.Location = new System.Drawing.Point(12, 134);
            this.ValueLabelTBox.Name = "ValueLabelTBox";
            this.ValueLabelTBox.ReadOnly = true;
            this.ValueLabelTBox.Size = new System.Drawing.Size(89, 23);
            this.ValueLabelTBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 328);
            this.Controls.Add(this.ValueLabelTBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultsTBox);
            this.Controls.Add(this.productionRateTBox);
            this.Controls.Add(this.demandRateTBox);
            this.Controls.Add(this.numberOfDemandingFactoriesTBox);
            this.Controls.Add(this.numberOfProductionFactoriesTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Factorio Supply/Demand Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox numberOfProductionFactoriesTBox;
        private TextBox numberOfDemandingFactoriesTBox;
        private TextBox demandRateTBox;
        private TextBox productionRateTBox;
        private TextBox resultsTBox;
        private Label label6;
        private Button calculateButton;
        private TextBox ValueLabelTBox;
    }
}
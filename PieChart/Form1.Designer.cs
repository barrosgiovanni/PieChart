using System.Windows.Forms.DataVisualization.Charting; 

namespace PieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.ComboBox();
            this.addExpenseLabel = new System.Windows.Forms.Label();
            this.expenseAmount = new System.Windows.Forms.TextBox();
            this.BtnResetChart = new System.Windows.Forms.Button();
            this.BtnAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.utilitiesTotal = new System.Windows.Forms.Label();
            this.insuranceTotal = new System.Windows.Forms.Label();
            this.housingTotal = new System.Windows.Forms.Label();
            this.healthTotal = new System.Windows.Forms.Label();
            this.foodTotal = new System.Windows.Forms.Label();
            this.entertainmentTotal = new System.Windows.Forms.Label();
            this.educationTotal = new System.Windows.Forms.Label();
            this.clothingTotal = new System.Windows.Forms.Label();
            this.autoTotal = new System.Windows.Forms.Label();
            this.BtnLoadChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(28, 36);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(84, 18);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category:";
            // 
            // categoriesList
            // 
            this.categoriesList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Items.AddRange(new object[] {
            "Auto",
            "Clothing",
            "Education",
            "Entertainment",
            "Food",
            "Health & Personal Care",
            "Housing",
            "Insurance",
            "Utilities"});
            this.categoriesList.Location = new System.Drawing.Point(123, 33);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(139, 26);
            this.categoriesList.TabIndex = 1;
            // 
            // addExpenseLabel
            // 
            this.addExpenseLabel.AutoSize = true;
            this.addExpenseLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseLabel.Location = new System.Drawing.Point(30, 87);
            this.addExpenseLabel.Name = "addExpenseLabel";
            this.addExpenseLabel.Size = new System.Drawing.Size(110, 18);
            this.addExpenseLabel.TabIndex = 5;
            this.addExpenseLabel.Text = "Add Expense:";
            // 
            // expenseAmount
            // 
            this.expenseAmount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmount.Location = new System.Drawing.Point(156, 84);
            this.expenseAmount.Name = "expenseAmount";
            this.expenseAmount.Size = new System.Drawing.Size(100, 26);
            this.expenseAmount.TabIndex = 6;
            // 
            // BtnResetChart
            // 
            this.BtnResetChart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetChart.Location = new System.Drawing.Point(999, 473);
            this.BtnResetChart.Name = "BtnResetChart";
            this.BtnResetChart.Size = new System.Drawing.Size(141, 27);
            this.BtnResetChart.TabIndex = 7;
            this.BtnResetChart.Text = "Reset Chart";
            this.BtnResetChart.UseVisualStyleBackColor = true;
            // 
            // BtnAddExpense
            // 
            this.BtnAddExpense.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddExpense.Location = new System.Drawing.Point(258, 83);
            this.BtnAddExpense.Name = "BtnAddExpense";
            this.BtnAddExpense.Size = new System.Drawing.Size(63, 30);
            this.BtnAddExpense.TabIndex = 8;
            this.BtnAddExpense.Text = "Add";
            this.BtnAddExpense.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Auto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clothing :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Education :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Entertainment :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Food :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Health and Personal Care :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Housing :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Insurance :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Utilities :";
            // 
            // utilitiesTotal
            // 
            this.utilitiesTotal.AutoSize = true;
            this.utilitiesTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilitiesTotal.Location = new System.Drawing.Point(121, 483);
            this.utilitiesTotal.Name = "utilitiesTotal";
            this.utilitiesTotal.Size = new System.Drawing.Size(43, 18);
            this.utilitiesTotal.TabIndex = 27;
            this.utilitiesTotal.Text = "0.00";
            // 
            // insuranceTotal
            // 
            this.insuranceTotal.AutoSize = true;
            this.insuranceTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceTotal.Location = new System.Drawing.Point(138, 443);
            this.insuranceTotal.Name = "insuranceTotal";
            this.insuranceTotal.Size = new System.Drawing.Size(43, 18);
            this.insuranceTotal.TabIndex = 26;
            this.insuranceTotal.Text = "0.00";
            // 
            // housingTotal
            // 
            this.housingTotal.AutoSize = true;
            this.housingTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housingTotal.Location = new System.Drawing.Point(124, 403);
            this.housingTotal.Name = "housingTotal";
            this.housingTotal.Size = new System.Drawing.Size(43, 18);
            this.housingTotal.TabIndex = 25;
            this.housingTotal.Text = "0.00";
            // 
            // healthTotal
            // 
            this.healthTotal.AutoSize = true;
            this.healthTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthTotal.Location = new System.Drawing.Point(268, 363);
            this.healthTotal.Name = "healthTotal";
            this.healthTotal.Size = new System.Drawing.Size(48, 18);
            this.healthTotal.TabIndex = 24;
            this.healthTotal.Text = "0.00 ";
            // 
            // foodTotal
            // 
            this.foodTotal.AutoSize = true;
            this.foodTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTotal.Location = new System.Drawing.Point(104, 323);
            this.foodTotal.Name = "foodTotal";
            this.foodTotal.Size = new System.Drawing.Size(43, 18);
            this.foodTotal.TabIndex = 23;
            this.foodTotal.Text = "0.00";
            // 
            // entertainmentTotal
            // 
            this.entertainmentTotal.AutoSize = true;
            this.entertainmentTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entertainmentTotal.Location = new System.Drawing.Point(170, 282);
            this.entertainmentTotal.Name = "entertainmentTotal";
            this.entertainmentTotal.Size = new System.Drawing.Size(43, 18);
            this.entertainmentTotal.TabIndex = 22;
            this.entertainmentTotal.Text = "0.00";
            // 
            // educationTotal
            // 
            this.educationTotal.AutoSize = true;
            this.educationTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationTotal.Location = new System.Drawing.Point(136, 241);
            this.educationTotal.Name = "educationTotal";
            this.educationTotal.Size = new System.Drawing.Size(43, 18);
            this.educationTotal.TabIndex = 21;
            this.educationTotal.Text = "0.00";
            // 
            // clothingTotal
            // 
            this.clothingTotal.AutoSize = true;
            this.clothingTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothingTotal.Location = new System.Drawing.Point(125, 201);
            this.clothingTotal.Name = "clothingTotal";
            this.clothingTotal.Size = new System.Drawing.Size(43, 18);
            this.clothingTotal.TabIndex = 20;
            this.clothingTotal.Text = "0.00";
            // 
            // autoTotal
            // 
            this.autoTotal.AutoSize = true;
            this.autoTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoTotal.Location = new System.Drawing.Point(101, 161);
            this.autoTotal.Name = "autoTotal";
            this.autoTotal.Size = new System.Drawing.Size(43, 18);
            this.autoTotal.TabIndex = 19;
            this.autoTotal.Text = "0.00";
            // 
            // BtnLoadChart
            // 
            this.BtnLoadChart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadChart.Location = new System.Drawing.Point(858, 473);
            this.BtnLoadChart.Name = "BtnLoadChart";
            this.BtnLoadChart.Size = new System.Drawing.Size(134, 27);
            this.BtnLoadChart.TabIndex = 28;
            this.BtnLoadChart.Text = "Load Chart";
            this.BtnLoadChart.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(512, 33);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(631, 427);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 533);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtnLoadChart);
            this.Controls.Add(this.utilitiesTotal);
            this.Controls.Add(this.insuranceTotal);
            this.Controls.Add(this.housingTotal);
            this.Controls.Add(this.healthTotal);
            this.Controls.Add(this.foodTotal);
            this.Controls.Add(this.entertainmentTotal);
            this.Controls.Add(this.educationTotal);
            this.Controls.Add(this.clothingTotal);
            this.Controls.Add(this.autoTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddExpense);
            this.Controls.Add(this.BtnResetChart);
            this.Controls.Add(this.expenseAmount);
            this.Controls.Add(this.addExpenseLabel);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.categoryLabel);
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoriesList;
        private System.Windows.Forms.Label addExpenseLabel;
        private System.Windows.Forms.TextBox expenseAmount;
        private System.Windows.Forms.Button BtnResetChart;
        private System.Windows.Forms.Button BtnAddExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label utilitiesTotal;
        private System.Windows.Forms.Label insuranceTotal;
        private System.Windows.Forms.Label housingTotal;
        private System.Windows.Forms.Label healthTotal;
        private System.Windows.Forms.Label foodTotal;
        private System.Windows.Forms.Label entertainmentTotal;
        private System.Windows.Forms.Label educationTotal;
        private System.Windows.Forms.Label clothingTotal;
        private System.Windows.Forms.Label autoTotal;
        private System.Windows.Forms.Button BtnLoadChart;
        private Chart chart1;
    }
}


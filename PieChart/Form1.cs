﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PieChart
{
    // Group 3:
    // Daniel Benjumea Villarraga, Giovanni Evangelista De Barros, Max Dyson

    public partial class Form1 : Form
    {
        List<Category> ListOfCategories { get; set; } = new List<Category>();
        public void InitializeCategories()
        {
            Category auto = new Category("Auto", 0.00);
            ListOfCategories.Add(auto);
            Category clothing = new Category("Clothing", 0.00);
            ListOfCategories.Add(clothing);
            Category education = new Category("Education", 0.00);
            ListOfCategories.Add(education);
            Category entertainment = new Category("Entertainment", 0.00);
            ListOfCategories.Add(entertainment);
            Category food = new Category("Food", 0.00);
            ListOfCategories.Add(food);
            Category health = new Category("Health & Personal Care", 0.00);
            ListOfCategories.Add(health);
            Category housing = new Category("Housing", 0.00);
            ListOfCategories.Add(housing);
            Category insurance = new Category("Insurance", 0.00);
            ListOfCategories.Add(insurance);
            Category utilities = new Category("Utilities", 0.00);
            ListOfCategories.Add(utilities);
        }
        public Form1()
        {
            InitializeCategories();
            InitializeComponent();
        }

        private void UpdateValues(Category categoryToBeUpdated)
        {
            switch (categoryToBeUpdated.Name)
            {
                case "Auto":
                    autoTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    autoTotal.Refresh();
                    break;
                case "Clothing":
                    clothingTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    clothingTotal.Refresh();
                    break;
                case "Education":
                    educationTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    educationTotal.Refresh();
                    break;
                case "Entertainment":
                    entertainmentTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    entertainmentTotal.Refresh();
                    break;
                case "Food":
                    foodTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    foodTotal.Refresh();
                    break;
                case "Health & Personal Care":
                    healthTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    healthTotal.Refresh();
                    break;
                case "Housing":
                    housingTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    housingTotal.Refresh();
                    break;
                case "Insurance":
                    insuranceTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    insuranceTotal.Refresh();
                    break;
                case "Utilities":
                    utilitiesTotal.Text = categoryToBeUpdated.TotalAmount.ToString();
                    utilitiesTotal.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void BtnAddExpense_Click(object sender, EventArgs e)
        {
            string inputCategory = categoriesList.Text;
            double inputAmount = double.Parse(expenseAmount.Text);
            foreach (Category category in ListOfCategories)
            {
                if (category.Name == inputCategory)
                {
                    category.TotalAmount += inputAmount;
                    Category categoryToBeUpdated = category;
                    UpdateValues(categoryToBeUpdated);
                }
            }

            expenseAmount.Text = "";
            categoriesList.Text = "";
        }

        private void BtnLoadChart_Click(object sender, EventArgs e)
        {

            // Clear the previous data from the expensePieChart 

            expensePieChart.Series[0].Points.Clear();

            
            foreach(Category category in ListOfCategories)
            {

                // The total amount should not be greater than 0 because it would not make a slice

                if (category.TotalAmount > 0)
                {
                    // Inserts a category to the expensePieChart  

                    expensePieChart.Series[0].Points.AddXY(category.Name, category.TotalAmount);

                }

            }



        }


        private void BtnResetChart_Click(object sender, EventArgs e)
        {
            foreach (Category category in ListOfCategories)
            {
                category.TotalAmount = 0;
            }
            foreach (var control in this.Controls)
            {
                if (control is Label label)
                {
                    if (label.Name.Contains("Total"))
                    {
                        label.Text = "0.00";
                    }
                    label.Refresh();
                }
            }
            expenseAmount.Text = "";
            categoriesList.Text = "";
        }
     


    }
}

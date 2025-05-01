using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ShoppingListApp
{
    public partial class Form2 : Form
    {
        string jsonFilePath = "shoppinglist.json";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();

            // Add non-empty items from textboxes
            if (!string.IsNullOrWhiteSpace(txtItem1.Text)) items.Add(txtItem1.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtItem2.Text)) items.Add(txtItem2.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtItem3.Text)) items.Add(txtItem3.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtItem4.Text)) items.Add(txtItem4.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtItem5.Text)) items.Add(txtItem5.Text.Trim());

            if (items.Count == 0)
            {
                MessageBox.Show("Please enter at least one item.");
                return;
            }

            // Save to JSON
            string json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);

            MessageBox.Show("Shopping list saved.");
            this.Close();
        }
    }
}
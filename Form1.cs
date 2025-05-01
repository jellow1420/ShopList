using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ShoppingListApp
{
    public partial class Form1 : Form
    {
        string jsonFilePath = "shoppinglist.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Auto-load the shopping list when the form opens
            LoadShoppingList();
        }

        private void OpenShopList_Click(object sender, EventArgs e)
        {
            // Debug message to confirm button functionality
            MessageBox.Show("OpenShopList button clicked!");
            LoadShoppingList();
        }

        private void LoadShoppingList()
        {
            try
            {
                // Check if the JSON file exists
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);

                    // Debugging JSON content
                    MessageBox.Show($"JSON Content: {json}");

                    // Deserialize the JSON content
                    List<string> items = JsonConvert.DeserializeObject<List<string>>(json);

                    // Clear the list and populate it with items from the JSON file
                    ShoppingList.Items.Clear();
                    foreach (var item in items)
                    {
                        ShoppingList.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No shopping list found. Please add items.");
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors gracefully
                MessageBox.Show($"Error loading shopping list: {ex.Message}");
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            // Open Form2 to add items
            Form2 addForm = new Form2();
            addForm.ShowDialog();

            // Refresh the shopping list after adding items
            LoadShoppingList();
        }

        private void ShoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Respond to item selection (not implemented)
        }
    }
}
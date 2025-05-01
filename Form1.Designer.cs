namespace ShoppingListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ShoppingList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Shopping List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenShopList_Click);
            // 
            // ShoppingList
            // 
            this.ShoppingList.FormattingEnabled = true;
            this.ShoppingList.ItemHeight = 16;
            this.ShoppingList.Location = new System.Drawing.Point(12, 178);
            this.ShoppingList.Name = "ShoppingList";
            this.ShoppingList.Size = new System.Drawing.Size(300, 200);
            this.ShoppingList.TabIndex = 1;
            this.ShoppingList.SelectedIndexChanged += new System.EventHandler(this.ShoppingList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShoppingList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Shopping List App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ShoppingList;
        private System.Windows.Forms.Button button2;
    }
}
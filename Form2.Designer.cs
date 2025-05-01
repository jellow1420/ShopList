namespace ShoppingListApp
{
    partial class Form2
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
            this.txtItem1 = new System.Windows.Forms.TextBox();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.txtItem3 = new System.Windows.Forms.TextBox();
            this.txtItem4 = new System.Windows.Forms.TextBox();
            this.txtItem5 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItem1
            // 
            this.txtItem1.Location = new System.Drawing.Point(12, 48);
            this.txtItem1.Name = "txtItem1";
            this.txtItem1.Size = new System.Drawing.Size(100, 22);
            this.txtItem1.TabIndex = 0;
            // 
            // txtItem2
            // 
            this.txtItem2.Location = new System.Drawing.Point(12, 76);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.Size = new System.Drawing.Size(100, 22);
            this.txtItem2.TabIndex = 1;
            // 
            // txtItem3
            // 
            this.txtItem3.Location = new System.Drawing.Point(12, 104);
            this.txtItem3.Name = "txtItem3";
            this.txtItem3.Size = new System.Drawing.Size(100, 22);
            this.txtItem3.TabIndex = 2;
            // 
            // txtItem4
            // 
            this.txtItem4.Location = new System.Drawing.Point(12, 132);
            this.txtItem4.Name = "txtItem4";
            this.txtItem4.Size = new System.Drawing.Size(100, 22);
            this.txtItem4.TabIndex = 3;
            // 
            // txtItem5
            // 
            this.txtItem5.Location = new System.Drawing.Point(12, 160);
            this.txtItem5.Name = "txtItem5";
            this.txtItem5.Size = new System.Drawing.Size(100, 22);
            this.txtItem5.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 60);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtItem5);
            this.Controls.Add(this.txtItem4);
            this.Controls.Add(this.txtItem3);
            this.Controls.Add(this.txtItem2);
            this.Controls.Add(this.txtItem1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtItem1;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.TextBox txtItem3;
        private System.Windows.Forms.TextBox txtItem4;
        private System.Windows.Forms.TextBox txtItem5;
        private System.Windows.Forms.Button btnSave;
    }
}
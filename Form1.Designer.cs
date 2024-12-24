namespace ShoppingCart
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
            chbCoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            tbCoffeePrice = new TextBox();
            Total = new Label();
            tbGreenTeaPrice = new TextBox();
            btCheckOut = new Button();
            tbTotal = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(140, 61);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 0;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(140, 90);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(77, 19);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "Green Tea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(223, 61);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(100, 23);
            tbCoffeePrice.TabIndex = 2;
            tbCoffeePrice.TextChanged += tbCoffeePrice_TextChanged;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(291, 140);
            Total.Name = "Total";
            Total.Size = new Size(32, 15);
            Total.TabIndex = 3;
            Total.Text = "Total";
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(223, 90);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 4;
            // 
            // btCheckOut
            // 
            btCheckOut.Location = new Point(456, 61);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(75, 377);
            btCheckOut.TabIndex = 5;
            btCheckOut.Text = "Check Out";
            btCheckOut.UseVisualStyleBackColor = true;
            btCheckOut.Click += btCheckOut_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(340, 137);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 6;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(340, 61);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(100, 23);
            tbCoffeeQuantity.TabIndex = 7;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(340, 90);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 31);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 9;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 31);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "Quantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbTotal);
            Controls.Add(btCheckOut);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(Total);
            Controls.Add(tbCoffeePrice);
            Controls.Add(chbGreenTea);
            Controls.Add(chbCoffee);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbCoffee;
        private CheckBox chbGreenTea;
        private TextBox tbCoffeePrice;
        private Label Total;
        private TextBox tbGreenTeaPrice;
        private Button btCheckOut;
        private TextBox tbTotal;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
        private Label label1;
        private Label label2;
    }
}

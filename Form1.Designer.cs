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
            tbCash = new TextBox();
            Cash = new Label();
            tbChange = new TextBox();
            tb1000 = new TextBox();
            tb500 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            label4 = new Label();
            lb1000 = new Label();
            lb500 = new Label();
            lb100 = new Label();
            lb50 = new Label();
            lb20 = new Label();
            lb10 = new Label();
            lb5 = new Label();
            lb1 = new Label();
            button1 = new Button();
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
            Total.Location = new Point(291, 210);
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
            btCheckOut.Size = new Size(75, 106);
            btCheckOut.TabIndex = 5;
            btCheckOut.Text = "Check Out";
            btCheckOut.UseVisualStyleBackColor = true;
            btCheckOut.Click += btCheckOut_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(340, 207);
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
            // tbCash
            // 
            tbCash.Location = new Point(340, 282);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(100, 23);
            tbCash.TabIndex = 11;
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.Location = new Point(293, 286);
            Cash.Name = "Cash";
            Cash.Size = new Size(33, 15);
            Cash.TabIndex = 12;
            Cash.Text = "Cash";
            // 
            // tbChange
            // 
            tbChange.Location = new Point(615, 54);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(100, 23);
            tbChange.TabIndex = 13;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(615, 83);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(100, 23);
            tb1000.TabIndex = 14;
            // 
            // tb500
            // 
            tb500.Location = new Point(615, 112);
            tb500.Name = "tb500";
            tb500.Size = new Size(100, 23);
            tb500.TabIndex = 15;
            // 
            // tb100
            // 
            tb100.Location = new Point(615, 141);
            tb100.Name = "tb100";
            tb100.Size = new Size(100, 23);
            tb100.TabIndex = 16;
            // 
            // tb50
            // 
            tb50.Location = new Point(615, 170);
            tb50.Name = "tb50";
            tb50.Size = new Size(100, 23);
            tb50.TabIndex = 17;
            // 
            // tb20
            // 
            tb20.Location = new Point(615, 199);
            tb20.Name = "tb20";
            tb20.Size = new Size(100, 23);
            tb20.TabIndex = 18;
            // 
            // tb10
            // 
            tb10.Location = new Point(615, 228);
            tb10.Name = "tb10";
            tb10.Size = new Size(100, 23);
            tb10.TabIndex = 19;
            // 
            // tb5
            // 
            tb5.Location = new Point(615, 257);
            tb5.Name = "tb5";
            tb5.Size = new Size(100, 23);
            tb5.TabIndex = 20;
            // 
            // tb1
            // 
            tb1.Location = new Point(615, 286);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 57);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 22;
            label4.Text = "Change";
            // 
            // lb1000
            // 
            lb1000.AutoSize = true;
            lb1000.Location = new Point(571, 86);
            lb1000.Name = "lb1000";
            lb1000.Size = new Size(31, 15);
            lb1000.TabIndex = 23;
            lb1000.Text = "1000";
            // 
            // lb500
            // 
            lb500.AutoSize = true;
            lb500.Location = new Point(571, 115);
            lb500.Name = "lb500";
            lb500.Size = new Size(25, 15);
            lb500.TabIndex = 24;
            lb500.Text = "500";
            // 
            // lb100
            // 
            lb100.AutoSize = true;
            lb100.Location = new Point(571, 144);
            lb100.Name = "lb100";
            lb100.Size = new Size(25, 15);
            lb100.TabIndex = 25;
            lb100.Text = "100";
            // 
            // lb50
            // 
            lb50.AutoSize = true;
            lb50.Location = new Point(571, 173);
            lb50.Name = "lb50";
            lb50.Size = new Size(19, 15);
            lb50.TabIndex = 26;
            lb50.Text = "50";
            // 
            // lb20
            // 
            lb20.AutoSize = true;
            lb20.Location = new Point(571, 202);
            lb20.Name = "lb20";
            lb20.Size = new Size(19, 15);
            lb20.TabIndex = 27;
            lb20.Text = "20";
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(571, 231);
            lb10.Name = "lb10";
            lb10.Size = new Size(19, 15);
            lb10.TabIndex = 28;
            lb10.Text = "10";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(572, 260);
            lb5.Name = "lb5";
            lb5.Size = new Size(13, 15);
            lb5.TabIndex = 29;
            lb5.Text = "5";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(572, 290);
            lb1.Name = "lb1";
            lb1.Size = new Size(13, 15);
            lb1.TabIndex = 30;
            lb1.Text = "1";
            // 
            // button1
            // 
            button1.Location = new Point(456, 202);
            button1.Name = "button1";
            button1.Size = new Size(75, 107);
            button1.TabIndex = 31;
            button1.Text = "pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lb1);
            Controls.Add(lb5);
            Controls.Add(lb10);
            Controls.Add(lb20);
            Controls.Add(lb50);
            Controls.Add(lb100);
            Controls.Add(lb500);
            Controls.Add(lb1000);
            Controls.Add(label4);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(Cash);
            Controls.Add(tbCash);
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
        private TextBox tbCash;
        private Label Cash;
        private TextBox tbChange;
        private TextBox tb1000;
        private TextBox tb500;
        private TextBox tb100;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
        private Label label4;
        private Label lb1000;
        private Label lb500;
        private Label lb100;
        private Label lb50;
        private Label lb20;
        private Label lb10;
        private Label lb5;
        private Label lb1;
        private Button button1;
    }
}

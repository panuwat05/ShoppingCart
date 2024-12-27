using System.Security.Policy;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void tbCoffeePrice_TextChanged(object sender, EventArgs e)
        {


        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            // get amout
            string strCoffeePrice = tbCoffeePrice.Text;
            string strGreenTeaPrice = tbGreenTeaPrice.Text;

            // get price
            string strCoffeeQuantity = tbCoffeeQuantity.Text;
            string strGreenTeaQuantity = tbGreenTeaQuantity.Text;



            double iCoffeePrice = 0;
            double iCoffeeQuantity = 0;
            double iGreenTeaPrice = 0;
            double iGreenTeaQuantity = 0;
            try
            {
                // str to double
                // chbCoffee.Checked เเปลงค่าเป็นบูลีน
                if (chbCoffee.Checked)
                {
                    iCoffeePrice = double.Parse(strCoffeePrice);
                    iCoffeeQuantity = double.Parse(strCoffeeQuantity);
                }
                if (chbGreenTea.Checked)
                {
                    iGreenTeaPrice = double.Parse(strGreenTeaPrice);
                    iGreenTeaQuantity = double.Parse(strGreenTeaQuantity);
                }
            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
                iGreenTeaPrice = 0;
                iGreenTeaQuantity = 0;
            }

            // calculate total
            double iTotalCoffee = iCoffeePrice * iCoffeeQuantity;
            double iTotalGreenTea = iGreenTeaPrice * iGreenTeaQuantity;
            double itotal = iTotalCoffee + iTotalGreenTea;


            // display total
            tbTotal.Text = itotal.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // get total
            string strtotal = tbTotal.Text;
            string strCash = tbCash.Text;
            string strChange = tbChange.Text;
            string strTotal = tbTotal.Text;

            // str to double
            double iCash = 1;
            try
            {
                iCash = double.Parse(strCash);
            }
            catch (Exception ex)
            {
                iCash = 0;
            }
            double iTotal = double.Parse(strTotal);

            // calculate 
            double iChange = iCash - iTotal;

            //// display total
            tbChange.Text = iChange.ToString();

            
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] denominationTextBoxes = {tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1};

            // Clear all text boxes first
            foreach (var textBox in denominationTextBoxes)
            {
                textBox.Text = "0";
            }

            // Calculate each denomination
            for (int i = 0; i < denominations.Length; i++)
            {
                int denom = denominations[i];
                int count = (int)(iChange / denom);

                if (count > 0)
                {
                    denominationTextBoxes[i].Text = count.ToString();
                    iChange %= denom;
                }
            }
        }

       
    }
}

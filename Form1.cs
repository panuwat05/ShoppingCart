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
            string strGreenTeaQuantity = tbCoffeeQuantity.Text;

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
    }
}

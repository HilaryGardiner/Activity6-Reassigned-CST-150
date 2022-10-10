namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double storeDoubleConversion;// variable to store double conversion
            double storeWeightInKilograms; // Variable to store conversion from lbs to kilograms
            if (double.TryParse(textBoxInput.Text, out storeDoubleConversion))
            {
                
                storeWeightInKilograms = storeDoubleConversion / 2.205;
                string storeStringConversion; // variable to store string conversion
                storeStringConversion = storeWeightInKilograms.ToString("n3");//Convert double to string

                labelOutputResult.Text = storeStringConversion; // display the result from textBoxInput after calculation
                 
            }
            else
            {
                MessageBox.Show("Enter a valid number.");
            }
        }
    }
}
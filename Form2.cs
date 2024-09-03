//Gill Guimaraes
//CIST 2341
//Lab 2 Part II


namespace Convert
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Why is this console command not displaying in output window?..
            //Console.WriteLine("convert button was pressed");

            //this is correctly displaying the ouput
            System.Diagnostics.Debug.WriteLine("convert button was pressed");



            if (fahrToCelRadio.Checked == true)
            {
                //using try catch block for user input validation
                try
                {
                    //grabbing user iput
                    string fahrenheitInput = fahrTxtBox.Text;

                    //converting userInput to double
                    double doubleValue = Double.Parse(fahrenheitInput);

                    //calculate conversion
                    double result = (doubleValue - 32) * 5 / 9;

                    // assigning result value to celTxtBox and passing the ToString() method
                    celTxtBox.Text = result.ToString();

                    // having fun with string Concatenation
                    System.Diagnostics.Debug.WriteLine("Fahrenheit to Celsius. " + fahrenheitInput + " F is equal to: " + result + " celsius.");

                }
                catch
                {
                    MessageBox.Show("Please enter a numeric value in the Fahrenheit field to be converted.");
                }

                //setting title bar value to radio selection
                Form2.ActiveForm.Text = fahrToCelRadio.Text;
            }
            if (celToFahrRadio.Checked == true)
            {
                try
                {
                    //reversing my logic from above
                    string celsiusInput = celTxtBox.Text;
                    double doubleValue = Double.Parse(celsiusInput);
                    double result = (doubleValue * 9 / 5) + 32;
                    fahrTxtBox.Text = result.ToString();
                    System.Diagnostics.Debug.WriteLine("Celsius to Fahrenheit. " + celsiusInput + " C is equal to: " + result + " Fahrenheit.");

                }
                catch
                {
                    MessageBox.Show("Please enter a numeric value in the Celsius field to be converted.");
                }
                Form2.ActiveForm.Text = celToFahrRadio.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Exit button was pressed."); // this is not working.
            System.Diagnostics.Debug.WriteLine("exit button was pressed");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fahrTxtBox.Text = string.Empty;
            celTxtBox.Text= string.Empty;
            //Console.WriteLine("Inputs cleared");
            System.Diagnostics.Debug.WriteLine("Input fields have been cleared");
        }

        private void fahrToCelRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fahrTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void celTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

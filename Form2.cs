
/*********************************************************

   Gill Guimaraes

   Lab #3 - September 6, 2024

   I wrote this code myself...
   I did not use AI or copy code from Google or another student

 *********************************************************/

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
                    System.Diagnostics.Debug.WriteLine(fahrenheitInput + " F is equal to: " + result + " celsius.");
                    fahrToCelRadio.Checked = false; //clearing radio.checked so Celsius txt box will display
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
                    System.Diagnostics.Debug.WriteLine(celsiusInput + " C is equal to: " + result + " Fahrenheit.");
                    celToFahrRadio.Checked = false;

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
            System.Diagnostics.Debug.WriteLine("exit button was pressed");

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Leaving already?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (celToFahrRadio.Checked == true)
            {
                fahrTxtBox.Visible = false;
            }
            else if (celToFahrRadio.Checked == false)
            {
                fahrTxtBox.Visible = true;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fahrTxtBox.Text = string.Empty;
            celTxtBox.Text = string.Empty;
            fahrToCelRadio.Checked = false;
            celToFahrRadio.Checked = false;
            System.Diagnostics.Debug.WriteLine("Input fields have been cleared");
            Console.WriteLine("Inputs cleared");
        }

        private void fahrToCelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (fahrToCelRadio.Checked == true)
            {
                celTxtBox.Visible = false;
            }
            else if (fahrToCelRadio.Checked == false)
            {
                celTxtBox.Visible = true;
            }
        }

        private void fahrTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void celTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}

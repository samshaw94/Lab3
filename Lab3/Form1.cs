namespace Lab3
{
    public partial class Form1 : Form
    {
        /* Name: Sam Shaw
        * Date: start October 27 - finish october
        * This program calculates an annuity */

        double totalPayments = 0;
        const int minYears = 5;
        const string myName = "Sam Shaw";

        public Form1()
        {
            InitializeComponent();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            //displays help messsage when clicking on the help picture
            string helpMessage =
                "This program reads in 2 numbers:\n " + "\tFuture Value: amount of \"$\"\n" + "\tyears: must be at least "
                + minYears + "\nand calculates payments based on:\n" + "\tYearly interest rate of " + lblRatePerYear.Text + "%";
            MessageBox.Show(helpMessage, myName);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //displays total payments and closes form
            //use C for currency
            string exitMessage = "Thanks for using the program!\n" + totalPayments.ToString("C");
            MessageBox.Show(exitMessage, myName);
            this.Close();
        }
        //create ResetAll method
        private void ResetAll()
        {
            grpSolution.Visible = false;
            txtFutureValue.Clear();
            txtYears.Clear();
            lblPayment.Text = "";
            txtFutureValue.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double futureValue;
                int years;
                //reading in data
                futureValue = Convert.ToDouble(txtFutureValue.Text);
                years = Convert.ToInt32(txtYears.Text);

                //make sure they enter a minimum of 5 years
                if (years < minYears)
                {
                    MessageBox.Show("Years must be at least " + minYears, myName);

                    txtYears.Clear();
                    //put cursor back
                    txtYears.Focus();

                    //not sure if return is the right thing here - check slides
                    return;
                }
                //calculate, 
                double yearlyRate = Convert.ToDouble(lblRatePerYear.Text);
                //convert to monthly values
                double r = (double)yearlyRate / 100 / 12;
                int n = years * 12;

                //calculate payment
                double payment = ((double)futureValue * r) / (Math.Pow(1 + r, n) - 1);
                //display answer, use C for currency
                lblPayment.Text = payment.ToString("C");
                //display solution group??
                grpSolution.Visible = true;
                //add to running total
                totalPayments += Convert.ToDouble(payment);
            } catch (Exception ex)
            {//show message if catch is needed
                string catchMessage = "Message Encountered\n" + "input string was not in the correct format";
                MessageBox.Show(catchMessage, myName);
            }
        }
    }
}

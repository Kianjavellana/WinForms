using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string position = textBox2.Text;
            double hoursWorked = double.Parse(textBox3.Text);
            double ratePerHour = double.Parse(textBox4.Text);
            double overtimeRate = double.Parse(textBox5.Text);

            // Calculate the regular hours and OT hours
            double regularHours = Math.Min(hoursWorked, 40);
            double OTHours = Math.Max(0, hoursWorked - 40);

            // Calculate the rate pay and total OT pay
            double ratePay = regularHours * ratePerHour;
            double overtimePay = OTHours * overtimeRate;

            // Calculate the gross salary
            double grossSalary = ratePay + overtimePay;

            // Calculate the SSS and withholding tax
            double sss = grossSalary * 0.05;
            double withholdingTax = grossSalary * 0.1;

            // Calculate the total deduction and net salary
            double totalDeduction = sss + withholdingTax;
            double netSalary = grossSalary - totalDeduction;

            // Display the results in the labels
            textBox6.Text = OTHours.ToString("0.00");
            textBox7.Text = regularHours.ToString("0.00");
            textBox8.Text = ratePerHour.ToString("0.00");
            textBox9.Text = grossSalary.ToString("0.00");
            textBox10.Text = sss.ToString("0.00");
            textBox11.Text = withholdingTax.ToString("0.00");
            textBox12.Text = totalDeduction.ToString("0.00");
            textBox13.Text = netSalary.ToString("0.00");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

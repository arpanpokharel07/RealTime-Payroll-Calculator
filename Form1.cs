
namespace RealTIme_Payroll_Calculator
{

	public partial class Form1 : Form
	{
		List<TaxBracket> _federal = new List<TaxBracket>();
		List<TaxBracket> _alberta = new List<TaxBracket>();
		List<TaxBracket> _british_columbia = new List<TaxBracket>();
		List<TaxBracket> ontario = new List<TaxBracket>();


		void LoadONTax()
		{
			ontario.Add(new TaxBracket(5.05, 0, 51446));
			ontario.Add(new TaxBracket(9.15, 51446, 102894));
			ontario.Add(new TaxBracket(11.16, 102894, 150000));
			ontario.Add(new TaxBracket(12.16, 150000, 220000));
			ontario.Add(new TaxBracket(13.16, 220000, 0));
		}
		void LoadABTax()
		{
			_alberta.Add(new TaxBracket(10, 0, 148269));
			_alberta.Add(new TaxBracket(12, 148269, 177922));
			_alberta.Add(new TaxBracket(13, 177922, 237230));
			_alberta.Add(new TaxBracket(14, 237230, 355845));
			_alberta.Add(new TaxBracket(15, 355845, 0));
		}
		void LoadBCTax()
		{
			_british_columbia.Add(new TaxBracket(5.06, 0, 47937));
			_british_columbia.Add(new TaxBracket(7.7, 47937, 95875));
			_british_columbia.Add(new TaxBracket(10.5, 95875, 110076));
			_british_columbia.Add(new TaxBracket(12.29, 110076, 133664));
			_british_columbia.Add(new TaxBracket(14.7, 133664, 181232));
			_british_columbia.Add(new TaxBracket(16.8, 181232, 252752));
			_british_columbia.Add(new TaxBracket(20.5, 252752, 0));
		}


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadFederalTax();
			LoadONTax();
			LoadABTax();
			LoadBCTax();
			cbFrequency.SelectedIndex = 0;
			cbProvince.SelectedIndex = 0;
		}

		void LoadFederalTax()
		{
			_federal.Add(new TaxBracket(15, 0, 55867));
			_federal.Add(new TaxBracket(20.5, 55867, 111733));
			_federal.Add(new TaxBracket(26, 111733, 173205));
			_federal.Add(new TaxBracket(29, 173205, 246752));
			_federal.Add(new TaxBracket(33, 246752, 0));
		}
		void CalculateFederalTax(double amount)
		{
			double tax = 0;
			if (0 < amount && amount <= 50000)
			{
				//Example: 25k
				// 25k
				tax = amount * 0.1;
				lblSalary.Text = "25k";
			}
			else if (50000 < amount && amount <= 110000)
			{
				//Example: 60k
				//50k 10k
				tax = (50000 * 0.1) + ((amount - 50000) * 0.1);
				lblSalary.Text = "60k";
			}
			else if (11000 < amount && amount <= 150000)
			{
				//Example: 140k
				//
				tax = (50000 * 0.1) + ((110000 - 50000) * 0.1) + ((amount - 110000) * 0.1);
				lblSalary.Text = "140k";
			}
			else if (150000 < amount && amount <= 240000)
			{
				//Example: 200k
				tax = (50000 * 0.1) + ((110000 - 50000) * 0.1) + ((150000 - 110000) * 0.1) + ((amount - 150000) * 0.1);
				lblSalary.Text = "200k";
			}
			else if (240000 < amount)
			{
				//Example:250k
				tax = (50000 * 0.1) + ((110000 - 50000) * 0.1) + ((150000 - 110000) * 0.1) + ((240000 - 150000) * 0.1) + ((amount-240000)*0.1);
				lblSalary.Text = "250k";
			}

			lblSalary.Text += "\n Amount is:" + amount + "\n Tax is: " + tax.ToString();
		}

		void CalculateProvinceTax(double amount)
		{

		}


		private void btnCalculate_Click(object sender, EventArgs e)
		{
			//Takes all the value from the users for calculation
			string province = cbProvince.Text;
			string frequency = cbFrequency.Text;
			double hours = double.Parse(txtHours.Text);
			double rate = double.Parse(txtRate.Text);
			double salary = rate * hours;

			//Calculating annual salary
			switch (frequency)
			{
				case "Annual":
					{
						salary *= 1;
						break;
					}
				case "Semi-Annual":
					{
						salary *= 2;
						break;
					}
				case "Monthly":
					{
						salary *= 12;
						break;
					}
				case "Bi-weekly":
					{
						salary *= 26;
						break;
					}
				case "Weekly":
					{
						salary *= 52;
						break;
					}
			}

			//Calculating federal tax
			CalculateFederalTax(salary);

			//Calculating provincial tax
			//CalculateProvinceTax(salary);
		}

	}
}

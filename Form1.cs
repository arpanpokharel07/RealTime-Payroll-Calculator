
namespace RealTIme_Payroll_Calculator
{

	public partial class Form1 : Form
	{
		double _provinceTax = 0;
		double _federalTax = 0;
		double CalculateABTax(double amount)
		{
			double _provinceTax = 0;
			if (0 < amount && amount <= 148269)
			{
				_provinceTax = amount * 0.1;
			}
			else if (148269 < amount && amount <= 177922)
			{
				_provinceTax = (148269 * 0.1) + ((amount - 148269) * 0.12);
			}
			else if (177922< amount && amount <= 237230)
			{
				_provinceTax = (148269 * 0.1) + ((177922- 148269) * 0.12) + ((amount - 177922) * 0.13);

			}
			else if (237230< amount && amount <= 355845)
			{
				_provinceTax = (148269 * 0.1) + ((177922- 148269) * 0.12) + ((237230- 177922) * 0.13) + ((amount - 237230) * 0.14);

			}
			else if (355845< amount)
			{
				_provinceTax = (148269 * 0.1) + ((177922- 148269) * 0.12) + ((237230- 177922) * 0.13) + ((355845- 237230) * 0.14) + ((amount - 355845) * 0.15);

			}
			return _provinceTax;
		}
		double CalculateBCTax(double amount)
		{
			if (0 < amount && amount <= 47937)
			{
				_provinceTax = amount * 0.0506;
			}
			else if (47937 < amount && amount <= 95875)
			{
				_provinceTax = (47937 * 0.0506) + ((amount - 47937) * 0.077);
			}
			else if (95875 < amount && amount <= 110076)
			{
				_provinceTax = (47937 * 0.0506) + ((95875 - 47937) * 0.077) +
						((amount - 95875) * 0.105);

			}
			else if (110076 < amount && amount <= 133664)
			{
				_provinceTax = (47937 * 0.0506) + ((95875 - 47937) * 0.077) + 
					((110076 - 95875) * 0.105) + ((amount - 110076) * 0.1229);

			}
			else if (133664 < amount && amount <= 181232)
			{
				_provinceTax = (47937 * 0.0506) + ((95875 - 47937) * 0.077) + 
					((110076 - 95875) * 0.105) + ((110076 - 95875) * 0.1229) + 
					((amount - 133664) * 0.147);

			}
			else if (181232 < amount && amount <= 252752)
			{
				_provinceTax = (47937 * 0.0506) + ((95875 - 47937) * 0.077) + 
					((110076 - 95875) * 0.105) + ((110076 - 95875) * 0.1229) + 
					((133664 - 110076) * 0.147) + ((amount - 181232) * 0.168);

			}
			else if (252752 < amount)
			{
				_provinceTax = (47937 * 0.0506) + ((95875 - 47937) * 0.077) + 
					((110076 - 95875) * 0.105) + ((110076 - 95875) * 0.1229) + 
					((133664 - 110076) * 0.147) + ((181232 - 133664) * 0.168) + 
					((amount - 252752) * 0.205);

			}
			return _provinceTax;
		}
		double CalculateONTax( double amount)
		{
			int[] threshold= { 51446, 102894, 150000, 220000};
			double[] rate = { 5.05/100, 9.15/100, 11.16 / 100, 12.16/100, 13.16/100 };

			if (0 < amount && amount <= threshold[0])
			{
				_provinceTax = amount * rate[0];
			}
			else if (threshold[0] < amount && amount <= threshold[1])
			{
				_provinceTax = (threshold[0] * rate[0]) + ((amount - threshold[0]) * rate[1]);
			}
			else if (threshold[1] < amount && amount <= threshold[2])
			{
				_provinceTax = (threshold[0] * rate[0]) + ((threshold[1] - threshold[0]) * rate[1]) + ((amount - threshold[1]) * rate[2]);

			}
			else if (threshold[2] < amount && amount <= threshold[3])
			{
				_provinceTax = (threshold[0] * rate[0]) + ((threshold[1] - threshold[0]) * rate[1]) + ((threshold[2] - threshold[1]) * rate[2]) + ((amount - threshold[2]) * rate[3]);

			}
			else if (threshold[3] < amount)
			{
				_provinceTax = (threshold[0] * rate[0]) + ((threshold[1] - threshold[0]) * rate[1]) + ((threshold[2] - threshold[1]) * rate[2]) + ((threshold[3] - threshold[2]) * rate[3]) + ((amount - threshold[3]) * rate[4]);

			}
			return _provinceTax;
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbFrequency.SelectedIndex = 0;
			cbProvince.SelectedIndex = 0;
		}

		
		void CalculateFederalTax(double amount)
		{
			if (0 < amount && amount <= 55867)
			{
				_federalTax = amount * 0.15;
			}
			else if (55867 < amount && amount <= 111733)
			{
				_federalTax = (55867 * 0.15) + ((amount - 55867) * 0.205);
			}
			else if (111733 < amount && amount <= 173205)
			{
				_federalTax = (55867 * 0.15) + ((111733 - 55867) * 0.205) + ((amount - 111733) * 0.26);

			}
			else if (173205 < amount && amount <= 246752)
			{
				_federalTax = (55867 * 0.15) + ((111733 - 55867) * 0.205) + ((173205 - 111733) * 0.26) + ((amount - 173205) * 0.29);

			}
			else if (246752 < amount)
			{
				_federalTax = (55867 * 0.15) + ((111733 - 55867) * 0.205) + ((173205 - 111733) * 0.26) + ((246752 - 173205) * 0.29) + ((amount - 246752) * 0.33);

			}

			lblSalary.Text += "\n Total amount is: $" + Math.Round((amount+ 15705), 2) + "\n Federal Tax is: $" + Math.Round(_federalTax, 2).ToString();
		}
		void CalculateProvinceTax(double amount)
		{
			switch (cbProvince.Text)
			{
				case "Ontario":
					{
						lblSalary.Text += "\n ON Tax: " + Math.Round(CalculateONTax(amount), 2);
						break;
					}
				case "Alberta":
					{
						lblSalary.Text += "\n AB Tax: " + Math.Round(CalculateABTax(amount), 2);
						break;
					}
				case "British Columbia":
					{
						lblSalary.Text += "\n BC Tax: " + Math.Round(CalculateBCTax(amount), 2);
						break;
					}
			}
		}
	

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			lblSalary.Text = "";
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
						salary *= 52;
						break;
					}
				case "Semi-Annual":
					{
						salary *= 26;
						break;
					}
				case "Monthly":
					{
						salary *= 52/12;
						break;
					}
				case "Bi-weekly":
					{
						salary *= 2;
						break;
					}
				case "Weekly":
					{
						salary *= 1;
						break;
					}
			}

			CalculateFederalTax((salary - 15705));
			CalculateProvinceTax(salary);
			//Calculating federal_provinceTax
			double allTax = Math.Round(_federalTax + _provinceTax, 2);
			double afterTax = Math.Round(salary - allTax, 2);
			lblSalary.Text += "\n Total tax: " + allTax + "\n After Tax: " + afterTax;
		}

	}
}

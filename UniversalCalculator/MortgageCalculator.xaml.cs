using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void mortgageCalButton_Click(object sender, RoutedEventArgs e)
		{
			double principle, repayment, monthlyIR,years, yearlyIR, months;
			double totalmonths;
			
			principle = double.Parse(prinBorrowTextBox.Text);
			yearlyIR = double.Parse(yearlyIRTextBox.Text);
			years = double.Parse(yearsTextBox.Text);
			months = double.Parse(monthsTextBox.Text);
			monthlyIR = (yearlyIR / 12 /100);
			monthlyIRTextBox.Text = monthlyIR.ToString("0.0000") + "%";
			totalmonths = years*12 + months;
			repayment = principle*monthlyIR*(Math.Pow((1 + monthlyIR),totalmonths))/((Math.Pow((1+monthlyIR),totalmonths))-1);

			monthlyRepaymentTextBox.Text = repayment.ToString("0.00");
		}

		private void exitMortageButton_Click(object sender, RoutedEventArgs e)
		{
			;
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography.Core;
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
	public sealed partial class CurrencyCoversion : Page
	{
		public CurrencyCoversion()
		{
			this.InitializeComponent();
		}

		private void currencyConvertButton_Click(object sender, RoutedEventArgs e)
		{
			double amount1, amount2, conversionRate;
			string currency1, currency2;
			

			amount1 = double.Parse(amountTextBox.Text);
			currency1 = fromComboBox.SelectedValue.ToString();
			currency2 = toComboBox.SelectedValue.ToString();
			from1TextBlock.Text = amount1 + " " + currency1 + " =\n";
			conversionRate = 1;
			switch (currency1)
			{
				case "USD - US Dollar":
					switch (currency2)
					{
						case "Euro":
							conversionRate = 0.85189982;
							break;
						case "USD - US Dollar":
							conversionRate = 1;
							break;
						case "British Pound":
							conversionRate = 0.72872436;
							break;
						case "Indian Rupee":
							conversionRate = 74.257327;
							break;
					}
					break;
				case "Euro":
					switch (currency2)
					{
						case "Euro":
							conversionRate = 1;
							break;
						case "USD - US Dollar":
							conversionRate = 1.1739732;
							break;
						case "British Pound":
							conversionRate = 0.8556672;
							break;
						case "Indian Rupee":
							conversionRate = 87.00755;
							break;
					}
					break;
				case "British Pound":
					switch (currency2)
					{
						case "Euro":
							conversionRate = 1.1686692;
							break;
						case "USD - US Dollar":
							conversionRate = 1.371907;
							break;
						case "British Pound":
							conversionRate = 1;
							break;
						case "Indian Rupee":
							conversionRate = 101.68635;
							break;
					}
					break;
				case "Indian Rupee":
					switch (currency2)
					{
						case "Euro":
							conversionRate = 0.013492774;
							break;
						case "USD - US Dollar":
							conversionRate = 0.011492628;
							break;
						case "British Pound":
							conversionRate = 0.0098339397;
							break;
						case "Indian Rupee":
							conversionRate = 1;
							break;
					}
					break;
			}
			amount2 = conversion(amount1, conversionRate);
			to1TextBlock.Text = "$" + amount2 + " " + currency2;
			from2TextBlock.Text = "1 "+currency1+" = "+ conversionRate+" "+currency2;
			to2TextBlock.Text = "1 "+currency2+" = "+ 1/conversionRate+" "+currency1;

			
        }

		static double conversion(double amount, double conversionRate)
		{
			double amount1;
			amount1 = amount * conversionRate;
			return amount1;
			
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}

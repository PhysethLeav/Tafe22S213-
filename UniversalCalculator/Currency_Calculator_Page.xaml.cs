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
	public sealed partial class Currency_Calculator_Page : Page
	{
		public Currency_Calculator_Page()
		{
			this.InitializeComponent();
		}

		double[] conversionRate = new double[] { 0.85189982, 0.72872436, 74.257327, 1.1739732, 0.8556672, 87.00755, 1.371907, 1.1686692, 101.68635, 0.011492628, 0.013492774, 0.0098339397 };


		private async void ConversionButton_Click(object sender, RoutedEventArgs e)
		{
			int fromSelection, toSelection;
			double fromConversionRate, toConversionRate, toAmount;

			fromSelection = fromCurrencyComboBox.SelectedIndex;
			toSelection = toCurrencyComboBox.SelectedIndex;

			if (fromSelection == toSelection)
			{
				var dialog = new Windows.UI.Popups.MessageDialog("You cannot convert to the same currency. Please select another currency to convert.");
				await dialog.ShowAsync();
				fromCurrencyComboBox.Focus(FocusState.Programmatic);
				return;
			}
			else
			{
				if (fromSelection == 0) // USD
				{
					if (toSelection == 1)
					{
						toConversionRate = conversionRate[0];
						fromConversionRate = conversionRate[3];

						outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  US Dollars  =  ";

						toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
						outputAmountToTextBlock.Text = toAmount.ToString("C8") + " Euro";
						fromConversionRateTextBlock.Text = "1 USD = " + toConversionRate.ToString() + " Euro";
						toConversionRateTextBlock.Text = "1 Euro = " + fromConversionRate.ToString() + " USD";
					}

					if(toSelection == 2)
					{
						toConversionRate = conversionRate[1];
						fromConversionRate = conversionRate[6];

						outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  US Dollars = ";

						toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
						outputAmountToTextBlock.Text = toAmount.ToString("C8") + " British Pounds";
						fromConversionRateTextBlock.Text = "1 USD = " + toConversionRate.ToString() + " British Pounds";
						toConversionRateTextBlock.Text = "1 British Pound = " + fromConversionRate.ToString() + " USD";
					}

					if (toSelection == 3)
					{
						toConversionRate = conversionRate[2];
						fromConversionRate = conversionRate[11];

						outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  US Dollars = ";

						toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
						outputAmountToTextBlock.Text = toAmount.ToString("C8") + " Indian Rupees";
						fromConversionRateTextBlock.Text = "1 USD = " + toConversionRate.ToString() + " Indian Rupees";
						toConversionRateTextBlock.Text = "1 Indian Rupees = " + fromConversionRate.ToString() + " USD";
					}
				}
				else
				{
					if (fromSelection == 1)  // Euro    
					{
						if (toSelection == 0)
						{
							toConversionRate = conversionRate[4];
							fromConversionRate = conversionRate[0];

							outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  Euro = ";

							toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
							outputAmountToTextBlock.Text = toAmount.ToString("C8") + " Indian Rupees";
							fromConversionRateTextBlock.Text = "1 Euro = " + toConversionRate.ToString() + " Indian Rupees";
							toConversionRateTextBlock.Text = "1 Indian Rupee = " + fromConversionRate.ToString() + " Euro";
						}

						if (toSelection == 2)
						{
							toConversionRate = conversionRate[4];
							fromConversionRate = conversionRate[7];

							outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  Euro = ";

							toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
							outputAmountToTextBlock.Text = toAmount.ToString("C8") + " Indian Rupees";
							fromConversionRateTextBlock.Text = "1 Euro = " + toConversionRate.ToString() + " Indian Rupees";
							toConversionRateTextBlock.Text = "1 Indian Rupee = " + fromConversionRate.ToString() + " Euro";
						}

						if (toSelection == 3)
						{
							toConversionRate = conversionRate[2];
							fromConversionRate = conversionRate[11];

							outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  Euro = ";

							toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
							outputAmountToTextBlock.Text = toAmount.ToString("C8") + " Indian Rupees";
							fromConversionRateTextBlock.Text = "1 Euro = " + toConversionRate.ToString() + " Indian Rupees";
							toConversionRateTextBlock.Text = "1 Indian Rupee = " + fromConversionRate.ToString() + " Euro";
						}
					}
					else
					{
						if (fromSelection == 2) // British Pound
						{
							if (toSelection == 0)
							{

								toConversionRate = conversionRate[6];
								fromConversionRate = conversionRate[1];

								outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  British Pound ";

								toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
								outputAmountToTextBlock.Text = toAmount.ToString("C8") + " USD";
								fromConversionRateTextBlock.Text = "1 British Pound = " + toConversionRate.ToString() + " USD";
								toConversionRateTextBlock.Text = "1 USD" + fromConversionRate.ToString() + " British Pounds";

							}

							if (toSelection == 1)
							{

								toConversionRate = conversionRate[8];
								fromConversionRate = conversionRate[11];

								outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  British Pound ";

								toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
								outputAmountToTextBlock.Text = toAmount.ToString("C8") + " USD";
								fromConversionRateTextBlock.Text = "1 British Pound = " + toConversionRate.ToString() + " USD";
								toConversionRateTextBlock.Text = "1 USD" + fromConversionRate.ToString() + " British Pounds";

							}

						}
						else
						{
							if (fromSelection == 3) // Rupee
							{
								if (toSelection == 0)
								{
									toConversionRate = conversionRate[9];
									fromConversionRate = conversionRate[22];

									outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  Rupees ";

									toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
									outputAmountToTextBlock.Text = toAmount.ToString("C8") + "  British Pounds";
									fromConversionRateTextBlock.Text = "1 Rupee = " + toConversionRate.ToString() + " British Pounds";
									toConversionRateTextBlock.Text = "1 British Pound = " + fromConversionRate.ToString() + " Rupees";
								}

								if (toSelection == 1)
								{
									toConversionRate = conversionRate[10];
									fromConversionRate = conversionRate[5];

									outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  Rupees ";

									toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
									outputAmountToTextBlock.Text = toAmount.ToString("C8") + "  British Pounds";
									fromConversionRateTextBlock.Text = "1 Rupee = " + toConversionRate.ToString() + " British Pounds";
									toConversionRateTextBlock.Text = "1 British Pound = " + fromConversionRate.ToString() + " Rupees";
								}

								if (toSelection == 2)
								{
									toConversionRate = conversionRate[11];
									fromConversionRate = conversionRate[8];

									outputAmountFromTextBlock.Text = amountTextBox.Text.ToString() + "  Rupees ";

									toAmount = double.Parse(amountTextBox.Text) * toConversionRate;
									outputAmountToTextBlock.Text = toAmount.ToString("C8") + "  British Pounds";
									fromConversionRateTextBlock.Text = "1 Rupee = " + toConversionRate.ToString() + " British Pounds";
									toConversionRateTextBlock.Text = "1 British Pound = " + fromConversionRate.ToString() + " Rupees";
								}
							}
						}
					}
				}
			}
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}

	}
}

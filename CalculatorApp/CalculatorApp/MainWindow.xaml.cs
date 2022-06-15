using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		String operation = "";
		int entries = 0;
		private string[] strNumbers = new string[2];

		public MainWindow()
		{
			InitializeComponent();
		}

		Boolean isOn = false;
		private void ButtonOn_Click_Power(object sender, RoutedEventArgs e)
		{
			if (!isOn)
			{
				isOn = true;
				ButtonOn_Click_Clear(sender, e);
				txtbox.Text = txtbox.Text + "ON";
				entries = 0;
			}
			else
			{
				isOn = true;
			}
		}

		private void ButtonOn_Click_PowerOff(object sender, RoutedEventArgs e)
		{
			if (isOn == true)
			{
				txtbox.Text = "Off";
				Array.Clear(strNumbers, 0, strNumbers.Length);
				isOn = false;
				entries = 0;
			}
		}

		private void ButtonOn_Click_Run(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 3)
			{

				double number1 = Double.Parse(strNumbers[0]);
				double number2 = Double.Parse(strNumbers[1]);

				string results = "";
				switch (operation)
				{
					case "+":
						results = CalculatorLogic.Addition(number1, number2);
						txtbox.Text = results;
						strNumbers[0] = results;
						operation = "";
						entries = 1;
						break;
					case "-":
						results = CalculatorLogic.Subtraction(number1, number2);
						txtbox.Text = results;
						strNumbers[0] = results;
						operation = "";
						entries = 1;
						break;
					case "*":
						results = CalculatorLogic.Mutliplication(number1, number2);
						txtbox.Text = results;
						strNumbers[0] = results;
						operation = "";
						entries = 1;
						break;
					case "/":
						if (strNumbers[1] == "0")
						{
							txtbox.Text = "Error";
							Array.Clear(strNumbers, 0, strNumbers.Length);
							entries = 0;
							break;
						}
						else
						{
							results = CalculatorLogic.Division(number1, number2);
							txtbox.Text = results;
							strNumbers[0] = results;
							operation = "";
							entries = 1;
							break;
						}

					default:
						MessageBox.Show("An error has happened, reseting Calculator now.");
						isOn = false;
						txtbox.Text = "Reset Complete";
						entries = 0;
						Array.Clear(strNumbers, 0, strNumbers.Length);
						break;
				}

			}
		}

		private void ButtonOn_Click_Clear(object sender, RoutedEventArgs e)
		{
			if (isOn == true)
			{

				entries = 0;
				operation = "";
				txtbox.Text = "";
				Array.Clear(strNumbers, 0, strNumbers.Length);
			}

		}

		private void ButtonOn_Click_Add(object sender, RoutedEventArgs e)
		{
			if (isOn == true && (entries < 3) && (entries % 2) == 1)
			{
				operation = "+";
				txtbox.Text = txtbox.Text + "+";
				entries++;
			}
		}

		private void ButtonOn_Click_Seven(object sender, RoutedEventArgs e)
		{

			if (isOn == true && entries == 0)
			{

				txtbox.Text = "7";
				strNumbers[0] = "7";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "7";
				strNumbers[1] = "7";
				entries++;
			}
		}

		private void ButtonOn_Click_Eight(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "8";
				strNumbers[0] = "8";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "8";
				strNumbers[1] = "8";
				entries++;
			}
		}

		private void ButtonOn_Click_Nine(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "9";
				strNumbers[0] = "9";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "9";
				strNumbers[1] = "9";
				entries++;
			}
		}

		private void ButtonOn_Click_Divide(object sender, RoutedEventArgs e)
		{
			if (isOn == true && (entries < 3) && (entries % 2) == 1)
			{
				operation = "/";
				txtbox.Text = txtbox.Text + "/";
				entries++;
			}
		}

		private void ButtonOn_Click_Four(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "4";
				strNumbers[0] = "4";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "4";
				strNumbers[1] = "4";
				entries++;
			}
		}

		private void ButtonOn_Click_Five(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "5";
				strNumbers[0] = "5";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "5";
				strNumbers[1] = "5";
				entries++;
			}
		}

		private void ButtonOn_Click_Six(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "6";
				strNumbers[0] = "6";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "6";
				strNumbers[1] = "6";
				entries++;
			}
		}

		private void ButtonOn_Click_Multiply(object sender, RoutedEventArgs e)
		{
			if (isOn == true && (entries < 3) && (entries % 2) == 1)
			{
				operation = "*";
				txtbox.Text = txtbox.Text + "*";
				entries++;
			}
		}

		private void ButtonOn_Click_Zero(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "0";
				strNumbers[0] = "0";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "0";
				strNumbers[1] = "0";
				entries++;
			}
		}

		private void ButtonOn_Click_One(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "1";
				strNumbers[0] = "1";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "1";
				strNumbers[1] = "1";
				entries++;
			}
		}

		private void ButtonOn_Click_Two(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "2";
				strNumbers[0] = "2";
				entries++;

			}
			else if (isOn == true && (entries < 3) && (entries % 2) == 0)
			{

				txtbox.Text = txtbox.Text + "2";
				strNumbers[1] = "2";
				entries++;
			}
		}

		private void ButtonOn_Click_Three(object sender, RoutedEventArgs e)
		{
			if (isOn == true && entries == 0)
			{

				txtbox.Text = "3";
				strNumbers[0] = "3";
				entries++;

			}
			else if ((isOn == true && (entries < 3) && (entries % 2) == 0))
			{

				txtbox.Text = txtbox.Text + "3";
				strNumbers[1] = "3";
				entries++;
			}
		}

		private void ButtonOn_Click_Subtract(object sender, RoutedEventArgs e)
		{
			if (isOn == true && (entries < 3) && (entries % 2) == 1)
			{
				operation = "-";
				txtbox.Text = txtbox.Text + "-";
				entries++;
			}
		}
	}
}




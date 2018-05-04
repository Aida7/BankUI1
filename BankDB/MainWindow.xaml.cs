using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankDB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Client client;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExchangeRates_Clik(object sender, RoutedEventArgs e)
        {
            ExchangeRates window = new ExchangeRates();
            window.Show();
        }

        private void MoneyTransfer_Clik(object sender, RoutedEventArgs e)
        {
            Label label = new Label();
            label.Visibility = Visibility.Visible;
            TextBox textBox = new TextBox();
            textBox.Visibility = Visibility.Visible;
            
        }

        private void InvoiceAmount_Clik(object sender, RoutedEventArgs e)
        {
            namberCard.Visibility = Visibility.Visible;
            pin.Visibility = Visibility.Visible;
            cvv.Visibility = Visibility.Visible;
        }

        private void ToDeposit_Clik(object sender, RoutedEventArgs e)
        {
            namberCard.Visibility = Visibility.Visible;
            pin.Visibility = Visibility.Visible;
            cvv.Visibility = Visibility.Visible;
        }

        private void WithdrawMoney_Clik(object sender, RoutedEventArgs e)
        {
            namberCard.Visibility = Visibility.Visible;
            pin.Visibility = Visibility.Visible;
            cvv.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}

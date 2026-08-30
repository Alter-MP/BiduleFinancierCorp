using Microsoft.UI.Xaml;

namespace CardWidget.App
{
    public sealed partial class MainWindow : Window
    {
        private decimal balance = 0.00m;
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void AddFundsButton_Click(object sender, RoutedEventArgs e)
        {
            balance += 10;
            BalanceText.Text = $"Balance: {balance}";
        }
    }
}

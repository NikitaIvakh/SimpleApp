using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SimpleApp.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement uIElement in MainRoot.Children)
            {
                if (uIElement is Button button)
                    button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = (string)((Button)e.OriginalSource).Content;

            if (text == "AC")
                textLabel.Text = string.Empty;

            else if (text == "=")
            {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }

            else
                textLabel.Text += text;
        }
    }
}
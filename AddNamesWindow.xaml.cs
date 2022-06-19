using System;
using System.Windows;

namespace MyFirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text) && !LstNames.Items.Contains(txtName.Name))
            {
                LstNames.Items.Add((txtName.Text));
                txtName.Clear();
            }
        }
    }
}
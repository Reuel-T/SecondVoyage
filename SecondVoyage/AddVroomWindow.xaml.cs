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
using System.Windows.Shapes;

namespace SecondVoyage
{
    /// <summary>
    /// Interaction logic for AddVroomWindow.xaml
    /// </summary>
    public partial class AddVroomWindow : Window
    {
        public AddVroomWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string make = txbMake.Text;
            string model = txbModel.Text;
            string color = txbColor.Text;
            double price = Convert.ToDouble(txbPrice.Text);

            ListHolder.GetInstance().AddVroom(new Vroom(make, model, price, color, 0));
        }
    }
}

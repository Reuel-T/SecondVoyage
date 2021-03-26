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

namespace SecondVoyage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lsbVrooms.ItemsSource = ListHolder.GetInstance().Vrooms;
            btnRemove.IsEnabled = false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddVroomWindow avm = new AddVroomWindow();
            avm.Show();
            
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            ListHolder.GetInstance().Vrooms.Remove((Vroom)lsbVrooms.SelectedItem);
        }

        private void lsbVrooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lsbVrooms.SelectedIndex > -1) 
            {
                btnRemove.IsEnabled = true;
            }
            else 
            {
                btnRemove.IsEnabled = false;
            }
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            if(lsbVrooms.Items.Count > 0) 
            {
                ReportWindow rw = new ReportWindow();
                rw.Show();
            }
        }

        private void btnSell_Click(object sender, RoutedEventArgs e)
        {
            if (lsbVrooms.SelectedIndex > -1) 
            {
                (lsbVrooms.SelectedItem as Vroom).Sales++;
            }
        }
    }
}

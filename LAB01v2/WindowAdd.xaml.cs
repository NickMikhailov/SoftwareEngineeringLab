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
using System.Windows.Shapes;

namespace LAB01v2
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbDetail_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (tbDetail.Text != "")
            {
                detailTrue.Visibility = Visibility.Visible;
                detailFalse.Visibility = Visibility.Hidden;
            }
            else 
            {
                detailFalse.Visibility = Visibility.Visible;
                detailTrue.Visibility = Visibility.Hidden; 
            }
        }

        private void tbCell_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(tbCell.Text,out _))
            {
                cellTrue.Visibility = Visibility.Visible;
                cellFalse.Visibility = Visibility.Hidden;
            }
            else
            {
                cellFalse.Visibility = Visibility.Visible;
                cellTrue.Visibility = Visibility.Hidden;
            }
        }

        private void tbQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(tbQuantity.Text, out _))
            {
                quantityTrue.Visibility = Visibility.Visible;
                quantityFalse.Visibility = Visibility.Hidden;
            }
            else
            {
                quantityFalse.Visibility = Visibility.Visible;
                quantityTrue.Visibility = Visibility.Hidden;
            }
        }
    }
}

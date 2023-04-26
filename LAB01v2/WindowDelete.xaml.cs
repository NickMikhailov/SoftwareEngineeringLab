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
    /// Логика взаимодействия для WindowDelete.xaml
    /// </summary>
    public partial class WindowDelete : Window
    {
        public WindowDelete()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

	}
}

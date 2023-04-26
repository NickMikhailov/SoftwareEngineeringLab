using LAB01v2.Models;
using LAB01v2.Services;
using NickMikhailov;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LAB01v2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\inventoryList.json";
        private BindingList<TableModel> _inventoryList;
        private FileIOService _fileIOService;

        public MainWindow()
        {
            InitializeComponent();
            _inventoryList = new BindingList<TableModel>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIOService = new FileIOService(PATH);
            try
            {
                _inventoryList = _fileIOService.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            dgInventoryList.ItemsSource = _inventoryList;
        }
        //private void Window_Closing(object sender, CancelEventArgs e)
        //{
            
        //}
        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd wAdd = new WindowAdd();
            wAdd.Show();
            wAdd.bAdd.Click += (s, ev) =>
            {
                string d = wAdd.tbDetail.Text;
                if (d != "" &&
                int.TryParse(wAdd.tbCell.Text, out int c) &&
                int.TryParse(wAdd.tbQuantity.Text, out int q))
                {
                    _inventoryList.Add(new TableModel(d, c, q));
                    wAdd.Close();
                }
                else
                {
                    MessageBox.Show("Проверьте данные!");
                }
            };
        }
        private void dgInventoryList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TableModel selectedItem = (TableModel)dgInventoryList.SelectedItem;

            if (MessageBox.Show("Confirm to delete the entry with ID " + selectedItem.Id, caption: "Confirmation", button: MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                _inventoryList.Remove(selectedItem);
            }
        }
        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            WindowDelete wDelete = new WindowDelete();
            wDelete.Show();
            wDelete.bDeleteById.Click += (s, ev) =>
            {
                foreach (var item in _inventoryList)
                {
                    if (item.Id.ToString().Equals(wDelete.tbID.Text.ToString()))
                    {
                        _inventoryList.Remove(item);
                        break;
                    };
                }
                wDelete.Close();
            };
			wDelete.bDeleteByDetail.Click += (s, ev) =>
			{
                Delete delete = new Delete();

				dgInventoryList.ItemsSource = 
                    _inventoryList = 
                    delete.ByDetail(_inventoryList,wDelete.tbDetail.Text.ToString());
				wDelete.Close();
			};
		}
        private void bFilterSet_Click(object sender, RoutedEventArgs e)
        {
            BindingList<TableModel> _inventoryListFiltered = new BindingList<TableModel>();
            if (tbFilterDetail.Text != "" && tbFilterCell.Text == "")
            {
                foreach (var item in _inventoryList)
                {
                    if (item.Detail == tbFilterDetail.Text)
                    {
                        _inventoryListFiltered.Add(item);
                    }
                }
            }
            else if (tbFilterDetail.Text == "" && tbFilterCell.Text != "")
            {
                if (int.TryParse(tbFilterCell.Text, out int c))
                {
                    foreach (var item in _inventoryList)
                    {
                        if (item.Cell == c)
                        {
                            _inventoryListFiltered.Add(item);
                        }
                    }
                }
                else MessageBox.Show("Проверьте данные");
            }
            else if (tbFilterDetail.Text != "" && tbFilterCell.Text != "")
            {
                if (int.TryParse(tbFilterCell.Text, out int c))
                {
                    foreach (var item in _inventoryList)
                    {
                        if (item.Cell == c && item.Detail == tbFilterDetail.Text)
                        {
                            _inventoryListFiltered.Add(item);
                        }
                    }
                }
                else MessageBox.Show("Проверьте данные");
            }
            else return;
            dgInventoryList.ItemsSource = _inventoryListFiltered;
        }
        private void bFilterCancel_Click(object sender, RoutedEventArgs e)
        {
            dgInventoryList.ItemsSource = _inventoryList;
            tbFilterCell.Text = string.Empty; ;
            tbFilterDetail.Text = string.Empty;
        }
        private void bSortDescending_Click(object sender, RoutedEventArgs e)
        {
            Sort sort = new Sort();
            switch (cbSort.Text)
            {
                case "Detail":
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByDetail(_inventoryList, true);
                    break;
                case "Cell":
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByCell(_inventoryList, true);
                    break;
                case "Quantity":
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByQuantity(_inventoryList, true);
                    break;
                case "ID":
                default:
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByID(_inventoryList, true);
                    break;
            }
        }
        private void bSortAscending_Click(object sender, RoutedEventArgs e)
        {
            Sort sort = new Sort();
            switch (cbSort.Text)
            {
                case "Detail":
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByDetail(_inventoryList);
                    break;
                case "Cell":
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByCell(_inventoryList);
                    break;
                case "Quantity":
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByQuantity(_inventoryList);
                    break;
                case "ID":
                default:
                    dgInventoryList.ItemsSource = _inventoryList = sort.ByID(_inventoryList);
                    break;
            }
        }
        private void bSumByOneDetail_Click(object sender, RoutedEventArgs e)
        {
            dgInventoryList.Visibility = Visibility.Collapsed;
            dgInventoryListToSum.Visibility = Visibility.Visible;
            BindingList<SumTableModel> _inventoryListToSum = new BindingList<SumTableModel>();
            string detail = tbDetailToSum.Text;
            SumTableModel _sumTableModel = new SumTableModel(detail, 0);
            foreach (var inventory in _inventoryList)
            {
                if (detail == inventory.Detail.ToString())
                {
                    _sumTableModel.Quantity += inventory.Quantity;
                }
            }
            _inventoryListToSum.Add(_sumTableModel);
            dgInventoryListToSum.ItemsSource = _inventoryListToSum;
        }
        private void bSumByDetails_Click(object sender, RoutedEventArgs e)
        {
            dgInventoryList.Visibility = Visibility.Collapsed;
            dgInventoryListToSum.Visibility = Visibility.Visible;
            BindingList<SumTableModel> _inventoryListToSum = new BindingList<SumTableModel>();
            SumTableModel _sumTableModel;
            foreach (var inventory in _inventoryList)
            {
                if ((_sumTableModel=containsDetail(_inventoryListToSum,inventory))==null)
                {
                     _inventoryListToSum.Add(new SumTableModel(inventory.Detail,inventory.Quantity));
                }
                else
                {
                    _sumTableModel.Quantity += inventory.Quantity;
                }
            }
            dgInventoryListToSum.ItemsSource = _inventoryListToSum;
        }
        private void bSumCancel_Click(object sender, RoutedEventArgs e)
        {
            dgInventoryList.Visibility = Visibility.Visible;
            dgInventoryListToSum.Visibility = Visibility.Collapsed;


            tbDetailToSum.Text = "detail";
            SumTableModel.counterZero();
            bAdd.IsDefault = true;            
        }
        private void bExit_Click(object sender, RoutedEventArgs e)
        {
			if (MessageBox.Show("Save changes?", caption: "Exit", button: MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
				_fileIOService.Save(_inventoryList);
			}
			Close();
        }
        private SumTableModel containsDetail(BindingList<SumTableModel> _inventoryListToSum, TableModel _entry)
        {
            foreach (var inventory in _inventoryListToSum)
            {
                if (inventory.Detail == _entry.Detail)
                {
                    return inventory;
                }
            }
            return null;
        }
        private void tbDetailToSum_TextChanged(object sender, TextChangedEventArgs e)
        {
            bSumByOneDetail.IsDefault = true;
        }
    }
}

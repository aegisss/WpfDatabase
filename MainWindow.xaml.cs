using System;
using System.Collections.Generic;
using System.Data;
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
using Database.MagazineDataSetTableAdapters;
namespace Database
{
    public partial class MainWindow : Window
    {
        PostTableAdapter adapter = new PostTableAdapter();
        EmployeeTableAdapter Adapter = new EmployeeTableAdapter();


        public MainWindow()
        {
            InitializeComponent();
            RangDataGrid.ItemsSource = adapter.GetData();
            PostComboBox.ItemsSource = Adapter.GetData();
            PostComboBox.DisplayMemberPath = "Age";
        }

        private void PostComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (PostComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(cell.ToString());
        }
    }
}

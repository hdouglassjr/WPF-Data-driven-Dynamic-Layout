using System;
using System.Windows;
using System.Windows.Data;
using System.Windows;
using System.Data;
using System.Data.OleDb;
using System.Windows.Controls;

namespace WPF_Data_driven_Dynamic_Layout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable dtEmployees = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            dtEmployees = GetData();
            BindData();
        }

        private void BindData()
        {
            lvEmployees.DataContext = dtEmployees;
            lvEmployees.SetBinding(ItemsControl.ItemsSourceProperty, new Binding());
            c1Employees.DisplayMemberBinding = new Binding("LastName");
            c2Employees.DisplayMemberBinding = new Binding("FirstName");
            c3Employees.DisplayMemberBinding = new Binding("Title");
        }

        private DataTable GetData()
        {
            var connString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hdoug\source\Data\;Extended Properties=""text;HDR=yes;FMT=delimited"";";
            var sSql = "Select * from employees.csv";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sSql,connString);

            try
            {
                adapter.Fill(dtEmployees);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dtEmployees;
        }
    }
}

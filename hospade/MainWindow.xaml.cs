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
using Microsoft.Office.Interop.Excel;
using static System.Net.Mime.MediaTypeNames;

namespace hospade
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TablDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void XlsButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application aplication = new
            Microsoft.Office.Interop.Excel.Application();
            Workbook ObjWorkBook = Application.Workbooks.Open(C: \Users\Student\Downloads\stan.xlsx);
        }
    }
}

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

namespace SklepWPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ClientPanel : UserControl
    {
        public ClientPanel()
        {
            InitializeComponent();
        }

        private void ClearPersonalData_Click(object sender, RoutedEventArgs e)
        {
            Username.Clear();
            Surname.Clear();
            StreetName.Clear();
            PostalCode.Clear();
            PhoneNumber.Clear();
            City.Clear();
            Email.Clear();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = SearchQueryTextBox.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }
    }
}

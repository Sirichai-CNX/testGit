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

namespace HelloWorldGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double income, expense, costproduct, savemoneydate;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello" + " " + txtFirstName.Text + " " + txtLastName.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            income  = double.Parse(txtInCome.Text);
            expense = double.Parse(txtExPense.Text);
            costproduct = double.Parse(txtCostProDuct.Text);
            savemoneydate = costproduct / (income - expense);

            if (expense >= income)
            {
                MessageBox.Show("ช้าก่อน คุณไม่เหลือเงินออมเลยนะ!");
            }
            else
            {
                txtSaveMoneyDate.Text = savemoneydate.ToString();
            }
        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtProduct_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtInCome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

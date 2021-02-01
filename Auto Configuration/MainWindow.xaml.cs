using System;
using System.IO;
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
using Microsoft.Win32;
using System.Windows.Media.Animation;
using Auto_Configuration.winform;




namespace Auto_Configuration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gen_Button.IsEnabled = false;
            Cancel_Button.IsEnabled = false;
        }

        

        private void FSE_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            FSE_TXT.Text = openFileDialog.FileName;
            FSE_TXT.Foreground = Brushes.Black;

        }

        private void DTD_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            DTD_txt.Text = openFileDialog.FileName;
            DTD_txt.Foreground = Brushes.Black;

        }

        private void m150_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            m150_txt.Text = openFileDialog.FileName;
            m150_txt.Foreground = Brushes.Black;
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Gen_Button_Click(object sender, RoutedEventArgs e)
        {
            Cancel_Button.IsEnabled = true;
            var progress = new Progress<int>(x => Prog1.Value = x);
            
            formula form = new formula(); // method of conversion
                                          // string outfile = form.convert_formula(loc); // getting output name
            await Task.Run(() => form.progressbar_result(progress));

           

           
            Prog1.Value = 0;
            SL_TXT.Clear();
            FSE_TXT.Clear();
            DTD_txt.Clear();
            pre_check.IsChecked = false;
            new_check.IsChecked = false;
            Mesaage success_message = new Mesaage();
            success_message.ShowDialog();

        }

        private void SL_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            
            SL_TXT.Text = openFileDialog.FileName;
            SL_TXT.Foreground = Brushes.Black;
        }

        private void pre_check_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pre_check_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)pre_check.IsChecked)
            {
                m150_txt.IsEnabled = false;
                m150_Button.IsEnabled = false;
                m150_label.SetCurrentValue(ForegroundProperty, Brushes.Gray); ;
                if ((!SL_TXT.Text.Equals("")) && (!DTD_txt.Text.Equals("")) && (!FSE_TXT.Text.Equals("")))
                {
                    Gen_Button.IsEnabled = true;
                }
            }
        }

        private void new_check_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)new_check.IsChecked)
            {
                m150_txt.IsEnabled = true;
                m150_Button.IsEnabled = true;
                m150_label.IsEnabled = true;
                if ((!SL_TXT.Text.Equals("")) && (!DTD_txt.Text.Equals("")) && (!FSE_TXT.Text.Equals("")))
                {
                    Gen_Button.IsEnabled = true;
                }

            }
        }
        private void text_click(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= text_click;
        }
        private void FSEtext_click(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= FSEtext_click;
        }
        private void dtdtext_click(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= dtdtext_click;
        }
        private void modeltext_click(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= modeltext_click;
        }


    }
}

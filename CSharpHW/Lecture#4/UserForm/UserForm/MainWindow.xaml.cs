using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;


namespace UserForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {



            if ( CheckName(_firstName.Text) && CheckName(_lastName.Text) && CheckDate(_birthDate.Text)  && 
                CheckEmail(_email.Text)  && CheckInfo(_info.Text) )
         
            {

                _validationStatus.Text = "Accepted";
               
            }


            else
            {
                _validationStatus.Text = "Not  valid";
            }


                


        }



        private static bool CheckInfo(String _infoString)
        {


            return (_infoString.Length < 2000);
        }


        private static bool CheckPhoneNumber(String _numberString)
        {

            int len = _numberString.Length;


            if (len != 12) return false;


            for (int i = 0; i < len; i++)
            {
                if ('0' <= _numberString[i] && _numberString[i] <= '9' ) continue;

                return false;
            }

            return true;
        }




        private static bool CheckName(String _nameString)
        {

            int len = _nameString.Length;


            if (len >= 255) return false;


            for  (int  i = 0; i < len; i++)
            {
                if ('a' <= _nameString[i] && _nameString[i] <= 'z' || 'A' <= _nameString[i] && _nameString[i] <= 'Z') continue;

                return false;
            }

            return true;
        }


        private static bool CheckEmail(String _emailString)
        {

            int len = _emailString.Length;
            if (len >= 255) return false;


            for (int i = 0; i < len; i++)
            {
                if (_emailString[i] == '@') return  true;
                
            }

            return false;
        }



        private static    bool CheckDate(String dateString)
        {

            


            string[] formats = {"dd/MM/yyyy", "d/MM/yyyy" , "d/M/yyyy", "dd/M/yyyy" };

            DateTime dateValue;

            DateTime.TryParseExact(dateString, formats,
                                       new CultureInfo("uk-UA"),   //Ukraine  Culture  Info
                                       DateTimeStyles.None,
                                       out dateValue);
            

            

            return (1990 < dateValue.Year && dateValue.Year < DateTime.Now.Year);
        }


        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

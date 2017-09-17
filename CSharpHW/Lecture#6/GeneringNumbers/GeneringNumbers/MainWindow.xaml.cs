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

namespace GeneringNumbers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static int desiredValue;
        static int attempts;

        public MainWindow()
        {
            InitializeComponent();
            SetValues();
        
        }



        void   SetValues()
        {
            desiredValue = GetRandomValue();
            attempts = 3;

        }

        int  GetRandomValue()
        {
            Random rnd = new Random();

            return rnd.Next(0, 11);

        }

        void Analyze(int value)
        {
            
            if  (value == desiredValue)
            {
                MessageBox.Show("Success  choice!  Program  will  generate   new  numer");
                desiredValue = GetRandomValue();
                attempts = 3;
                
            }


            else
            {
                attempts--;
                MessageBox.Show(   String.Format ("Unsuccess  choice! {0}  attempt leave", attempts.ToString()));
            }

            if  (attempts == 0)
            {
                MessageBox.Show("You   used   all   attempts.  Program  will  generate   new  number");

                SetValues();

            }

        }


        private void _submit_Click(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show(desiredValue.ToString());
            int number = default(Int32);

            try
            {
                number =  Int32.Parse( _guessedNumber.Text);
        
                if (number < 0 || number > 10)
                    throw new OverflowException();
            }


            catch (FormatException )
            {
                MessageBox.Show("Not  valid   format");
            }


            catch (OverflowException )
            {
                MessageBox.Show("Out  of   range");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
            Analyze(number);
            

            
        }




    }
}

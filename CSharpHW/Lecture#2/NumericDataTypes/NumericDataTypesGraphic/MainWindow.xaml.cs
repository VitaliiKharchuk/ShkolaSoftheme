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

namespace NumericDataTypesGraphic
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

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {

            if  ((bool)_sbyte.IsChecked)
            {

                _default.Text = default(SByte).ToString();
                _min.Text =  SByte.MinValue.ToString();
                _max.Text = SByte.MaxValue.ToString();
 
            }


            else  if  ((bool)_short.IsChecked)
            {
                _default.Text = default(Int16).ToString();
                _min.Text = Int16.MinValue.ToString();
                _max.Text = Int16.MaxValue.ToString();

            }


            else   if  ((bool)  _int.IsChecked)
            {
                _default.Text = default(Int32).ToString();
                _min.Text = Int32.MinValue.ToString();
                _max.Text = Int32.MaxValue.ToString();

            }

            else if ((bool)_long.IsChecked)
            {
                _default.Text = default(Int64).ToString();
                _min.Text = Int64.MinValue.ToString();
                _max.Text = Int64.MaxValue.ToString();

            }



            else if ((bool)_byte.IsChecked)
            {

                _default.Text = default(Byte).ToString();
                _min.Text = Byte.MinValue.ToString();
                _max.Text = Byte.MaxValue.ToString();

            }


            else if ((bool)_ushort.IsChecked)
            {
                _default.Text = default(UInt16).ToString();
                _min.Text = UInt16.MinValue.ToString();
                _max.Text = UInt16.MaxValue.ToString();

            }


            else if ((bool)_uint.IsChecked)
            {
                _default.Text = default(UInt32).ToString();
                _min.Text = UInt32.MinValue.ToString();
                _max.Text = UInt32.MaxValue.ToString();

            }

            else if ((bool)_ulong.IsChecked)
            {
                _default.Text = default(UInt64).ToString();
                _min.Text = UInt64.MinValue.ToString();
                _max.Text = UInt64.MaxValue.ToString();

            }


            else if ((bool)_float.IsChecked)
            {
                _default.Text = default(Single).ToString();
                _min.Text = Single.MinValue.ToString();
                _max.Text = Single.MaxValue.ToString();

            }


            else if ((bool)_double.IsChecked)
            {
                _default.Text = default(Double).ToString();
                _min.Text = Double.MinValue.ToString();
                _max.Text = Double.MaxValue.ToString();

            }

            else if ((bool)_decimal.IsChecked)
            {
                _default.Text = default(Decimal).ToString();
                _min.Text = Decimal.MinValue.ToString();
                _max.Text = Decimal.MaxValue.ToString();

            }




        }
    }
}

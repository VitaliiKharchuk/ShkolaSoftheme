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


namespace BirthDayGraphic
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

        private void _getZodiacSign_Click(object sender, RoutedEventArgs e)
        {


            DateTime birthDay =  default(DateTime);


            if (ReadDate(_date.Text, ref birthDay) == false)
            {
                _date.Text = "";
                _validation.Text = "Incorerct  format.";

            }



            else
            {
                _validation.Text = "Correct";

                _age.Text = GetAge(birthDay).ToString();

                _zodiacSign.Text = GetZodiacSign(birthDay);




                /*
                Image i = new Image();
                i.Source = new BitmapImage(  new  Uri   ( "photo1", UriKind.Relative));

                this.Content = i;
                this.img = i;
                */
            }   


            
            
        }


        private static bool ReadDate(string  dateString,  ref DateTime   dateValue)
        {

            
            string[] formats = { "d/M/yyyy" };

           
            return (DateTime.TryParseExact(dateString, formats,
                                        new CultureInfo("uk-UA"),   //Ukraine  Culture  Info
                                        DateTimeStyles.None,
                                        out dateValue));
            
           
        }

        public static String GetZodiacSign(DateTime birthDay)
        {

            /*
                Aries(March 21 - April 19)
                
                Taurus(April 20 - May 20)

                Gemini May 21 - June 20)

                Cancer(June 21 - July 22)
                
                Leo(July 23 - August 22)
                
                Virgo(August 23 - September 22)

                Libra(September 23 - October 22)

                Scorpio(October 23 - November 21)

                Sagittarius(November 22 - December 21)

                Capricorn(December 22 - January 19)

                Aquarius(January 20 to February 18)

                Pisces(February 19 to March 20)

            */
            int day = birthDay.Day;

            switch (birthDay.Month)
            {
                case 1:
                    {
                        if (day < 20)
                            return "Capricorn";

                        else
                            return "Aquarius";



                    }
                case 2:
                    {

                        if (day < 19)
                            return "Aquarius";

                        else
                            return "Pisces";

                    }



                case 3:
                    {

                        if (day < 21)
                            return "Pisces";

                        else
                            return "Aries";

                    }

                case 4:
                    {

                        if (day < 22)
                            return "Aries";

                        else
                            return "Taurus";

                    }
                case 5:
                    {


                        if (day < 21)
                            return "Taurus";

                        else
                            return "Gemini";

                    }
                case 6:
                    {

                        if (day < 21)
                            return "Gemini";

                        else
                            return "Cancer";

                    }
                case 7:
                    {

                        if (day < 23)
                            return "Cancer";

                        else
                            return "Leo";

                    }
                case 8:
                    {

                        if (day < 23)
                            return "Leo";

                        else
                            return "Virgo";

                    }
                case 9:
                    {

                        if (day < 23)
                            return "Virgo";

                        else
                            return "Libra";

                    }
                case 10:
                    {

                        if (day < 23)
                            return "Libra";

                        else
                            return "Scorpio";

                    }
                case 11:
                    {

                        if (day < 22)
                            return "Scorpio";

                        else
                            return "Saggisterius";

                    }
                case 12:
                    {

                        if (day < 22)
                            return "Saggisterius";

                        else
                            return "Capricorn";

                    }
                default:
                    return "zodiac sign  is unknown";

            }



        }



        public static int GetAge(DateTime birthDay)
        {

            DateTime currentDate = DateTime.Now;


            int age = currentDate.Year - birthDay.Year;



            if (currentDate.Month < birthDay.Month)           //analyze if  person   had   birthday  in   current   year.
                                                              //If   not   make   decrement  for age  
                age--;

            else if (currentDate.Month == birthDay.Month)
            {
                if (currentDate.Day < birthDay.Day)
                    age--;


            }



            return age;

        }


        private void _Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}

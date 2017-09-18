using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Human
    {
        //BirthDate, FirstName, Lastame, Age.

        private DateTime _birthDate;
        private string _firstName;
        private string _lastName;
        private int _age;



        public Human()
        {
            _birthDate = default(DateTime);
            _firstName = "Jesus";
            _lastName = "Christos";
            _age = 33;

        }

        public Human(DateTime  _bd ,  string _fn = "Donald",  string _ln = "Trump", int _a = 0)

        {
            _birthDate = _bd;
            _firstName = _fn;
            _firstName = _ln;
            this._age = _a;

        }

        public   bool MyEquals(Human  obj)
        {

            if (obj == null) return false;



            return (this._age == obj._age &&
                this._birthDate == obj._birthDate &&
                this._firstName == obj._firstName &&
                this._lastName == obj._lastName);

        }


        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clone
{
    class User : ICloneable
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }
        public OperationSystem OS { get; set; }    


       
        public object Clone()   //  deep  cloning
        {

            OperationSystem anotherSystem = new OperationSystem { nameSystem = OS.nameSystem };


            return new User
            {
                firstName = this.firstName,
                lastName = this.lastName,
                ID = this.ID,
                OS = anotherSystem
                //OS = this.OS      new    object  will  have  old reference  
            };



        }


        public void GetUserInformation()
        {
            Console.WriteLine("firstName = " +  firstName + " lastName =  "  +  lastName + "  ID "  +  ID + "  Operation system = " + OS.nameSystem);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authorization
{
    interface IUser
    {
        string name { get; set; }
        int password { get; set; }
        string email { get; set; }
        void GetFullInfo();
    }
}

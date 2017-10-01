using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileOperator
{
    class MobileConnection
    {
        public ConnectionType Type { get; set; }
        public MobileAccount Sender { get; set; }
        public MobileAccount Receiver { get; set; }
    }
}

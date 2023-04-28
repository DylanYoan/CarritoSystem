using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Paypal
{
    public class Checkout_Order
    {
        public class ItemTotal
        {
            public string currency_code { get; set; } 
            public string value { get; set; } 
        }

        public class Breakdown
        {
            public ItemTotal item_total { get; set; }
        }

        public class Amount
        {
            public string currency_code { get; set; }
            public string value { get; set; }
            public Breakdown breakdown { get; set; }
        }
    }
}

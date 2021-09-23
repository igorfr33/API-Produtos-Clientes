using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Model
{
    [AttributeUsage (AttributeTargets.All)]
    public class CryptoData : System.Attribute
    {
        public CryptoData ()
        { 
        }
        public int id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_seminarski_tattoostudio.Configuration
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public int TokenDuration { get; set; }
    }
}

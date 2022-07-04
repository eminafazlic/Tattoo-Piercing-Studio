using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model.Responses
{
    public class UserAuthenticationResult
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
    }
}

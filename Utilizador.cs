using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumindoWebApi
{
    class Utilizador
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public Morada Address { get; set; }
    }
}

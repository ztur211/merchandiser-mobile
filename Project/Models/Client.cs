using System;
using SQLite;

namespace Project.Models
{
    public class Client
    {
        public string ClientName { get; set; }
        public string ClientContact { get; set; }

        public string ClientImage { get; set; }
        public override string ToString()
        {
            return ClientName;
        }
    }
}
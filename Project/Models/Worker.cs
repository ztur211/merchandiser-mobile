using System;
using SQLite;

namespace Project.Models
{
    public class Worker
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Image { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
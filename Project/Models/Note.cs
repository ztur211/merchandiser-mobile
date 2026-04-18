using System;
using SQLite;

namespace Project.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public bool isChecked { get; set; }
        public string isCheckedMessage
        {
            get { return this.isChecked ? "Yes" : "No"; }
        }
    }
}
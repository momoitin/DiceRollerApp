using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DnDApp.Classes
{
    public class Money
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Copper { get; set; }

        public string Silver { get; set; }

        public string Gold { get; set; }

        public string Platinum { get; set; }

        public Money()
        {
        }
    }
}

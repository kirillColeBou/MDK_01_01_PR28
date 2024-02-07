using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcClub_Тепляков.Model
{
    public class Club
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string time_work { get; set; }

        public Club() { }

        public Club(int Id, string Name, string Address, string Time_work)
        {
            this.id = Id;
            this.name = Name;
            this.address = Address;
            this.time_work = Time_work;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcClub_Тепляков.Model
{
    public class Rent
    {
        public int id { get; set; }
        public int id_club { get; set; }
        public string client { get; set; }
        public DateTime date_rent { get; set; }
        public string time_rent { get; set; }

        public Rent() { }

        public Rent(int Id, int Id_club, string Client, DateTime Date_rent, string Time_rent)
        {
            this.id = Id;
            this.id_club = Id_club;
            this.client = Client;
            this.date_rent = Date_rent;
            this.time_rent = Time_rent;
        }
    }
}

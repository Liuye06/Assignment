using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class HallReservationManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public DateTime StartDate { get; set; }
        public string CustomerName { get; set; }
        public string HallName { get; set; }
        public string Function { get; set; }
        public string Status { get; set; }

    }
}

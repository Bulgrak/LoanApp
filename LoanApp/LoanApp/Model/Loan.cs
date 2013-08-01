using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp.Model
{
    class Loan
    {
        public List<Loan> MyLoans { get; set; }
        public string gert;
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime HandInDate { get; set; }

        public Loan()
        {
            MyLoans = new List<Loan>();
        }

        public string Gert
        {
            get {return gert;}
            set { gert = value;}
        }
    }
}

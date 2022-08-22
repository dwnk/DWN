using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwn.Domain.Models
{
    public class Portfolio
    {
        public Portfolio()
        {
            Trades = new List<Trade>();
        }
        public DateTime NextPaymentDate { get; set; }
        public int TotalTrades { get; set; }
        public List<Trade> Trades { get; set; }
    }
}

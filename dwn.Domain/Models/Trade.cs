using dwn.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwn.Domain.Models
{
    public  class Trade : ITrade
    {
        public double Value { get; set; }
        public string? ClientSector { get; set; }
        public DateTime NextPendingPaymentDate { get; set; }
        public TradeCategory? Category { get; set; }
    }
}

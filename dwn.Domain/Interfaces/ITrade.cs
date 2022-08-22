using dwn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwn.Domain.Interfaces
{
    public interface ITrade
    {
        double Value { get; set; }
        string? ClientSector { get; set; }
        DateTime NextPendingPaymentDate { get; set; }
        TradeCategory? Category { get; set; }
    }
}

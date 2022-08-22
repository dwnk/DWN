using dwn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwn.Domain.Interfaces
{
    public interface ITradeService
    {
        public string VerifyTradeCategory(Trade trade, DateTime referenceDate);
    }
}

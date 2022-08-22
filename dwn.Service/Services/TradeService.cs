using dwn.Domain.Interfaces;
using dwn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwn.Service.Services
{
    public class TradeService : ITradeService
    {
        public string VerifyTradeCategory(Trade trade, DateTime referenceDate)
        {
            return CheckTradeCategory(trade, referenceDate);
        }

        private string CheckTradeCategory(Trade item, DateTime referenceDate)
        {
            string category = string.Empty;
            if (item.NextPendingPaymentDate.AddDays(30) < referenceDate)
                return "EXPIRED";

            if (item.Value > 1000000)
            {
                switch (item.ClientSector?.ToUpper())
                {
                    case "PRIVATE":
                        return "HIGHRISK";
                    case "PUBLIC":
                        return "MEDIUMRISK";
                }
            }
            return category;
        }
    }
}

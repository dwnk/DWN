using dwn.Application.DependencyInjection;
using dwn.Domain.Interfaces;
using dwn.Domain.Models;
using dwn.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;

Q1();

void Q1()
{
    var builder = Host.CreateDefaultBuilder()
        .ConfigureServices((hostContext, services) =>
        {
            services.AdicionarDependencias();
        });
    var host = builder.Build();

    var portfollio = new Portfolio();

    string referenceDate = Console.ReadLine();
    portfollio.NextPaymentDate = DateTime.ParseExact(referenceDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
    portfollio.TotalTrades = Int32.Parse(Console.ReadLine());

    var tradeList = new List<Trade>();

    for (int i = 0; i < portfollio.TotalTrades; i++)
    {
        var trade = new Trade();
        string inlineTrade = Console.ReadLine();
        fillTrade(inlineTrade, trade);

        tradeList.Add(trade);
    }

    portfollio.Trades = tradeList;
    foreach (var item in portfollio.Trades)
    {
        using (IServiceScope scope = host.Services.CreateScope())
        {
            var tradeService = scope.ServiceProvider.GetRequiredService<ITradeService>();
            string itemCategory = tradeService.VerifyTradeCategory(item, portfollio.NextPaymentDate);
            Console.WriteLine(itemCategory);
        }
    }
}

void fillTrade(string inlineTrade, Trade trade)
{
    var tradeObj = inlineTrade.Split(" ");
    trade.Value = double.Parse(tradeObj[0]);
    trade.ClientSector = tradeObj[1];
    trade.NextPendingPaymentDate = DateTime.ParseExact(tradeObj[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);
}

//Q2:
//I would add the boolean property at Trade Model, and at service layer i would add a validation to check if IsPoliticallyExposed property is true or false.

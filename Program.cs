using System;
using System.Net;

class currency
{
    static void ReadAPI(string[] args)
    {
        using var client = new WebClient();
        var content = client.DownloadString("https://api.kucoin.com/api/v1/market/stats?symbol=BTC-USDT");
        Console.WriteLine(content);
    }
}
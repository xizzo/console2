using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static List<CovidData> lstCovidData;
    static string CityName = "Temse";

    static async Task Main(string[] args)
    {
        await GetJsonData();

        if(lstCovidData.Count > 0)
        {
            Console.WriteLine($"Found {lstCovidData.Count.ToString()} data points for {CityName}");
            PrintDataPoints();
        }
        else
        {
            Console.WriteLine($"No data points found for {CityName}");
        }

        Console.WriteLine("Done");
        Console.ReadLine();
    }

    static async Task GetJsonData()
    {
        Console.WriteLine("Retrieving Data...");
        HttpClient client = new HttpClient();
        HttpResponseMessage httpResponse = await client.GetAsync(new Uri("https://epistat.sciensano.be/Data/COVID19BE_CASES_MUNI.json"));

        if (httpResponse.IsSuccessStatusCode)
        {
            string strResponse = await httpResponse.Content.ReadAsStringAsync();
            strResponse = strResponse.Trim();

            lstCovidData = JsonConvert.DeserializeObject<List<CovidData>>(strResponse);
            lstCovidData = lstCovidData.Where(x => x.TXDESCRNL == CityName).ToList();
        }
        else
        {
            Console.WriteLine($"Failed to retrieve data: {httpResponse.StatusCode.ToString()}");
        }
    }

    static void PrintDataPoints()
    {
        lstCovidData.ForEach(x =>
        {
            Console.WriteLine($"{x.DATE} | {x.CASES}");
        });
    }
}

using System.Globalization;
using CsvHelper;

namespace PPB_Pricing;



public class Data
{
    private List<Data> csvData;
    public int HomeTeamWinner { get; set; }
    public int AwayTeamWinner { get; set; }
    public int HomeTeamPoints { get; set; }
    public int AwayTeamPoints { get; set; }

    public List<Data> CSVData
    {
        get
        {
            using var reader = new StreamReader("/Users/Amrita.Bindukalpa/Downloads/GameResults.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Data>().ToList();
        }
    }
    public double HomeTeamWins
    {
        get
        {
            return CSVData.Count(r => r.HomeTeamWinner == 1);
        }
    }
    
    public double AwayTeamWins
    {
        get
        {
            return CSVData.Count(r => r.AwayTeamWinner == 1);
        }
    }
    public double TotalMatchesPlayed
    {
        get
        {
            return CSVData.Count();
        }
    }

}
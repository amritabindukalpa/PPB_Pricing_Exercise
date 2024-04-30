using System.Globalization;
using CsvHelper;

namespace PPB_Pricing;

public class Data
{
    public int HomeTeamWinner { get; set; }
    public int AwayTeamWinner { get; set; }
    public int HomeTeamPoints { get; set; }
    public int AwayTeamPoints { get; set; }
    public bool IsHomeTeamWin => HomeTeamWinner == 1;
}

public class Stats
{
    public Stats(string csvFilePath)
    {
        using var reader = new StreamReader(csvFilePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        DataList = csv.GetRecords<Data>().ToList();
    }
    
    public IEnumerable<Data> DataList { get; set; }
    
    public int TotalMatchesPlayed => DataList.Count();
    
    public int HomeTeamWins => DataList.Count(r => r.IsHomeTeamWin);
    public int AwayTeamWins => TotalMatchesPlayed - HomeTeamWins;

    public int HomeTeamPoints => DataList.Sum(r => r.HomeTeamPoints);
    public int AwayTeamPoints => DataList.Sum(r => r.AwayTeamPoints);
}
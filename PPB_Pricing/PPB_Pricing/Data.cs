using System.Globalization;
using CsvHelper;

namespace PPB_Pricing;

public interface IData
{
    List<Data> ReadData(string csvFilePath);
}

public class Data : IData
{
    public int HomeTeamWinner { get; set; }
    public int AwayTeamWinner { get; set; }
    public int HomeTeamPoints { get; set; }
    public int AwayTeamPoints { get; set; }

    public List<Data> ReadData(string csvFilePath)
    {
        using var reader = new StreamReader(csvFilePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<Data>().ToList();
    }
}
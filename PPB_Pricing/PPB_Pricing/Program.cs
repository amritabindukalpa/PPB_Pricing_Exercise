// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CsvHelper;
using PPB_Pricing;



var data = new Data();
Console.WriteLine($"Total Matches Played: {data.TotalMatchesPlayed}");
Console.WriteLine($"Home team win probability: {data.HomeTeamWins/data.TotalMatchesPlayed*100 }");
Console.WriteLine($"Away team win probability: {data.AwayTeamWins/data.TotalMatchesPlayed *100}");
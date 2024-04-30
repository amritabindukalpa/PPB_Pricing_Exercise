// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CsvHelper;
using PPB_Pricing;



var stats = new Stats("/Users/Amrita.Bindukalpa/Downloads/GameResults.csv");
Console.WriteLine($"Total Matches Played: {stats.HomeTeamWins}");
Console.WriteLine($"Home team win probability: {(double)stats.HomeTeamWins/stats.TotalMatchesPlayed*100 }");
Console.WriteLine($"Away team win probability: {(double)stats.AwayTeamWins/stats.TotalMatchesPlayed *100}");
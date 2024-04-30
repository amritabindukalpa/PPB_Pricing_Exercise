// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CsvHelper;
using PPB_Pricing;



var stats = new Stats("/Users/Amrita.Bindukalpa/Downloads/GameResults.csv");
Console.WriteLine($"Total Matches Played: {stats.HomeTeamWins}");
Console.WriteLine($"Home team win probability: {(double)stats.HomeTeamWins/stats.TotalMatchesPlayed*100 }");
Console.WriteLine($"Away team win probability: {(double)stats.AwayTeamWins/stats.TotalMatchesPlayed *100}");

var dataArray = stats.DataList.Select(r => (double)r.AwayTeamPoints + r.HomeTeamPoints).ToArray();
var medianForHalfPoint = MathFunctions.CalculateMedian( dataArray);
var meanForHalfPoint = MathFunctions.CalculateMean(dataArray);
var sdForHalfPoint = MathFunctions.CalculateStandardDeviation(dataArray);
double probability = MathFunctions.CalculateProobability(meanForHalfPoint, sdForHalfPoint, medianForHalfPoint-.5);
Console.WriteLine($"Half point being under probability: {probability*100}");
Console.WriteLine($"Half point being over probability: {(1-probability)*100}");
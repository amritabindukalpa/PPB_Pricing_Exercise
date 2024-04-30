// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CsvHelper;
using PPB_Pricing;



var stats = new Stats("Resources/GameResults.csv");
Console.WriteLine($"Total Matches Played: {stats.HomeTeamWins}");
Console.WriteLine($"Home team win probability: {Math.Round((double)stats.HomeTeamWins/stats.TotalMatchesPlayed,2)*100 }%");
Console.WriteLine($"Away team win probability: {(double)stats.AwayTeamWins/stats.TotalMatchesPlayed *100}%");

var dataArray = stats.DataList.Select(r => (double)r.AwayTeamPoints + r.HomeTeamPoints).ToArray();
var medianForHalfPoint = MathFunctions.CalculateMedian( dataArray);
var meanForHalfPoint = MathFunctions.CalculateMean(dataArray);
var sdForHalfPoint = MathFunctions.CalculateStandardDeviation(dataArray);
double probability = MathFunctions.CalculateProobability(meanForHalfPoint, sdForHalfPoint, medianForHalfPoint-.5)*100;
Console.WriteLine($"Half point being under probability: {probability}%");
Console.WriteLine($"Half point being over probability: {100-probability}%");

dataArray = stats.DataList.Select(r => (double) r.HomeTeamPoints-r.AwayTeamPoints).ToArray();
var meanForLessThanOrExactly = MathFunctions.CalculateMean(dataArray);
var sdForLessThanOrExactly = MathFunctions.CalculateStandardDeviation(dataArray);
double zScore = (10 - meanForLessThanOrExactly) / sdForLessThanOrExactly;

double probabilityLessThanOrExactly = MathFunctions.CalculateProobability(0, 1, zScore)*100;
Console.WriteLine($"Probability of home team winning by less than or exactly 10 points : {probabilityLessThanOrExactly}%");
Console.WriteLine($"Probability of home team winning by 11 or more points : {100 - probabilityLessThanOrExactly}%");

dataArray = stats.DataList.Select(r => (double) r.AwayTeamPoints-r.HomeTeamPoints).ToArray();
var meanForAwayLessThanOrExactly = MathFunctions.CalculateMean(dataArray);
var sdForAwayLessThanOrExactly = MathFunctions.CalculateStandardDeviation(dataArray);
zScore = (10 - meanForAwayLessThanOrExactly) / sdForAwayLessThanOrExactly;

double probabilityAwayLessThanOrExactly = MathFunctions.CalculateProobability(0, 1, zScore)*100;
Console.WriteLine($"Probability of away team winning by less than or exactly 10 points : {probabilityAwayLessThanOrExactly}%");
Console.WriteLine($"Probability of away team winning by 11 or more points : {100 - probabilityAwayLessThanOrExactly}%");
// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CsvHelper;
using PPB_Pricing;

var count = new Data().ReadData("/Users/Amrita.Bindukalpa/Downloads/GameResults.csv").Count();


Console.WriteLine($"Total Matches Played: {count}");
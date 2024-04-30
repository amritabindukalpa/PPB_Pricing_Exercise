using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPB_Pricing;

namespace PPB_Pricing.Tests;

[TestClass]
[TestSubject(typeof(Stats))]
public class StatsTest
{
    private Stats stats;
    [TestInitialize]
    public void ReadData()
    {
        stats = new Stats("/Users/Amrita.Bindukalpa/PPB_Pricing_Exercise/PPB_Pricing/PPB_Pricing.Tests/GameResults.csv");
    }

    [TestMethod]
    public void Test_Count_Of_Records()
    {

        Assert.AreEqual(stats.TotalMatchesPlayed, 10, "Count does not match total number of records");
    }
    
    [TestMethod]
    public void Test_Count_Of_HomeTeamWins()
    {
       
        Assert.AreEqual(stats.HomeTeamWins, 3, "Count does not match home team wins");
    }
    
    [TestMethod]
    public void Test_Count_Of_AwayTeamWins()
    {
        
        Assert.AreEqual(stats.AwayTeamWins, 7, "Count does not match away team wins");
    }
    
    [TestMethod]
    public void Test_AwayTeam_Points()
    {
        
        Assert.AreEqual(stats.AwayTeamPoints, 80, "Count does not match away team wins");
    }
    
    
    [TestMethod]
    public void Test_HomeTeam_Points()
    {
        
        Assert.AreEqual(stats.HomeTeamPoints, 30, "Count does not match away team wins");
    }
}
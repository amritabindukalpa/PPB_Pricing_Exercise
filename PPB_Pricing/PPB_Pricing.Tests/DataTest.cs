using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPB_Pricing;

namespace PPB_Pricing.Tests;

[TestClass]
[TestSubject(typeof(Data))]
public class DataTest
{
    private List<Data> data;
    [TestInitialize]
    public void ReadData()
    {
        data = new Data().ReadData("/Users/Amrita.Bindukalpa/PPB_Pricing/PPB_Pricing.Tests/GameResults.csv");
    }

    [TestMethod]
    public void Test_Count_Of_Records()
    {

        Assert.AreEqual(data.ToList().Count(), 10, "Count does not match total number of records");
    }
    
    [TestMethod]
    public void Test_Count_Of_HomeTeamWins()
    {
       
        Assert.AreEqual(data.Count(r => r.HomeTeamWinner == 1), 3, "Count does not match home team wins");
    }
    
    [TestMethod]
    public void Test_Count_Of_AwayTeamWins()
    {
        
        Assert.AreEqual(data.Count(r => r.HomeTeamWinner == 0), 7, "Count does not match away team wins");
    }
}
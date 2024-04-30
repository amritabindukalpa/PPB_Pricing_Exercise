using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

namespace PPB_Pricing;

public static class MathFunctions
{
    public static double CalculateMedian(double[] data)
    {
        return data.Median();
    }

    public static double CalculateMean(double[] data)
    {
        return data.Mean();
    }

    public static double CalculateStandardDeviation(double[] data)
    {
        return data.StandardDeviation();
    }

    public static double CalculateProobability(double mean, double sd, double median)
    {
        return  Normal.CDF(mean, sd, median);
    }
}
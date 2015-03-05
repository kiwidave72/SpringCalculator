using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringRaceCalculator.Library
{
    public enum Measurments
    {
        Kilograms,
        Grams
    }

    public static class SpringRate
    {
        public static double CalculateCompression(double rate , double newtons , int unCompressedLength )
        {
            //F = k*x
            var length = rate*newtons;

            return unCompressedLength-length;
        }

        public static double ToNewtons(double weight, Measurments weightMeasurment)
        {
            if (weightMeasurment == Measurments.Kilograms)
            {
                return 9.80665002864 * weight;
            }
            else
            {
                return 0;
            }
        }
    }
}

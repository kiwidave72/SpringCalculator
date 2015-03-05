using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpringRaceCalculator.Library;

namespace SpringRateCalculator.Acceptance.Tests
{
    public class SpringRateCalculatorTest
    {
        private double _rate;
        private double _newtons;
        private int _uncompressLength;
        private double _weight;
        private int _wishboneLength;
        private double _ratio;


        internal void Given_the_spring_rate_of(double rate)
        {
            _rate = rate;

        }

        internal void Given_the_force_of(double newtons)
        {
            _newtons = newtons;
            
            _ratio = 1;
        }

        internal void Given_the_spring_length_of(int uncompressLength)
        {
            _uncompressLength = uncompressLength;
        }

        internal void Given_the_leverage_percentage_of(int percentage)
        {
            _ratio = (100/percentage);
        }
        
        internal void Given_the_shock_off_set_of(int offset)
        {
            _ratio = (_wishboneLength / offset);
        }

        internal void When_we_apply_the_resulting_force()
        {
            _newtons = _newtons / _ratio;
        }

        internal void Given_the_wishbone_length_of(int length)
        {
            _wishboneLength = length;
        }


        internal void Then_the_compressed_length_is(double expectedCompressLength)
        {
            var length = SpringRate.CalculateCompression(_rate, _newtons, _uncompressLength);

            Assert.IsTrue(length == expectedCompressLength, string.Format("expected compressed Length was {0} the actual length was {1}", expectedCompressLength, length));

        }
        internal void Given_the_weight_in_kgs(double weight)
        {
            
            _weight=weight;
        }

        internal  void Then_the_force_is(double expectedForce)
        {
            var force = SpringRate.ToNewtons(_weight, Measurments.Kilograms);

            Assert.IsTrue(force == expectedForce,
                string.Format("expected force was {0} the actual force was {1}", expectedForce, force));
        }
    }
}
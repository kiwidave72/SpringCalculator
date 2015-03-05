using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpringRaceCalculator.Library;

namespace SpringRateCalculator.Acceptance.Tests
{
    [TestClass]
    public class About_calculator : SpringRateCalculatorTest
    {

        [TestMethod]
        public void can_calculate_compressed_length()
        {
            Given_the_spring_rate_of(1.00);

            Given_the_spring_length_of(10);

            Given_the_force_of(2);

            When_we_apply_the_resulting_force();

            Then_the_compressed_length_is(8);
        }

        [TestMethod]
        public void can_calculate_compressed_length_with_leverage()
        {
            Given_the_spring_rate_of(1.00);

            Given_the_spring_length_of(10);

            Given_the_force_of(2);

            Given_the_leverage_percentage_of(50);

            When_we_apply_the_resulting_force();

            Then_the_compressed_length_is(9);
        }

        [TestMethod]
        public void can_calculate_compressed_length_with_a_given_wishbone_length()
        {
            Given_the_spring_rate_of(1.00);

            Given_the_spring_length_of(10);

            Given_the_force_of(2);

            Given_the_wishbone_length_of(80);

            Given_the_shock_off_set_of(70);

            When_we_apply_the_resulting_force();

            Then_the_compressed_length_is(8);
        }

        [TestMethod]
        public void can_convert_force_from_weight()
        {
            Given_the_weight_in_kgs(1);
            
            Then_the_force_is(9.80665002864);
        }

        
    }
}

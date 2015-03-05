using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpringRaceCalculator.Library;

namespace SpringRateCalculator.Acceptance.Tests
{
    [TestClass]
    public class About_vehicle_as_dead_weight : SpringRateCalculatorTest
    {
         [TestMethod]
        public void for_example()
        {
            Given_the_spring_rate_of(0.00);

            Given_the_spring_length_of(10);

            Given_the_force_of(SpringRate.ToNewtons(2,Measurments.Kilograms));

            Given_the_wishbone_length_of(80);

            Given_the_shock_off_set_of(70);

            When_we_apply_the_resulting_force();

            Then_the_compressed_length_is(10);

        }
    }
}

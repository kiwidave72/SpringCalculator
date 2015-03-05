using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SpringRaceCalculator.Library
{
    public class StaticVehicle
    {
        public float Weight { get; set; }

        public RearEnd Rear { get; set; }

        public FrontEnd Front { get; set; }
    }

    public class FrontEnd 
    {
        public string LeftSide { get; set; }

        public string RightSide { get; set; }
    }

    public class RearEnd 
    {
        public SideComponent LeftSide { get; set; }

        public SideComponent RightSide { get; set; }
    }

    public class SideComponent
    {
        public StaticComponent Wishbone { get; set; }

        public StaticComponent TopLink { get; set; }

        public SpringComponent Spring { get; set; }

    }

    public class SpringComponent
    {
        public float Rate { get; set; }

        public float Length { get; set; }
    }

    public class StaticComponent
    {
        public float Length { get; set; }

        public Location FixedLocation { get; set; }
    }

    public class Location
    {
        public float InnerZOffset { get; set; }

        public float InnerXOffset { get; set; }

        public float InnerYOffset { get; set; }

    }

}

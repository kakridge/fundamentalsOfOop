using System;

namespace FundamentalsOfOop
{
    public class Delorean
    {
        private readonly FluxCapacitor _fluxCapacitor = new FluxCapacitor();

        public string Accelerate()
        {
            var date = _fluxCapacitor.Disperse();
            return date.ToLongDateString();
        }

        private class FluxCapacitor
        {
            private readonly Random _generator = new Random();

            public DateTime Disperse()
            {
                var y = 0x7BA;
                var m = 0xB;
                var d = 0xC;
                var start = new DateTime(y, m, d);
                var range = (DateTime.Today - start).Days;
                return start.AddDays(_generator.Next(range));
            }
        }
    }
}
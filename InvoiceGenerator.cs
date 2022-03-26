using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        const int COST_PER_KILOMETER = 10;
        const int COST_PER_MINUTE = 1;
        const int MINIMUM_FARE = 5;

        

        public double GenerateFare(double distance, int time)
        {
            var fair = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            if (fair > MINIMUM_FARE)
            {
                return fair;
            }
            return MINIMUM_FARE;
        }
    }
}

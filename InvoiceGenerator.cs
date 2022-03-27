using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        const int COST_PER_KILOMETER = 10;
        const int COST_PER_MINUTE = 1;
        const int MINIMUM_FARE = 5;
        List<Ride> rides = new List<Ride>();


        public double GenerateFare(double distance, int time)
        {
            var fair = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            if (fair > MINIMUM_FARE)
            {
                return fair;
            }
            return MINIMUM_FARE;
        }

        public void AddRide(double distance, int time)
        {
            rides.Add(new Ride()
            {
                distance = distance,
                time = time
            });
        }
        public double CalculateAggregate()
        {
            double fair = 0;
            foreach (Ride ride in rides)
            {
                fair += GenerateFare(ride.distance, ride.time);
            }
            return fair;
        }
    }
}

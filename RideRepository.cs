using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    internal class RideRepository
    {
        public Dictionary<string, List<Ride>> user_rides;

        public RideRepository()
        {
            user_rides = new Dictionary<string, List<Ride>>();
        }
        public void AddRideInRideRepo(string user_Id, List<Ride> rides)
        {
            user_rides[user_Id] = rides;
        }
        public List<Ride> GetRideByUserId(string user_Id)
        {
            try
            {
                return user_rides[user_Id];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

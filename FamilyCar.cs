using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_3
{/// <summary>
/// Family.
/// </summary>
    public class FamilyCar : Car
    {/// <summary>
     /// Initializes a new instance of the <see cref="FamilyCar"/> class.
     /// </summary>
     /// <param name="maxSpeed">Speed.</param>
     /// <param name="weight">weight.</param>
     /// <param name="brand">brand.</param>
     /// <param name="numOfDoors">numOfDoors.</param>
     /// <param name="rateOfSafety">Safety.</param>
        public FamilyCar(
            int maxSpeed,
            int weight,
            string brand,
            int numOfDoors,
            int rateOfSafety)
            : base(maxSpeed, weight, brand, numOfDoors)
        {
            this.RateOfSafety = rateOfSafety;
        }

          /// <summary>
         /// Gets rate Of Safety.
         /// </summary>
        public int RateOfSafety { get; }

        /// <inheritdoc/>
        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{this.MaxSpeed}km/h, Weight:{this.Weight}kg, Brand:{this.Brand}, Number of doors:{this.NumOfDoors}");
        }

        /// <inheritdoc/>
        public override void Move()
        {
           Console.WriteLine("I travel with my family!");
        }
    }
}

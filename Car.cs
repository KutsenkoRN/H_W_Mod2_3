using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_3
{/// <summary>
/// class Car.
/// </summary>
    public class Car : Vehicle
    { /// <summary>
      /// Initializes a new instance of the <see cref="Car"/> class.
      /// </summary>
      /// <param name="maxSpeed">speed.</param>
      /// <param name="weight">weight.</param>
      /// <param name="brand">brand.</param>
      /// <param name="numOfDoors">doors.</param>
        public Car(
            int maxSpeed,
            int weight,
            string brand,
            int numOfDoors)
            : base(maxSpeed, weight)
        {
            this.Brand = brand;
            this.NumOfDoors = numOfDoors;
        }

        /// <summary>
        /// Gets brend.
        /// </summary>
        public string Brand { get; }

        /// <summary>
        /// Gets num of doors.
        /// </summary>
        public int NumOfDoors { get; }

        /// <inheritdoc/>
        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{this.MaxSpeed}km/h, Weight:{this.Weight}kg, Brand:{this.Brand}, Number of doors:{this.NumOfDoors}");
        }

        /// <inheritdoc/>
        public override void Move()
        {
            Console.WriteLine("I am driving!");
        }
    }
}

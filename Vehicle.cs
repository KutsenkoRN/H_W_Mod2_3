namespace H_W_Mod2_3
{/// <summary>
/// Base.
/// </summary>
    public abstract class Vehicle
    {/// <summary>
     /// Initializes a new instance of the <see cref="Vehicle"/> class.
     /// Abstract class constructor.
     /// </summary>
     /// <param name="maxSpeed">speed.</param>
     /// <param name="weight">weihle.</param>
        public Vehicle(int maxSpeed, int weight)
        {
            this.MaxSpeed = maxSpeed;
            this.Weight = weight;
        }

    /// <summary>
    /// Gets max speed.
    /// </summary>
        public int MaxSpeed { get; }

        /// <summary>
        /// Gets weight.
        /// </summary>
        public int Weight { get; }

        /// <summary>
        /// Compare.
        /// </summary>
        /// <param name="vehicle">weight.</param>
        /// <returns>weight return.</returns>
        public int CompareTo(Vehicle vehicle)
        {
            return this.Weight - vehicle.Weight;
        }

        /// <summary>
        /// Move.
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// Info.
        /// </summary>
        public abstract void ShowInfo();
    }
}
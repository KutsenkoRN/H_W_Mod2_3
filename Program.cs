using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace H_W_Mod2_3
{/// <summary>
/// Start point to app.
/// </summary>
    internal class Program
    {/// <summary>
     /// Start of app.
     /// </summary>
     /// <param name ="args">addet via console.</param>
        public static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(240, 2500, "Volkswagen", 5),
                new Car(220, 2100, "Volkswagen", 5),
                new Car(210, 1800, "Renault", 5),
                new FamilyCar(160, 2000, "Renault", 4, 9),
                new FamilyCar(180, 2100, "Volkswagen", 5, 9),
            };

            Vehicle[] foundBrands = vehicles.FindByBrand("Volkswagen");
            for (int i = 0; i < foundBrands.Length; i++)
            {
                foundBrands[i].ShowInfo();
            }
        }
    }
}
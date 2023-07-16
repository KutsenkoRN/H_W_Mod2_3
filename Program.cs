using System;
using System.Diagnostics;

namespace H_W_Mod2_3
{/// <summary>
/// Start point to app.
/// </summary>
    internal class Program
    {/// <summary>
     /// Start of app.
     /// </summary>
     /// <param name ="args">addet via console.</param>
        private static void Main(string[] args)
        {
            {
                Car volkswagentouareg = new Car(240, 2500, "Volkswagen", 5);
                FamilyCar renaulttrafic = new FamilyCar(160, 2000, "Renault", 4, 9);

                volkswagentouareg.ShowInfo();
                renaulttrafic.ShowInfo();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H_W_Mod2_3
{/// <summary>
/// extension method.
/// </summary>
    internal static class ExtensionMethods
    {/// <summary>
     /// Initializes static members of the <see cref="ExtensionMethods"/> class.
     /// extension method FindByBrand.
     /// </summary>
     /// <param name="">vehicle.</param>
     /// <param name="brand">brand.</param>
     /// <returns>return.</returns>
#pragma warning disable SA1611 // Element parameters should be documented
        public static Vehicle[] FindByBrand(this Vehicle[] vehicles, string brand)
        {
            Vehicle[] extraArray = new Vehicle[vehicles.Length];
            int counter = 0;
            foreach (var veh in vehicles)
            {
                if (veh.Brand == brand)
                {
                    extraArray[counter++] = veh;
                }
            }

            Vehicle[] result = new Vehicle[counter];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = extraArray[i];
            }

            return result;
        }
    }
}

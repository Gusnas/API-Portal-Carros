using Portal_Carros_API.Domain.Helpers;
using Portal_Carros_API.Domain.Models;

namespace Portal_Carros_API.List
{
    public class CarList 
    {
        private static List<Cars> carList = new List<Cars>()
            {
                new Cars (1, 10.0, 55, 25, 16, "peugeot 208 gt", ECarsType.Turbo),
                new Cars (2, 11.3, 44, 21, 25, "citroen ds3", ECarsType.Turbo),
                new Cars (3, 10.2, 50, 10, 46, "chevrolet chevette", ECarsType.Basic),
                new Cars (4, 6.7, 80, 50, 20, "bmw 328i", ECarsType.Economic),
                new Cars (5, 9.5, 40, 36, 14, "volkswagen gol", ECarsType.Turbo)
            };

        public static List<Cars> GetCarList()
        {
            return carList;
        }
    }
}

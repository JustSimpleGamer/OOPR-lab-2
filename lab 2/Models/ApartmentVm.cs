using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Models
{
    public class ApartmentVm //1. Реалізація класу
    {
        public string SleepingPlacesNumber { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public string ApartmentСlass { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public List<int> StayTime { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public ApartmentVm() //4. конструктор без параметрів
        {
            SleepingPlacesNumber = "";
            ApartmentСlass = "";
            StayTime = new List<int>() {0, 0, 0};
        }
        public ApartmentVm(string sleepingPlacesNumber, string apartmentСlass, List<int> stayTime) //4. конструктор з параметрами
        {
            SleepingPlacesNumber = sleepingPlacesNumber;
            ApartmentСlass = apartmentСlass;
            StayTime = stayTime;
        }
    }
}

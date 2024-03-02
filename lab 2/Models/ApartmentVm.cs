using System.Collections.Generic;

namespace lab_2.Models
{
    public class ApartmentVm //1. Class implementation
    {
        public string SleepingPlacesNumber { get; set; } //3. Implementing a data field using properties { get; set; }
        public string ApartmentСlass { get; set; } //3. Implementing a data field using properties { get; set; }
        public List<int> StayTime { get; set; } //3. Implementing a data field using properties { get; set; }
        public ApartmentVm() //4. Constructor without parameters
        {
            SleepingPlacesNumber = "";
            ApartmentСlass = "";
            StayTime = new List<int>() {0, 0, 0};
        }
        public ApartmentVm(string sleepingPlacesNumber, string apartmentСlass, List<int> stayTime) //4. Constructor with parameters
        {
            SleepingPlacesNumber = sleepingPlacesNumber;
            ApartmentСlass = apartmentСlass;
            StayTime = stayTime;
        }
    }
}

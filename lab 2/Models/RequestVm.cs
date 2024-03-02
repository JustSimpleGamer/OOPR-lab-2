namespace lab_2.Models
{
    public class RequestVm //1. Class implementation
    {
        public RequestStates State {  get; set; } //3. Implementing a data field using properties { get; set; }
        public ApartmentVm Apartment { get; set; } //3. Implementing a data field using properties { get; set; } + 2. звязок між класами
        public RequestVm() //4. Constructor without parameters
        {
            State = 0;
            Apartment = new ApartmentVm();
        }
        public RequestVm(RequestStates requestState, ApartmentVm apartment) //4. Constructor with parameters
        {
            State = requestState;
            Apartment = apartment;
        }
    }
}

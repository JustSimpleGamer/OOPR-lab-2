using System;

namespace lab_2.Models
{
    [Serializable]
    public class ClientVm : HumanVm //1. Class implementation
    {
        public string Status { get; set; } //3. Implementing a data field using properties { get; set; }
        public RequestVm Request {  get; set; } //3. Implementing a data field using properties { get; set; } + 2. звязок між класами
        public ClientVm() //4. Constructor without parameters
        { }
        public ClientVm(string name, string surmame, string patronymic) : base(name, surmame, patronymic) //4. Constructor with parameters + 6. Example of using the base keyword to access members of the base class
        {

        }
        public ClientVm(string name, string surmame, string patronymic, string phoneNumber, string status) : base(name, surmame, patronymic, phoneNumber) //4. Constructor with parameters + 6. Example of using the base keyword to access members of the base class
        {
            Status = status;
        }
        sealed public override string GetFullInformation() //7. preventing other classes from inheriting from this class using the sealed member + 8. provided a new implementation of a member inherited from the base class via override + 9. virtual function
        {
            return base.GetFullInformation() + " " + Status; //6. demonstrating access to base members from a derived class using the base keyword
        }
        new public string GetClassInformation() //5. implementation of hiding the inherited method through the new modifier
        {
            return Status;
        }
    }
}

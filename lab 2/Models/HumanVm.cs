namespace lab_2.Models
{
    public class HumanVm //1. Class implementation
    {
        public string Name { get; set; } //3. Implementing a data field using properties { get; set; }
        public string Surname { get; set; } //3. Implementing a data field using properties { get; set; }
        public string Patronymic { get; set; } //3. Implementing a data field using properties { get; set; }
        public string PhoneNumber {  get; set; } //3. Implementing a data field using properties { get; set; }

        public HumanVm() //4. Constructor without parameters
        { }
        public HumanVm(string name, string surmame, string patronymic) //4. Constructor with parameters
        {
            Name = name;
            Surname = surmame;
            Patronymic = patronymic;
        }
        public HumanVm(string name, string surmame, string patronymic, string phoneNumber) //4. Constructor with parameters
        {
            Name = name;
            Surname = surmame;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
        }
        public virtual string GetFullInformation() //9. virtual function
        {
            return Name + " " + Surname + " " + Patronymic + " " + PhoneNumber;
        }
        public string GetClassInformation()
        {
            return Name + " " + Surname + " " + Patronymic + " " + PhoneNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Models
{
    public class HumanVm //1. Реалізація класу
    {
        public string Name { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public string Surname { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public string Patronymic { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public string PhoneNumber {  get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }                          
        public HumanVm() //4. конструктор без параметрів
        { }
        public HumanVm(string name, string surmame, string patronymic) //4. конструктор з параметрами
        {
            Name = name;
            Surname = surmame;
            Patronymic = patronymic;
        }
        public HumanVm(string name, string surmame, string patronymic, string phoneNumber) //4. конструктор з параметрами
        {
            Name = name;
            Surname = surmame;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
        }
        public virtual string GetFullInformation() //9. віртуальна функція
        {
            return Name + " " + Surname + " " + Patronymic + " " + PhoneNumber;
        }
        public string GetClassInformation()
        {
            return Name + " " + Surname + " " + Patronymic + " " + PhoneNumber;
        }
    }
}

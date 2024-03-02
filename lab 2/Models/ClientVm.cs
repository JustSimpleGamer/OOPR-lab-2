using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Models
{
    [Serializable]
    public class ClientVm : HumanVm //1. Реалізація класу
    {
        public string Status { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public RequestVm Request {  get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; } + 2. звязок між класами
        public ClientVm() //4. конструктор без параметрів
        { }
        public ClientVm(string name, string surmame, string patronymic) : base(name, surmame, patronymic) //4. конструктор з параметрами + 6. приклад використання ключового слова base при до доступу до членів базового класу
        {

        }
        public ClientVm(string name, string surmame, string patronymic, string phoneNumber, string status) : base(name, surmame, patronymic, phoneNumber) //4. конструктор з параметрами + 6. приклад використання ключового слова base при до доступу до членів базового класу
        {
            Status = status;
        }
        sealed public override string GetFullInformation() //7. заборона іншим класам успадковувати від цього класу за допомогою члена sealed + 8. надана нова реалізація члена, успадкованого від базового класу за допомогою override + 9. віртуальна функція
        {
            return base.GetFullInformation() + " " + Status; //6. демонстрація доступу до членів базового з похідного класу за допомогою слова base
        }
        new public string GetClassInformation() //5. реалізація приховування успадкованого методу через модифікатор new
        {
            return Status;
        }
    }
}

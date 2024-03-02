using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Models
{
    public class RequestVm //1. Реалізація класу
    {
        public RequestStates State {  get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public ApartmentVm Apartment { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; } + 2. звязок між класами
        public RequestVm() //4. конструктор без параметрів
        {
            State = 0;
            Apartment = new ApartmentVm();
        }
        public RequestVm(RequestStates requestState, ApartmentVm apartment) //4. конструктор з параметрами
        {
            State = requestState;
            Apartment = apartment;
        }
    }
}

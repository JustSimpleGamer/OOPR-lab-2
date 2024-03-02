using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2.Models
{
    public class ClientManagerVm //1. Реалізація класу
    {
        public string ClientsProfilesFolderPath = "D:\\Work\\IV семестр\\Об'єктно орієнтоване проектування Лаб №2\\lab 2\\lab 2\\Clients\\";
        public string ClientProfileMainFilePath;
        public string ClientProfilePasswordFilePath;
        public ClientVm Client {  get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public ClientManagerVm() //4. конструктор без параметрів
        {
            Client = null;
        }
        public ClientManagerVm(ClientVm client) //4. конструктор з параметрами
        {
            Client = client;
            ClientsProfilesFolderPath += Client.Name + " " + Client.Surname + " " + Client.Patronymic + "\\";
            ClientProfileMainFilePath = ClientsProfilesFolderPath + "Client.json";
            ClientProfilePasswordFilePath = ClientsProfilesFolderPath + "Password.txt";
        }
        public ClientManagerVm(ref ClientVm client) //4. конструктор з параметрами
        {
            Client = client;
            ClientsProfilesFolderPath += Client.Name + " " + Client.Surname + " " + Client.Patronymic + "\\";
            ClientProfileMainFilePath = ClientsProfilesFolderPath + "Client.json";
            ClientProfilePasswordFilePath = ClientsProfilesFolderPath + "Password.txt";
        }
        public ClientManagerVm(string clinetName, string clientSurname, string clientPatronymic) //4. конструктор з параметрами
        {
            Client = new ClientVm(clinetName, clientSurname, clientPatronymic);
            ClientsProfilesFolderPath += Client.Name + " " + Client.Surname + " " + Client.Patronymic + "\\";
            ClientProfileMainFilePath += ClientsProfilesFolderPath + "Client.json";
            ClientProfilePasswordFilePath = ClientsProfilesFolderPath + "Password.txt";
        }
    }
}

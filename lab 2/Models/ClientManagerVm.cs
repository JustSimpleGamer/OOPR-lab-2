namespace lab_2.Models
{
    public class ClientManagerVm //1. Class implementation
    {
        public string ClientsProfilesFolderPath = "D:\\Work\\IV семестр\\Об'єктно орієнтоване проектування Лаб №2\\lab 2\\lab 2\\Clients\\";
        public string ClientProfileMainFilePath;
        public string ClientProfilePasswordFilePath;
        public ClientVm Client {  get; set; } //3. Implementing a data field using properties { get; set; }
        public ClientManagerVm() //4. Constructor without parameters
        {
            Client = null;
        }
        public ClientManagerVm(ClientVm client) //4. Constructor with parameters
        {
            Client = client;
            ClientsProfilesFolderPath += Client.Name + " " + Client.Surname + " " + Client.Patronymic + "\\";
            ClientProfileMainFilePath = ClientsProfilesFolderPath + "Client.json";
            ClientProfilePasswordFilePath = ClientsProfilesFolderPath + "Password.txt";
        }
        public ClientManagerVm(ref ClientVm client) //4. Constructor with parameters
        {
            Client = client;
            ClientsProfilesFolderPath += Client.Name + " " + Client.Surname + " " + Client.Patronymic + "\\";
            ClientProfileMainFilePath = ClientsProfilesFolderPath + "Client.json";
            ClientProfilePasswordFilePath = ClientsProfilesFolderPath + "Password.txt";
        }
        public ClientManagerVm(string clinetName, string clientSurname, string clientPatronymic) //4. Constructor with parameters
        {
            Client = new ClientVm(clinetName, clientSurname, clientPatronymic);
            ClientsProfilesFolderPath += Client.Name + " " + Client.Surname + " " + Client.Patronymic + "\\";
            ClientProfileMainFilePath += ClientsProfilesFolderPath + "Client.json";
            ClientProfilePasswordFilePath = ClientsProfilesFolderPath + "Password.txt";
        }
    }
}

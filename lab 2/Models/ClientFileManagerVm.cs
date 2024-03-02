using System.IO;
using System.Text.Json;

namespace lab_2.Models
{
    public class ClientFileManagerVm //1. Class implementation
    {
        public string ClientProfileFolderPath { get; set; } = "D:\\Work\\IV семестр\\Об'єктно орієнтоване проектування Лаб №2\\lab 2\\lab 2\\Clients\\"; //3. Implementing a data field using properties { get; set; }
        public string ClientProfileMainFilePath { get; set; }  //3. Implementing a data field using properties { get; set; }
        public string ClientProfilePasswordFilePath { get; set; } //3. Implementing a data field using properties { get; set; }
        public string ClientPassword { get; set; } //3. Implementing a data field using properties { get; set; }

        public ClientVm Client;

        public ClientFileManagerVm(string clientName, string clientSurname, string clientPatronymic, string password) //4. Constructor with parameters
        {
            ClientProfileFolderPath += $"{clientName} {clientSurname} {clientPatronymic}\\";
            ClientProfileMainFilePath = $"{ClientProfileFolderPath}Client.json";
            ClientProfilePasswordFilePath = $"{ClientProfileFolderPath}Password.txt";
            ClientPassword = password;
        }

        public ClientFileManagerVm(ClientVm client) //4. Constructor with parameters
        {
            ClientProfileFolderPath += $"{client.Name} {client.Surname} {client.Patronymic}\\";
            ClientProfileMainFilePath = ClientProfileFolderPath + "Client.json";
            ClientProfilePasswordFilePath = ClientProfileFolderPath + "Password.txt";

            Client = client;
        }

        public bool IsAllClientAuthorizationDataCorrect()
        {
            if (!Directory.Exists(ClientProfileFolderPath))
            {
                return false;
            }

            if (ClientPassword != System.IO.File.ReadAllText(ClientProfilePasswordFilePath))
            {
                return false;
            }

            return true;
        }

        public ClientVm LoadClient() //11. Method that reads from a class object's data field file (the entire object)
        {
            ClientVm client;
            using (FileStream fs = new FileStream(ClientProfileMainFilePath, FileMode.Open, FileAccess.Read))
            {
                client = JsonSerializer.Deserialize<ClientVm>(fs);
                Client = client;
            }
            return client;
        }

        public void SaveClient() //11. Method that writes to the file the data fields of the class object (the entire object)
        {
            using (FileStream fs = new FileStream(ClientProfileMainFilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                JsonSerializer.Serialize(fs, Client);
            }
        }

        public bool CreateProfile(string password) //11. Method that writes to the file the data fields of the class object (the entire object)
        {
            if (Directory.Exists(ClientProfileFolderPath) == true)
            {
                return false;
            }
            Directory.CreateDirectory(ClientProfileFolderPath);
            using (FileStream fs = new FileStream(ClientProfileMainFilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                JsonSerializer.Serialize(fs, Client);
            }
            System.IO.File.WriteAllText(ClientProfilePasswordFilePath, password);
            return true;
        }
    }
}


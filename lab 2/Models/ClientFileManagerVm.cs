using System.IO;
using System.Text.Json;

namespace lab_2.Models
{
    public class ClientFileManagerVm
    {
        public string ClientProfileFolderPath { get; set; } = "D:\\Work\\IV семестр\\Об'єктно орієнтоване проектування Лаб №2\\lab 2\\lab 2\\Clients\\"; //3. реалізація поля даних за допомогою властивостей { get; set; }
        public string ClientProfileMainFilePath { get; set; }  //3. реалізація поля даних за допомогою властивостей { get; set; }
        public string ClientProfilePasswordFilePath { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }
        public string ClientPassword { get; set; } //3. реалізація поля даних за допомогою властивостей { get; set; }

        public ClientVm Client;

        public ClientFileManagerVm(string clientName, string clientSurname, string clientPatronymic, string password)
        {
            ClientProfileFolderPath += $"{clientName} {clientSurname} {clientPatronymic}\\";
            ClientProfileMainFilePath = $"{ClientProfileFolderPath}Client.json";
            ClientProfilePasswordFilePath = $"{ClientProfileFolderPath}Password.txt";
            ClientPassword = password;
        }

        public ClientFileManagerVm(ClientVm client)
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

        public ClientVm LoadClient() //11. метод, що читає з файлу поля даних об'єкта класу (весь об'єкт)
        {
            ClientVm client;
            using (FileStream fs = new FileStream(ClientProfileMainFilePath, FileMode.Open, FileAccess.Read))
            {
                client = JsonSerializer.Deserialize<ClientVm>(fs);
                Client = client;
            }
            return client;
        }

        public void SaveClient() //11. метод, що записує в файл поля даних об'єкта класу (весь об'єкт)
        {
            using (FileStream fs = new FileStream(ClientProfileMainFilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                JsonSerializer.Serialize(fs, Client);
            }
        }

        public bool CreateProfile(string password) //11. метод, що записує в файл поля даних об'єкта класу (весь об'єкт)
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


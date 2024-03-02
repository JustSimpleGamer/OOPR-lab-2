using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using lab_2.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace lab_2
{
    public enum RequestStates { Відхилено = -1, Розлядається = 0, Свалено = 1 }
    public enum Tabs { SignUp = 0, SignIn = 1, Administrator = 2, Client = 3, Request = 4 }
    public enum StayTime { Days, Hours, Minutes}
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            Color Dark = Color.FromArgb(33, 33, 33);
            Color LessDark = Color.FromArgb(42, 42, 42);
            Color LightGrey = Color.LightGray;
            Color MoreDark = Color.FromArgb(5, 5, 5);
            Color Orange = Color.Orange;
            Color White = Color.White;
            materialSkinManager.ColorScheme = new ColorScheme(Dark, Dark, MoreDark, Orange, TextShade.WHITE);

            TabControl_MainTabs.SelectTab(0);

            //List<int> a = new List<int>();
            //List<int>.Enumerator b = a.GetEnumerator();
            //int c = b.MoveNext;
        }
        private void TabControl_MainTabs_Selected(object sender, TabControlEventArgs e)
        {
            //Administrator
            if(TabControl_MainTabs.SelectedIndex == (int)Tabs.Administrator)
            {
                Administrator = new AdministratorVm();

                ClientsFoldersPaths = (Directory.GetDirectories("D:\\Work\\IV семестр\\Об'єктно орієнтоване проектування Лаб №2\\lab 2\\lab 2\\Clients\\")).ToList();

                //Clients = new List<ClientVm>();

                //ClientsManagerVm CurrentClientManager = new ClientsManagerVm(AdmnistratorClientsManager[CurrentAdministratorClientIter].Client);

                for (int i = 0; i < ClientsFoldersPaths.Count; i++)
                {
                    using (FileStream fs = new FileStream(ClientsFoldersPaths[i] + "\\Client.json", FileMode.Open, FileAccess.Read))
                    {
                        //Clients.Add(JsonSerializer.Deserialize<ClientVm>(fs));
                        ClientManagerVm temp = new ClientManagerVm(JsonSerializer.Deserialize<ClientVm>(fs));
                        Administrator.ClientsManagers.AddLast(temp);
                    }
                }

                if(Administrator.ClientsManagers.Count == 0)
                {
                    Tab_Administrator_Panel_RequesList.Visible = false;
                    Tab_Administrator_Button_NextRequest.Enabled = false;
                    return;
                }
                Tab_Administrator_Panel_RequesList.Visible = true;
                if (Administrator.ClientsManagers.Count == 1)
                {
                    Tab_Administrator_Button_NextRequest.Enabled = false;
                }
                else
                {
                    Tab_Administrator_Button_NextRequest.Enabled = true;
                }
                AdministratorVm.Nodes = Administrator.ClientsManagers.First;
                AdministratorVm.ShowRequestAtAdministrator(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
            }
            //Client
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Client)
            {
                AuthorizedClientManager.Client = AuthorizedClientFileManager.LoadClient();

                if (AuthorizedClientManager.Client.Request == null)
                {
                    Tab_Client_Panel_RequesForm.Visible = false;
                    return;
                }
                Tab_Client_Panel_RequesForm.Visible = true;

                if (AuthorizedClientManager.Client.Request.State == RequestStates.Розлядається || AuthorizedClientManager.Client.Request.State == RequestStates.Відхилено)
                {
                    Tab_Client_Button_Pay.Enabled = false;
                }
                else
                {
                    Tab_Client_Button_Pay.Enabled = true;
                }
              
                Tab_Client_Label_ClientName.Text = AuthorizedClientManager.Client.Name;
                Tab_Client_Label_ClientSurname.Text = AuthorizedClientManager.Client.Surname;
                Tab_Client_Label_ClientPatronymic.Text = AuthorizedClientManager.Client.Patronymic;
                Tab_Client_Label_ClientPhoneNumber.Text = AuthorizedClientManager.Client.PhoneNumber;
                Tab_Client_Label_SleepingPlacesNumber.Text = AuthorizedClientManager.Client.Request.Apartment.SleepingPlacesNumber;
                Tab_Client_Label_ApartmentСlass.Text = AuthorizedClientManager.Client.Request.Apartment.ApartmentСlass;
                Tab_Client_Label_StayTime.Text = AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Days].ToString() + " Днів " + AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Hours].ToString() + " Годин " + AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Minutes].ToString() + " Хвилин";
                Tab_Client_Label_RequestState.Text = AuthorizedClientManager.Client.Request.State.ToString();
            }
            //Request
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Request)
            {
                RequestStayTimeDays = 0;
                Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
                RequestStayTimeHours = 0;
                Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
                RequestStayTimeMinutes = 0;
                Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();

                Tab_Request_Button_DaysUp.Enabled = true;
                Tab_Request_Button_DaysDown.Enabled = false;
                Tab_Request_Button_HoursUp.Enabled = true;
                Tab_Request_Button_HoursDown.Enabled = false;
                Tab_Request_Button_MinutesUp.Enabled = true;
                Tab_Request_Button_MinutesDown.Enabled = false;
            }
        }
        //Administrator
        public List<string> ClientsFoldersPaths;
        //public List<ClientVm> Clients; //10. An array of class object pointers
        //public List<ClientManagerVm> AdmnistratorClientsManager; //10. An array of class object pointers
        public AdministratorVm Administrator;
        private void Tab_Administrator_Button_NextRequest_Click(object sender, EventArgs e)
        {
            AdministratorVm.Nodes = AdministratorVm.Nodes.Next;
            if (AdministratorVm.Nodes.Next == null)
            {
                Tab_Administrator_Button_NextRequest.Enabled = false;
            }
            else
            {              
                Tab_Administrator_Button_NextRequest.Enabled = true;
            }
            Tab_Administrator_Button_PrevRequest.Enabled = true;

            AdministratorVm.ShowRequestAtAdministrator(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
        }
        private void Tab_Administrator_Button_PrevRequest_Click(object sender, EventArgs e)
        {
            AdministratorVm.Nodes = AdministratorVm.Nodes.Previous;
            if (AdministratorVm.Nodes.Previous == null)
            {
                Tab_Administrator_Button_PrevRequest.Enabled = false;
            }
            else
            {
                Tab_Administrator_Button_PrevRequest.Enabled = true;
            }
            Tab_Administrator_Button_NextRequest.Enabled = true;

            AdministratorVm.ShowRequestAtAdministrator(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
        }
        private void Tab_Administrator_Button_ConfirmRequest_Click(object sender, EventArgs e)
        {
            AdministratorVm.Nodes.Value.Client.Request.State = RequestStates.Свалено;
            Tab_Administrator_Label_RequestState.Text = "Свалено";
            ClientFileManagerVm currentAdminisatrorClientFileManager = new ClientFileManagerVm(AdministratorVm.Nodes.Value.Client);
            currentAdminisatrorClientFileManager.SaveClient();
        }
        private void Tab_Administrator_Button_DeclineRequest_Click(object sender, EventArgs e)
        {
            AdministratorVm.Nodes.Value.Client.Request.State = RequestStates.Відхилено;
            Tab_Administrator_Label_RequestState.Text = "Відхилено";
            ClientFileManagerVm currentAdminisatrorClientFileManager = new ClientFileManagerVm(AdministratorVm.Nodes.Value.Client);
            currentAdminisatrorClientFileManager.SaveClient();
        }
        // Client
        public ClientVm AuthorizedClient;
        public ClientManagerVm AuthorizedClientManager;
        public ClientFileManagerVm AuthorizedClientFileManager;
        private void Tab_Client_Button_Pay_Click(object sender, EventArgs e)
        {
            AuthorizedClientManager.Client.Request = null;
            //AuthorizedClientManager.SaveProfile();
            AuthorizedClientFileManager.SaveClient();
            Tab_Client_Panel_RequesForm.Visible = false;
        }
        private void Tab_Client_Button_MoveToRequest_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.Request);
        }
        private void Tab_Client_Button_MoveToSignIn_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.SignIn);
        }
        //SignIn
        private void Tab_Client_Button_SignIn_Click(object sender, EventArgs e)
        {
            string ClinetName = Tab_SignIn_TextBox_ClientName.Text;
            string ClientSurname = Tab_SignIn_TextBox_ClientSurname.Text;
            string ClientPatronymic = Tab_SignIn_TextBox_ClientPatronymic.Text;
            string ClientPassword = Tab_SignIn_TextBox_ClientPassword.Text;

            if (ClinetName == "" || ClientSurname == "" || ClientPatronymic == "" || ClientPassword == "")
            {
                MessageBox.Show("Будь-ласка, заповність усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            AuthorizedClientFileManager = new ClientFileManagerVm(ClinetName, ClientSurname, ClientPatronymic, ClientPassword);

            if(AuthorizedClientFileManager.IsAllClientAuthorizationDataCorrect() == true)
            {
                AuthorizedClient = AuthorizedClientFileManager.LoadClient();
                AuthorizedClientManager = new ClientManagerVm(ref AuthorizedClient);
                MessageBox.Show("Авторизація пройшла успішно", "Усіпх", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                TabControl_MainTabs.SelectTab((int)Tabs.Client);
                return;
            }

            MessageBox.Show("Ви невірно ввели ініціали або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        //SignUp
        private void Tab_SignUp_Button_SignUp_Click(object sender, EventArgs e)
        {
            string ClinetName = Tab_SignUp_TextBox_ClientName.Text;
            string ClientSurname = Tab_SignUp_TextBox_ClientSurname.Text;
            string ClientPatronymic = Tab_SignUp_TextBox_ClientPatronymic.Text;
            string ClientPhoneNumber = Tab_SignUp_TextBox_ClientPhoneNumber.Text;
            string ClientStatus = Tab_SignUp_ComboBox_ClientStatus.Text;
            string ClientPassword = Tab_SignUp_TextBox_ClientPassword.Text;
            string ClientPasswordСonfirmation = Tab_SignUp_TextBox_ClientPasswordСonfirmation.Text;

            if (ClinetName == "" || ClientSurname == "" || ClientPatronymic == "" || ClientPhoneNumber == "" || ClientStatus == "" || ClientPassword == "" || ClientPasswordСonfirmation == "")
            {
                MessageBox.Show("Будь-ласка, заповність усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (ClientPassword != ClientPasswordСonfirmation)
            {
                MessageBox.Show("Будь-ласка, введені пароль і підтвердження паролю повинні бути одаковими", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            ClientVm newClient = new ClientVm(ClinetName, ClientSurname, ClientPatronymic, ClientPhoneNumber, ClientStatus);
            ClientFileManagerVm newClientFileManagerVm = new ClientFileManagerVm(newClient);
            if (newClientFileManagerVm.CreateProfile(ClientPassword) == false)
            {
                MessageBox.Show("Клієнт з даними ініціалами вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            MessageBox.Show("Профіль було успішно створено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void Tab_SignUp_TextBox_ClientPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tab_SignUp_TextBox_ClientPhoneNumber.TextLength; i++)
            {
                if (Tab_SignUp_TextBox_ClientPhoneNumber.Text[i] < '0' || Tab_SignUp_TextBox_ClientPhoneNumber.Text[i] > '9')
                {
                    Tab_SignUp_TextBox_ClientPhoneNumber.Text = Tab_SignUp_TextBox_ClientPhoneNumber.Text.Remove(i, 1);
                    return;
                }
            }
        }
        //Request
        public int RequestStayTimeDays = 0;
        public int RequestStayTimeHours = 0;
        public int RequestStayTimeMinutes = 0;
        private void Tab_Request_Buttonn_SendRequest_Click(object sender, EventArgs e)
        {
            if(RequestStayTimeDays == 0 && RequestStayTimeHours == 0 && RequestStayTimeMinutes == 0)
            {
                MessageBox.Show("Будь-ласка, загальний час перебування у номері не повинен дорівнювати нулю", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            AuthorizedClientManager.Client.Request = new RequestVm();

            AuthorizedClientManager.Client.Request.Apartment.SleepingPlacesNumber = Tab_Request_ComboBox_SleepingPlacesNumber.Text;
            AuthorizedClientManager.Client.Request.Apartment.ApartmentСlass = Tab_Request_ComboBox_ApartmentСlass.Text;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Days] = RequestStayTimeDays;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Hours] = RequestStayTimeHours;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Minutes] = RequestStayTimeMinutes;

            AuthorizedClientFileManager.SaveClient();

            MessageBox.Show("Заявка була успішно подана на розглядання", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            TabControl_MainTabs.SelectTab((int)Tabs.Client);
        }
        private void Tab_Request_Button_MoveToClient_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.Client);
        }
        private void Tab_Request_Button_DaysUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays >= 364)
            {
                Tab_Request_Button_DaysUp.Enabled = false;
            }
            Tab_Request_Button_DaysDown.Enabled = true;
            RequestStayTimeDays++;
            Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
        }
        private void Tab_Request_Button_DaysDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays <= 1)
            {
                Tab_Request_Button_DaysDown.Enabled = false;
            }
            Tab_Request_Button_DaysUp.Enabled = true;
            RequestStayTimeDays--;
            Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
        }
        private void Tab_Request_Button_HoursUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeHours >= 23)
            {
                Tab_Request_Button_HoursUp.Enabled = false;
            }
            Tab_Request_Button_HoursDown.Enabled = true;
            RequestStayTimeHours++;
            Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
        }
        private void Tab_Request_Button_HoursDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeHours <= 1)
            {
                Tab_Request_Button_HoursDown.Enabled = false;
            }
            Tab_Request_Button_HoursUp.Enabled = true;
            RequestStayTimeHours--;
            Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
        }
        private void Tab_Request_Button_MinutesUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeMinutes >= 59)
            {
                Tab_Request_Button_MinutesUp.Enabled = false;
            }
            Tab_Request_Button_MinutesDown.Enabled = true;
            RequestStayTimeMinutes ++;
            Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();
        }
        private void Tab_Request_Button_MinutesDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeMinutes <= 1)
            {
                Tab_Request_Button_MinutesDown.Enabled = false;
            }
            Tab_Request_Button_MinutesUp.Enabled = true;
            RequestStayTimeMinutes--;
            Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();
        }
        //Other
        private void Tab_SignUp_TextBox_ClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientSurname.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPatronymic.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPhoneNumber.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_ComboBox_ClientStatus.Focus();
            }
        }
        private void Tab_SignUp_ComboBox_ClientStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPassword.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPasswordСonfirmation.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPasswordСonfirmation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                object sen = new object();
                Tab_SignUp_Button_SignUp_Click(sen, e);
            }
        }
    }
}

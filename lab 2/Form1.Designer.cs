namespace lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl_MainTabs = new System.Windows.Forms.TabControl();
            this.Tab_Authorization = new System.Windows.Forms.TabPage();
            this.Tab_SignIn_TextBox_ClientPatronymic = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignIn_TextBox_ClientPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignIn_TextBox_ClientSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignIn_TextBox_ClientName = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_Client_Button_SignIn = new MaterialSkin.Controls.MaterialButton();
            this.Tab_SignUp = new System.Windows.Forms.TabPage();
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignUp_TextBox_ClientPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignUp_ComboBox_ClientStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.Tab_SignUp_TextBox_ClientPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignUp_TextBox_ClientPatronymic = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignUp_TextBox_ClientSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignUp_TextBox_ClientName = new MaterialSkin.Controls.MaterialTextBox();
            this.Tab_SignUp_Button_SignUp = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Aministrator = new System.Windows.Forms.TabPage();
            this.Tab_Administrator_Panel_RequesList = new System.Windows.Forms.Panel();
            this.Tab_Administrator_Label_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_Button_PrevRequest = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Administrator_Button_NextRequest = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Administrator_Button_DeclineRequest = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Administrator_Button_ConfirmRequest = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Administrator_Label_RequestState = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_Label_StayTime = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_Label_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_Label_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_Label_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_Label_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_Label_ClientName = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_RequestState = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_StayTime = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Administrator_LabelText_ClientName = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab_Client = new System.Windows.Forms.TabPage();
            this.Tab_Client_Button_MoveToSignIn = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Client_Button_MoveToRequest = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Client_Panel_RequesForm = new System.Windows.Forms.Panel();
            this.Tab_Client_Label_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_Button_Pay = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Client_Label_RequestState = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_Label_StayTime = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_Label_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_Label_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_Label_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_Label_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_Label_ClientName = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_RequestState = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_StayTime = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Client_LabelText_ClientName = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Tab_Request = new System.Windows.Forms.TabPage();
            this.Tab_Request_Button_MoveToClient = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Request_LabelText_StayTime = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Request_LabelText_Minutes = new System.Windows.Forms.Label();
            this.Tab_Request_LabelText_Hours = new System.Windows.Forms.Label();
            this.Tab_Request_LabelText_Days = new System.Windows.Forms.Label();
            this.Tab_Request_Label_MinutesCount = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Request_Label_HoursCount = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Request_Label_DaysCount = new MaterialSkin.Controls.MaterialLabel();
            this.Tab_Request_ComboBox_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialComboBox();
            this.Tab_Request_ComboBox_ApartmentСlass = new MaterialSkin.Controls.MaterialComboBox();
            this.Tab_Request_Button_MinutesUp = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Request_Button_MinutesDown = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Request_Button_HoursUp = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Request_Button_HoursDown = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Request_Button_DaysDown = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Request_Button_DaysUp = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Request_Buttonn_SendRequest = new MaterialSkin.Controls.MaterialButton();
            this.TabControl_MainTabs.SuspendLayout();
            this.Tab_Authorization.SuspendLayout();
            this.Tab_SignUp.SuspendLayout();
            this.Tab_Aministrator.SuspendLayout();
            this.Tab_Administrator_Panel_RequesList.SuspendLayout();
            this.Tab_Client.SuspendLayout();
            this.Tab_Client_Panel_RequesForm.SuspendLayout();
            this.Tab_Request.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_MainTabs
            // 
            this.TabControl_MainTabs.Controls.Add(this.Tab_Authorization);
            this.TabControl_MainTabs.Controls.Add(this.Tab_SignUp);
            this.TabControl_MainTabs.Controls.Add(this.Tab_Aministrator);
            this.TabControl_MainTabs.Controls.Add(this.Tab_Client);
            this.TabControl_MainTabs.Controls.Add(this.Tab_Request);
            this.TabControl_MainTabs.Location = new System.Drawing.Point(-4, 66);
            this.TabControl_MainTabs.Name = "TabControl_MainTabs";
            this.TabControl_MainTabs.SelectedIndex = 0;
            this.TabControl_MainTabs.Size = new System.Drawing.Size(808, 388);
            this.TabControl_MainTabs.TabIndex = 0;
            this.TabControl_MainTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_MainTabs_Selected);
            // 
            // Tab_Authorization
            // 
            this.Tab_Authorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Authorization.Controls.Add(this.Tab_SignIn_TextBox_ClientPatronymic);
            this.Tab_Authorization.Controls.Add(this.Tab_SignIn_TextBox_ClientPassword);
            this.Tab_Authorization.Controls.Add(this.Tab_SignIn_TextBox_ClientSurname);
            this.Tab_Authorization.Controls.Add(this.Tab_SignIn_TextBox_ClientName);
            this.Tab_Authorization.Controls.Add(this.Tab_Client_Button_SignIn);
            this.Tab_Authorization.Location = new System.Drawing.Point(4, 22);
            this.Tab_Authorization.Name = "Tab_Authorization";
            this.Tab_Authorization.Size = new System.Drawing.Size(800, 362);
            this.Tab_Authorization.TabIndex = 4;
            this.Tab_Authorization.Text = "Авторизація";
            // 
            // Tab_SignIn_TextBox_ClientPatronymic
            // 
            this.Tab_SignIn_TextBox_ClientPatronymic.AnimateReadOnly = false;
            this.Tab_SignIn_TextBox_ClientPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignIn_TextBox_ClientPatronymic.Depth = 0;
            this.Tab_SignIn_TextBox_ClientPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignIn_TextBox_ClientPatronymic.Hint = "По батькові";
            this.Tab_SignIn_TextBox_ClientPatronymic.LeadingIcon = null;
            this.Tab_SignIn_TextBox_ClientPatronymic.Location = new System.Drawing.Point(403, 80);
            this.Tab_SignIn_TextBox_ClientPatronymic.MaxLength = 50;
            this.Tab_SignIn_TextBox_ClientPatronymic.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignIn_TextBox_ClientPatronymic.Multiline = false;
            this.Tab_SignIn_TextBox_ClientPatronymic.Name = "Tab_SignIn_TextBox_ClientPatronymic";
            this.Tab_SignIn_TextBox_ClientPatronymic.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignIn_TextBox_ClientPatronymic.TabIndex = 16;
            this.Tab_SignIn_TextBox_ClientPatronymic.Text = "Олексійович";
            this.Tab_SignIn_TextBox_ClientPatronymic.TrailingIcon = null;
            // 
            // Tab_SignIn_TextBox_ClientPassword
            // 
            this.Tab_SignIn_TextBox_ClientPassword.AnimateReadOnly = false;
            this.Tab_SignIn_TextBox_ClientPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignIn_TextBox_ClientPassword.Depth = 0;
            this.Tab_SignIn_TextBox_ClientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignIn_TextBox_ClientPassword.Hint = "Пароль";
            this.Tab_SignIn_TextBox_ClientPassword.LeadingIcon = null;
            this.Tab_SignIn_TextBox_ClientPassword.Location = new System.Drawing.Point(403, 135);
            this.Tab_SignIn_TextBox_ClientPassword.MaxLength = 50;
            this.Tab_SignIn_TextBox_ClientPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignIn_TextBox_ClientPassword.Multiline = false;
            this.Tab_SignIn_TextBox_ClientPassword.Name = "Tab_SignIn_TextBox_ClientPassword";
            this.Tab_SignIn_TextBox_ClientPassword.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignIn_TextBox_ClientPassword.TabIndex = 15;
            this.Tab_SignIn_TextBox_ClientPassword.Text = "Password";
            this.Tab_SignIn_TextBox_ClientPassword.TrailingIcon = null;
            // 
            // Tab_SignIn_TextBox_ClientSurname
            // 
            this.Tab_SignIn_TextBox_ClientSurname.AnimateReadOnly = false;
            this.Tab_SignIn_TextBox_ClientSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignIn_TextBox_ClientSurname.Depth = 0;
            this.Tab_SignIn_TextBox_ClientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignIn_TextBox_ClientSurname.Hint = "Прізвище";
            this.Tab_SignIn_TextBox_ClientSurname.LeadingIcon = null;
            this.Tab_SignIn_TextBox_ClientSurname.Location = new System.Drawing.Point(197, 135);
            this.Tab_SignIn_TextBox_ClientSurname.MaxLength = 50;
            this.Tab_SignIn_TextBox_ClientSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignIn_TextBox_ClientSurname.Multiline = false;
            this.Tab_SignIn_TextBox_ClientSurname.Name = "Tab_SignIn_TextBox_ClientSurname";
            this.Tab_SignIn_TextBox_ClientSurname.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignIn_TextBox_ClientSurname.TabIndex = 14;
            this.Tab_SignIn_TextBox_ClientSurname.Text = "Шуневич";
            this.Tab_SignIn_TextBox_ClientSurname.TrailingIcon = null;
            // 
            // Tab_SignIn_TextBox_ClientName
            // 
            this.Tab_SignIn_TextBox_ClientName.AnimateReadOnly = false;
            this.Tab_SignIn_TextBox_ClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignIn_TextBox_ClientName.Depth = 0;
            this.Tab_SignIn_TextBox_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignIn_TextBox_ClientName.Hint = "Ім\'я";
            this.Tab_SignIn_TextBox_ClientName.LeadingIcon = null;
            this.Tab_SignIn_TextBox_ClientName.Location = new System.Drawing.Point(197, 80);
            this.Tab_SignIn_TextBox_ClientName.MaxLength = 50;
            this.Tab_SignIn_TextBox_ClientName.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignIn_TextBox_ClientName.Multiline = false;
            this.Tab_SignIn_TextBox_ClientName.Name = "Tab_SignIn_TextBox_ClientName";
            this.Tab_SignIn_TextBox_ClientName.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignIn_TextBox_ClientName.TabIndex = 13;
            this.Tab_SignIn_TextBox_ClientName.Text = "Максим";
            this.Tab_SignIn_TextBox_ClientName.TrailingIcon = null;
            // 
            // Tab_Client_Button_SignIn
            // 
            this.Tab_Client_Button_SignIn.AutoSize = false;
            this.Tab_Client_Button_SignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Client_Button_SignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Client_Button_SignIn.Depth = 0;
            this.Tab_Client_Button_SignIn.HighEmphasis = true;
            this.Tab_Client_Button_SignIn.Icon = global::lab_2.Properties.Resources.free_icon_login_11600247;
            this.Tab_Client_Button_SignIn.Location = new System.Drawing.Point(307, 247);
            this.Tab_Client_Button_SignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Client_Button_SignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Button_SignIn.Name = "Tab_Client_Button_SignIn";
            this.Tab_Client_Button_SignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Client_Button_SignIn.Size = new System.Drawing.Size(180, 36);
            this.Tab_Client_Button_SignIn.TabIndex = 12;
            this.Tab_Client_Button_SignIn.Text = "Атворизуватися";
            this.Tab_Client_Button_SignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Client_Button_SignIn.UseAccentColor = false;
            this.Tab_Client_Button_SignIn.UseVisualStyleBackColor = true;
            this.Tab_Client_Button_SignIn.Click += new System.EventHandler(this.Tab_Client_Button_SignIn_Click);
            // 
            // Tab_SignUp
            // 
            this.Tab_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_TextBox_ClientPasswordСonfirmation);
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_TextBox_ClientPassword);
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_ComboBox_ClientStatus);
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_TextBox_ClientPhoneNumber);
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_TextBox_ClientPatronymic);
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_TextBox_ClientSurname);
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_TextBox_ClientName);
            this.Tab_SignUp.Controls.Add(this.Tab_SignUp_Button_SignUp);
            this.Tab_SignUp.Location = new System.Drawing.Point(4, 22);
            this.Tab_SignUp.Name = "Tab_SignUp";
            this.Tab_SignUp.Size = new System.Drawing.Size(800, 362);
            this.Tab_SignUp.TabIndex = 3;
            this.Tab_SignUp.Text = "Регістрація";
            // 
            // Tab_SignUp_TextBox_ClientPasswordСonfirmation
            // 
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.AnimateReadOnly = false;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Depth = 0;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Hint = "Підтвердження паролю";
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.LeadingIcon = null;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Location = new System.Drawing.Point(295, 222);
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.MaxLength = 50;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Multiline = false;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Name = "Tab_SignUp_TextBox_ClientPasswordСonfirmation";
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Size = new System.Drawing.Size(210, 50);
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.TabIndex = 14;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.Text = "Password";
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.TrailingIcon = null;
            this.Tab_SignUp_TextBox_ClientPasswordСonfirmation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_SignUp_TextBox_ClientPasswordСonfirmation_KeyPress);
            // 
            // Tab_SignUp_TextBox_ClientPassword
            // 
            this.Tab_SignUp_TextBox_ClientPassword.AnimateReadOnly = false;
            this.Tab_SignUp_TextBox_ClientPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignUp_TextBox_ClientPassword.Depth = 0;
            this.Tab_SignUp_TextBox_ClientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignUp_TextBox_ClientPassword.Hint = "Пароль";
            this.Tab_SignUp_TextBox_ClientPassword.LeadingIcon = null;
            this.Tab_SignUp_TextBox_ClientPassword.Location = new System.Drawing.Point(406, 165);
            this.Tab_SignUp_TextBox_ClientPassword.MaxLength = 50;
            this.Tab_SignUp_TextBox_ClientPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignUp_TextBox_ClientPassword.Multiline = false;
            this.Tab_SignUp_TextBox_ClientPassword.Name = "Tab_SignUp_TextBox_ClientPassword";
            this.Tab_SignUp_TextBox_ClientPassword.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignUp_TextBox_ClientPassword.TabIndex = 13;
            this.Tab_SignUp_TextBox_ClientPassword.Text = "Password";
            this.Tab_SignUp_TextBox_ClientPassword.TrailingIcon = null;
            this.Tab_SignUp_TextBox_ClientPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_SignUp_TextBox_ClientPassword_KeyPress);
            // 
            // Tab_SignUp_ComboBox_ClientStatus
            // 
            this.Tab_SignUp_ComboBox_ClientStatus.AutoResize = false;
            this.Tab_SignUp_ComboBox_ClientStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_SignUp_ComboBox_ClientStatus.Depth = 0;
            this.Tab_SignUp_ComboBox_ClientStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Tab_SignUp_ComboBox_ClientStatus.DropDownHeight = 174;
            this.Tab_SignUp_ComboBox_ClientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tab_SignUp_ComboBox_ClientStatus.DropDownWidth = 121;
            this.Tab_SignUp_ComboBox_ClientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_SignUp_ComboBox_ClientStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Tab_SignUp_ComboBox_ClientStatus.FormattingEnabled = true;
            this.Tab_SignUp_ComboBox_ClientStatus.Hint = "Статус";
            this.Tab_SignUp_ComboBox_ClientStatus.IntegralHeight = false;
            this.Tab_SignUp_ComboBox_ClientStatus.ItemHeight = 43;
            this.Tab_SignUp_ComboBox_ClientStatus.Items.AddRange(new object[] {
            "Гість",
            "Постійний клієнт",
            "VIP"});
            this.Tab_SignUp_ComboBox_ClientStatus.Location = new System.Drawing.Point(406, 110);
            this.Tab_SignUp_ComboBox_ClientStatus.MaxDropDownItems = 4;
            this.Tab_SignUp_ComboBox_ClientStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignUp_ComboBox_ClientStatus.Name = "Tab_SignUp_ComboBox_ClientStatus";
            this.Tab_SignUp_ComboBox_ClientStatus.Size = new System.Drawing.Size(200, 49);
            this.Tab_SignUp_ComboBox_ClientStatus.StartIndex = 0;
            this.Tab_SignUp_ComboBox_ClientStatus.TabIndex = 12;
            this.Tab_SignUp_ComboBox_ClientStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_SignUp_ComboBox_ClientStatus_KeyPress);
            // 
            // Tab_SignUp_TextBox_ClientPhoneNumber
            // 
            this.Tab_SignUp_TextBox_ClientPhoneNumber.AnimateReadOnly = false;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Depth = 0;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Hint = "Номер телефону";
            this.Tab_SignUp_TextBox_ClientPhoneNumber.LeadingIcon = null;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Location = new System.Drawing.Point(406, 54);
            this.Tab_SignUp_TextBox_ClientPhoneNumber.MaxLength = 50;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Multiline = false;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Name = "Tab_SignUp_TextBox_ClientPhoneNumber";
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignUp_TextBox_ClientPhoneNumber.TabIndex = 11;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.Text = "0673802728";
            this.Tab_SignUp_TextBox_ClientPhoneNumber.TrailingIcon = null;
            this.Tab_SignUp_TextBox_ClientPhoneNumber.TextChanged += new System.EventHandler(this.Tab_SignUp_TextBox_ClientPhoneNumber_TextChanged);
            this.Tab_SignUp_TextBox_ClientPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_SignUp_TextBox_ClientPhoneNumber_KeyPress);
            // 
            // Tab_SignUp_TextBox_ClientPatronymic
            // 
            this.Tab_SignUp_TextBox_ClientPatronymic.AnimateReadOnly = false;
            this.Tab_SignUp_TextBox_ClientPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignUp_TextBox_ClientPatronymic.Depth = 0;
            this.Tab_SignUp_TextBox_ClientPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignUp_TextBox_ClientPatronymic.Hint = "По батькові";
            this.Tab_SignUp_TextBox_ClientPatronymic.LeadingIcon = null;
            this.Tab_SignUp_TextBox_ClientPatronymic.Location = new System.Drawing.Point(200, 165);
            this.Tab_SignUp_TextBox_ClientPatronymic.MaxLength = 50;
            this.Tab_SignUp_TextBox_ClientPatronymic.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignUp_TextBox_ClientPatronymic.Multiline = false;
            this.Tab_SignUp_TextBox_ClientPatronymic.Name = "Tab_SignUp_TextBox_ClientPatronymic";
            this.Tab_SignUp_TextBox_ClientPatronymic.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignUp_TextBox_ClientPatronymic.TabIndex = 10;
            this.Tab_SignUp_TextBox_ClientPatronymic.Text = "Олексійович";
            this.Tab_SignUp_TextBox_ClientPatronymic.TrailingIcon = null;
            this.Tab_SignUp_TextBox_ClientPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_SignUp_TextBox_ClientPatronymic_KeyPress);
            // 
            // Tab_SignUp_TextBox_ClientSurname
            // 
            this.Tab_SignUp_TextBox_ClientSurname.AnimateReadOnly = false;
            this.Tab_SignUp_TextBox_ClientSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignUp_TextBox_ClientSurname.Depth = 0;
            this.Tab_SignUp_TextBox_ClientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignUp_TextBox_ClientSurname.Hint = "Прізвище";
            this.Tab_SignUp_TextBox_ClientSurname.LeadingIcon = null;
            this.Tab_SignUp_TextBox_ClientSurname.Location = new System.Drawing.Point(200, 110);
            this.Tab_SignUp_TextBox_ClientSurname.MaxLength = 50;
            this.Tab_SignUp_TextBox_ClientSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignUp_TextBox_ClientSurname.Multiline = false;
            this.Tab_SignUp_TextBox_ClientSurname.Name = "Tab_SignUp_TextBox_ClientSurname";
            this.Tab_SignUp_TextBox_ClientSurname.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignUp_TextBox_ClientSurname.TabIndex = 9;
            this.Tab_SignUp_TextBox_ClientSurname.Text = "Шуневич";
            this.Tab_SignUp_TextBox_ClientSurname.TrailingIcon = null;
            this.Tab_SignUp_TextBox_ClientSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_SignUp_TextBox_ClientSurname_KeyPress);
            // 
            // Tab_SignUp_TextBox_ClientName
            // 
            this.Tab_SignUp_TextBox_ClientName.AnimateReadOnly = false;
            this.Tab_SignUp_TextBox_ClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab_SignUp_TextBox_ClientName.Depth = 0;
            this.Tab_SignUp_TextBox_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tab_SignUp_TextBox_ClientName.Hint = "Ім\'я";
            this.Tab_SignUp_TextBox_ClientName.LeadingIcon = null;
            this.Tab_SignUp_TextBox_ClientName.Location = new System.Drawing.Point(200, 54);
            this.Tab_SignUp_TextBox_ClientName.MaxLength = 50;
            this.Tab_SignUp_TextBox_ClientName.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_SignUp_TextBox_ClientName.Multiline = false;
            this.Tab_SignUp_TextBox_ClientName.Name = "Tab_SignUp_TextBox_ClientName";
            this.Tab_SignUp_TextBox_ClientName.Size = new System.Drawing.Size(200, 50);
            this.Tab_SignUp_TextBox_ClientName.TabIndex = 8;
            this.Tab_SignUp_TextBox_ClientName.Text = "Максим";
            this.Tab_SignUp_TextBox_ClientName.TrailingIcon = null;
            this.Tab_SignUp_TextBox_ClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_SignUp_TextBox_ClientName_KeyPress);
            // 
            // Tab_SignUp_Button_SignUp
            // 
            this.Tab_SignUp_Button_SignUp.AutoSize = false;
            this.Tab_SignUp_Button_SignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_SignUp_Button_SignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_SignUp_Button_SignUp.Depth = 0;
            this.Tab_SignUp_Button_SignUp.HighEmphasis = true;
            this.Tab_SignUp_Button_SignUp.Icon = global::lab_2.Properties.Resources.free_icon_add_user_1621563;
            this.Tab_SignUp_Button_SignUp.Location = new System.Drawing.Point(310, 277);
            this.Tab_SignUp_Button_SignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_SignUp_Button_SignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_SignUp_Button_SignUp.Name = "Tab_SignUp_Button_SignUp";
            this.Tab_SignUp_Button_SignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_SignUp_Button_SignUp.Size = new System.Drawing.Size(180, 36);
            this.Tab_SignUp_Button_SignUp.TabIndex = 7;
            this.Tab_SignUp_Button_SignUp.Text = "Зареєструватися";
            this.Tab_SignUp_Button_SignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_SignUp_Button_SignUp.UseAccentColor = false;
            this.Tab_SignUp_Button_SignUp.UseVisualStyleBackColor = true;
            this.Tab_SignUp_Button_SignUp.Click += new System.EventHandler(this.Tab_SignUp_Button_SignUp_Click);
            // 
            // Tab_Aministrator
            // 
            this.Tab_Aministrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Aministrator.Controls.Add(this.Tab_Administrator_Panel_RequesList);
            this.Tab_Aministrator.Controls.Add(this.label1);
            this.Tab_Aministrator.Location = new System.Drawing.Point(4, 22);
            this.Tab_Aministrator.Name = "Tab_Aministrator";
            this.Tab_Aministrator.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Aministrator.Size = new System.Drawing.Size(800, 362);
            this.Tab_Aministrator.TabIndex = 0;
            this.Tab_Aministrator.Text = "Адміністратор";
            // 
            // Tab_Administrator_Panel_RequesList
            // 
            this.Tab_Administrator_Panel_RequesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_ClientPhoneNumber);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_ClientPhoneNumber);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Button_PrevRequest);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Button_NextRequest);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Button_DeclineRequest);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Button_ConfirmRequest);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_RequestState);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_StayTime);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_ApartmentСlass);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_SleepingPlacesNumber);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_ClientPatronymic);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_ClientSurname);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_Label_ClientName);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_RequestState);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_StayTime);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_ApartmentСlass);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_SleepingPlacesNumber);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_ClientPatronymic);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_ClientSurname);
            this.Tab_Administrator_Panel_RequesList.Controls.Add(this.Tab_Administrator_LabelText_ClientName);
            this.Tab_Administrator_Panel_RequesList.Location = new System.Drawing.Point(146, 70);
            this.Tab_Administrator_Panel_RequesList.Name = "Tab_Administrator_Panel_RequesList";
            this.Tab_Administrator_Panel_RequesList.Size = new System.Drawing.Size(508, 254);
            this.Tab_Administrator_Panel_RequesList.TabIndex = 0;
            this.Tab_Administrator_Panel_RequesList.Visible = false;
            // 
            // Tab_Administrator_Label_ClientPhoneNumber
            // 
            this.Tab_Administrator_Label_ClientPhoneNumber.Depth = 0;
            this.Tab_Administrator_Label_ClientPhoneNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_ClientPhoneNumber.Location = new System.Drawing.Point(255, 69);
            this.Tab_Administrator_Label_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_ClientPhoneNumber.Name = "Tab_Administrator_Label_ClientPhoneNumber";
            this.Tab_Administrator_Label_ClientPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_Label_ClientPhoneNumber.TabIndex = 16;
            this.Tab_Administrator_Label_ClientPhoneNumber.Text = "PhoneNumber";
            this.Tab_Administrator_Label_ClientPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_ClientPhoneNumber
            // 
            this.Tab_Administrator_LabelText_ClientPhoneNumber.Depth = 0;
            this.Tab_Administrator_LabelText_ClientPhoneNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_ClientPhoneNumber.Location = new System.Drawing.Point(49, 69);
            this.Tab_Administrator_LabelText_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_ClientPhoneNumber.Name = "Tab_Administrator_LabelText_ClientPhoneNumber";
            this.Tab_Administrator_LabelText_ClientPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_LabelText_ClientPhoneNumber.TabIndex = 15;
            this.Tab_Administrator_LabelText_ClientPhoneNumber.Text = "Номер телефону";
            this.Tab_Administrator_LabelText_ClientPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Button_PrevRequest
            // 
            this.Tab_Administrator_Button_PrevRequest.AutoSize = false;
            this.Tab_Administrator_Button_PrevRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Administrator_Button_PrevRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Administrator_Button_PrevRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Administrator_Button_PrevRequest.Depth = 0;
            this.Tab_Administrator_Button_PrevRequest.Enabled = false;
            this.Tab_Administrator_Button_PrevRequest.HighEmphasis = true;
            this.Tab_Administrator_Button_PrevRequest.Icon = global::lab_2.Properties.Resources.free_icon_back_4315468;
            this.Tab_Administrator_Button_PrevRequest.Location = new System.Drawing.Point(-1, 105);
            this.Tab_Administrator_Button_PrevRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Administrator_Button_PrevRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Button_PrevRequest.Name = "Tab_Administrator_Button_PrevRequest";
            this.Tab_Administrator_Button_PrevRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Administrator_Button_PrevRequest.Size = new System.Drawing.Size(40, 38);
            this.Tab_Administrator_Button_PrevRequest.TabIndex = 14;
            this.Tab_Administrator_Button_PrevRequest.Text = "1";
            this.Tab_Administrator_Button_PrevRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Administrator_Button_PrevRequest.UseAccentColor = false;
            this.Tab_Administrator_Button_PrevRequest.UseVisualStyleBackColor = false;
            this.Tab_Administrator_Button_PrevRequest.Click += new System.EventHandler(this.Tab_Administrator_Button_PrevRequest_Click);
            // 
            // Tab_Administrator_Button_NextRequest
            // 
            this.Tab_Administrator_Button_NextRequest.AutoSize = false;
            this.Tab_Administrator_Button_NextRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Administrator_Button_NextRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Administrator_Button_NextRequest.Depth = 0;
            this.Tab_Administrator_Button_NextRequest.HighEmphasis = true;
            this.Tab_Administrator_Button_NextRequest.Icon = global::lab_2.Properties.Resources.free_icon_next_4315612;
            this.Tab_Administrator_Button_NextRequest.Location = new System.Drawing.Point(467, 105);
            this.Tab_Administrator_Button_NextRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Administrator_Button_NextRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Button_NextRequest.Name = "Tab_Administrator_Button_NextRequest";
            this.Tab_Administrator_Button_NextRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Administrator_Button_NextRequest.Size = new System.Drawing.Size(40, 38);
            this.Tab_Administrator_Button_NextRequest.TabIndex = 14;
            this.Tab_Administrator_Button_NextRequest.Text = "1";
            this.Tab_Administrator_Button_NextRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Administrator_Button_NextRequest.UseAccentColor = false;
            this.Tab_Administrator_Button_NextRequest.UseVisualStyleBackColor = true;
            this.Tab_Administrator_Button_NextRequest.Click += new System.EventHandler(this.Tab_Administrator_Button_NextRequest_Click);
            // 
            // Tab_Administrator_Button_DeclineRequest
            // 
            this.Tab_Administrator_Button_DeclineRequest.AutoSize = false;
            this.Tab_Administrator_Button_DeclineRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Administrator_Button_DeclineRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Administrator_Button_DeclineRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Administrator_Button_DeclineRequest.Depth = 0;
            this.Tab_Administrator_Button_DeclineRequest.HighEmphasis = true;
            this.Tab_Administrator_Button_DeclineRequest.Icon = global::lab_2.Properties.Resources.free_icon_cancel_126497;
            this.Tab_Administrator_Button_DeclineRequest.Location = new System.Drawing.Point(210, 207);
            this.Tab_Administrator_Button_DeclineRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Administrator_Button_DeclineRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Button_DeclineRequest.Name = "Tab_Administrator_Button_DeclineRequest";
            this.Tab_Administrator_Button_DeclineRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Administrator_Button_DeclineRequest.Size = new System.Drawing.Size(40, 38);
            this.Tab_Administrator_Button_DeclineRequest.TabIndex = 13;
            this.Tab_Administrator_Button_DeclineRequest.Text = "1";
            this.Tab_Administrator_Button_DeclineRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Administrator_Button_DeclineRequest.UseAccentColor = false;
            this.Tab_Administrator_Button_DeclineRequest.UseVisualStyleBackColor = false;
            this.Tab_Administrator_Button_DeclineRequest.Click += new System.EventHandler(this.Tab_Administrator_Button_DeclineRequest_Click);
            // 
            // Tab_Administrator_Button_ConfirmRequest
            // 
            this.Tab_Administrator_Button_ConfirmRequest.AutoSize = false;
            this.Tab_Administrator_Button_ConfirmRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Administrator_Button_ConfirmRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Administrator_Button_ConfirmRequest.Depth = 0;
            this.Tab_Administrator_Button_ConfirmRequest.HighEmphasis = true;
            this.Tab_Administrator_Button_ConfirmRequest.Icon = global::lab_2.Properties.Resources.free_icon_confirm_467129;
            this.Tab_Administrator_Button_ConfirmRequest.Location = new System.Drawing.Point(259, 207);
            this.Tab_Administrator_Button_ConfirmRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Administrator_Button_ConfirmRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Button_ConfirmRequest.Name = "Tab_Administrator_Button_ConfirmRequest";
            this.Tab_Administrator_Button_ConfirmRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Administrator_Button_ConfirmRequest.Size = new System.Drawing.Size(40, 38);
            this.Tab_Administrator_Button_ConfirmRequest.TabIndex = 1;
            this.Tab_Administrator_Button_ConfirmRequest.Text = "1";
            this.Tab_Administrator_Button_ConfirmRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Administrator_Button_ConfirmRequest.UseAccentColor = false;
            this.Tab_Administrator_Button_ConfirmRequest.UseVisualStyleBackColor = true;
            this.Tab_Administrator_Button_ConfirmRequest.Click += new System.EventHandler(this.Tab_Administrator_Button_ConfirmRequest_Click);
            // 
            // Tab_Administrator_Label_RequestState
            // 
            this.Tab_Administrator_Label_RequestState.Depth = 0;
            this.Tab_Administrator_Label_RequestState.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_RequestState.Location = new System.Drawing.Point(256, 184);
            this.Tab_Administrator_Label_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_RequestState.Name = "Tab_Administrator_Label_RequestState";
            this.Tab_Administrator_Label_RequestState.Size = new System.Drawing.Size(200, 19);
            this.Tab_Administrator_Label_RequestState.TabIndex = 12;
            this.Tab_Administrator_Label_RequestState.Text = "State";
            this.Tab_Administrator_Label_RequestState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_StayTime
            // 
            this.Tab_Administrator_Label_StayTime.Depth = 0;
            this.Tab_Administrator_Label_StayTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_StayTime.Location = new System.Drawing.Point(256, 161);
            this.Tab_Administrator_Label_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_StayTime.Name = "Tab_Administrator_Label_StayTime";
            this.Tab_Administrator_Label_StayTime.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_Label_StayTime.TabIndex = 11;
            this.Tab_Administrator_Label_StayTime.Text = "Time in D.H.M.";
            this.Tab_Administrator_Label_StayTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ApartmentСlass
            // 
            this.Tab_Administrator_Label_ApartmentСlass.Depth = 0;
            this.Tab_Administrator_Label_ApartmentСlass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_ApartmentСlass.Location = new System.Drawing.Point(256, 138);
            this.Tab_Administrator_Label_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_ApartmentСlass.Name = "Tab_Administrator_Label_ApartmentСlass";
            this.Tab_Administrator_Label_ApartmentСlass.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_Label_ApartmentСlass.TabIndex = 10;
            this.Tab_Administrator_Label_ApartmentСlass.Text = "Count";
            this.Tab_Administrator_Label_ApartmentСlass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_SleepingPlacesNumber
            // 
            this.Tab_Administrator_Label_SleepingPlacesNumber.Depth = 0;
            this.Tab_Administrator_Label_SleepingPlacesNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_SleepingPlacesNumber.Location = new System.Drawing.Point(256, 92);
            this.Tab_Administrator_Label_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_SleepingPlacesNumber.Name = "Tab_Administrator_Label_SleepingPlacesNumber";
            this.Tab_Administrator_Label_SleepingPlacesNumber.Size = new System.Drawing.Size(200, 46);
            this.Tab_Administrator_Label_SleepingPlacesNumber.TabIndex = 9;
            this.Tab_Administrator_Label_SleepingPlacesNumber.Text = "Count";
            this.Tab_Administrator_Label_SleepingPlacesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ClientPatronymic
            // 
            this.Tab_Administrator_Label_ClientPatronymic.Depth = 0;
            this.Tab_Administrator_Label_ClientPatronymic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_ClientPatronymic.Location = new System.Drawing.Point(256, 46);
            this.Tab_Administrator_Label_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_ClientPatronymic.Name = "Tab_Administrator_Label_ClientPatronymic";
            this.Tab_Administrator_Label_ClientPatronymic.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_Label_ClientPatronymic.TabIndex = 8;
            this.Tab_Administrator_Label_ClientPatronymic.Text = "Patronymic";
            this.Tab_Administrator_Label_ClientPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ClientSurname
            // 
            this.Tab_Administrator_Label_ClientSurname.Depth = 0;
            this.Tab_Administrator_Label_ClientSurname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_ClientSurname.Location = new System.Drawing.Point(256, 23);
            this.Tab_Administrator_Label_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_ClientSurname.Name = "Tab_Administrator_Label_ClientSurname";
            this.Tab_Administrator_Label_ClientSurname.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_Label_ClientSurname.TabIndex = 7;
            this.Tab_Administrator_Label_ClientSurname.Text = "Surname";
            this.Tab_Administrator_Label_ClientSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ClientName
            // 
            this.Tab_Administrator_Label_ClientName.Depth = 0;
            this.Tab_Administrator_Label_ClientName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_Label_ClientName.Location = new System.Drawing.Point(256, 0);
            this.Tab_Administrator_Label_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_Label_ClientName.Name = "Tab_Administrator_Label_ClientName";
            this.Tab_Administrator_Label_ClientName.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_Label_ClientName.TabIndex = 6;
            this.Tab_Administrator_Label_ClientName.Text = "Name";
            this.Tab_Administrator_Label_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_RequestState
            // 
            this.Tab_Administrator_LabelText_RequestState.Depth = 0;
            this.Tab_Administrator_LabelText_RequestState.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_RequestState.Location = new System.Drawing.Point(50, 184);
            this.Tab_Administrator_LabelText_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_RequestState.Name = "Tab_Administrator_LabelText_RequestState";
            this.Tab_Administrator_LabelText_RequestState.Size = new System.Drawing.Size(200, 19);
            this.Tab_Administrator_LabelText_RequestState.TabIndex = 5;
            this.Tab_Administrator_LabelText_RequestState.Text = "Стан заявки:";
            this.Tab_Administrator_LabelText_RequestState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_StayTime
            // 
            this.Tab_Administrator_LabelText_StayTime.Depth = 0;
            this.Tab_Administrator_LabelText_StayTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_StayTime.Location = new System.Drawing.Point(50, 161);
            this.Tab_Administrator_LabelText_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_StayTime.Name = "Tab_Administrator_LabelText_StayTime";
            this.Tab_Administrator_LabelText_StayTime.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_LabelText_StayTime.TabIndex = 4;
            this.Tab_Administrator_LabelText_StayTime.Text = "Час перебування:";
            this.Tab_Administrator_LabelText_StayTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ApartmentСlass
            // 
            this.Tab_Administrator_LabelText_ApartmentСlass.Depth = 0;
            this.Tab_Administrator_LabelText_ApartmentСlass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_ApartmentСlass.Location = new System.Drawing.Point(50, 138);
            this.Tab_Administrator_LabelText_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_ApartmentСlass.Name = "Tab_Administrator_LabelText_ApartmentСlass";
            this.Tab_Administrator_LabelText_ApartmentСlass.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_LabelText_ApartmentСlass.TabIndex = 3;
            this.Tab_Administrator_LabelText_ApartmentСlass.Text = "Клас апартаментів:";
            this.Tab_Administrator_LabelText_ApartmentСlass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_SleepingPlacesNumber
            // 
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.Depth = 0;
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.Location = new System.Drawing.Point(50, 104);
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.Name = "Tab_Administrator_LabelText_SleepingPlacesNumber";
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.TabIndex = 2;
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.Text = "Кількість місць у номері:";
            this.Tab_Administrator_LabelText_SleepingPlacesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ClientPatronymic
            // 
            this.Tab_Administrator_LabelText_ClientPatronymic.Depth = 0;
            this.Tab_Administrator_LabelText_ClientPatronymic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_ClientPatronymic.Location = new System.Drawing.Point(50, 46);
            this.Tab_Administrator_LabelText_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_ClientPatronymic.Name = "Tab_Administrator_LabelText_ClientPatronymic";
            this.Tab_Administrator_LabelText_ClientPatronymic.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_LabelText_ClientPatronymic.TabIndex = 1;
            this.Tab_Administrator_LabelText_ClientPatronymic.Text = "По батькові:";
            this.Tab_Administrator_LabelText_ClientPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ClientSurname
            // 
            this.Tab_Administrator_LabelText_ClientSurname.Depth = 0;
            this.Tab_Administrator_LabelText_ClientSurname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_ClientSurname.Location = new System.Drawing.Point(50, 23);
            this.Tab_Administrator_LabelText_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_ClientSurname.Name = "Tab_Administrator_LabelText_ClientSurname";
            this.Tab_Administrator_LabelText_ClientSurname.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_LabelText_ClientSurname.TabIndex = 1;
            this.Tab_Administrator_LabelText_ClientSurname.Text = "Прізвище:";
            this.Tab_Administrator_LabelText_ClientSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ClientName
            // 
            this.Tab_Administrator_LabelText_ClientName.Depth = 0;
            this.Tab_Administrator_LabelText_ClientName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Administrator_LabelText_ClientName.Location = new System.Drawing.Point(50, 0);
            this.Tab_Administrator_LabelText_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Administrator_LabelText_ClientName.Name = "Tab_Administrator_LabelText_ClientName";
            this.Tab_Administrator_LabelText_ClientName.Size = new System.Drawing.Size(200, 23);
            this.Tab_Administrator_LabelText_ClientName.TabIndex = 0;
            this.Tab_Administrator_LabelText_ClientName.Text = "Ім\'я:";
            this.Tab_Administrator_LabelText_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(194, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 124);
            this.label1.TabIndex = 15;
            this.label1.Text = "Перелік залишених заявок:\r\n\r\nНа даний момент, заявок немає\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Client
            // 
            this.Tab_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Client.Controls.Add(this.Tab_Client_Button_MoveToSignIn);
            this.Tab_Client.Controls.Add(this.Tab_Client_Button_MoveToRequest);
            this.Tab_Client.Controls.Add(this.Tab_Client_Panel_RequesForm);
            this.Tab_Client.Controls.Add(this.label2);
            this.Tab_Client.Location = new System.Drawing.Point(4, 22);
            this.Tab_Client.Name = "Tab_Client";
            this.Tab_Client.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Client.Size = new System.Drawing.Size(800, 362);
            this.Tab_Client.TabIndex = 1;
            this.Tab_Client.Text = "Клієнт";
            // 
            // Tab_Client_Button_MoveToSignIn
            // 
            this.Tab_Client_Button_MoveToSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Client_Button_MoveToSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Client_Button_MoveToSignIn.Depth = 0;
            this.Tab_Client_Button_MoveToSignIn.HighEmphasis = true;
            this.Tab_Client_Button_MoveToSignIn.Icon = global::lab_2.Properties.Resources.free_icon_back_4315468;
            this.Tab_Client_Button_MoveToSignIn.Location = new System.Drawing.Point(7, 6);
            this.Tab_Client_Button_MoveToSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Client_Button_MoveToSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Button_MoveToSignIn.Name = "Tab_Client_Button_MoveToSignIn";
            this.Tab_Client_Button_MoveToSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Client_Button_MoveToSignIn.Size = new System.Drawing.Size(194, 36);
            this.Tab_Client_Button_MoveToSignIn.TabIndex = 17;
            this.Tab_Client_Button_MoveToSignIn.Text = "Меню авторизації";
            this.Tab_Client_Button_MoveToSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Client_Button_MoveToSignIn.UseAccentColor = false;
            this.Tab_Client_Button_MoveToSignIn.UseVisualStyleBackColor = true;
            this.Tab_Client_Button_MoveToSignIn.Click += new System.EventHandler(this.Tab_Client_Button_MoveToSignIn_Click);
            // 
            // Tab_Client_Button_MoveToRequest
            // 
            this.Tab_Client_Button_MoveToRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Client_Button_MoveToRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Client_Button_MoveToRequest.Depth = 0;
            this.Tab_Client_Button_MoveToRequest.HighEmphasis = true;
            this.Tab_Client_Button_MoveToRequest.Icon = global::lab_2.Properties.Resources.free_icon_next_4315612;
            this.Tab_Client_Button_MoveToRequest.Location = new System.Drawing.Point(579, 6);
            this.Tab_Client_Button_MoveToRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Client_Button_MoveToRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Button_MoveToRequest.Name = "Tab_Client_Button_MoveToRequest";
            this.Tab_Client_Button_MoveToRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Client_Button_MoveToRequest.Size = new System.Drawing.Size(214, 36);
            this.Tab_Client_Button_MoveToRequest.TabIndex = 2;
            this.Tab_Client_Button_MoveToRequest.Text = "Оформлення заявки";
            this.Tab_Client_Button_MoveToRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Client_Button_MoveToRequest.UseAccentColor = false;
            this.Tab_Client_Button_MoveToRequest.UseVisualStyleBackColor = true;
            this.Tab_Client_Button_MoveToRequest.Click += new System.EventHandler(this.Tab_Client_Button_MoveToRequest_Click);
            // 
            // Tab_Client_Panel_RequesForm
            // 
            this.Tab_Client_Panel_RequesForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_ClientPhoneNumber);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_ClientPhoneNumber);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Button_Pay);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_RequestState);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_StayTime);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_ApartmentСlass);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_SleepingPlacesNumber);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_ClientPatronymic);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_ClientSurname);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_Label_ClientName);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_RequestState);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_StayTime);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_ApartmentСlass);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_SleepingPlacesNumber);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_ClientPatronymic);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_ClientSurname);
            this.Tab_Client_Panel_RequesForm.Controls.Add(this.Tab_Client_LabelText_ClientName);
            this.Tab_Client_Panel_RequesForm.Location = new System.Drawing.Point(146, 70);
            this.Tab_Client_Panel_RequesForm.Name = "Tab_Client_Panel_RequesForm";
            this.Tab_Client_Panel_RequesForm.Size = new System.Drawing.Size(508, 254);
            this.Tab_Client_Panel_RequesForm.TabIndex = 1;
            this.Tab_Client_Panel_RequesForm.Visible = false;
            // 
            // Tab_Client_Label_ClientPhoneNumber
            // 
            this.Tab_Client_Label_ClientPhoneNumber.Depth = 0;
            this.Tab_Client_Label_ClientPhoneNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_ClientPhoneNumber.Location = new System.Drawing.Point(255, 69);
            this.Tab_Client_Label_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_ClientPhoneNumber.Name = "Tab_Client_Label_ClientPhoneNumber";
            this.Tab_Client_Label_ClientPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_Label_ClientPhoneNumber.TabIndex = 18;
            this.Tab_Client_Label_ClientPhoneNumber.Text = "PhoneNumber";
            this.Tab_Client_Label_ClientPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_ClientPhoneNumber
            // 
            this.Tab_Client_LabelText_ClientPhoneNumber.Depth = 0;
            this.Tab_Client_LabelText_ClientPhoneNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_ClientPhoneNumber.Location = new System.Drawing.Point(49, 69);
            this.Tab_Client_LabelText_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_ClientPhoneNumber.Name = "Tab_Client_LabelText_ClientPhoneNumber";
            this.Tab_Client_LabelText_ClientPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_LabelText_ClientPhoneNumber.TabIndex = 17;
            this.Tab_Client_LabelText_ClientPhoneNumber.Text = "Номер телефону";
            this.Tab_Client_LabelText_ClientPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Button_Pay
            // 
            this.Tab_Client_Button_Pay.AutoSize = false;
            this.Tab_Client_Button_Pay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Client_Button_Pay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Client_Button_Pay.Depth = 0;
            this.Tab_Client_Button_Pay.HighEmphasis = true;
            this.Tab_Client_Button_Pay.Icon = global::lab_2.Properties.Resources.free_icon_payment_method_1019709;
            this.Tab_Client_Button_Pay.Location = new System.Drawing.Point(169, 209);
            this.Tab_Client_Button_Pay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Client_Button_Pay.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Button_Pay.Name = "Tab_Client_Button_Pay";
            this.Tab_Client_Button_Pay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Client_Button_Pay.Size = new System.Drawing.Size(180, 38);
            this.Tab_Client_Button_Pay.TabIndex = 13;
            this.Tab_Client_Button_Pay.Text = "Оплатити заявку";
            this.Tab_Client_Button_Pay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Client_Button_Pay.UseAccentColor = false;
            this.Tab_Client_Button_Pay.UseVisualStyleBackColor = true;
            this.Tab_Client_Button_Pay.Click += new System.EventHandler(this.Tab_Client_Button_Pay_Click);
            // 
            // Tab_Client_Label_RequestState
            // 
            this.Tab_Client_Label_RequestState.Depth = 0;
            this.Tab_Client_Label_RequestState.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_RequestState.Location = new System.Drawing.Point(256, 184);
            this.Tab_Client_Label_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_RequestState.Name = "Tab_Client_Label_RequestState";
            this.Tab_Client_Label_RequestState.Size = new System.Drawing.Size(200, 19);
            this.Tab_Client_Label_RequestState.TabIndex = 12;
            this.Tab_Client_Label_RequestState.Text = "State";
            this.Tab_Client_Label_RequestState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_StayTime
            // 
            this.Tab_Client_Label_StayTime.Depth = 0;
            this.Tab_Client_Label_StayTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_StayTime.Location = new System.Drawing.Point(256, 161);
            this.Tab_Client_Label_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_StayTime.Name = "Tab_Client_Label_StayTime";
            this.Tab_Client_Label_StayTime.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_Label_StayTime.TabIndex = 11;
            this.Tab_Client_Label_StayTime.Text = "Time in D.H.M.";
            this.Tab_Client_Label_StayTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ApartmentСlass
            // 
            this.Tab_Client_Label_ApartmentСlass.Depth = 0;
            this.Tab_Client_Label_ApartmentСlass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_ApartmentСlass.Location = new System.Drawing.Point(256, 138);
            this.Tab_Client_Label_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_ApartmentСlass.Name = "Tab_Client_Label_ApartmentСlass";
            this.Tab_Client_Label_ApartmentСlass.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_Label_ApartmentСlass.TabIndex = 10;
            this.Tab_Client_Label_ApartmentСlass.Text = "Count";
            this.Tab_Client_Label_ApartmentСlass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_SleepingPlacesNumber
            // 
            this.Tab_Client_Label_SleepingPlacesNumber.Depth = 0;
            this.Tab_Client_Label_SleepingPlacesNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_SleepingPlacesNumber.Location = new System.Drawing.Point(256, 92);
            this.Tab_Client_Label_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_SleepingPlacesNumber.Name = "Tab_Client_Label_SleepingPlacesNumber";
            this.Tab_Client_Label_SleepingPlacesNumber.Size = new System.Drawing.Size(200, 46);
            this.Tab_Client_Label_SleepingPlacesNumber.TabIndex = 9;
            this.Tab_Client_Label_SleepingPlacesNumber.Text = "Count";
            this.Tab_Client_Label_SleepingPlacesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ClientPatronymic
            // 
            this.Tab_Client_Label_ClientPatronymic.Depth = 0;
            this.Tab_Client_Label_ClientPatronymic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_ClientPatronymic.Location = new System.Drawing.Point(256, 46);
            this.Tab_Client_Label_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_ClientPatronymic.Name = "Tab_Client_Label_ClientPatronymic";
            this.Tab_Client_Label_ClientPatronymic.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_Label_ClientPatronymic.TabIndex = 8;
            this.Tab_Client_Label_ClientPatronymic.Text = "Patronymic";
            this.Tab_Client_Label_ClientPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ClientSurname
            // 
            this.Tab_Client_Label_ClientSurname.Depth = 0;
            this.Tab_Client_Label_ClientSurname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_ClientSurname.Location = new System.Drawing.Point(256, 23);
            this.Tab_Client_Label_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_ClientSurname.Name = "Tab_Client_Label_ClientSurname";
            this.Tab_Client_Label_ClientSurname.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_Label_ClientSurname.TabIndex = 7;
            this.Tab_Client_Label_ClientSurname.Text = "Surname";
            this.Tab_Client_Label_ClientSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ClientName
            // 
            this.Tab_Client_Label_ClientName.Depth = 0;
            this.Tab_Client_Label_ClientName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_Label_ClientName.Location = new System.Drawing.Point(256, 0);
            this.Tab_Client_Label_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_Label_ClientName.Name = "Tab_Client_Label_ClientName";
            this.Tab_Client_Label_ClientName.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_Label_ClientName.TabIndex = 6;
            this.Tab_Client_Label_ClientName.Text = "Name";
            this.Tab_Client_Label_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_RequestState
            // 
            this.Tab_Client_LabelText_RequestState.Depth = 0;
            this.Tab_Client_LabelText_RequestState.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_RequestState.Location = new System.Drawing.Point(50, 184);
            this.Tab_Client_LabelText_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_RequestState.Name = "Tab_Client_LabelText_RequestState";
            this.Tab_Client_LabelText_RequestState.Size = new System.Drawing.Size(200, 19);
            this.Tab_Client_LabelText_RequestState.TabIndex = 5;
            this.Tab_Client_LabelText_RequestState.Text = "Стан заявки:";
            this.Tab_Client_LabelText_RequestState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_StayTime
            // 
            this.Tab_Client_LabelText_StayTime.Depth = 0;
            this.Tab_Client_LabelText_StayTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_StayTime.Location = new System.Drawing.Point(50, 161);
            this.Tab_Client_LabelText_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_StayTime.Name = "Tab_Client_LabelText_StayTime";
            this.Tab_Client_LabelText_StayTime.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_LabelText_StayTime.TabIndex = 4;
            this.Tab_Client_LabelText_StayTime.Text = "Час перебування:";
            this.Tab_Client_LabelText_StayTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ApartmentСlass
            // 
            this.Tab_Client_LabelText_ApartmentСlass.Depth = 0;
            this.Tab_Client_LabelText_ApartmentСlass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_ApartmentСlass.Location = new System.Drawing.Point(50, 138);
            this.Tab_Client_LabelText_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_ApartmentСlass.Name = "Tab_Client_LabelText_ApartmentСlass";
            this.Tab_Client_LabelText_ApartmentСlass.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_LabelText_ApartmentСlass.TabIndex = 3;
            this.Tab_Client_LabelText_ApartmentСlass.Text = "Клас апартаментів:";
            this.Tab_Client_LabelText_ApartmentСlass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_SleepingPlacesNumber
            // 
            this.Tab_Client_LabelText_SleepingPlacesNumber.Depth = 0;
            this.Tab_Client_LabelText_SleepingPlacesNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_SleepingPlacesNumber.Location = new System.Drawing.Point(50, 104);
            this.Tab_Client_LabelText_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_SleepingPlacesNumber.Name = "Tab_Client_LabelText_SleepingPlacesNumber";
            this.Tab_Client_LabelText_SleepingPlacesNumber.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_LabelText_SleepingPlacesNumber.TabIndex = 2;
            this.Tab_Client_LabelText_SleepingPlacesNumber.Text = "Кількість місць у номері:";
            this.Tab_Client_LabelText_SleepingPlacesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ClientPatronymic
            // 
            this.Tab_Client_LabelText_ClientPatronymic.Depth = 0;
            this.Tab_Client_LabelText_ClientPatronymic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_ClientPatronymic.Location = new System.Drawing.Point(50, 46);
            this.Tab_Client_LabelText_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_ClientPatronymic.Name = "Tab_Client_LabelText_ClientPatronymic";
            this.Tab_Client_LabelText_ClientPatronymic.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_LabelText_ClientPatronymic.TabIndex = 1;
            this.Tab_Client_LabelText_ClientPatronymic.Text = "По батькові:";
            this.Tab_Client_LabelText_ClientPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ClientSurname
            // 
            this.Tab_Client_LabelText_ClientSurname.Depth = 0;
            this.Tab_Client_LabelText_ClientSurname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_ClientSurname.Location = new System.Drawing.Point(50, 23);
            this.Tab_Client_LabelText_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_ClientSurname.Name = "Tab_Client_LabelText_ClientSurname";
            this.Tab_Client_LabelText_ClientSurname.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_LabelText_ClientSurname.TabIndex = 1;
            this.Tab_Client_LabelText_ClientSurname.Text = "Прізвище:";
            this.Tab_Client_LabelText_ClientSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ClientName
            // 
            this.Tab_Client_LabelText_ClientName.Depth = 0;
            this.Tab_Client_LabelText_ClientName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Client_LabelText_ClientName.Location = new System.Drawing.Point(50, 0);
            this.Tab_Client_LabelText_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Client_LabelText_ClientName.Name = "Tab_Client_LabelText_ClientName";
            this.Tab_Client_LabelText_ClientName.Size = new System.Drawing.Size(200, 23);
            this.Tab_Client_LabelText_ClientName.TabIndex = 0;
            this.Tab_Client_LabelText_ClientName.Text = "Ім\'я:";
            this.Tab_Client_LabelText_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(193, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 124);
            this.label2.TabIndex = 16;
            this.label2.Text = "У вас ще немає створеної заявки. Перейдіть у меню оформлення заявки для створення" +
    " заявки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Request
            // 
            this.Tab_Request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Request.Controls.Add(this.Tab_Request_Button_MoveToClient);
            this.Tab_Request.Controls.Add(this.Tab_Request_LabelText_StayTime);
            this.Tab_Request.Controls.Add(this.Tab_Request_LabelText_Minutes);
            this.Tab_Request.Controls.Add(this.Tab_Request_LabelText_Hours);
            this.Tab_Request.Controls.Add(this.Tab_Request_LabelText_Days);
            this.Tab_Request.Controls.Add(this.Tab_Request_Label_MinutesCount);
            this.Tab_Request.Controls.Add(this.Tab_Request_Label_HoursCount);
            this.Tab_Request.Controls.Add(this.Tab_Request_Label_DaysCount);
            this.Tab_Request.Controls.Add(this.Tab_Request_ComboBox_SleepingPlacesNumber);
            this.Tab_Request.Controls.Add(this.Tab_Request_ComboBox_ApartmentСlass);
            this.Tab_Request.Controls.Add(this.Tab_Request_Button_MinutesUp);
            this.Tab_Request.Controls.Add(this.Tab_Request_Button_MinutesDown);
            this.Tab_Request.Controls.Add(this.Tab_Request_Button_HoursUp);
            this.Tab_Request.Controls.Add(this.Tab_Request_Button_HoursDown);
            this.Tab_Request.Controls.Add(this.Tab_Request_Button_DaysDown);
            this.Tab_Request.Controls.Add(this.Tab_Request_Button_DaysUp);
            this.Tab_Request.Controls.Add(this.Tab_Request_Buttonn_SendRequest);
            this.Tab_Request.Location = new System.Drawing.Point(4, 22);
            this.Tab_Request.Name = "Tab_Request";
            this.Tab_Request.Size = new System.Drawing.Size(800, 362);
            this.Tab_Request.TabIndex = 2;
            this.Tab_Request.Text = "Заявка";
            // 
            // Tab_Request_Button_MoveToClient
            // 
            this.Tab_Request_Button_MoveToClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Button_MoveToClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Button_MoveToClient.Depth = 0;
            this.Tab_Request_Button_MoveToClient.HighEmphasis = true;
            this.Tab_Request_Button_MoveToClient.Icon = global::lab_2.Properties.Resources.free_icon_back_4315468;
            this.Tab_Request_Button_MoveToClient.Location = new System.Drawing.Point(7, 6);
            this.Tab_Request_Button_MoveToClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Button_MoveToClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Button_MoveToClient.Name = "Tab_Request_Button_MoveToClient";
            this.Tab_Request_Button_MoveToClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Button_MoveToClient.Size = new System.Drawing.Size(110, 36);
            this.Tab_Request_Button_MoveToClient.TabIndex = 18;
            this.Tab_Request_Button_MoveToClient.Text = "Кабінет";
            this.Tab_Request_Button_MoveToClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Button_MoveToClient.UseAccentColor = false;
            this.Tab_Request_Button_MoveToClient.UseVisualStyleBackColor = true;
            this.Tab_Request_Button_MoveToClient.Click += new System.EventHandler(this.Tab_Request_Button_MoveToClient_Click);
            // 
            // Tab_Request_LabelText_StayTime
            // 
            this.Tab_Request_LabelText_StayTime.Depth = 0;
            this.Tab_Request_LabelText_StayTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Request_LabelText_StayTime.Location = new System.Drawing.Point(175, 181);
            this.Tab_Request_LabelText_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_LabelText_StayTime.Name = "Tab_Request_LabelText_StayTime";
            this.Tab_Request_LabelText_StayTime.Size = new System.Drawing.Size(142, 49);
            this.Tab_Request_LabelText_StayTime.TabIndex = 17;
            this.Tab_Request_LabelText_StayTime.Text = "Час перебування:";
            this.Tab_Request_LabelText_StayTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Request_LabelText_Minutes
            // 
            this.Tab_Request_LabelText_Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Tab_Request_LabelText_Minutes.Location = new System.Drawing.Point(433, 183);
            this.Tab_Request_LabelText_Minutes.Name = "Tab_Request_LabelText_Minutes";
            this.Tab_Request_LabelText_Minutes.Size = new System.Drawing.Size(46, 12);
            this.Tab_Request_LabelText_Minutes.TabIndex = 16;
            this.Tab_Request_LabelText_Minutes.Text = "Хвилин";
            // 
            // Tab_Request_LabelText_Hours
            // 
            this.Tab_Request_LabelText_Hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Tab_Request_LabelText_Hours.Location = new System.Drawing.Point(378, 183);
            this.Tab_Request_LabelText_Hours.Name = "Tab_Request_LabelText_Hours";
            this.Tab_Request_LabelText_Hours.Size = new System.Drawing.Size(46, 12);
            this.Tab_Request_LabelText_Hours.TabIndex = 15;
            this.Tab_Request_LabelText_Hours.Text = "Годин";
            this.Tab_Request_LabelText_Hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_LabelText_Days
            // 
            this.Tab_Request_LabelText_Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Tab_Request_LabelText_Days.Location = new System.Drawing.Point(323, 183);
            this.Tab_Request_LabelText_Days.Name = "Tab_Request_LabelText_Days";
            this.Tab_Request_LabelText_Days.Size = new System.Drawing.Size(46, 12);
            this.Tab_Request_LabelText_Days.TabIndex = 14;
            this.Tab_Request_LabelText_Days.Text = "Днів";
            this.Tab_Request_LabelText_Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_MinutesCount
            // 
            this.Tab_Request_Label_MinutesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Request_Label_MinutesCount.Depth = 0;
            this.Tab_Request_Label_MinutesCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Request_Label_MinutesCount.Location = new System.Drawing.Point(431, 181);
            this.Tab_Request_Label_MinutesCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Label_MinutesCount.Name = "Tab_Request_Label_MinutesCount";
            this.Tab_Request_Label_MinutesCount.Size = new System.Drawing.Size(49, 49);
            this.Tab_Request_Label_MinutesCount.TabIndex = 6;
            this.Tab_Request_Label_MinutesCount.Text = "0";
            this.Tab_Request_Label_MinutesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_HoursCount
            // 
            this.Tab_Request_Label_HoursCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Request_Label_HoursCount.Depth = 0;
            this.Tab_Request_Label_HoursCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Request_Label_HoursCount.Location = new System.Drawing.Point(376, 181);
            this.Tab_Request_Label_HoursCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Label_HoursCount.Name = "Tab_Request_Label_HoursCount";
            this.Tab_Request_Label_HoursCount.Size = new System.Drawing.Size(49, 49);
            this.Tab_Request_Label_HoursCount.TabIndex = 5;
            this.Tab_Request_Label_HoursCount.Text = "0";
            this.Tab_Request_Label_HoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_DaysCount
            // 
            this.Tab_Request_Label_DaysCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Request_Label_DaysCount.Depth = 0;
            this.Tab_Request_Label_DaysCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Request_Label_DaysCount.Location = new System.Drawing.Point(321, 181);
            this.Tab_Request_Label_DaysCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Label_DaysCount.Name = "Tab_Request_Label_DaysCount";
            this.Tab_Request_Label_DaysCount.Size = new System.Drawing.Size(49, 49);
            this.Tab_Request_Label_DaysCount.TabIndex = 4;
            this.Tab_Request_Label_DaysCount.Text = "0";
            this.Tab_Request_Label_DaysCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_ComboBox_SleepingPlacesNumber
            // 
            this.Tab_Request_ComboBox_SleepingPlacesNumber.AutoResize = false;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Request_ComboBox_SleepingPlacesNumber.Depth = 0;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.DropDownHeight = 174;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.DropDownWidth = 121;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Request_ComboBox_SleepingPlacesNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Tab_Request_ComboBox_SleepingPlacesNumber.FormattingEnabled = true;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.Hint = "Кількість місць у номері";
            this.Tab_Request_ComboBox_SleepingPlacesNumber.IntegralHeight = false;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.ItemHeight = 43;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.Items.AddRange(new object[] {
            "Одномісний з одномісним ліжком",
            "Одноміснйи з двомісним ліжком",
            "Двомісний з одним двухмісним ліжком",
            "Двомісний з двома одномісними ліжками",
            "Трьохмісний з трьома одномісними ліжками",
            "Трьохмісний з одномісним та двохмісним ліжком",
            "Чотирьохмісний з двома двомісними ліжками"});
            this.Tab_Request_ComboBox_SleepingPlacesNumber.Location = new System.Drawing.Point(180, 19);
            this.Tab_Request_ComboBox_SleepingPlacesNumber.MaxDropDownItems = 4;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.Name = "Tab_Request_ComboBox_SleepingPlacesNumber";
            this.Tab_Request_ComboBox_SleepingPlacesNumber.Size = new System.Drawing.Size(440, 49);
            this.Tab_Request_ComboBox_SleepingPlacesNumber.StartIndex = 0;
            this.Tab_Request_ComboBox_SleepingPlacesNumber.TabIndex = 3;
            // 
            // Tab_Request_ComboBox_ApartmentСlass
            // 
            this.Tab_Request_ComboBox_ApartmentСlass.AutoResize = false;
            this.Tab_Request_ComboBox_ApartmentСlass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Request_ComboBox_ApartmentСlass.Depth = 0;
            this.Tab_Request_ComboBox_ApartmentСlass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Tab_Request_ComboBox_ApartmentСlass.DropDownHeight = 174;
            this.Tab_Request_ComboBox_ApartmentСlass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tab_Request_ComboBox_ApartmentСlass.DropDownWidth = 121;
            this.Tab_Request_ComboBox_ApartmentСlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Tab_Request_ComboBox_ApartmentСlass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Tab_Request_ComboBox_ApartmentСlass.FormattingEnabled = true;
            this.Tab_Request_ComboBox_ApartmentСlass.Hint = "Клас апартаментів";
            this.Tab_Request_ComboBox_ApartmentСlass.IntegralHeight = false;
            this.Tab_Request_ComboBox_ApartmentСlass.ItemHeight = 43;
            this.Tab_Request_ComboBox_ApartmentСlass.Items.AddRange(new object[] {
            "Економ",
            "Економ+",
            "Бізнес",
            "Люкс",
            "Преміум"});
            this.Tab_Request_ComboBox_ApartmentСlass.Location = new System.Drawing.Point(300, 74);
            this.Tab_Request_ComboBox_ApartmentСlass.MaxDropDownItems = 4;
            this.Tab_Request_ComboBox_ApartmentСlass.MouseState = MaterialSkin.MouseState.OUT;
            this.Tab_Request_ComboBox_ApartmentСlass.Name = "Tab_Request_ComboBox_ApartmentСlass";
            this.Tab_Request_ComboBox_ApartmentСlass.Size = new System.Drawing.Size(200, 49);
            this.Tab_Request_ComboBox_ApartmentСlass.StartIndex = 0;
            this.Tab_Request_ComboBox_ApartmentСlass.TabIndex = 2;
            // 
            // Tab_Request_Button_MinutesUp
            // 
            this.Tab_Request_Button_MinutesUp.AutoSize = false;
            this.Tab_Request_Button_MinutesUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Button_MinutesUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Button_MinutesUp.Depth = 0;
            this.Tab_Request_Button_MinutesUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab_Request_Button_MinutesUp.HighEmphasis = true;
            this.Tab_Request_Button_MinutesUp.Icon = global::lab_2.Properties.Resources.free_icon_up_arrow_4315708;
            this.Tab_Request_Button_MinutesUp.Location = new System.Drawing.Point(435, 139);
            this.Tab_Request_Button_MinutesUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Button_MinutesUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Button_MinutesUp.Name = "Tab_Request_Button_MinutesUp";
            this.Tab_Request_Button_MinutesUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Button_MinutesUp.Size = new System.Drawing.Size(40, 36);
            this.Tab_Request_Button_MinutesUp.TabIndex = 13;
            this.Tab_Request_Button_MinutesUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Button_MinutesUp.UseAccentColor = false;
            this.Tab_Request_Button_MinutesUp.UseVisualStyleBackColor = true;
            this.Tab_Request_Button_MinutesUp.Click += new System.EventHandler(this.Tab_Request_Button_MinutesUp_Click);
            // 
            // Tab_Request_Button_MinutesDown
            // 
            this.Tab_Request_Button_MinutesDown.AutoSize = false;
            this.Tab_Request_Button_MinutesDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Button_MinutesDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Button_MinutesDown.Depth = 0;
            this.Tab_Request_Button_MinutesDown.Enabled = false;
            this.Tab_Request_Button_MinutesDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab_Request_Button_MinutesDown.HighEmphasis = true;
            this.Tab_Request_Button_MinutesDown.Icon = global::lab_2.Properties.Resources.free_icon_down_arrow_4315506;
            this.Tab_Request_Button_MinutesDown.Location = new System.Drawing.Point(435, 236);
            this.Tab_Request_Button_MinutesDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Button_MinutesDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Button_MinutesDown.Name = "Tab_Request_Button_MinutesDown";
            this.Tab_Request_Button_MinutesDown.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Button_MinutesDown.Size = new System.Drawing.Size(40, 36);
            this.Tab_Request_Button_MinutesDown.TabIndex = 12;
            this.Tab_Request_Button_MinutesDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Button_MinutesDown.UseAccentColor = false;
            this.Tab_Request_Button_MinutesDown.UseVisualStyleBackColor = true;
            this.Tab_Request_Button_MinutesDown.Click += new System.EventHandler(this.Tab_Request_Button_MinutesDown_Click);
            // 
            // Tab_Request_Button_HoursUp
            // 
            this.Tab_Request_Button_HoursUp.AutoSize = false;
            this.Tab_Request_Button_HoursUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Button_HoursUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Button_HoursUp.Depth = 0;
            this.Tab_Request_Button_HoursUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab_Request_Button_HoursUp.HighEmphasis = true;
            this.Tab_Request_Button_HoursUp.Icon = global::lab_2.Properties.Resources.free_icon_up_arrow_4315708;
            this.Tab_Request_Button_HoursUp.Location = new System.Drawing.Point(380, 139);
            this.Tab_Request_Button_HoursUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Button_HoursUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Button_HoursUp.Name = "Tab_Request_Button_HoursUp";
            this.Tab_Request_Button_HoursUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Button_HoursUp.Size = new System.Drawing.Size(40, 36);
            this.Tab_Request_Button_HoursUp.TabIndex = 11;
            this.Tab_Request_Button_HoursUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Button_HoursUp.UseAccentColor = false;
            this.Tab_Request_Button_HoursUp.UseVisualStyleBackColor = true;
            this.Tab_Request_Button_HoursUp.Click += new System.EventHandler(this.Tab_Request_Button_HoursUp_Click);
            // 
            // Tab_Request_Button_HoursDown
            // 
            this.Tab_Request_Button_HoursDown.AutoSize = false;
            this.Tab_Request_Button_HoursDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Button_HoursDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Button_HoursDown.Depth = 0;
            this.Tab_Request_Button_HoursDown.Enabled = false;
            this.Tab_Request_Button_HoursDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab_Request_Button_HoursDown.HighEmphasis = true;
            this.Tab_Request_Button_HoursDown.Icon = global::lab_2.Properties.Resources.free_icon_down_arrow_4315506;
            this.Tab_Request_Button_HoursDown.Location = new System.Drawing.Point(380, 236);
            this.Tab_Request_Button_HoursDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Button_HoursDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Button_HoursDown.Name = "Tab_Request_Button_HoursDown";
            this.Tab_Request_Button_HoursDown.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Button_HoursDown.Size = new System.Drawing.Size(40, 36);
            this.Tab_Request_Button_HoursDown.TabIndex = 10;
            this.Tab_Request_Button_HoursDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Button_HoursDown.UseAccentColor = false;
            this.Tab_Request_Button_HoursDown.UseVisualStyleBackColor = true;
            this.Tab_Request_Button_HoursDown.Click += new System.EventHandler(this.Tab_Request_Button_HoursDown_Click);
            // 
            // Tab_Request_Button_DaysDown
            // 
            this.Tab_Request_Button_DaysDown.AutoSize = false;
            this.Tab_Request_Button_DaysDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Button_DaysDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Button_DaysDown.Depth = 0;
            this.Tab_Request_Button_DaysDown.Enabled = false;
            this.Tab_Request_Button_DaysDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab_Request_Button_DaysDown.HighEmphasis = true;
            this.Tab_Request_Button_DaysDown.Icon = global::lab_2.Properties.Resources.free_icon_down_arrow_4315506;
            this.Tab_Request_Button_DaysDown.Location = new System.Drawing.Point(325, 236);
            this.Tab_Request_Button_DaysDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Button_DaysDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Button_DaysDown.Name = "Tab_Request_Button_DaysDown";
            this.Tab_Request_Button_DaysDown.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Button_DaysDown.Size = new System.Drawing.Size(40, 36);
            this.Tab_Request_Button_DaysDown.TabIndex = 8;
            this.Tab_Request_Button_DaysDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Button_DaysDown.UseAccentColor = false;
            this.Tab_Request_Button_DaysDown.UseVisualStyleBackColor = true;
            this.Tab_Request_Button_DaysDown.Click += new System.EventHandler(this.Tab_Request_Button_DaysDown_Click);
            // 
            // Tab_Request_Button_DaysUp
            // 
            this.Tab_Request_Button_DaysUp.AutoSize = false;
            this.Tab_Request_Button_DaysUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Button_DaysUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Button_DaysUp.Depth = 0;
            this.Tab_Request_Button_DaysUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab_Request_Button_DaysUp.HighEmphasis = true;
            this.Tab_Request_Button_DaysUp.Icon = global::lab_2.Properties.Resources.free_icon_up_arrow_4315708;
            this.Tab_Request_Button_DaysUp.Location = new System.Drawing.Point(325, 139);
            this.Tab_Request_Button_DaysUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Button_DaysUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Button_DaysUp.Name = "Tab_Request_Button_DaysUp";
            this.Tab_Request_Button_DaysUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Button_DaysUp.Size = new System.Drawing.Size(40, 36);
            this.Tab_Request_Button_DaysUp.TabIndex = 7;
            this.Tab_Request_Button_DaysUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Button_DaysUp.UseAccentColor = false;
            this.Tab_Request_Button_DaysUp.UseVisualStyleBackColor = true;
            this.Tab_Request_Button_DaysUp.Click += new System.EventHandler(this.Tab_Request_Button_DaysUp_Click);
            // 
            // Tab_Request_Buttonn_SendRequest
            // 
            this.Tab_Request_Buttonn_SendRequest.AutoSize = false;
            this.Tab_Request_Buttonn_SendRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab_Request_Buttonn_SendRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Tab_Request_Buttonn_SendRequest.Depth = 0;
            this.Tab_Request_Buttonn_SendRequest.HighEmphasis = true;
            this.Tab_Request_Buttonn_SendRequest.Icon = global::lab_2.Properties.Resources.free_icon_approve_8667878;
            this.Tab_Request_Buttonn_SendRequest.Location = new System.Drawing.Point(300, 290);
            this.Tab_Request_Buttonn_SendRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Tab_Request_Buttonn_SendRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Request_Buttonn_SendRequest.Name = "Tab_Request_Buttonn_SendRequest";
            this.Tab_Request_Buttonn_SendRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Tab_Request_Buttonn_SendRequest.Size = new System.Drawing.Size(200, 36);
            this.Tab_Request_Buttonn_SendRequest.TabIndex = 0;
            this.Tab_Request_Buttonn_SendRequest.Text = "Відправити заявку";
            this.Tab_Request_Buttonn_SendRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Tab_Request_Buttonn_SendRequest.UseAccentColor = false;
            this.Tab_Request_Buttonn_SendRequest.UseVisualStyleBackColor = true;
            this.Tab_Request_Buttonn_SendRequest.Click += new System.EventHandler(this.Tab_Request_Buttonn_SendRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl_MainTabs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система замовлення готелю";
            this.TabControl_MainTabs.ResumeLayout(false);
            this.Tab_Authorization.ResumeLayout(false);
            this.Tab_SignUp.ResumeLayout(false);
            this.Tab_Aministrator.ResumeLayout(false);
            this.Tab_Administrator_Panel_RequesList.ResumeLayout(false);
            this.Tab_Client.ResumeLayout(false);
            this.Tab_Client.PerformLayout();
            this.Tab_Client_Panel_RequesForm.ResumeLayout(false);
            this.Tab_Request.ResumeLayout(false);
            this.Tab_Request.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_MainTabs;
        private System.Windows.Forms.TabPage Tab_Aministrator;
        private System.Windows.Forms.TabPage Tab_Client;
        private System.Windows.Forms.TabPage Tab_Request;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Buttonn_SendRequest;
        private MaterialSkin.Controls.MaterialComboBox Tab_Request_ComboBox_ApartmentСlass;
        private MaterialSkin.Controls.MaterialComboBox Tab_Request_ComboBox_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_DaysUp;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_DaysDown;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_MinutesUp;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_MinutesDown;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_HoursUp;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_HoursDown;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_Label_MinutesCount;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_Label_HoursCount;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_Label_DaysCount;
        private System.Windows.Forms.Label Tab_Request_LabelText_Days;
        private System.Windows.Forms.Label Tab_Request_LabelText_Minutes;
        private System.Windows.Forms.Label Tab_Request_LabelText_Hours;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_LabelText_StayTime;
        private System.Windows.Forms.TabPage Tab_SignUp;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPatronymic;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientSurname;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientName;
        private MaterialSkin.Controls.MaterialButton Tab_SignUp_Button_SignUp;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialComboBox Tab_SignUp_ComboBox_ClientStatus;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPasswordСonfirmation;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPassword;
        private System.Windows.Forms.TabPage Tab_Authorization;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientPatronymic;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientPassword;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientSurname;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientName;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_SignIn;
        private System.Windows.Forms.Panel Tab_Administrator_Panel_RequesList;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientName;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_RequestState;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientName;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_RequestState;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_ConfirmRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_DeclineRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_NextRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_PrevRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Tab_Client_Panel_RequesForm;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_RequestState;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientName;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_RequestState;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientName;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_Pay;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_MoveToRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_MoveToClient;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_MoveToSignIn;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientPhoneNumber;
    }
}


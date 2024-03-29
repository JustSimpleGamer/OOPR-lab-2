﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace lab_2.Models
{
    public class AdministratorVm //1. Class implementation
    {
        public LinkedList<ClientManagerVm> ClientsManagers { get; set; } //3. Implementing a data field using properties { get; set; }
        static public LinkedListNode<ClientManagerVm> Nodes { get; set; } //12. A static pointer (iterator) to a linked list of objects
        public AdministratorVm() //4. Constructor without parameters
        {
            ClientsManagers = new LinkedList<ClientManagerVm>();
        }
        public AdministratorVm(LinkedList<ClientManagerVm> clientsManagers) //4. Constructor with parameters
        {
            ClientsManagers = clientsManagers;
        }
        static public void ShowRequestAtAdministrator(Label label_ClientName, Label label_ClientSurname, Label label_ClientPatronymic, Label label_ClientPhoneNumber, Label label_SleepingPlacesNumber, Label label_ApartmentСlass, Label label_StayTime, Label label_RequestState, Button button_ConfirmRequest, Button button_DeclineRequest) //12. Static method for list view
        {
            label_ClientName.Text = AdministratorVm.Nodes.Value.Client.Name;
            label_ClientSurname.Text = AdministratorVm.Nodes.Value.Client.Surname;
            label_ClientPatronymic.Text = AdministratorVm.Nodes.Value.Client.Patronymic;
            label_ClientPhoneNumber.Text = AdministratorVm.Nodes.Value.Client.PhoneNumber;
            if (AdministratorVm.Nodes.Value.Client.Request == null)
            {
                label_SleepingPlacesNumber.Visible = false;
                label_ApartmentСlass.Visible = false;
                label_StayTime.Visible = false;
                label_RequestState.Visible = false;
                button_ConfirmRequest.Enabled = false;
                button_DeclineRequest.Enabled = false;
            }
            else
            {
                label_SleepingPlacesNumber.Visible = true;
                label_ApartmentСlass.Visible = true;
                label_StayTime.Visible = true;
                label_RequestState.Visible = true;
                button_ConfirmRequest.Enabled = true;
                button_DeclineRequest.Enabled = true;

                label_SleepingPlacesNumber.Text = AdministratorVm.Nodes.Value.Client.Request.Apartment.SleepingPlacesNumber;
                label_ApartmentСlass.Text = AdministratorVm.Nodes.Value.Client.Request.Apartment.ApartmentСlass;
                label_StayTime.Text = AdministratorVm.Nodes.Value.Client.Request.Apartment.StayTime[(int)StayTime.Days].ToString() + " Днів " + AdministratorVm.Nodes.Value.Client.Request.Apartment.StayTime[(int)StayTime.Hours].ToString() + " Годин " + AdministratorVm.Nodes.Value.Client.Request.Apartment.StayTime[(int)StayTime.Minutes].ToString() + " Хвилин";
                label_RequestState.Text = AdministratorVm.Nodes.Value.Client.Request.State.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.Models;
using Xamarin.Forms;

namespace Project.Views
{
    public partial class ClientsPage : ContentPage
    {
        public IList<Client> Clients { get; private set; }

        public ClientsPage()
        {
            InitializeComponent();

            Clients = new List<Client>();

            Clients.Add(new Client
            {
                ClientName = "Countdown Lynnmall",
                ClientContact = "09 826 0340",
                ClientImage = "countdown.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "Countdown Kelston",
                ClientContact = "09 818 4372",
                ClientImage = "countdown.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "Countdown Te Atatu",
                ClientContact = "09 834 5451",
                ClientImage = "countdown.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "Countdown Westgate",
                ClientContact = "09 832 5382",
                ClientImage = "countdown.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "Countdown Northwest",
                ClientContact = "09 416 0934",
                ClientImage = "countdown.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "Fresh Choice Ranui",
                ClientContact = "09 833 8420",
                ClientImage = "freshchoice.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "New World New Lynn",
                ClientContact = "09 825 1110",
                ClientImage = "newworld.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "New World Green Bay",
                ClientContact = "09 827 4070",
                ClientImage = "newworld.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "Pak N Save Westgate",
                ClientContact = "09 417 0162",
                ClientImage = "paknsave.jpg"
            });

            Clients.Add(new Client
            {
                ClientName = "Pak N Save Mt Albert",
                ClientContact = "09 820 0218",
                ClientImage = "paknsave.jpg"
            });

            BindingContext = this;
            
        }

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Client selectedItem = e.CurrentSelection[0] as Client;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.Models;
using Xamarin.Forms;

namespace Project.Views
{
    public partial class WorkersPage : ContentPage
    {
        public IList<Worker> Workers { get; private set; }

        public WorkersPage()
        {
            InitializeComponent();

            Workers = new List<Worker>();
            Workers.Add(new Worker
            {
                Name = "Aaron",
                Contact = "021 98765432",
                Image = "aaron.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Anita",
                Contact = "021 87654321",
                Image = "anita.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Behzad",
                Contact = "021 76543210",
                Image = "behzad.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Jay",
                Contact = "021 01234567",
                Image = "jay.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Jen",
                Contact = "021 12345678",
                Image = "jen.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Joanne",
                Contact = "021 23456789",
                Image = "joanne.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Judy",
                Contact = "027 98765432",
                Image = "judy.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Kerry",
                Contact = "027 87654321",
                Image = "kerry.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Lucy",
                Contact = "027 76543210",
                Image = "lucy.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Mark",
                Contact = "027 01234567",
                Image = "mark.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Rob",
                Contact = "027 12345678",
                Image = "rob.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Ryan",
                Contact = "027 23456789",
                Image = "ryan.jpg"
            });

            Workers.Add(new Worker
            {
                Name = "Troy",
                Contact = "022 98765432",
                Image = "troy.jpg"
            });

            BindingContext = this;
            
        }
        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Worker selectedItem = e.CurrentSelection[0] as Worker;
        }
    }
}
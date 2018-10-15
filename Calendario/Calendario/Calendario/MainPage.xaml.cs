using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamForms.Controls;

namespace Calendario
{
    public partial class MainPage : ContentView
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void OnStart()
        {
            // Handle when your app starts
            //calendar.SpecialDates.Add(new SpecialDate(DateTime.Now.AddDays(5)) { BackgroundColor = Color.Fuchsia, TextColor = Color.Accent, BorderColor = Color.Maroon, BorderWidth = 8 });
            //calendar.SpecialDates.Add(new SpecialDate(DateTime.Now.AddDays(6)) { BackgroundColor = Color.Fuchsia, TextColor = Color.Accent, BorderColor = Color.Maroon, BorderWidth = 8 });
            //calendar.RaiseSpecialDatesChanged();

            var dates = new List<SpecialDate>();

            var specialDate = new SpecialDate(new DateTime(2018, 10, 26));
            specialDate.BackgroundColor = Color.Green;
            specialDate.TextColor = Color.White;

            dates.Add(specialDate);

            calendario.SpecialDates = new ObservableCollection<SpecialDate>(dates);
            calendario.SelectedDate = (DateTime.Now);

        }
    }
}

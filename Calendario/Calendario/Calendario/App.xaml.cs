using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms.Controls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Calendario
{
    public partial class App : Application
    {
        Calendar calendar;

        public App()
        {
            InitializeComponent();


            calendar = new Calendar
            {
                MaxDate = DateTime.Now.AddDays(30),
                MinDate = DateTime.Now.AddDays(-1),
                //DisableDatesLimitToMaxMinRange = true,
                MultiSelectDates = false,
                DisableAllDates = false,
                WeekdaysShow = true,
                ShowNumberOfWeek = true,
                //BorderWidth = 1,
                //BorderColor = Color.Transparent,
                //OuterBorderWidth = 0,
                //SelectedBorderWidth = 1,
                ShowNumOfMonths = 1,
                EnableTitleMonthYearView = true,
                WeekdaysTextColor = Color.Teal,
                StartDay = DayOfWeek.Monday,
                SelectedTextColor = Color.Fuchsia,
                SpecialDates = new List<SpecialDate>{
                    new SpecialDate(DateTime.Now.AddDays(2)) { BackgroundColor = Color.Green, TextColor = Color.Accent, BorderColor = Color.Lime, BorderWidth=8, Selectable = true },
                    new SpecialDate(DateTime.Now.AddDays(3))
                    {
                        BackgroundColor = Color.Green,
                        TextColor = Color.Blue,
                        Selectable = true,
                        BackgroundPattern = new BackgroundPattern(1)
                        {
                            Pattern = new List<Pattern>
                            {
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Yellow,Text = "Test", TextColor=Color.DarkBlue, TextSize=11, TextAlign=TextAlign.LeftTop},
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Red},
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Purple},
                                //new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Green},
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Green, },
                            }
                        }
                    },
                    new SpecialDate(new DateTime(2018, 10, 20))
                    {
                        Selectable = true,
                        TextColor = Color.Transparent,
                        BackgroundImage = FileImageSource.FromFile("dcalendario.png") as FileImageSource,
                        BackgroundColor = Color.Blue,
                        BackgroundPattern = new BackgroundPattern(2)
                        {
                            
                            Pattern = new List<Pattern>
                            {
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.75f, Color = Color.Yellow,Text = "Test", TextColor=Color.DarkBlue, TextSize=11, TextAlign=TextAlign.LeftTop},                                
                            }
                        }

                    },
                    new SpecialDate(new DateTime(2018, 10, 27))
                    {
                        Selectable = true,
                        TextColor = Color.Transparent,
                        BackgroundImage = FileImageSource.FromFile("dcalendario.png") as FileImageSource,
                        BackgroundColor = Color.Blue                        
                    }
                }
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                BackgroundColor = Color.White,
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, Device.RuntimePlatform == Device.iOS ? 25 : 5, 5, 5),
                        Children = {
                            calendar//,c2
						}
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

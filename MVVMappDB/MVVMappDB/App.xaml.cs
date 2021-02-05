using System;
using System.IO;
using Xamarin.Forms;

namespace MVVMappDB
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends2.db";
        public static FriendAsyncRepository database;
        public static FriendAsyncRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FriendAsyncRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
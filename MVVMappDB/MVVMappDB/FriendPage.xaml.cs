using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMappDB
{
    public partial class FriendPage : ContentPage
    {
        public FriendPage()
        {
            InitializeComponent();
        }
        private async void SaveFriend(object sender, EventArgs e)
        {
            var friend = (Friend)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                await App.Database.SaveItemAsync(friend);
            }
            await this.Navigation.PopAsync();
        }
        private async void DeleteFriend(object sender, EventArgs e)
        {
            var friend = (Friend)BindingContext;
            await App.Database.DeleteItemAsync(friend);
            await this.Navigation.PopAsync();
        }
        private async void Cancel(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}
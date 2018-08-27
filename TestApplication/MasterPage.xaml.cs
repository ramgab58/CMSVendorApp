using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApplication
{
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
           InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            //Master = new MasterPage();
            IsPresented = false;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Awesome Title", "Displaying awesome alert!", "Cancel");
        }
    }
}

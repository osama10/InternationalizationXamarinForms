using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internationalization.Internationalization;
using Xamarin.Forms;

namespace Internationalization.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            lb_Name.Text = AppResources.Name + ": ";
            lb_Password.Text = AppResources.Password + ": ";
        }

        void OnLangSelected(Object sender , EventArgs args)
        {
            var item = (Picker)sender;

            if(item.SelectedIndex == 1)
            {
                lb_Name.Text = AppResources.Name_fr;
                lb_Password.Text = AppResources.Password_fr;
            }
            else if (item.SelectedIndex == 2)
            {
                lb_Name.Text = AppResources.Name_es;
                lb_Password.Text = AppResources.Password_es;
            }
            else
            {
                lb_Name.Text = AppResources.Name;
                lb_Password.Text = AppResources.Password;
            }
        }
    }
}

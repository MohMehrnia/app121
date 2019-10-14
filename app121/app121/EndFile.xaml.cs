using app121.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app121
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EndFile : ContentPage
    {
        public IList<CardInfo> CardsInfo { get; private set; }
        public EndFile()
        {
            InitializeComponent();

            CardsInfo = new List<CardInfo>();
            CardsInfo.Add(new CardInfo() { Reason = "ترکیدن لوله", Status = "خاتمه یافته", Address = "بلوار گلستان" });
            CardsInfo.Add(new CardInfo() { Reason = "خرابی کنتور", Status = "خاتمه یافته", Address = "بلوار گلستان" });
            CardsInfo.Add(new CardInfo() { Reason = "نشت لوله آب", Status = "خاتمه یافته", Address = "بلوار گلستان" });
            CardsInfo.Add(new CardInfo() { Reason = "نشست فاضلاب", Status = "خاتمه یافته", Address = "بلوار گلستان" });

            BindingContext = this;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CardInfo selectedItem = e.SelectedItem as CardInfo;
            CardDetails details = new CardDetails();
            await Navigation.PushModalAsync(details);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CardInfo tappedItem = e.Item as CardInfo;
        }
    }
}
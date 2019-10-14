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
    public partial class CurrentFile : ContentPage
    {
        public IList<CardInfo> CardsInfo { get; private set; }
        public CurrentFile()
        {
            InitializeComponent();
            CardsInfo = new List<CardInfo>();
            CardsInfo.Add(new CardInfo() { Reason = "ترکیدن لوله", Status = "در دست بررسی", Address = "بلوار گلستان - خیابان اسفند - مجتمع پارس 1" });
            CardsInfo.Add(new CardInfo() { Reason = "خرابی کنتور", Status = "در دست بررسی", Address = "بلوار گلستان" });
            CardsInfo.Add(new CardInfo() { Reason = "نشت لوله آب", Status = "در دست بررسی", Address = "بلوار گلستان" });
            CardsInfo.Add(new CardInfo() { Reason = "نشست فاضلاب", Status = "در دست بررسی", Address = "بلوار گلستان" });

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
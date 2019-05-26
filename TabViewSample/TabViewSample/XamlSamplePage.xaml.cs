using System;
using System.Collections.Generic;
using Xam.Plugin.TabView;
using Xamarin.Forms;

namespace TabViewSample
{
    public partial class XamlSamplePage : ContentPage
    {
        TabViewControl tabView1 = null;
        public XamlSamplePage()
        {
            InitializeComponent();

             tabView1 = new TabViewControl();
            tabView1.HorizontalOptions = LayoutOptions.FillAndExpand;
            tabView1.VerticalOptions = LayoutOptions.FillAndExpand;

            TabItem tabItem = new TabItem("One", new ColorsView());
            TabItem tabItem2 = new TabItem("Two", new ColorsView());

            tabView1.ItemSource.Add(tabItem);
            tabView1.ItemSource.Add(tabItem2);

            this.Content = tabView1;
        }

        async void GoBackClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            tabView1.HorizontalOptions = LayoutOptions.FillAndExpand;
            tabView1.VerticalOptions = LayoutOptions.FillAndExpand;


        }
    }
}

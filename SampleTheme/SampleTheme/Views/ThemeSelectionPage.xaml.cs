using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using Syncfusion.SfNumericTextBox.XForms;
using Syncfusion.XForms.Themes;

namespace SampleTheme
{
    public partial class ThemeSelectionPage : ContentPage
    {
        public ThemeSelectionPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
          
            if (button.Text == "Light")
            {
                var lightTheme = mergedDictionaries.OfType<LightTheme>().FirstOrDefault();
                if (lightTheme != null)
                {
                    mergedDictionaries.Remove(lightTheme);
                }
                mergedDictionaries.Add(new DarkTheme());

                button.Text = "Dark";
            }
            else
            {
                var darkTheme = mergedDictionaries.OfType<DarkTheme>().FirstOrDefault();
                if (darkTheme != null)
                {
                    mergedDictionaries.Remove(darkTheme);
                }
                mergedDictionaries.Add(new LightTheme());
               
                button.Text = "Light";
            }
        }
    }

}

using Movies.Models;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace Movies.Converters
{
    public class MenuItemTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var menuItemType = (MenuItemType)value;

            switch (menuItemType)
            {
                case MenuItemType.Settings:
                    if (Device.RuntimePlatform == Device.GTK || Device.RuntimePlatform == Device.WPF)
                        return "Images/movies-settings.png";
                    else if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/movies-settings.png";
                    else if (Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS)
                        return "movies_settings";
                    else
                        return string.Empty;
                default:
                    return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
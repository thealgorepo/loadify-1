﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace loadify.ValueConverter
{
    public class ExistsToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool) value)
                return new BitmapImage(new Uri("pack://application:,,,/loadify;component/Resources/success_tick.png"));

            return new BitmapImage(new Uri("pack://application:,,,/loadify;component/Resources/error_cross.png"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

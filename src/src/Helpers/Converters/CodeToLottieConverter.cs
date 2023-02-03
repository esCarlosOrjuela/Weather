using System;
using System.Globalization;
using SkiaSharp.Extended.UI.Controls;

namespace src.Helpers.Converters
{
    public class CodeToLottieConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var code = (float)value;

            return code switch
            {
                0 => new SKFileLottieImageSource { File = "ani-weather-sunny.json" },
                1 => new SKFileLottieImageSource { File = "ani-weather-sunny.json" },
                2 => new SKFileLottieImageSource { File = "ani-weather-foggy.json" },
                3 => new SKFileLottieImageSource { File = "ani-weather-foggy.json" },
                45 => new SKFileLottieImageSource { File = "ani-weather-foggy.json" },
                48 => new SKFileLottieImageSource { File = "ani-weather-foggy.json" },
                51 => new SKFileLottieImageSource { File = "ani-weather-partly-shower.json" },
                53 => new SKFileLottieImageSource { File = "ani-weather-partly-shower.json" },
                55 => new SKFileLottieImageSource { File = "ani-weather-partly-shower.json" },
                56 => new SKFileLottieImageSource { File = "ani-weather-partly-shower.json" },
                57 => new SKFileLottieImageSource { File = "ani-weather-partly-shower.json" },
                61 => new SKFileLottieImageSource { File = "ani-weather-stormshowersday.json" },
                63 => new SKFileLottieImageSource { File = "ani-weather-stormshowersday.json" },
                65 => new SKFileLottieImageSource { File = "ani-weather-stormshowersday.json" },
                66 => new SKFileLottieImageSource { File = "ani-weather-snow.json" },
                67 => new SKFileLottieImageSource { File = "ani-weather-snow.json" },
                71 => new SKFileLottieImageSource { File = "ani-weather-snow.json" },
                73 => new SKFileLottieImageSource { File = "ani-weather-snow.json" },
                75 => new SKFileLottieImageSource { File = "ani-weather-snow.json" },
                77 => new SKFileLottieImageSource { File = "ani-weather-snow.json" },
                80 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                81 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                82 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                85 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                86 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                95 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                96 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                99 => new SKFileLottieImageSource { File = "ani-weather-storm.json" },
                _ => throw new NotImplementedException(),
            };

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}


using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WPF_TreeView
{
    /// <summary>
    /// Converts a full path to a specific image type of a drive, folder, or file
    /// </summary>
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = (string)value;

            if (path == null)
                return null;

            string imgName = "file.png";

            string normalizedPath = path.Replace('/', '\\');
            int lastIndex = normalizedPath.LastIndexOf('\\');

            if (lastIndex < 0 || string.IsNullOrEmpty(normalizedPath.Substring(lastIndex + 1))) //This is a drive
                imgName = "drive.png";
            else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
                imgName = "folder-closed.png";

            return new BitmapImage(new Uri($"pack://application:,,,/images/{imgName}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

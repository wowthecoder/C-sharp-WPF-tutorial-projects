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
    [ValueConversion(typeof(DirectoryItemType), typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imgName = "file.png";

            switch ((DirectoryItemType)value)
            {
                case DirectoryItemType.Drive:
                    imgName = "drive.png";
                    break;
                case DirectoryItemType.Folder:
                    imgName = "folder-closed.png";
                    break;
            }

            return new BitmapImage(new Uri($"pack://application:,,,/images/{imgName}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

using System.Text.RegularExpressions;

namespace ShortcutMaker
{
    public class Settings
     {
        public static int ShortcutButtonControl_Size { get; set; }
        public static bool isDarkMode { get; set; }

        #region GetIcons
        public static Bitmap AddIcon { 
            get 
            { 
                return isDarkMode ? ResourceTemp.addIcon : ResourceTemp.addIcon_Black;
            }
        }
        public static Bitmap SaveIcon
        {
            get
            {
                return isDarkMode ? ResourceTemp.saveIcon : ResourceTemp.saveIcon_Black;
            }
        }
        public static Bitmap EditIcon
        {
            get
            {
                return isDarkMode ? ResourceTemp.editIcon : ResourceTemp.editIcon_Black;
            }
        }
        public static Bitmap OptionsIcon
        {
            get
            {
                return isDarkMode ? ResourceTemp.optionsIcon : ResourceTemp.optionsIcon_Black;
            }
        }
        public static Bitmap PadlockOpen
        {
            get
            {
                return isDarkMode ? ResourceTemp.padlockOpen : ResourceTemp.padlockOpen_Black;
            }
        }
        public static Bitmap PadlockClose
        {
            get
            {
                return isDarkMode ? ResourceTemp.padlockClose : ResourceTemp.padlockClose_Black;
            }
        }
        public static Bitmap ReturnIcon
        {
            get
            {
                return isDarkMode ? ResourceTemp.returnIcon : ResourceTemp.returnIcon_Black;
            }
        }
        #endregion

        public static string GenerateCFGFileFromDictionary(Dictionary<string[], object> data)
        {
            string result = "";
            foreach (KeyValuePair<string[], object> pair in data)
            {
                string description = pair.Key[0];
                if (pair.Value == null)
                {
                    result += $"\n#### {description.ToUpper()} ####\n";
                    continue;
                }

                string name = pair.Key[1].ToLower();
                result += $"# {description}\n";
                switch (pair.Value)
                {
                    case string[]:
                        result += $"{name} = [";
                        foreach (string value in (string[])pair.Value)
                            result += value + (value.Equals(((string[])pair.Value).Last()) ? "" : ",");
                        result += "]\n";
                        break;
                    case List<string>:
                        result += $"{name} = [";
                        foreach (string value in (List<string>)pair.Value)
                            result += value + (value.Equals(((List<string>)pair.Value).Last()) ? "" : ",");
                        result += "]\n";
                        break;
                    case Color:
                        Color color = (Color)pair.Value;
                        result += $"{name} = {$"#{color.R:X2}{color.G:X2}{color.B:X2}"}\n";
                        break;
                    //string, bool, int, deciaml, short, Point, Size
                    default:
                        result += $"{name} = {pair.Value}\n";
                        break;
                }
            }
            return result;
        }

        public static Dictionary<string, object> GetDictionaryFromCFGFile(string data)
        {
            Dictionary<string, object> result = new();

            List<string> settings = data.Split('\r', '\n').ToList();
            settings.RemoveAll(x => x.StartsWith('#') || string.IsNullOrEmpty(x));

            foreach (string item in settings)
            {
                string[] values = item.Split("=", count: 2);
                string name = values[0].Replace(" ", ""), value = values[1].Replace(" ", ""); 

                switch (value)
                {
                    case string _ when Regex.IsMatch(value, @"^\d+$"): //Number
                        int.TryParse(value, out int _number);
                        result.Add(name, _number);
                        break;
                    case string _ when Regex.IsMatch(value, @"^\d+[.,]\d+?$"): //Decimal
                        decimal.TryParse(value, out decimal _decimal);
                        result.Add(name, _decimal);
                        break;
                    case string _ when Regex.IsMatch(value, @"^(?i)(true|false)$"): //bool
                        Boolean.TryParse(value, out bool _bool);
                        result.Add(name, _bool);
                        break;
                    case string _ when Regex.IsMatch(value, @"^\{Width=\d+,(\s|)Height=\d+\}$"): //Size
                        string[] size = value.Replace("{", "").Replace("}", "").Split(',', '=');
                        int.TryParse(size[1], out int width);
                        int.TryParse(size[3], out int height);
                        result.Add(name, new Size(width, height));
                        break;
                    case string _ when Regex.IsMatch(value, @"^\{X=\d+,(\s|)Y=\d+\}$"): //Point
                        string[] point = value.Replace("{", "").Replace("}", "").Split(',', '=');
                        int.TryParse(point[1], out int x);
                        int.TryParse(point[3], out int y);
                        result.Add(name, new Point(x, y));
                        break;
                    case string _ when Regex.IsMatch(value, @"^#(?:[0-9a-fA-F]{3}){1,2}$"): //Color
                        result.Add(name, (Color)new ColorConverter().ConvertFromString(value));
                        break;
                    case string _ when Regex.IsMatch(value, @"^\[([a-zA-Z0-9,]*,|[a-zA-Z0-9,]*)\]$"): //Array
                        result.Add(name, value.Replace("[", "").Replace("]", "").Split(','));
                        break;
                    default:
                        MessageBox.Show($"string... {name} |{value}|");
                        result.Add(name, value);
                        break;
                }
            }

            return result;
        }
    }
}

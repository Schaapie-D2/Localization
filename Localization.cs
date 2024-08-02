using OfficeOpenXml;

namespace Schaapie_D2.Localization
{
    public class Localization
    {
        /// <summary>
        /// Path to the Excel file to use for localization.
        /// Default is C:/startup/directory/lang.xlsx
        /// </summary>
        public static string ExcelFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lang.xlsx");
        /// <summary>
        /// The language to use.
        /// Default is English
        /// </summary>
        public static Language Language = Language.English;

        static ExcelPackage package;
        static Dictionary<Language, int> languageColumnIndexes;
        /// <summary>
        /// Initializes the Localization class. IMPORTANT: Use this AFTER ExcelFilePath is set!
        /// </summary>
        public static void Init()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            package = new ExcelPackage(new FileInfo(ExcelFilePath));
            var worksheet = package.Workbook.Worksheets[0];
            languageColumnIndexes = new Dictionary<Language, int>();
            int columns = worksheet.Dimension.Columns;

            for (int col = 1; col <= columns; col++)
            {
                string header = worksheet.Cells[1, col].Text.Trim();
                if (Enum.TryParse(header, true, out Language lang))
                {
                    languageColumnIndexes[lang] = col;
                }
            }
        }
        /// <summary>
        /// Gets the text that corresponds to the key and language.
        /// </summary>
        /// <param name="keyName">The name of the key.</param>
        /// <returns>The text from the specified key in the specified language.</returns>
        public static string Get(string keyName)
        {
            return DGet(keyName, Language);
        }
        /// <summary>
        /// Gets the text that corresponds to the key and language.
        /// </summary>
        /// <param name="keyName">The name of the key.</param>
        /// <param name="language">The language to get.</param>
        /// <returns>The text from the specified key in the specified language.</returns>
        public static string Get(string keyName, Language language)
        {
            return DGet(keyName, language);
        }

        static string DGet(string keyName, Language language)
        {
            if (!languageColumnIndexes.TryGetValue(language, out int languageColumn))
            {
                return "Language column not found";
            }

            var worksheet = package.Workbook.Worksheets[0];
            int keyColumn = 1;

            for (int row = 2; row <= worksheet.Dimension.Rows; row++)
            {
                string key = worksheet.Cells[row, keyColumn].Text.Trim();
                if (key.Equals(keyName, StringComparison.OrdinalIgnoreCase))
                {
                    return worksheet.Cells[row, languageColumn].Text.Trim();
                }
            }

            return "Key not found";
        }
        /// <summary>
        /// Disposes the Excel package. Use this when you are done using the class.
        /// </summary>
        public static void CloseExcelPackage()
        {
            if (package != null)
            {
                package.Dispose();
                package = null;
            }
        }
    }

    public enum Language
    {
        English = 0,
        Spanish = 1,
        French = 2,
        German = 3,
        Italian = 4,
        Portuguese = 5,
        Russian = 6,
        ChineseSimplified = 7,
        ChineseTraditional = 8,
        Japanese = 9,
        Korean = 10,
        Dutch = 11,
        Arabic = 12,
        Hindi = 13,
        Swedish = 14,
        Norwegian = 15,
        Danish = 16,
        Finnish = 17,
        Greek = 18,
        Turkish = 19,
        Polish = 20,
        Czech = 21,
        Hungarian = 22,
        Romanian = 23,
        Thai = 24,
        Vietnamese = 25,
        Hebrew = 26,
        Indonesian = 27,
        Malay = 28,
        Bengali = 29,
        Persian = 30,
        Ukrainian = 31,
        Bulgarian = 32,
        Croatian = 33,
        Serbian = 34,
        Slovak = 35,
        Lithuanian = 36,
        Latvian = 37,
        Estonian = 38,
        Filipino = 39,
        Swahili = 40,
        Afrikaans = 41,
        Sinhala = 42,
        Tamil = 43,
        Telugu = 44,
        Kannada = 45,
        Urdu = 46,
        Nepali = 47,
        Pashto = 48,
        Kurdish = 49,
        Azerbaijani = 50,
        Mongolian = 51,
        Armenian = 52,
        Georgian = 53,
        Belarusian = 54,
        Kazakh = 55,
        Uzbek = 56,
        Turkmen = 57,
        Kyrgyz = 58,
        Tajik = 59,
        Lao = 60,
        Burmese = 61,
        Khmer = 62,
        Amharic = 63,
        Tigrinya = 64,
        Somali = 65,
        Yiddish = 66,
        HaitianCreole = 67,
        Luxembourgish = 68,
        Maltese = 69,
        Quechua = 70,
        Guarani = 71,
        Xhosa = 72,
        Zulu = 73,
        Welsh = 74,
        Irish = 75,
        ScottishGaelic = 76,
        Basque = 77,
        Catalan = 78,
        Galician = 79,
        SerbianLatin = 80,
        SerbianCyrillic = 81,
        Montenegrin = 82,
        Bosnian = 83
    }
}
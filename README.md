# Localization
Implement localization with an Excel document.

# How to use

## Excel
Create an Excel file in the format.
| Keys  | English | Dutch  | French  |
|-------|---------|--------|---------|
| hello | Hello   | Hallo  | Bonjour |
| world | World   | Wereld | Monde   |

## Example code
```
using Schaapie_D2.Localization;

namespace Localization_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Localization.ExcelFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lang.xlsx"); // define the path to the Excel file
            Localization.Init(); // Initialize Localization. IMPORTANT: Use this AFTER the code that sets ExcelFilePath!
            Localization.Language = Language.English; // Define the language to use

            string input = Console.ReadLine(); // user writes a key name (in the Excel above: hello, world)
            string text = Localization.Get(input); // get the key in the specified language

            Console.WriteLine(text);

            Localization.CloseExcelPackage(); // Dispose the Excel package when the class is no longer in use
        }
    }
}

```

# Supported languages
| Language | Supported | Planned |
|----------|-----------|--------|
|English | Yes |
|Spanish | Yes |
|French | Yes |
|German | Yes |
|Italian | Yes |
|Portuguese | Yes |
|Russian | Yes |
|Chinese Simplified | Yes |
|Chinese Traditional | Yes |
|Japanese | Yes |
|Korean | Yes |
|Dutch | Yes |
|Arabic | Yes |
|Hindi | Yes |
|Swedish | Yes |
|Norwegian | Yes |
|Danish | Yes |
|Finnish | Yes |
|Greek | Yes |
|Turkish | Yes |
|Polish | Yes |
|Czech | Yes |
|Hungarian | Yes |
|Romanian | Yes |
|Thai | Yes |
|Vietnamese | Yes |
|Hebrew | Yes |
|Indonesian | Yes |
|Malay | Yes |
|Bengali | Yes |
|Persian | Yes |
|Ukrainian | Yes |
|Bulgarian | Yes |
|Croatian | Yes |
|Serbian | Yes |
|Slovak | Yes |
|Lithuanian | Yes |
|Latvian | Yes |
|Estonian | Yes |
|Filipino | Yes |
|Swahili | Yes |
|Afrikaans | Yes |
|Sinhala | Yes |
|Tamil | Yes |
|Telugu | Yes |
|Kannada | Yes |
|Urdu | Yes |
|Nepali | Yes |
|Pashto | Yes |
|Kurdish | Yes |
|Azerbaijani | Yes |
|Mongolian | Yes |
|Armenian | Yes |
|Georgian | Yes |
|Belarusian | Yes |
|Kazakh | Yes |
|Uzbek | Yes |
|Turkmen | Yes |
|Kyrgyz | Yes |
|Tajik | Yes |
|Lao | Yes |
|Burmese | Yes |
|Khmer | Yes |
|Amharic | Yes |
|Tigrinya | Yes |
|Somali | Yes |
|Yiddish | Yes |
|HaitianCreole | Yes |
|Luxembourgish | Yes |
|Maltese | Yes |
|Quechua | Yes |
|Guarani | Yes |
|Xhosa | Yes |
|Zulu | Yes |
|Welsh | Yes |
|Irish | Yes |
|Scottish Gaelic | Yes |
|Basque | Yes |
|Catalan | Yes |
|Galician | Yes |
|Serbian Latin | Yes |
|Serbian Cyrillic | Yes |
|Montenegrin | Yes |
|Bosnian | Yes |
|Custom Language | No | Yes |

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

class Program
{
    static void Main(string[] args)
    {
        string[] strings = InputConsoleStrings("Введите строки (через пробел)", ' ');

        PrintStringArray(strings);

        string[] shortStrings = GetStringsByMaxLength(strings, 3);

        PrintStringArray(shortStrings);
    }


    /// <summary>Метод выводит сообщение, читает строку со ввода терминала и разделяет её на несколько строк по разделителю.
    /// message - сообщение для вывода.
    /// separator - символ, который будет разделять аргументы.</summary>
    private static string[] InputConsoleStrings(string message, char separator)
    {
        // Выводит сообщение.
        Console.WriteLine(message);

        string[] inputSplitted = Console.ReadLine()!.Split(separator);

        return inputSplitted;
    }

    /// <summary>Метод создаёт массив строк, который состоит из элементов заданного массива длиной меньше или равно заданной максимальной длине строки.
    /// strings - исходный массив строк.
    /// maxLength - максимальная длина строки.</summary>
    private static string[] GetStringsByMaxLength(string[] strings, int maxLength)
    {
        // Находит длину результирующего массива.
        int shortStringsLength = 0;
        for (int i = 0; i < strings.Length; i++)
            if (strings[i].Length <= maxLength)
                shortStringsLength++;

        var shortStrings = new string[shortStringsLength];
        int count = 0;

        // Заполняет результирующий массив.
        for (int i = 0; i < shortStrings.Length; i++)
        {
            if (strings[i].Length <= maxLength)
            {
                shortStrings[count] = strings[i];
                count++;
            }
        }

        return shortStrings;
    }

    /// <summary>Метод выводит заданный массив строк в консоль через запятую, обрамляя каждый элемент кавычками.
    /// array - заданный массив.
    private static void PrintStringArray(string[] array)
    {
        string result = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            result = $"{result}, \"{array[i]}\"";
        }
        Console.WriteLine(result);
    }
}


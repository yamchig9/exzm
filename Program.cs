Console.WriteLine("Введите строки через запятую:");
string? input = Console.ReadLine();

// Разделить входную строку на подстроки по запятой
string[] inputArray = input!.Split(',');

// Удалить лишние пробелы в начале и конце каждой строки
for (int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = inputArray[i].Trim();
}

// Подсчитать количество строк, удовлетворяющих условию
int count = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

// Создать новый массив строк подходящего размера
string[] resultArray = new string[count];
int index = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        resultArray[index++] = str;
    }
}

// Вывести результат
Console.WriteLine($"Результат: {string.Join(", ", resultArray)}");

//1
Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
Console.WriteLine("Введите цифру для поиска: ");
char digitToFind = Console.ReadKey().KeyChar;
Console.WriteLine(); 

if (numberStr.Contains(digitToFind))
{
    int position = numberStr.IndexOf(digitToFind) + 1; 
    Console.WriteLine($"Yes, цифра {digitToFind} присутствует в числе на позиции {position}.");
}
else
{
    Console.WriteLine($"No, цифра {digitToFind} не присутствует в числе.");
}
Console.WriteLine();

//2
Console.WriteLine("Введите длину прямоугольника:");
string lengthInput = Console.ReadLine();

Console.WriteLine("Введите ширину прямоугольника:");
string widthInput = Console.ReadLine();

double length, width;
bool isValidLength = double.TryParse(lengthInput.Trim().Replace(".", ","), out length);
bool isValidWidth = double.TryParse(widthInput.Trim().Replace(".", ","), out width);

if (string.IsNullOrWhiteSpace(lengthInput) || string.IsNullOrWhiteSpace(widthInput))
{
    Console.WriteLine("Длина и ширина прямоугольника должны быть заданы.");
}
else if (!isValidLength || !isValidWidth)
{
    Console.WriteLine("Длина и ширина прямоугольника должны быть дробными числами.");
}
else if (length <= 0 || width <= 0)
{
    Console.WriteLine("Длина и ширина прямоугольника должны быть положительными числами.");
}
else
{
    double area = length * width;
    Console.WriteLine("Площадь прямоугольника: " + area);
}
Console.WriteLine();


//3

Console.WriteLine("Введите две стороны прямоугольника, разделенные пробелом:");
string input1 = Console.ReadLine();

string[] sides = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

if (sides.Length != 2)
{
    Console.WriteLine("введите ровно две стороны прямоугольника");
    return;
}

double side1, side2;
if (!double.TryParse(sides[0].Trim(), out side1) || !double.TryParse(sides[1].Trim(), out side2))
{
    Console.WriteLine("введите корректные числовые значения для сторон прямоугольника");
    return;
}

if (side1 <= 0 || side2 <= 0)
{
    Console.WriteLine("cтороны прямоугольника должны быть положительными числами.");
    return;
}

double S = side1 * side2;
Console.WriteLine($"Площадь прямоугольника равна: {S}");
Console.WriteLine();


//4

Console.WriteLine("Введите строку: ");
string input2 = Console.ReadLine();

// Удаление пробелов и приведение к нижнему регистру
string cleanedInput = input2.Replace(" ", "").ToLower();


// Проверка на палиндром
bool isPalindrome = cleanedInput.SequenceEqual(cleanedInput.Reverse());

if (isPalindrome)
{
    Console.WriteLine("Введенная строка является палиндромом без учета пробелов.");
}
else
{
    Console.WriteLine("Введенная строка не является палиндромом без учета пробелов.");
}
Console.WriteLine();


//5 

Console.WriteLine("Введите зашифрованную строку: ");
string cipherText = Console.ReadLine().ToLower(); // Преобразуем в нижний регистр
Console.WriteLine("Введите сдвиг (K): ");
int shift = int.Parse(Console.ReadLine());

string alphabet = "абвгдежзиклмнопрстуфхцчшщыьэюя";
string decryptedText = "";

int i = 0;
while (i < cipherText.Length)
{
    char letter = cipherText[i];

    if (alphabet.Contains(letter.ToString()))
    {
        int index = alphabet.IndexOf(letter);
        int newIndex = (index - shift + alphabet.Length) % alphabet.Length;
        decryptedText += alphabet[newIndex];
    }
    else
    {
        decryptedText += letter; 
    }

    i += 1; 
}

Console.WriteLine("Расшифрованный текст: " + decryptedText);
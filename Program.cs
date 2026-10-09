string sub = "Программирование";
foreach (char letter in sub)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"Кол-во букв: {sub.Length}");

//2
int[] grades = { 4, 5, 3, 5, 4 };
int o = 0;
foreach (int grade in grades)
{
    Console.WriteLine(grade);
    o += grade;
}
double av = (double)o / grades.Length;
Console.WriteLine($"Средний балл: {o}");
Console.WriteLine($"Сумма оценок: {av}");

//3
string[] students = { "Аня", "Ярослав", "Вика" };
int count = 0;
foreach (string student in students)
{
    count++;
    Console.WriteLine($"{count}.{student}");
}

//4
int[] points = { 10, 20, 15 };

for (int point =0; point< points.Length; point++)
{
    points[point] = points[point] + 5;
}
foreach (int p in points)
{
    Console.WriteLine(p);
}
//5
string[] studentss = { "Аня", "Борис", "Вика" };
int number = 1;

foreach (string studeent in studentss)
{
    Console.WriteLine($"{number}.{studeent}");
    number++;
}
//самостоятельные
//A
int[] num = { 5, 12, 8, 20, 3 };
int s = 0;

Console.WriteLine("Элементы массива:");
foreach (int n in num)
{
    Console.WriteLine(n);
    s += n;
}
Console.WriteLine($"Сумма всех чисел: {s}");
//Б
string[] dayweek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

foreach (string day in dayweek)
{
    Console.WriteLine($"{day}!");
}

//6
int[] j = { 130, 240, 85, 300, 500 };
int maxd = j[0];
int mind = j[0];

foreach (int c in j)
{
    if (c > maxd)
    {
        maxd = c;
    }
    if (c < mind)
    {
        mind = c;
    }
}
Console.WriteLine($"Макс. количество очков:{maxd}");
Console.WriteLine($"Мин.количество очков:{mind}");
//7
int[] g = { 4, 5, 3, 5, 5, 2, 4, 5 };
int q = 0;

foreach (int w in g)
{
    if (w == 5)
    {
        q++;
    }
}
Console.WriteLine($"Количество оценок, равных 5: {q}");
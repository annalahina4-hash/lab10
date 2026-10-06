string sub = "Программирование";
foreach (char letter in sub)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"Кол-во букв: {sub.Length}");

//2
int[] grades = { 4, 5, 3, 5, 4 };
int o = 0;
int count = 0;
foreach (int grade in grades)
{
    o += grade;
    count++;
    Console.WriteLine(grade);
}
Console.WriteLine($"Средний балл: {(double)o / count}");
Console.WriteLine($"сумма: {o}");

//3
string[] students = { "Аня", "Ярослав", "Вика" };

foreach (string student in students)
{
    Console.WriteLine(student);
}


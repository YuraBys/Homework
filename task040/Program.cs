// Задача 40. Напишите программу которая на вход принимает 3 числа
// и проверяет, может ли сущ тругольник со сторонами такой длины.
// Теорема о нерав треуг: каждая сторона меньше суммы 2-х других

int a;
int b;
int c;
bool able;
string answer;

Console.WriteLine("ВВедите первую сторону треугольника A: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите вторую сторону треугольника B: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите третью сторону треугольника C: ");
c = Convert.ToInt32(Console.ReadLine());

able = CheckAbilityTriacl(a, b, c);
answer = ShowAnswer(able);
Console.WriteLine($"{answer}");

bool CheckAbilityTriacl(int a, int b, int c)
{
    if(a < (b + c) && b < (a + c) && c < (a + b))
    {
        return true;
    }
    else
    {
        return false;
    }
}

string ShowAnswer(bool ability)
{
    if(ability){
        return "Треугольник возможен";
    }
    else{
        return "Треугольник не возможен";
    }
}
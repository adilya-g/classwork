string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
int course = int.Parse(Console.ReadLine());
string groupNum = Console.ReadLine();
bool hasHomePet = 50 > age;

Console.WriteLine("Анкета студента");
Console.WriteLine("Вас зовут: "+name);
Console.WriteLine("Ваш возраст: " + age);
Console.WriteLine("Ваш курс: " + course);
Console.WriteLine("Номер группы: " + groupNum);
Console.WriteLine("Питомец: " + hasHomePet);


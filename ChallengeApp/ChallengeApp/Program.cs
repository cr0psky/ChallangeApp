var name = "Ewa";
char myVar1 = 'K';
var age = 33;

if (myVar1 == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (myVar1 != 'K' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (age > 33)
{
    Console.WriteLine("Pozostałe osoby");
}
// Zadanie domowe dzień 4
var name = "Ewa";
bool female = true;
var age = 33;
if (age < 30 && female)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && !female)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Kto inny");
}
using Microsoft.VisualBasic;
//k - kobieta, m - męzczyzna

string name = "Ewa";
string gender = "k";
var age = 33;
string nationality = "Polka";

if (age < 30 && gender == "k")
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (gender != "k" && age < 18)
{
    Console.WriteLine("Niepełnoletni męzczyzna");
}
else if (name == "Ewa" && nationality == "Polka")
{
    Console.WriteLine ("Ewa jest Polką.");
}
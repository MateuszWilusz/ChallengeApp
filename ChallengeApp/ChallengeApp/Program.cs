﻿using System.ComponentModel.Design;

string name = "Ewa";
int age = 33;
var sex = "kobieta";

if (sex != "kobieta.") ;

if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
else
{
    Console.WriteLine("Pełnoletni mężczyzna.");
}
if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (age > 30)
{
    Console.WriteLine("Kobieta powyżej lat 30.");
}
else if (age == 30)
{
    Console.WriteLine("Kobieta lat 30.");
}
else if (age < 18)
{
    Console.WriteLine("Kobieta poniżej lat 30.");
}
else
{
    Console.WriteLine("Niepełnoletnia kobieta.");
}
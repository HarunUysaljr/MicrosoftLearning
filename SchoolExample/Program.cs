
using System;


int totalQuizz = 3;

int harun1 = 70;
int harun2 = 80;
int harun3 = 40;

int Ahmet1 = 70;
int Ahmet2 = 12;
int Ahmet3 = 70;

//Basicexample01


decimal harunNote = (harun1 + harun2 + harun3) / totalQuizz;
decimal ahmetNote = (Ahmet1 + Ahmet2 + Ahmet3) / totalQuizz;



Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Harun:\t\t" + harunNote + "\tA-");
Console.WriteLine("Ahmet:\t\t" + ahmetNote + "\tB+");
;

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();





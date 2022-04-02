using System;

// LAB 2 ASSIGNMENT

bool logic = true;
char letter = 'r';
double real = 5.26;
int num = 4;
long numl = 4000000;
string name = "david";
uint unum = 3456;
ulong unuml = 3263265;

//implicit typecasting
float ireal = 3;

//explicit typecasting
int ereal = (int)4.55;
int enumb = Int32.Parse("34");
decimal dec = 5.67M;
float reals = 3.146F;

Console.WriteLine(logic);
Console.WriteLine(letter);
Console.WriteLine(real);
Console.WriteLine(num);
Console.WriteLine(numl);
Console.WriteLine(name);
Console.WriteLine(unum);
Console.WriteLine(unuml);

Console.WriteLine("Below are examples of implicit type casting");
Console.WriteLine(ireal);

Console.WriteLine("Below are examples of explicit type casting");
Console.WriteLine(ereal);
Console.WriteLine(dec);
Console.WriteLine(reals);

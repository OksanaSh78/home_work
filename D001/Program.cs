/* Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
 int a = 5; b = 7 -> max=7
 int a = 2; b = 107 -> max=10
 int a = -9; b = -3 -> max=-3 
*/

int a = 5;
int b = 7;
int max = a;

if(a > max) max = a;
if(b > max) max = b;


Console.Write("max = ");
Console.WriteLine(max);

int c = 2;
int d = 10;
int max1 = c;

if(c > max1) max1 = c;
if(d > max1) max1 = d;


Console.Write("max1 = ");
Console.WriteLine(max1);

int e = -9;
int f = -3;
int max2 = e;

if(e > max2) max2 = e;
if(f > max2) max2 = f;


Console.Write("max2 = ");
Console.WriteLine(max2);
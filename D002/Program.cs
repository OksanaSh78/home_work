/* Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел int a = 5; b = 7 -> max=7
 int a = 2; b = 3; p = 7
 int d = 44; e = 5; f = 78
 int h = 22; j = 3; k = 9
*/

int a = 2;
int b = 3;
int p = 7;
int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(p > max) max = p;

Console.Write("max = ");
Console.WriteLine(max);

int d = 44;
int e = 5;
int f = 78;
int max1 = d;

if(d > max1) max1 = d;
if(e > max1) max1 = e;
if(f > max1) max1 = f;

Console.Write("max1 = ");
Console.WriteLine(max1);

int h = 22;
int j = 3;
int k = 9;
int max2 = h;

if(h > max2) max2 = h;
if(j > max2) max2 = j;
if(k > max2) max2 = k;


Console.Write("max2 = ");
Console.WriteLine(max2);

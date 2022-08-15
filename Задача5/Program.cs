// Инкременты

int a = 7;
int b = 4;
int c = 25;
a++;
int sum = a++ + ++b + ++c;
b++;
++c;
int sum2 = a + ++b + c++ + a;
Console.WriteLine($"{sum} - {sum2}");

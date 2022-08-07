int a = 0;
int b = 0;
while(a == b) {
  a = new Random().Next(1, 10);
  b = new Random().Next(1, 10);
}
Console.WriteLine("Первое число: " + a);
Console.WriteLine("Второе число: " + b);
if(a > b){
    Console.Write ("большее число: " + a);
}else{
    Console.Write("большее число: " + b);
}
int n = new Random().Next(1, 33);
Console.WriteLine("N = " + n);
for(int i = 0; i < n; i++){
    if(i%2 == 0){
        Console.Write(i + ", ");
    }
}

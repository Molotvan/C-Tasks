
int max = 0;
int[] randoms = {new Random().Next(1, 100), new Random().Next(1, 100), new Random().Next(1, 100)};

for(int i = 0; i < randoms.Length; i++){
    if (randoms[i] > max){
        max = randoms[i];
    }
}

Console.Write("Имеем числа: " );
for(int i = 0; i < randoms.Length; i++){
    Console.Write(randoms[i] + " ");   
}

Console.WriteLine("Большее число: " + max);
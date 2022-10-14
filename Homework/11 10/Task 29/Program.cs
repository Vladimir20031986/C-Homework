Console.Clear();
int[] Array = new int[8];
void ArrRandom(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
    {
    int num = new Random().Next(0,1000);
    arr[i] = num;
    Console.Write(arr[i] + " ");
    }
}
ArrRandom(Array);

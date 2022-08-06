int primeNumber(int num)
{
    int flag = 0;

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            flag = 1;
            break;
        }
        else
        {
            flag = 0;
        }
    }
    return flag;
}




int valToSend=0;
int count = 0;
int tof;



Console.WriteLine("This program will print out all prime numbers between 1 and the number you wish.");
Console.WriteLine("Please enter the max number:");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[maxNum];
int[] primeNum = new int[maxNum];

for (int j=0; j< maxNum; j++)
{
    array[j] = j+1;
}

for (int i=0; i< maxNum; i++)
{
    valToSend = array[i];
    tof = primeNumber(valToSend);
    if(tof == 0)
    {
        count++;
        primeNum[i] = array[i];
    }

}

Console.WriteLine("\nPrime Numbers:");
foreach (int item in primeNum)
{   if(item!=0)
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine("\nTotal Number of Prime Numbers:  {0}", count);

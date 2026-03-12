//1-25 arasi ozleride daxil olmaqla tam adedlerin kvadratlari cemi
static void IntPowSum()
{
    int sum = 0;
    for(int i=1; i<=25; i++)
    {
        sum += i * i;
    }
    Console.WriteLine(sum);
}
//IntPowSum();



//1 array teyin ederik burada murekkeb ededlerin cemini tapiriq
//FindSumComposite(3, 8, 13, 18, 21);
static void FindSumComposite(params int[] arr)
{
    int compositeSum = 0;
    int divideCount=0;
    for (int i=0; i < arr.Length; i++)
    {
        divideCount = 0;
        for (int j=1; j <= arr[i]; j++)
        {
            if(arr[i] % j==0)
            {
                divideCount++;
            }
        }
        if (divideCount > 2)
        {
            compositeSum += arr[i];
        }
    }
    Console.WriteLine(compositeSum);
}



// paramsa methoda 10 elementden ibaret array gonderib,methodda en kicik elementi nechenci element oldugunu tapib gosterecik
//FindSmallest(11, 2, 3, 4, 5, 6, 1, 8, 9, 10);
static void FindSmallest(params int[] arr)
{
    int smallest = arr[0];
    int indexSmallest = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i] < smallest)
        {
            smallest = arr[i];
            indexSmallest= i;
        }
    }
    Console.WriteLine($"the smallest number is: {smallest}, and it's index is: {indexSmallest}");
}



// verilen sozdeki sait herflerin sayini tapan method
GetSaitCount(Console.ReadLine());
static void GetSaitCount(string soz)
{
    char[] saitler = ['a', 'i', 'o', 'u', 'e'];
    int saitCount = 0;
    for (int i = 0; i < soz.Length; i++)
    {
        for (int j = 0; j < saitler.Length; j++) 
        {
            if (soz[i] == saitler[j])
            {
                saitCount++;
            }
        }
    }
    Console.WriteLine(saitCount);
}
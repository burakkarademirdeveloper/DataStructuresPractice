

using SortingAlgorithms;

Console.WriteLine("Sıralamak istediğiniz diziyi kendiniz belirlemelisiniz.");
Console.WriteLine("Diziniz kaç elemanlı olsun?");
int arrayCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayCount];
Console.WriteLine("Dizinizin elemanlarını giriniz.");
for (int i = 0; i < arrayCount; i++)
{
    Console.WriteLine((i+1)+". elemanı giriniz.");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Hangi algoritma ile sıralamak istiyorsunuz?");
Console.WriteLine("1- Bubble Sort");
Console.WriteLine("2- Insertion Sort");
Console.WriteLine("3- Merge Sort");
Console.WriteLine("4- Quick Sort");
Console.WriteLine("5- Selection Sort");
int algorithm = Convert.ToInt32(Console.ReadLine());
switch (algorithm)
{
    case 1:
        BubbleSort.Sort(array);
        Console.WriteLine("Bubble sort ile sıralanmış diziniz:");
        for (int i = 0; i < arrayCount; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        break;
    case 2:
        InsertionSort.Sort(array);
        Console.WriteLine("Insertion sort ile sıralanmış diziniz:");
        for (int i = 0; i < arrayCount; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        break;
    case 3:
        MergeSort.Sort(array);
        Console.WriteLine("Merge sort ile sıralanmış diziniz:");
        for (int i = 0; i < arrayCount; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        break;
    case 4:
        Quicksort.Sort(array);
        Console.WriteLine("Quick sort ile sıralanmış diziniz:");
        for (int i = 0; i < arrayCount; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        break;
    case 5:
        SelectionSort.Sort(array);
        Console.WriteLine("Selection sort ile sıralanmış diziniz:");
        for (int i = 0; i < arrayCount; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Hatalı seçim yaptınız.");
        break;
}



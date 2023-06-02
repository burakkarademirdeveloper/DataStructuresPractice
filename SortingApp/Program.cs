

using System.Data.SQLite;
using SortingAlgorithms;

string connectionString = "Data Source=C:/SQLite/Employee.db;Version=3;";
List<double> values = new List<double>();

using (SQLiteConnection connection = new SQLiteConnection(connectionString))
{
    connection.Open();

    string sql = "SELECT * FROM Employees";

    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
    {
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                double value;
                if (Double.TryParse(reader["Salary"].ToString(), out value))
                {
                    values.Add(value);
                }
            }
        }
    }
}

Console.WriteLine("Hangi algoritma ile sıralamak istersiniz?");
Console.WriteLine("1- Bubble Sort");
Console.WriteLine("2- Insertion Sort");
Console.WriteLine("3- Merge Sort");
Console.WriteLine("4- Quick Sort");
Console.WriteLine("5- Selection Sort");
int algorithm = Convert.ToInt32(Console.ReadLine());
switch (algorithm)
{
    case 1:
        double[] sortedValues = values.ToArray();
        BubbleSort.Sort(sortedValues);
        Console.WriteLine("Bubble sort ile sıralanmış diziniz:");
        foreach (double value in sortedValues)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        break;
    case 2:
        double[] sortedValues1 = values.ToArray();
        InsertionSort.Sort(sortedValues1);
        Console.WriteLine("Insertion sort ile sıralanmış diziniz:");
        foreach (double value in sortedValues1)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        break;
    case 3:
        double[] sortedValues2 = values.ToArray();
        MergeSort.Sort(sortedValues2);
        Console.WriteLine("Merge sort ile sıralanmış diziniz:");
        foreach (double value in sortedValues2)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        break;
    case 4:
        double[] sortedValues3 = values.ToArray();
        Quicksort.Sort(sortedValues3);
        Console.WriteLine("Quick sort ile sıralanmış diziniz:");
        foreach (double value in sortedValues3)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        break;
    case 5:
        double[] sortedValues4 = values.ToArray();
        SelectionSort.Sort(sortedValues4);
        Console.WriteLine("Selection sort ile sıralanmış diziniz:");
        foreach (double value in sortedValues4)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Hatalı seçim yaptınız.");
        break;
}




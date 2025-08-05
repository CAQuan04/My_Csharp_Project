//int[] months = new int[12];

//for (int i= 0; i<12;i++)
//{
//    months[i] = i+1;
//}

//foreach (int month in months)
//{
//    Console.WriteLine(month);
//}

string[,] names = new string[3, 2];//Initialize a 2D array with 3 rows and 2 columns
names[0, 0] = "A";
names[0, 1] = "B";
names[1, 0] = "C";
names[1, 1] = "D";
names[2, 0] = "E";
names[2, 1] = "F";

for (int i = 0;  i < 3;  i++)// Loop through each row
{
    for(int j = 0; j <2; j++)// Loop through each column
    {
               Console.Write(names[i, j]);
        if(j==1)
        {
            Console.WriteLine(); // Print a new line after each row
        }
    }
}

Console.ReadKey();
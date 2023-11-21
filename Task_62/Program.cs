// int[,] GetSpiral(int n)
//         {
//             int[,] result = new int[n, n];
//             for (int current= 1, intermediate = 0; intermediate < n/2; intermediate++)
//             {
//                 for (int j = intermediate; j < n - intermediate; j++)
//                     result[intermediate, j] = current;
//                 for (int j = intermediate; j < n - intermediate; j++)
//                     result[n - intermediate - 1, j] = current;
//                 for (int i = intermediate + 2; i < n - intermediate - 1; i++)
//                     result[i, intermediate] = current;
//                 for (int i = intermediate + 1; i < n - intermediate- 1; i++)
//                     result[i, n - intermediate - 1] = current;
//                 current = 1 - current;
//                 result[intermediate+ 1, intermediate] = current;
//             }
//             if (n%2 != 0 && result[0, 0] == 1)
//                 result[n/2, n/2] = 1;
//             return result;
//         }


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] spiralMatrix= new int[n,n];
Main(spiralMatrix,n);
PrintArray(spiralMatrix);
Console.ReadKey();


    void Main(int[,] args,int n) {
        int row = n, col = n;
        int[,] array = new int[row,col];
        int minRow = 0, maxRow = row - 1, minCol = 0, maxCol = col - 1;
        int count = 1;
        int max = row * col;
        while (count < max) {
            for (int i = minCol; i <= maxCol; i++) {
                array[minRow,i] = count;
                count++;
            }
            minRow = minRow + 1;
            for (int i = minRow; i <= maxRow; i++) {
                array[i,maxCol] = count;
                count++;
            }
            maxCol = maxCol - 1;
            for (int i = maxCol; i >= minCol; i--) {
                array[maxRow,i] = count;
                count++;
            }
            maxRow = maxRow - 1;
            for (int i = maxRow; i >= minRow; i--) {
                array[i,minCol] = count;
                count++;
            }
            minCol = minCol + 1;
        }
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                Console.Write($"[{array[i,j]}]");
            }
            Console.WriteLine("");
        }
        Console.ReadKey();
    
    }
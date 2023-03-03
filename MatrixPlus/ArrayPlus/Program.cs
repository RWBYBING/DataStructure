
namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            const int ROW = 3, COL = 3;
            int[,] A = {
                    {1, 3, 5},
                    {7, 9, 11},
                    {13, 15, 17}
                    };
            int[,] B = {
                    {9, 8, 7},
                    {6, 5, 4},
                    {3, 2, 1}
                    };
            int[,] C = new int[ROW, COL];
            MatrixPlus(A, B, 3, 3, ref C);
            for(i = 0;i < 3; i++)
            {
                for(j = 0;j < 3; j++)
                {
                    Console.Write(C[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

       /* dimX:矩阵的X轴维度 *
        * dimY:矩阵的Y轴维度 */
         static public void MatrixPlus(int[,] arr1, int[,] arr2, int dimX, int dimY, ref int[,] arr3)
        {
            int row, col;
            if (dimX <= 0 || dimY <= 0)
            {
                Console.WriteLine("矩阵的维数必须大于等于1");
                return;
            }
            for (row = 0; row < dimX; row++)
            {
                for (col = 0; col < dimY; col++)
                {
                    arr3[row, col] = arr1[row, col] + arr2[row, col];
                }
            }
        }
    }
}
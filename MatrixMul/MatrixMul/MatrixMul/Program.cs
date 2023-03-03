/* M,N,P为矩阵维数 */
static void MatrixMul(int[,] arr1, int[,] arr2, int[,] arr3, int M, int N, int P)
{
    int i, j, k, temp;
    if (M <= 0 || N <= 0 || P <= 0)
    {
        Console.WriteLine("维数必须大于0");
    }
    for(i = 0; i < M; i++)
    {
        for(j = 0; j < P; j++)
        {
            temp = 0;
            for(k = 0; k < N; k++)
            {
                temp += arr1[i, k] * arr2[k, j];
            }
            arr3[i, j] = temp;
        }
    }
}
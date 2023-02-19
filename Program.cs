//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
int[,] CreateRandomArray()
    {
        Console.WriteLine("Input quantity rows = ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity columns = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input maxValue = ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input minValue = ");
        int minValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
        for(int i = 0; i<rows; i++)
            for(int j = 0; j<columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue);
        return array;
    }
void ShowArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
        {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
  }
int[] PositionMinElemeentArray(int[,] array)
{
    int imin = 0;
    int jmin = 0;
    for(int i =0; i<array.GetLength(0); i++)
        for(int j = 0; j<array.GetLength(1); j++)
            if(array[i,j]<array[imin, jmin])
            {
                jmin = j;
                imin = i;
            }
    int[] pos = {imin, jmin};
    return pos;
}

int[,] DeleteRowColumnMinElement(int[,] array, int[] pos)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0, x = 0; i<array.GetLength(0); i++)
    {
        if(i != pos[0])
        {
            for(int j = 0, y = 0; j<array.GetLength(1); j++)
            {
                if(j != pos[1])
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }  
            }
            x++;
        }        
    }
    return newArray;
} 

int[,] newArray = CreateRandomArray();
ShowArray(newArray);
int[] pos = PositionMinElemeentArray(newArray);
int[,] matrix = DeleteRowColumnMinElement(newArray, pos);
ShowArray(matrix);


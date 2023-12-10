using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DolgushinVA.Sprint6.Task7.V15.Lib
{
    public class DataService : ISprint6Task7V15
    {
        public int[,] GetMatrix(string path)
        {
            string[] str = File.ReadAllLines(path);
            int rows = str[0].Split(';').Length;
            int columns = str.Length;
            int[,] matrix = new int[rows, columns];
            for (int r = 0; r < str.Length; r++)
            {
                string strIndexI = str[r];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < str.Length; c++)
                {
                    matrix[r, c] = Convert.ToInt32(strArr[c]);
                }
            }
            int row = matrix.GetLength(0);
            int colum = matrix.GetLength(1);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < colum; c++)
                {
                    if ((c == 7) && (matrix[r, c] < 10) && (matrix[r, c] % 3 == 0) && (matrix[r, c] != 0))
                    {
                        matrix[r, c] = 3;
                    }
                }
            }
            return matrix;
        }
    }
}

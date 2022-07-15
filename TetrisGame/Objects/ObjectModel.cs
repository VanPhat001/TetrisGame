using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame.Objects
{
    public class ObjectModel
    {
        private readonly List<bool[,]> _objectRotateList;

        public bool[,] this[int rotateIndex] => _objectRotateList[rotateIndex];

        public int RotateCount => _objectRotateList.Count;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isObject"></param>
        public ObjectModel(bool[,] isObject)
        {
            _objectRotateList = new List<bool[,]>();
            _objectRotateList.Add(isObject);

            for (int i = 0; i < 3; i++)
            {
                if (!Rotate90(_objectRotateList[i]))
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private bool CheckSame(bool[,] a, bool[,] b)
        {
            int rows = -1;
            int cols = -1;
            if ((cols = GetCols(a)) == GetCols(b) && (rows = GetRows(a)) == GetRows(b))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (a[i, j] != b[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isObject"></param>
        /// <returns></returns>
        private bool Rotate90(bool[,] isObject)
        {
            int rows = GetRows(isObject);
            int cols = GetCols(isObject);

            bool[,] newObject = new bool[cols, rows];

            for (int y = 0; y < cols; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    newObject[y, x] = isObject[rows - x - 1, y];
                }
            }

            for (int i = 0; i < RotateCount; i++)
            {
                if (CheckSame(_objectRotateList[i], newObject))
                {
                    return false;
                }
            }

            _objectRotateList.Add(newObject);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object"></param>
        /// <returns></returns>
        public static int GetRows<T>(T[,] @object)
        {
            return @object.GetLength(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object"></param>
        /// <returns></returns>
        public static int GetCols<T>(T[,] @object)
        {
            return @object.GetLength(1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rotateIndex"></param>
        /// <returns></returns>
        public bool[,] GetModelRotateIndex(int rotateIndex)
        {
            return this[rotateIndex];
        }
    }
}

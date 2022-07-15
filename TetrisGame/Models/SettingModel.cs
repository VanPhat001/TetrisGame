using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame.Models
{
    public class SettingModel
    {
        public int Row;
        public int Col;
        public int Speed;
        public static readonly int MaxRows = 30;
        public static readonly int MaxCols = 20;
        public static readonly int MaxSpeed = 2000;

        /// <summary>
        /// 
        /// </summary>
        public SettingModel()
        {
            Row = 5;
            Col = 5;
            Speed = 300;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        public SettingModel(int rows, int cols, int speed)
        {
            Row = rows;
            Col = cols;
            Speed = speed;
        }
    }
}

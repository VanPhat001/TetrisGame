using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame.Objects
{
    public class Board
    {
        private Cell[,] _cells;
        private TableLayoutPanel _tableBoard;
        private readonly Size _cellSize;

        public int Rows => _cells.GetLength(0);
        public int Cols => _cells.GetLength(1);


        public Cell this[int cellRow, int cellCol] => _cells[cellRow, cellCol];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startRow"></param>
        /// <param name="endRow"></param>
        /// <returns></returns>
        public async Task ClearRowAnimation(int startRow, int endRow)
        {
            int firstLineFullRow = -1;
            for (int y = endRow; y >= startRow; y--)
            {
                bool objectFullRow = true;
                for (int x = 0; x < Cols; x++)
                {
                    if (_cells[y, x].Status == CellEnums.Empty)
                    {
                        objectFullRow = false;
                        break;
                    }
                }

                if (objectFullRow)
                {
                    firstLineFullRow = firstLineFullRow == -1 ? y : firstLineFullRow;
                    // clear row effect
                    for (int x = 0; x < Cols; x++)
                    {
                        _cells[y, x].Status = CellEnums.Empty;
                        await Task.Delay(10);
                    }
                }
            }

            if (firstLineFullRow != -1)
            {
                // move row effect                
                for (int i = firstLineFullRow; i > 0; i--)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        _cells[i, j].Status = _cells[i - 1, j].Status;
                    }
                    await Task.Delay(25);
                }

                for (int j = 0; j < Cols; j++)
                {
                    _cells[0, j].Reset();
                }
                await Task.Delay(25);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Board(TableLayoutPanel tableBoard, int rows, int cosl)
        {
            _tableBoard = tableBoard;
            _cells = new Cell[rows, cosl];

            _cellSize = ResetTableBoard();

            FillData();
        }

        /// <summary>
        /// only use once time when call contructor
        /// </summary>        
        private Size ResetTableBoard()
        {
            // clear data
            _tableBoard.Controls.Clear();
            _tableBoard.ColumnCount = Cols;
            _tableBoard.RowCount = Rows;
            _tableBoard.ColumnStyles.Clear();
            _tableBoard.RowStyles.Clear();

            // create layout
            float rowPercent = 100F / Rows;
            float colPercent = 100F / Cols;

            int width = _tableBoard.Width;
            int height = _tableBoard.Height;
            int cellWidth = (int)(width * colPercent);
            int cellHeight = (int)(height * rowPercent);

            for (int i = 0; i < Rows; i++)
            {
                _tableBoard.RowStyles.Add(
                    new RowStyle(SizeType.Percent, rowPercent));
            }
            for (int i = 0; i < Cols; i++)
            {
                _tableBoard.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, colPercent));
            }

            return new Size(cellWidth, cellHeight);
        }

        /// <summary>
        /// only use once time when call contructor
        /// </summary>
        private void FillData()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    _cells[r, c] = new Cell(new Point(c, r))
                    {
                        Width = _cellSize.Width,
                        Height = _cellSize.Height,
                        //Text = $"{r} {c}",
                        Text = String.Empty,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        //BorderStyle = BorderStyle.Fixed3D
                    };
                    _tableBoard.Controls.Add(_cells[r, c], c, r);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetData()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    _cells[r, c].Reset();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool CheckRange(Point point)
        {
            return CheckColumnInBoard(point.X) && CheckRowInBoard(point.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool CheckColumnInBoard(int col)
        {
            return 0 <= col && col < Cols;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public bool CheckRowInBoard(int row)
        {
            return 0 <= row && row < Rows;
        }
    }
}

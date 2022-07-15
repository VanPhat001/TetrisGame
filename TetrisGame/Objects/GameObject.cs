using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame.Objects
{
    public class GameObject
    {
        private readonly Board _board;
        private readonly int _modelIndex;
        private int _modelRotateIndex;
        private Point _topLeftPoint;

        public int ModelIndex => _modelIndex;
        public int ModelRotateIndex { get => _modelRotateIndex; private set => _modelRotateIndex = value; }
        public Point TopLeftPoint { get => _topLeftPoint; set => _topLeftPoint = value; }


        public static readonly List<ObjectModel> ObjectModelList = new List<ObjectModel>()
        {
            // &&&&
            new ObjectModel(new bool[,]
            {
                {true , true, true, true}
            }),

            // &&&            
            new ObjectModel(new bool[,]
            {
                {true, true, true}
            }),

            // &&&
            // &            
            new ObjectModel(new bool[,]
            {
                {true , true, true},
                {true , false, false}
            }),

            // &
            // &&&
            new ObjectModel(new bool[,]
            {
                {true , false, false},
                {true , true, true}
            }),

            // &&
            // &&
            new ObjectModel(new bool[,]
            {
                {true , true},
                {true , true}
            }),

            // &&
            //  &&            
            new ObjectModel(new bool[,]
            {
                {true , true, false},
                {false, true, true}
            }),

            //  &&
            // &&
            new ObjectModel(new bool[,]
            {
                {false, true, true},
                {true , true, false}
            }),
        };
        public static int CountObjectModel => ObjectModelList.Count;

        public static ObjectModel GetObjectModel(int modelIndex)
        {
            return ObjectModelList[modelIndex];
        }
        public static int CountModelRotate(int modelIndex)
        {
            return ObjectModelList[modelIndex].RotateCount;
        }
        public static bool[,] GetModelRotate(int modelIndex, int rotateIndex)
        {
            return GetObjectModel(modelIndex)[rotateIndex];
        }

        /// <summary>
        /// fill fields and draw object model into board
        /// </summary>
        /// <param name="board"></param>
        /// <param name="modelIndex"></param>
        public GameObject(Board board, int modelIndex, int modelRotateIndex = 0)
        {
            _board = board;
            _modelIndex = modelIndex;
            ModelRotateIndex = modelRotateIndex;

            TopLeftPoint = new Point(
                x: (board.Cols - GetModelCols()) / 2,
                y: 0);

            DrawModel();
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetRandomRotate()
        {
            RemoveModel();
            ModelRotateIndex = (new Random()).Next(ObjectModelList[ModelIndex].RotateCount);
            DrawModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Rotate90()
        {
            RemoveModel();

            var oddValue = ModelRotateIndex++;
            if (ModelRotateIndex >= ObjectModelList[ModelIndex].RotateCount)
            {
                ModelRotateIndex = 0;
            }

            if (!CheckConflict(TopLeftPoint))
            {
                DrawModel();
                return true;
            }
            else
            {
                ModelRotateIndex = oddValue;
                DrawModel();
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool MoveLeft()
        {
            return CheckMove(DirectionEnums.Left);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool MoveDown()
        {
            return CheckMove(DirectionEnums.Down);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool MoveRight()
        {
            return CheckMove(DirectionEnums.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <exception cref="Exception"></exception>
        private bool CheckMove(DirectionEnums direction)
        {
            // clear status to check conflict
            RemoveModel();
            
            // from topLeftPoint, calculate newPoint and check it
            var newPoint = new Point(TopLeftPoint.X, TopLeftPoint.Y);
            switch (direction)
            {
                case DirectionEnums.Left:
                    newPoint.X--;
                    break;

                case DirectionEnums.Right:
                    newPoint.X++;
                    break;

                case DirectionEnums.Down:
                    newPoint.Y++;
                    break;

                default:
                    throw new Exception();
            }


            int modelCols = GetModelCols();
            int modelRows = GetModelRows();

            // draw model if possible
            if (_board.CheckRange(newPoint)
                && _board.CheckColumnInBoard(newPoint.X + modelCols - 1)
                && _board.CheckRowInBoard(newPoint.Y + modelRows - 1)
                && !CheckConflict(newPoint))
            {                
                // great, let's draw model right now                
                TopLeftPoint = newPoint;
                DrawModel();
                return true;
            }

            // restore previous status if can't draw model on newPoint
            DrawModel();
            return false;
        }

        /// <summary>
        /// check conflict at point
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool CheckConflict(Point point)
        {
            var model = GetCurrentModel();
            var modelRows = GetModelRows();
            var modelCols = GetModelCols();

            for (int r = 0; r < modelRows; r++)
            {
                for (int c = 0; c < modelCols; c++)
                {
                    if (model[r, c] && _board[point.Y + r, point.X + c].Status != CellEnums.Empty)
                    {
                        // can't draw model in here
                        // conflict current model and old model
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool[,] GetCurrentModel()
        {
            return GetModelRotate(ModelIndex, ModelRotateIndex);
            //return ObjectModelList[ModelIndex].GetModelRotateIndex(ModelRotateIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetModelCols()
        {
            return ObjectModel.GetCols(GetCurrentModel());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetModelRows()
        {
            return ObjectModel.GetRows(GetCurrentModel());
        }

        /// <summary>
        /// draw model into board (layout)
        /// </summary>
        private void DrawModel()
        {
            var model = GetCurrentModel();
            int rows = GetModelRows();
            int cols = GetModelCols();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (model[r, c])
                    {
                        _board[TopLeftPoint.Y + r, TopLeftPoint.X + c].Status = CellEnums.Object;
                    }
                }
            }
        }

        /// <summary>
        /// remove model to board (layout)
        /// </summary>
        private void RemoveModel()
        {
            var model = GetCurrentModel();
            int rows = GetModelRows();
            int cols = GetModelCols();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (model[r, c])
                    {
                        _board[TopLeftPoint.Y + r, TopLeftPoint.X + c].Status = CellEnums.Empty;
                    }
                }
            }
        }

    }
}

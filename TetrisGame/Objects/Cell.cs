using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame.Objects
{
    public class Cell : Label
    {
        private CellEnums _status;
        private readonly Point _cellLocate;

        public CellEnums Status
        {
            get => _status;
            set
            {
                switch (value)
                {
                    case CellEnums.Empty:
                        BackColor = Color.White;
                        break;

                    case CellEnums.Object:
                        BackColor = Color.LightSkyBlue;
                        break;

                    default:
                        throw new Exception();
                }

                _status = value;
            }
        }
        public Point CellLocate => _cellLocate;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locate"></param>
        /// <param name="status"></param>
        public Cell(Point locate, CellEnums status = CellEnums.Empty)
        {
            _cellLocate = locate;
            Status = status;
        }

        /// <summary>
        /// set empty cell
        /// </summary>
        public void Reset()
        {
            Status = CellEnums.Empty;
        }
    }
}

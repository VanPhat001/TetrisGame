using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame.Objects
{
    public class ObjectData
    {
        public int ModelIndex { get; set; }
        public int ModelRotateIndex { get; set; }

        public ObjectData(int modelIndex, int modelRotateIndex)
        {
            ModelIndex = modelIndex;
            ModelRotateIndex = modelRotateIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame.Objects
{
    public class FutureObjects
    {
        private TableLayoutPanel[] _tables;
        private static readonly int Rows = 4;
        private static readonly int Cols = 4;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        public FutureObjects(TableLayoutPanel[] tables)
        {
            _tables = tables;

            foreach (var table in _tables)
            {
                CreateLayout(table, Rows, Cols);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectDatas"></param>
        public void FillLayout(ObjectData[] objectDatas)
        {
            for (int i = 0; i < _tables.Length; i++)
            {
                DrawObjectIntoTable(_tables[i], objectDatas[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="objectData"></param>
        private void DrawObjectIntoTable(TableLayoutPanel table, ObjectData objectData)
        {
            var model = GameObject.GetModelRotate(objectData.ModelIndex, objectData.ModelRotateIndex);
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    var cell = table.Controls[r * Cols + c];
                    try
                    {
                        cell.BackColor = (model[r, c] ? Color.PowderBlue : Color.Transparent);
                    }
                    catch
                    {
                        cell.BackColor = Color.Transparent;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        private void CreateLayout(TableLayoutPanel table, int rows, int cols)
        {
            table.RowStyles.Clear();
            table.ColumnStyles.Clear();

            table.RowCount = rows;
            table.ColumnCount = cols;

            float widthPercent = 100F / cols;
            float heightPercent = 100F / rows;
            for (int i = 0; i < rows; i++)
            {
                table.RowStyles.Add(
                    new RowStyle(SizeType.Percent, heightPercent));
            }

            for (int i = 0; i < cols; i++)
            {
                table.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, widthPercent));
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var lbl = new Label()
                    {
                        Text = "",
                        BackColor = System.Drawing.Color.Transparent,
                        Width = (int)(table.Width * widthPercent),
                        Height = (int)(table.Height * heightPercent)
                    };

                    table.Controls.Add(lbl, c, r);
                }
            }
        }
    }
}

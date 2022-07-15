using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame.Objects
{
    public class GamePlay
    {
        private Board _board;
        private readonly int GameSpeed = 300;
        private GameObject _gameObject;
        private Queue<ObjectData> _objectModelQueue;
        private FutureObjects _futureObjects;

        /// <summary>
        /// 
        /// </summary>
        public GamePlay(TableLayoutPanel tableBoard, TableLayoutPanel[] subTables, int rows, int cols, int speed)
        {
            GameSpeed = speed;
            _board = new Board(tableBoard, rows, cols);
            _gameObject = null;
            _objectModelQueue = new Queue<ObjectData>();
            _futureObjects = new FutureObjects(subTables);
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task StartGame()
        {
            await NewGame();
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task Restart()
        {
            await NewGame();
        }

        /// <summary>
        /// 
        /// </summary>
        private async Task NewGame()
        {
            _board.ResetData();
            _objectModelQueue.Clear();

            var task = AddQueueTask(20);
            task.Start();
            task.Wait();

            var mtask = ShowObjectModelTask();
            mtask.Start();
            mtask.Wait();

            while (true)
            {
                await Task.Delay(GameSpeed);
                if (await MoveDownObject() == false)
                {
                    break;
                }
            }

            MessageBox.Show("finish");
        }

        /// <summary>
        /// 
        /// </summary>
        private Task ShowObjectModelTask()
        {
            Task mtask = new Task(() =>
            {
                ObjectData data = _objectModelQueue.Dequeue();
                _gameObject = new GameObject(
                    board: _board,
                    modelIndex: data.ModelIndex,
                    modelRotateIndex: data.ModelRotateIndex);

                Task task = new Task(() =>
                {
                    _futureObjects.FillLayout(new ObjectData[]
                    {
                        _objectModelQueue.ElementAt(0),
                        _objectModelQueue.ElementAt(1),
                        _objectModelQueue.ElementAt(2),
                    });
                });
                task.Start();
            });
            return mtask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private async Task<bool> MoveDownObject()
        {
            if (!_gameObject.MoveDown())
            {
                if (_gameObject.TopLeftPoint.Y == 0)
                {
                    // end game
                    return false;
                }
                else
                {
                    await _board.ClearRowAnimation(
                        startRow: _gameObject.TopLeftPoint.Y,
                        endRow: _gameObject.TopLeftPoint.Y + _gameObject.GetModelRows() - 1);
                }

                ShowObjectModelTask().Start();
                if (_objectModelQueue.Count <= 5)
                {
                    AddQueueTask(10).Start();
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void OnSpaceOrEnterDown()
        {
            _gameObject?.Rotate90();
        }

        /// <summary>
        /// 
        /// </summary>
        public void OnLeftArrowDown()
        {
            _gameObject?.MoveLeft();
        }

        /// <summary>
        /// 
        /// </summary>
        public void OnRightArrowDown()
        {
            _gameObject?.MoveRight();
        }

        /// <summary>
        /// 
        /// </summary>
        public void OnDownArrowDown()
        {
            _gameObject?.MoveDown();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEndGame()
        {
            throw new Exception("chua code");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="times"></param>
        private Task AddQueueTask(int times)
        {
            Task task = new Task(() =>
            {
                Random rand = new Random();
                for (int i = 0; i < times; i++)
                {
                    int modelIndex = rand.Next(GameObject.CountObjectModel);
                    int modelRotateIndex = rand.Next(GameObject.CountModelRotate(modelIndex));
                    _objectModelQueue.Enqueue(
                        new ObjectData(modelIndex, modelRotateIndex));
                }
            });
            return task;
        }
    }
}

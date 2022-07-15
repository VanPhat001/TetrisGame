using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisGame.Models;
using TetrisGame.Objects;

namespace TetrisGame.Views
{
    public partial class StartGameForm : Form
    {
        private GamePlay _gamePlay;
        private TableLayoutPanel[] _tableModels;

        /// <summary>
        /// 
        /// </summary>
        public StartGameForm(SettingModel settingModel)
        {
            InitializeComponent();

            _tableModels = new TableLayoutPanel[] {
                tableModel1,
                tableModel2,
                tableModel3
            };

            this.KeyDown += StartGameForm_KeyDown;

            _gamePlay = new GamePlay(tableLayoutPanelBoard, _tableModels, settingModel.Row, settingModel.Col, settingModel.Speed);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.Modifiers + "    " + e.KeyCode);
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    toolStripLabelStart.PerformClick();
                    return;
                }
                else if (e.KeyCode == Keys.R)
                {
                    toolStripLabelRestart.PerformClick();
                    return;
                }
                else if (e.KeyCode == Keys.B)
                {
                    toolStripLabelBack.PerformClick();
                    return;
                }
            }


            if (e.KeyCode == Keys.Down)
            {
                _gamePlay.OnDownArrowDown();
            }
            else if (e.KeyCode == Keys.Left)
            {
                _gamePlay.OnLeftArrowDown();
            }
            else if (e.KeyCode == Keys.Right)
            {
                _gamePlay.OnRightArrowDown();
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                _gamePlay.OnSpaceOrEnterDown();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void toolStripLabelStart_Click(object sender, EventArgs e)
        {
            await _gamePlay.StartGame();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void toolStripLabelRestart_Click(object sender, EventArgs e)
        {
            await _gamePlay.Restart();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void toolStripLabelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

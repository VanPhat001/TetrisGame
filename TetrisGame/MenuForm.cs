using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisGame.ViewModels;
using TetrisGame.Views;

namespace TetrisGame
{
    public partial class MenuForm : Form
    {
        private SettingViewModel settingViewModel;


        /// <summary>
        /// 
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
            settingViewModel = new SettingViewModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick_Quit(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick_Setting(object sender, EventArgs e)
        {
            this.Hide();

            SettingForm settingForm = new SettingForm(settingViewModel);
            settingForm.ShowDialog();

            this.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick_Start(object sender, EventArgs e)
        {
            this.Hide();

            StartGameForm startGameForm = new StartGameForm(new Models.SettingModel(
                rows: settingViewModel.RowValue, 
                cols: settingViewModel.ColValue,
                speed: settingViewModel.SpeedValue));
            startGameForm.ShowDialog();

            this.Show();
        }
    }
}

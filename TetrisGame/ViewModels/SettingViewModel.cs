using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisGame.Models;

namespace TetrisGame.ViewModels
{
    public class SettingViewModel : INotifyPropertyChanged
    {
        private SettingModel _model;

        public int RowValue
        {
            get => _model.Row;
            set
            {
                _model.Row = value;
                OnPropertyChanged(nameof(RowValue));
            }
        }
        public int ColValue
        {
            get => _model.Col;
            set
            {
                _model.Col = value;
                OnPropertyChanged(nameof(ColValue));
            }
        }
        public int SpeedValue
        {
            get => _model.Speed;
            set
            {
                _model.Speed = value;
                OnPropertyChanged(nameof(SpeedValue));
            }
        }
        public int MaxRows => SettingModel.MaxRows;
        public int MaxCols => SettingModel.MaxCols;
        public int MaxSpeed => SettingModel.MaxSpeed;

        /// <summary>
        /// 
        /// </summary>
        public SettingViewModel()
        {
            _model = new SettingModel();
            ColValue = 5;
            RowValue = 5;
            SpeedValue = 300;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propName"></param>
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

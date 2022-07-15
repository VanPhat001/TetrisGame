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

namespace TetrisGame.Views
{
    public partial class SettingForm : Form
    {
        private SettingViewModel _dataBindingContext;


        /// <summary>
        /// 
        /// </summary>
        public SettingForm(SettingViewModel dataBindingContext)
        {
            InitializeComponent();

            _dataBindingContext = dataBindingContext;

            this.AcceptButton = button1;

            BindingData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void BindingData()
        {
            // trackBarCols
            trackBarCols.Minimum = 5;
            trackBarCols.DataBindings.Add(
                nameof(trackBarCols.Maximum), _dataBindingContext, nameof(_dataBindingContext.MaxCols),
                true, DataSourceUpdateMode.OnPropertyChanged);
            trackBarCols.DataBindings.Add(
                nameof(trackBarCols.Value), _dataBindingContext, nameof(_dataBindingContext.ColValue),
                true, DataSourceUpdateMode.OnPropertyChanged);

            // trackBarRows
            trackBarRows.Minimum = 5;
            trackBarRows.DataBindings.Add(
                nameof(trackBarRows.Maximum), _dataBindingContext, nameof(_dataBindingContext.MaxRows),
                true, DataSourceUpdateMode.OnPropertyChanged);
            trackBarRows.DataBindings.Add(
                nameof(trackBarRows.Value), _dataBindingContext, nameof(_dataBindingContext.RowValue),
                true, DataSourceUpdateMode.OnPropertyChanged);

            // trackBarSpeed
            trackBarSpeed.Minimum = 100;
            trackBarSpeed.DataBindings.Add(
                nameof(trackBarSpeed.Maximum), _dataBindingContext, nameof(_dataBindingContext.MaxSpeed),
                true, DataSourceUpdateMode.OnPropertyChanged);
            trackBarSpeed.DataBindings.Add(
                nameof(trackBarSpeed.Value), _dataBindingContext, nameof(_dataBindingContext.SpeedValue),
                true, DataSourceUpdateMode.OnPropertyChanged);

            // lblCols
            lblCols.DataBindings.Add(
                nameof(lblCols.Text), _dataBindingContext, nameof(_dataBindingContext.MaxCols));

            // lblRows
            lblRows.DataBindings.Add(
                nameof(lblRows.Text), _dataBindingContext, nameof(_dataBindingContext.MaxRows));

            // lblSpeed
            lblSpeed.DataBindings.Add(
                nameof(lblSpeed.Text), _dataBindingContext, nameof(_dataBindingContext.MaxSpeed));

            // txbCols
            txbCols.DataBindings.Add(
                nameof(txbCols.Text), _dataBindingContext, nameof(_dataBindingContext.ColValue),
                true, DataSourceUpdateMode.OnPropertyChanged);

            // txbRows
            txbRows.DataBindings.Add(
                nameof(txbRows.Text), _dataBindingContext, nameof(_dataBindingContext.RowValue),
                true, DataSourceUpdateMode.OnPropertyChanged);

            // txbSpeed
            txbSpeed.DataBindings.Add(
                nameof(txbSpeed.Text), _dataBindingContext, nameof(_dataBindingContext.SpeedValue),
                true, DataSourceUpdateMode.OnPropertyChanged);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

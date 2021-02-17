using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlotLand.Helpers;
using PlotLand.Models;

namespace PlotLand.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Fields
        private string _inputString;
        private ObservableCollection<PlotModel> _plots = new ObservableCollection<PlotModel>();
        #endregion

        #region Properties
        public string InputString { get => _inputString; set => _UpdateField(ref _inputString, value); }
        public ObservableCollection<PlotModel> Plots { get => _plots; set => _UpdateField(ref _plots, value); }
        #endregion

        #region Delegates
        private readonly DelegateCommand _addPlotsCommand;
        public ICommand AddPlotsCommand => _addPlotsCommand;
        #endregion

        public MainWindowViewModel()
        {
            _addPlotsCommand = new DelegateCommand(_AddPlots);
        }

        private void _AddPlots()
        {
            Plots.Add(new PlotModel(InputString));
        }
    }
}

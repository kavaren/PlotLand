using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FileHelpers;
using PlotLand.Helpers;
using PlotLand.Models;

namespace PlotLand.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Fields
        private string _inputString;
        private BindingList<PlotModel> _plots = new BindingList<PlotModel>();
        #endregion

        #region Properties
        public string InputString { get => _inputString; set => _UpdateField(ref _inputString, value); }
        public BindingList<PlotModel> Plots { get => _plots; set => _UpdateField(ref _plots, value); }
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
            //Plots.Add(new PlotModel(InputString));
            var engine = new FileHelperEngine<PlotModel>();
            List<PlotModel> records = engine.ReadFile("testy.csv").ToList<PlotModel>();
            Plots = new BindingList<PlotModel>(records);
        }
    }
}

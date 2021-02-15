using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotLand.Models
{
    public class Activities
    {
        private object _activity;
        private DateTime _executionDate;
        private double _plotSize;
        private double _yields;
        private double _yieldsHay;

        public DateTime ExecutionDate { get => _executionDate; set => _executionDate = value; }
        public double PlotSize { get => _plotSize; set => _plotSize = value; }
        public double Yields { get => _yields; set => _yields = value; }
        public double YieldsHay { get => _yieldsHay; set => _yieldsHay = value; }
        public object Activity { get => _activity; set => _activity = value; }
    }
}

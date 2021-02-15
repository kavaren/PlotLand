namespace PlotLand.Models
{
    public class PlotModel
    {
        private string _plotSignature;
        private int _plotNumber;
        private double _plotArea;
        private PlotType _plotTypeUse;
        private string _plotOperation;
        private string _plotUsageType;

        public string PlotSignature { get => _plotSignature; set => _plotSignature = value; }
        public int PlotNumber { get => _plotNumber; set => _plotNumber = value; }
        public double PlotArea { get => _plotArea; set => _plotArea = value; }
        public PlotType PlotTypeUse { get => _plotTypeUse; set => _plotTypeUse = value; }
        public string PlotOperation { get => _plotOperation; set => _plotOperation = value; }
        public string PlotUsageType { get => _plotUsageType; set => _plotUsageType = value; }
    }
}

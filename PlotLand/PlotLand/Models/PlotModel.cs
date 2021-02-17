using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public PlotModel(string inputString)
        {
            string line = string.Empty;
            int charFrom = 0, charTo = 0;
            using (StringReader reader = new StringReader(inputString))
            {
                try
                {
                    line = reader.ReadLine();
                    //PlotSignature string
                    //line = reader.ReadLine();

                    charTo = line.IndexOf(',');
                    _plotSignature = line.Substring(charFrom+1, charTo-1);
                    charFrom = charTo;

                    //PlotNumber int
                    charTo = line.IndexOf(',', charFrom + 1);
                    var subString = line.Substring(charFrom + 3, charTo - 3);
                    _plotNumber = Int32.Parse(subString);
                    charFrom = charTo;

                    //PlotArea double
                    for (int i = 0; i < 7; i++)
                    {
                        charFrom = charTo;
                        charTo = line.IndexOf(',', charFrom + 1);
                    }
                    _plotArea = Double.Parse(line.Substring(charFrom + 2, charTo - 2));
                    charFrom = charTo;

                    //PlotTypeUse PlotType
                    line = reader.ReadLine();
                    Enum.TryParse(line, out _plotTypeUse);

                    //PlotOperation string
                    line = reader.ReadLine();
                    _plotOperation = line;

                    //PlotUsageType string
                    line = reader.ReadLine();
                    _plotUsageType = line;
                }
                catch (ArgumentException)
                {
                    throw;
                }
            }
        }

        public string PlotSignature { get => _plotSignature; set => _plotSignature = value; }
        public int PlotNumber { get => _plotNumber; set => _plotNumber = value; }
        public double PlotArea { get => _plotArea; set => _plotArea = value; }
        public PlotType PlotTypeUse { get => _plotTypeUse; set => _plotTypeUse = value; }
        public string PlotOperation { get => _plotOperation; set => _plotOperation = value; }
        public string PlotUsageType { get => _plotUsageType; set => _plotUsageType = value; }
    }
}

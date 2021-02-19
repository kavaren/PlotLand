using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotLand.Models
{
    public class PlotModel
    {
        private string _plotSignature;
        private string _plotNumber;
        private double _plotArea;
        private PlotType _plotTypeUse;
        private string _plotOperation;
        private string _plotUsageType;

        public PlotModel(string inputString)
        {
            string line = string.Empty;
            int charFrom = 0, charTo = 0, numFrom = 0, numTo = 0;
            using (StringReader reader = new StringReader(inputString))
            {
                try
                {

                    //   "\"A,\"\"2,05\"\",JPO,,,,,080103_2.0015.24,\"\"2,05\"\",ONW_6,\"\"2,05\"\",,,,,,,,,,,\"", "A", "24", (double)2.05, PlotType.None, "", ""
                    line = reader.ReadLine();

                    //PlotSignature string
                    charTo = line.IndexOf(',');
                    _plotSignature = line.Substring(charFrom + 1, charTo - 1);
                    charFrom = charTo;

                    //PlotArea double
                    charTo = line.IndexOf(',', charFrom + 1);
                    Double.TryParse(line.Substring(charFrom + 3, charTo - 2), NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("fr-FR"), out _plotArea) ;
                    charFrom = charTo;

                    //PlotTypeUse enum
                    for (int i = 0; i < 3; i++)
                    {
                        charFrom = charTo;
                        charTo = line.IndexOf(',', charFrom + 1);
                    }

                    try
                    {
                        _plotTypeUse = (PlotType)Enum.Parse(typeof(PlotType), line.Substring(charFrom + 1, charTo - charFrom - 1));
                    }
                    catch(System.ArgumentException)
                    {
                        _plotTypeUse = PlotType.None;

                    }
                    charFrom = charTo;

                    //PlotNumber int
                    for (int i = 0; i < 4; i++)
                    {
                        charFrom = charTo;
                        charTo = line.IndexOf(',', charFrom + 1);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        numFrom = numTo;
                        numTo = line.IndexOf('.', numFrom + 1);
                    }
                    _plotNumber = line.Substring(numTo + 1, charTo - 1  - numTo);

                    //PlotOperation string
                    _plotOperation = "";

                    //PlotUsageType string
                    _plotUsageType = "";
                }
                catch (ArgumentException)
                {
                    throw;
                }
            }
        }

        public string PlotSignature { get => _plotSignature; set => _plotSignature = value; }
        public string PlotNumber { get => _plotNumber; set => _plotNumber = value; }
        public double PlotArea { get => _plotArea; set => _plotArea = value; }
        public PlotType PlotTypeUse { get => _plotTypeUse; set => _plotTypeUse = value; }
        public string PlotOperation { get => _plotOperation; set => _plotOperation = value; }
        public string PlotUsageType { get => _plotUsageType; set => _plotUsageType = value; }
    }
}

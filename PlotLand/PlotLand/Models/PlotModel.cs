using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using PlotLand.Helpers;

namespace PlotLand.Models
{
    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    public class PlotModel
    {
#nullable enable
        private string? plotSignature;
        [FieldConverter(typeof(DecimalConverter))]
        private decimal plotArea;
        private string? plotTypeUse;
        public string? __4;
        public string? __5;
        public string? __6;
        public string? __7;
        private string? plotNumber;
        [FieldConverter(typeof(DecimalConverter))]
        public decimal? __9;
        public string? __10;
        [FieldConverter(typeof(DecimalConverter))]
        public decimal? __11;
        private string? plotUsageType;
        public string? __13;
        public string? __14;
        public string? __15;
        public string? __16;
        private string? plotOperation;
        public string? __18;
        public string? __19;
        public string? __20;
        public string? __21;
        public string? __22;

        public string? PlotSignature { get => plotSignature; set => plotSignature = value; }
        public string? PlotTypeUse { get => plotTypeUse; set => plotTypeUse = value; }
        public decimal PlotArea { get => plotArea; set => plotArea = value; }
        public string? PlotNumber { get => plotNumber; set => plotNumber = value; }
        public string? PlotUsageType { get => plotUsageType; set => plotUsageType = value; }
        public string? PlotOperation { get => plotOperation; set => plotOperation = value; }
#nullable disable

        public PlotModel()
        {
            
        }
    }
}

using FileHelpers;
using System;

namespace PlotLand.Helpers
{
    public class DecimalConverter : ConverterBase
    {
        public override object StringToField(string from)
        {
            return Convert.ToDecimal(Decimal.Parse(from.Trim('"')));
        }

        public override string FieldToString(object fieldValue)
        {
            return ((decimal)fieldValue).ToString("##.##");
        }

    }
}

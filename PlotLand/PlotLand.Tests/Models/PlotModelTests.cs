using NUnit.Framework;
using PlotLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace PlotLand.Models.Tests
{
    [TestFixture()]
    public class PlotModelTests
    {
        private static IEnumerable<TestCaseData> GetTestDataA()
        {
            yield return new TestCaseData("\"A,\"\"2,05\"\",JPO,,,,,080103_2.0015.24,\"\"2,05\"\",ONW_6,\"\"2,05\"\",,,,,,,,,,,\"", "A", "24", (double)2.05, PlotType.None, "", "");
            yield return new TestCaseData("\"A1,\"\"2,05\"\",PRSK,TUZ,,,,080103_2.0015.24,\"\"2,05\"\",,,5.4,,,0,,kośny,,,,,\"", "A1", "24", (double)2.05, PlotType.TUZ, "kośny", "");
            yield return new TestCaseData("\"A1a,\"\"2,05\"\",TUZ,TUZ,,,,080103_2.0015.24,\"\"2,05\"\",,,,,,,,,,,,,\"", "A1a", "24", (double)2.05, PlotType.None, "", "");
            yield return new TestCaseData("\"B,\"\"45,44\"\",JPO,,,,,321804_5.0003.376/2,\"\"34,59\"\",ONW_5,\"\"34,59\"\",,,,,,,,,,,\"", "B", "376/2", (double)45.44, PlotType.None, "", "");
            yield return new TestCaseData("\"B,\"\"45,44\"\",JPO,,,,,321804_5.0003.376/1,\"\"10,85\"\",ONW_5,\"\"10,85\"\",,,,,,,,,,,\"", "B", "376/1", (double)45.44, PlotType.None, "", "");
            yield return new TestCaseData("\"B1,\"\"8,32\"\",PRSK,TUZ,,,,321804_5.0003.376/2,\"\"8,32\"\",,,5.3,,,0,,kośny,,,,,\"", "B1", "376/2", (double)8.32, PlotType.TUZ, "kośny", "");
        }

        [TestCaseSource(nameof(GetTestDataA))]
        public void PlotModelConstructorSignatureTest(string _constructor, string _plotSignature, string _2, double _3, PlotType _4, string _5, string _6)
        {
            PlotModel model = new PlotModel(_constructor);
            Assert.That(model.PlotSignature, Is.EqualTo(_plotSignature));
        }

        [TestCaseSource(nameof(GetTestDataA))]
        public void PlotModelConstructorNumberTest(string _constructor, string _1, string _plotNumber, double _3, PlotType _4, string _5, string _6)
        {
            PlotModel model = new PlotModel(_constructor);
            Assert.That(model.PlotNumber, Is.EqualTo(_plotNumber));
        }

        [TestCaseSource(nameof(GetTestDataA))]
        public void PlotModelConstructorAreaTest(string _constructor, string _1, string _2, double _plotArea, PlotType _4, string _5, string _6)
        {
            PlotModel model = new PlotModel(_constructor);
            Assert.That(model.PlotArea, Is.EqualTo(_plotArea));
        }

        [TestCaseSource(nameof(GetTestDataA))]
        public void PlotModelConstructorTypeTest(string _constructor, string _1, string _2, double _3, PlotType _plotType, string _5, string _6)
        {
            PlotModel model = new PlotModel(_constructor);
            Assert.That(model.PlotTypeUse, Is.EqualTo(_plotType));
        }

        [TestCaseSource(nameof(GetTestDataA))]
        public void PlotModelConstructorOperationTest(string _constructor, string _1, string _2, double _3, PlotType _4, string _plotOperation, string _6)
        {
            PlotModel model = new PlotModel(_constructor);
            Assert.That(model.PlotOperation, Is.EqualTo(_plotOperation));
        }

        [TestCaseSource(nameof(GetTestDataA))]
        public void PlotModelConstructorUsageTest(string _constructor, string _1, string _2, double _3, PlotType _4, string _5, string _plotUsageType)
        {
            PlotModel model = new PlotModel(_constructor);
            Assert.That(model.PlotUsageType, Is.EqualTo(_plotUsageType));
        }
    }
}
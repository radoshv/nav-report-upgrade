using NavUpgrade.Data.StructuralUnits.Classic;

namespace NavUpgrade.Data.ReportModels
{
    public class ClassicReport : BaseReport
    {
        public Properties Properties { get; set; }
        public DataItems DataItems { get; set; }
        public RequestForm RequestForm { get; set; }
        public RdlData RdlData { get; set; }
        public RequestPage RequestPage { get; set; }
    }
}

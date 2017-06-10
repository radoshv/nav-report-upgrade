using NavUpgrade.Data.StructuralUnits.Rdlc;

namespace NavUpgrade.Data.ReportModels
{
    public class RdlcReport : BaseReport
    {
        public Properties Properties { get; set; }
        public Dataset Dataset { get; set; }
        public RequestPage RequestPage { get; set; }
        public RdlData RdlData { get; set; }
    }
}

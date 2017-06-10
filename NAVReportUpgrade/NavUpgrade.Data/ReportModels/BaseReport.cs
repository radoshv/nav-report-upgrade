using NavUpgrade.Data.StructuralUnits;

namespace NavUpgrade.Data.ReportModels
{
    public abstract class BaseReport
    {
        public ObjectHeader ObjectHeader { get; set; }
        public ObjectProperties ObjectProperties { get; set; }
    }
}

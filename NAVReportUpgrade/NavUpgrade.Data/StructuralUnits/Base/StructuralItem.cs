namespace NavUpgrade.Data.StructuralUnits.Base
{
    public abstract class StructuralItem
    {
        protected StructuralItem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Contents { get; set; }
    }
}
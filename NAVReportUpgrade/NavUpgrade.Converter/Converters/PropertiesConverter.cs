using ClassicProperties = NavUpgrade.Data.StructuralUnits.Classic.Properties;
using RdlcProperties = NavUpgrade.Data.StructuralUnits.Rdlc.Properties;

namespace NavUpgrade.Converter.Converters
{
    class PropertiesConverter
    {
        public RdlcProperties Convert(ClassicProperties properties)
        {
            return new RdlcProperties
            {
                Contents = properties.Contents
            };
        } 
    }
}

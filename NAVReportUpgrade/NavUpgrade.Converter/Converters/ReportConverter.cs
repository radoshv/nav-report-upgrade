using System;
using NavUpgrade.Data.ReportModels;

namespace NavUpgrade.Converter.Converters
{
    public class ReportConverter
    {
        private readonly PropertiesConverter _propertiesConverter;

        public ReportConverter()
        {
            //todo inject dependencies
            _propertiesConverter = new PropertiesConverter();
        }

        public RdlcReport ConvertClassicToRdlc(ClassicReport classic)
        {
            var rdlc = new RdlcReport
            {
                ObjectHeader = classic.ObjectHeader,
                ObjectProperties = classic.ObjectProperties,
            };

            var properties = _propertiesConverter.Convert(classic.Properties);

            throw new NotImplementedException();
        }
    }
}

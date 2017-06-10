using System;
using NavUpgrade.Data.StructuralUnits.Base;

namespace NavUpgrade.Parser.Helpers
{
    public class StructuralItemHelper
    {
        public T GetContents<T>(ref string text) where T : StructuralItem
        {
            text = text.Trim(' ', '\n');
            //var pos = text.IndexOf(T.Name);
            //if (pos != 0) throw new Exception(); //todo handle error

            throw new NotImplementedException();
        }
    }
}
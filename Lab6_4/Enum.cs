using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_4
{
    internal class EnumClass
    {
        internal static Eseasons Parse(Type type, string? seasonName, bool v)
        {
            if (Enum.TryParse(type, seasonName, v, out object result))
            {
                return (Eseasons)result;
            }
            throw new NotImplementedException();
        }

        public enum Eseasons
        {
            summer,
            winter,
            spring,
            automn
        }
    }
}

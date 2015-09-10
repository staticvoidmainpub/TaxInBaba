using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatterSample
{
    public interface IParser
    {
        void ParseToList(string filepath);
    }
}

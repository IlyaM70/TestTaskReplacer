using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacerClassLibrary.ReplacerStrategy
{
    public interface IReplaceStrategy
    {
        string ReplaceNumbersByString(int[] numbers);
    }
}

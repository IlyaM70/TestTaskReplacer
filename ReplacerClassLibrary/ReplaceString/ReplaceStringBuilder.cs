using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacerClassLibrary.ReplaceString
{
    public sealed class ReplaceStringBuilder : IReplaceStringBuilder
    {
        private string _result = "";

        public ReplaceStringBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _result = "";
        }

        public void AddByCondition(string replace, bool condition)
        {
            if (condition)
            {
                if (!string.IsNullOrEmpty(_result))
                {
                    _result += "-";
                }
                _result += replace;
            }
        }

        public string Build()
        {
            string result = _result;
            Reset();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacerClassLibrary.ReplaceString
{
    /// <summary>
    /// String builder for replacement
    /// </summary>
    public interface IReplaceStringBuilder
    {
        /// <summary>
        /// Add a string to replacement string by condition
        /// </summary>
        /// <param name="replace">string to add to replacement string</param>
        /// <param name="condition">if condition true method adds string to replacement string</param>
        void AddByCondition(string replace, bool condition);
    }
}

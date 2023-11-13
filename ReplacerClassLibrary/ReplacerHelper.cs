namespace ReplacerClassLibrary
{
    public static class ReplacerHelper
    {
        /// <summary>
        /// Get a string for a replacer based on condition
        /// </summary>
        /// <param name="replacer">String that replaces something</param>
        /// <param name="condition">Condition that determines replacement</param>
        /// <param name="previousResult">Result of previous replacement using this method if chain replacement needed</param>
        /// <returns></returns>
        public static string GetString(string replacer, bool condition, string previousResult = "")
        {
            string result = "";
            if (!string.IsNullOrEmpty(previousResult))
            {
                result = previousResult;
            }

            if (condition)
            {
                if (!string.IsNullOrEmpty(previousResult))
                {
                    result += "-";
                }

                result += replacer;
            }

            return result;
        }

    }
}

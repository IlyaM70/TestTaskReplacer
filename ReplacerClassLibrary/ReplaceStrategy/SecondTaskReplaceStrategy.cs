using ReplacerClassLibrary.ReplaceString;

namespace ReplacerClassLibrary.ReplacerStrategy
{
    public sealed class SecondTaskReplaceStrategy : IReplaceStrategy
    {
        public string ReplaceNumbersByString(int[] numbers)
        {
            string methodResult = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                string result = "";

                var replaceStringBuilder = new ReplaceStringBuilder();
                replaceStringBuilder.AddByCondition("fizz", numbers[i] % 3 == 0);
                replaceStringBuilder.AddByCondition("buzz", numbers[i] % 5 == 0);
                replaceStringBuilder.AddByCondition("muzz", numbers[i] % 4 == 0);
                replaceStringBuilder.AddByCondition("guzz", numbers[i] % 7 == 0);
                result = replaceStringBuilder.Build();

                if (string.IsNullOrEmpty(result))
                {
                    result = numbers[i].ToString();
                }

                if (i < numbers.Length - 1)
                    result = ($"{result},");

                methodResult += result;
            }

            return methodResult;
        }
    }
}

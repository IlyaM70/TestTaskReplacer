using ReplacerClassLibrary.ReplaceString;

namespace ReplacerClassLibrary.ReplacerStrategy
{
    public sealed class ThirdTaskReplaceStrategy : IReplaceStrategy
    {
        public string ReplaceNumbersByString(int[] numbers)
        {
            string methodResult = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                string result = "";

                var replaceStringBuilder = new ReplaceStringBuilder();        

                if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
                {
                    replaceStringBuilder.AddByCondition("good-boy", true);
                }
                else
                {
                    replaceStringBuilder.AddByCondition("dog",numbers[i] % 3 == 0);
                    replaceStringBuilder.AddByCondition("cat",numbers[i] % 5 == 0);
                }

                replaceStringBuilder.AddByCondition("muzz",numbers[i] % 4 == 0);
                replaceStringBuilder.AddByCondition("guzz",numbers[i] % 7 == 0);

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

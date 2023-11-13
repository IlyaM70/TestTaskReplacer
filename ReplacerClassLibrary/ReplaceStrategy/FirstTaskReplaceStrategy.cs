namespace ReplacerClassLibrary.ReplacerStrategy
{
    public sealed class FirstTaskReplaceStrategy : IReplaceStrategy
    {
        public string ReplaceNumbersByString(int[] numbers)
        {
            string methodResult = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                string result = "";

                result = ReplacerHelper.GetString("fizz",numbers[i] % 3 == 0);
                result = ReplacerHelper.GetString("buzz",numbers[i] % 5 == 0,result);

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

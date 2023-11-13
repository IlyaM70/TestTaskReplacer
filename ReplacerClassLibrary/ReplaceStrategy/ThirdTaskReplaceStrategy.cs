﻿namespace ReplacerClassLibrary.ReplacerStrategy
{
    public sealed class ThirdTaskReplaceStrategy : IReplaceStrategy
    {
        public string ReplaceNumbersByString(int[] numbers)
        {
            string methodResult = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                string result = "";

                if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
                {
                    result = ReplacerHelper.GetString("good-boy",true,result);
                }
                else
                {
                    result = ReplacerHelper.GetString("dog",numbers[i] % 3 == 0,result);
                    result = ReplacerHelper.GetString("cat",numbers[i] % 5 == 0,result);
                }

                result = ReplacerHelper.GetString("muzz",numbers[i] % 4 == 0,result);
                result = ReplacerHelper.GetString("guzz",numbers[i] % 7 == 0,result);

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
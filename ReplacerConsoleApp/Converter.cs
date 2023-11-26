namespace ReplacerClassLibrary
{
    public static class Converter
    {
        public static int[] NumbersStringToArray(string numbersString)
        {
            string[] numbersStringArray = numbersString.Replace(" ", "").Split(',');
            int[] numbersArray = new int[numbersString.Length];

            try
            {
                numbersArray = Array.ConvertAll(numbersStringArray, s => int.Parse(s));
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                    throw new Exception("numbers string is not right format. Right format:\"int1,int2..\" ");
            }
            return numbersArray;
        }
    }
}

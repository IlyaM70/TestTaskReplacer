namespace ReplacerTests
{
    public class FirstTaskTests
    {
        [Test]
        public void FirstTaskReplaceStrategyReplaceNumbersByStringReturnsExpectedResult()
        {
            Replacer firstTastReplacer
                     = new Replacer(new FirstTaskReplaceStrategy());
            int[] taskNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string expectedResult = "1,2,fizz,4,buzz,fizz,7,8,fizz,buzz,11,fizz,13,14,fizz-buzz";

            string result = firstTastReplacer.ReplaceNumbersByString(taskNumbers);
            Assert.That(expectedResult, Is.EqualTo(result));   
        }
    }
}
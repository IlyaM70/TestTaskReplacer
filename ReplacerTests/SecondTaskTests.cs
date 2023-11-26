namespace ReplacerTests
{
    public class SecondTaskTests
    {
        [Test]
        public void SecondTaskReplaceStrategyReplaceNumbersByStringReturnsExpectedResult()
        {
            Replacer secondTastReplacer
                     = new Replacer(new SecondTaskReplaceStrategy());
            int[] taskNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            string expectedResult = "1,2,fizz,muzz,buzz,fizz,guzz,muzz,fizz,buzz,11,fizz-muzz,13,guzz,fizz-buzz,fizz-buzz-muzz,fizz-buzz-guzz,fizz-buzz-muzz-guzz";

            string result = secondTastReplacer.ReplaceNumbersByString(taskNumbers);
            Assert.That(expectedResult, Is.EqualTo(result));   
        }
    }
}
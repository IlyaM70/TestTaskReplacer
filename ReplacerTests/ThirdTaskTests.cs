namespace ReplacerTests
{
    public class ThirdTaskTests
    {
        [Test]
        public void ThirdTaskReplaceStrategyReplaceNumbersByStringReturnsExpectedResult()
        {
            Replacer thirdTastReplacer
                     = new Replacer(new ThirdTaskReplaceStrategy());
            string passedString = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,60,105,420";
            string expectedResult = "1,2,dog,muzz,cat,dog,guzz,muzz,dog,cat,11,dog-muzz,13,guzz,good-boy,good-boy-muzz,good-boy-guzz,good-boy-muzz-guzz";
            int[] taskNumbers = Converter.NumbersStringToArray(passedString);

            string result = thirdTastReplacer.ReplaceNumbersByString(taskNumbers);
            Assert.That(expectedResult, Is.EqualTo(result));   
        }
    }
}
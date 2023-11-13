using ReplacerClassLibrary.ReplacerStrategy;


namespace ReplacerClassLibrary
{
    public class Replacer
    {
        private IReplaceStrategy _strategy;

        public Replacer(IReplaceStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IReplaceStrategy strategy)
        {
            _strategy = strategy;
        }

        public string ReplaceNumbersByString(int[] numbers)
        {
            return _strategy.ReplaceNumbersByString(numbers);
        }
    }
}

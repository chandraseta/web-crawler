namespace WebCrawler
{
    public abstract class Searcher
    {
        protected string pattern;

        public Searcher(string input)
        {
            pattern = input.ToLower();
        }

        public string getPattern()
        {
            return pattern;
        }
        
        public void setPattern(string input)
        {
            pattern = input.ToLower();
        }

        public abstract int searchIn(string text);
    }
}
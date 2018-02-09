namespace PagesComposite
{
    internal abstract class Page
    {
        public string Title { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }

        public abstract string ShowPage();
    }
}

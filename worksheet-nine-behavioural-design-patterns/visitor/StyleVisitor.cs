namespace visitor
{
    public class StyleVisitor : IVisitor
    {
        public void Visit(HtmlElement element) => element.StartTag= element.StartTag.Replace(">", "style='width:46px;'>");

        public void Visit(HtmlParentElement parentElement) => parentElement.StartTag= parentElement.StartTag.Replace(">", "style='width:46px;'>");
    }
}
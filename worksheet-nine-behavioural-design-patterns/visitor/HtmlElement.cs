using System;
using System.Collections.Generic;

namespace visitor
{
    public class HtmlElement : HtmlTag
    {
        public HtmlElement(string tagName)
        {
            TagName = tagName;
            TagBody = "";
            StartTag = "";
            EndTag = "";
        }

        public override string TagName { get; set; }
        public override string StartTag { get; set; }
        public override string EndTag { get; set; }
        private List<HtmlTag> ChildrenTag { get; set; }


        public override List<HtmlTag> GetChildren() => ChildrenTag;

        public override void GenerateHtml() => Console.WriteLine($"{StartTag}{TagBody}{EndTag}");

        public override void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace visitor
{
    public class HtmlParentElement : HtmlTag
    {
        public override string TagName { get; set; }
        public override string StartTag { get; set; }
        public override string EndTag { get; set; }
        public List<HtmlTag> ChildrenTag { get; set; }

        public HtmlParentElement(string tagName)
        {
            TagName = tagName;
            StartTag = "";
            EndTag = "";
            ChildrenTag = new List<HtmlTag>();
        }


        public override void AddChildTag(HtmlTag htmlTag) => ChildrenTag.Add(htmlTag);

        public override void RemoveChildTag(HtmlTag htmlTag) => ChildrenTag.Remove(htmlTag);

        public override void Accept(IVisitor visitor) => visitor.Visit(this);

        public override List<HtmlTag> GetChildren() => ChildrenTag;

        public override void GenerateHtml()
        {
            Console.WriteLine(StartTag);
            foreach (var tag in ChildrenTag)
            {
                tag.GenerateHtml();
            }
            Console.WriteLine(EndTag);
        }
    }
}
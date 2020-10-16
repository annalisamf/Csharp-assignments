using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Composite
{
    public class HtmlParentElement : HtmlTag
    {
        public string tagName { get; set; }


        public List<HtmlTag> ChildrenTag { get; set; }

        public HtmlParentElement(string body)
        {
            tagName = body;
            ChildrenTag = new List<HtmlTag>();
        }

        public void AddChildTag(HtmlTag htmlTag)
        {
            ChildrenTag.Add(htmlTag);
        }

        public void RemoveChildTag(HtmlTag htmlTag)
        {
            ChildrenTag.Remove(htmlTag);
        }

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
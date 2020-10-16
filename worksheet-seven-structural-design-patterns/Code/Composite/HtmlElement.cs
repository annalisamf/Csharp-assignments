using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Composite
{
    public class HtmlElement : HtmlTag
    {
        public HtmlElement(string s)
        {
            TagBody = s;
        }

        public override void GenerateHtml()
        {
            Console.WriteLine($"{StartTag}{TagBody}{EndTag}");
        }
    }
}
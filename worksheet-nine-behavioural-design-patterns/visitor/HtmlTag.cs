using System.Collections.Generic;

namespace visitor
{
    public abstract class HtmlTag
    {
        public abstract string TagName { get; set; }

        public abstract string StartTag { get; set; }

        public abstract string EndTag { get; set; }

        public string TagBody { get; set; }

        public virtual void AddChildTag(HtmlTag htmlTag)
        {
        }

        public virtual void RemoveChildTag(HtmlTag htmlTag)
        {
        }

        public abstract List<HtmlTag> GetChildren();
       
        public abstract void GenerateHtml();

        public abstract void Accept(IVisitor style);

    }
}
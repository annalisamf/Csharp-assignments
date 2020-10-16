using System;

namespace QuestionFour
{
    public class AccessControl : IPrototype
    {
        public string Access { get; set; }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public AccessControl Clone()
        {
            throw new NotImplementedException();
        }
    }
}
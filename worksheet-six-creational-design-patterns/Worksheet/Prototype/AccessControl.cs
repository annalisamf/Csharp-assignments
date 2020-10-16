using System;

namespace QuestionFour
{
    public class AccessControl : IPrototype
    {
        public AccessControl(string controlLevel, Access access)
        {
            Access = access;
            ControlLevel = controlLevel;
        }

        public static Access Access { get; set; } //could be a map of access for each user
        public static string ControlLevel { get; set; } // USER, ADMIN, MANAGER

        object ICloneable.Clone()
        {
            return Clone();
        }

        public AccessControl Clone()
        {
            return MemberwiseClone() as AccessControl;
            
        }
        
        public static implicit operator AccessControl(Access a) => new AccessControl(ControlLevel, a);
    }
}
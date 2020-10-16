using System.Reflection.Metadata.Ecma335;

namespace Flyweight
{
    public interface IPlatform
    {
        void Execute(Code code);
    }
}
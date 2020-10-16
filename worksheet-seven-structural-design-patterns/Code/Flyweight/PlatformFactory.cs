using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Flyweight
{
    public static class PlatformFactory
    {
        private static readonly Dictionary<string, IPlatform> Map = new Dictionary<string, IPlatform>();

        public static IPlatform PlatformInstance(string name)
        {
            var platform = Map.GetValueOrDefault(name);
            if (platform != null) return platform;

            switch (name)
            {
                case "Scala":
                    platform = new ScalaPlatform();
                    break;
                case "RUBY":
                    platform = new RubyPlatform();
                    break;
                case "JAVA":
                    platform = new JavaPlatform();
                    break;
                case "C":
                    platform = new CPlatform();
                    break;
                default:
                    break;
            }

            Map.Add(name, platform);
            return platform;
        }
    }
}
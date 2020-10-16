using System;

namespace template
{
    public class MySqLCSVCon: ConnectionTemplate
    {
        public override void SetDBDriver() => Console.WriteLine("Setting MySQL DB drivers...");

        public override void SetCredentials() => Console.WriteLine("Setting credentials for MySQL DB...");

        public override void SetData() => Console.WriteLine("Setting up data from cvs file...");
    }
}
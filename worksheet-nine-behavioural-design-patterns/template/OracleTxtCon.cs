using System;

namespace template
{
    public class OracleTxtCon: ConnectionTemplate
    {
        public override void SetDBDriver() => Console.WriteLine("Setting Oracle DB drivers...");

        public override void SetCredentials() => Console.WriteLine("Setting credentials for Oracle DB...");

        public override void SetData() => Console.WriteLine("Setting up data from txt file...");
    }
}
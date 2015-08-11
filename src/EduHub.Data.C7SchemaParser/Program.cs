using System;
using System.IO;
using System.Linq;

namespace EduHub.Data.C7SchemaParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2 || args.Any(a => string.IsNullOrWhiteSpace(a)) || !File.Exists(args[0]))
            {
                throw new ArgumentException("Invalid Command Line Arguments");
            }

            var schema = new C7Schema(args[0]);

            var schemaXml = schema.ToXElement();

            schemaXml.Save(args[1]);
        }
    }
}

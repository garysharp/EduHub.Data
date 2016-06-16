using EduHub.Data.SchemaParser.C7;
using EduHub.Data.SchemaParser.Db;
using System;
using System.Linq;

namespace EduHub.Data.SchemaParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var c7SchemaFilename = args[0];
            var csvDirectory = args[1];
            var output = args[2];

            // Parse C7 Schema File
            var schema = C7Parser.Parse(c7SchemaFilename);

            // Augment with Database Information
            DbParser.AugmentSchemaFromCsv(csvDirectory, schema);

            // Validate schema
            SchemaTests.TestForeignKeys(schema);

            var schemaXml = schema.ToXElement();

            schemaXml.Save(output);
        }
    }
}

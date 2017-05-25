﻿using EduHub.Data.SchemaParser.C7;
using EduHub.Data.SchemaParser.Db;
using EduHub.Data.SchemaParser.Models;
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
            var c7Elements = C7Parser.ParseSchemaFile(c7SchemaFilename);

            var schema = EduHubSchema.FromC7Schema(c7Elements);

            // TODO: Update SQL Schema with SGFC
            schema.RemoveEntity("SGFC");
            foreach (var field in schema.Entities.SelectMany(e => e.Fields))
            {
                if (field.ForeignParentKey.EntityName == "SGFC")
                {
                    field.ForeignParentKey = default((string, string));
                }
            }

            // Augment with Database Information
            DbParser.AugmentSchemaFromCsv(csvDirectory, schema);

            // Validate schema
            SchemaTests.TestForeignKeys(schema);

            var schemaXml = schema.ToXElement();

            schemaXml.Save(output);
        }
    }
}

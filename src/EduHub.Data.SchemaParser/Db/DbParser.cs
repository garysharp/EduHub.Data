using EduHub.Data.SchemaParser.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace EduHub.Data.SchemaParser.Db
{
    public static class DbParser
    {
        public static void AugmentSchemaFromCsv(string CsvDirectory, EduHubSchema Schema)
        {
            var tables = new List<SysTable>();
            using (var stream = new FileStream(Path.Combine(CsvDirectory, "SQL_Schema_Tables.csv"), FileMode.Open))
            {
                using (var reader = new CsvReader(stream))
                {
                    tables = SysBuilder.ImportCsv<SysTable>(reader,
                        (ColumnName: "NAME", Mapper: (t, v) => t.name = v),
                        (ColumnName: "OBJECT_ID", Mapper: (t, v) => t.object_id = int.Parse(v))
                        );
                }
            }

            var types = new List<SysType>();
            using (var stream = new FileStream(Path.Combine(CsvDirectory, "SQL_Schema_Types.csv"), FileMode.Open))
            {
                using (var reader = new CsvReader(stream))
                {
                    types = SysBuilder.ImportCsv<SysType>(reader,
                        (ColumnName: "NAME", Mapper: (t, v) => t.name = v),
                        (ColumnName: "USER_TYPE_ID", Mapper: (t, v) => t.user_type_id = int.Parse(v))
                        );
                }
            }

            var columns = new List<SysColumn>();
            using (var stream = new FileStream(Path.Combine(CsvDirectory, "SQL_Schema_Columns.csv"), FileMode.Open))
            {
                using (var reader = new CsvReader(stream))
                {
                    columns = SysBuilder.ImportCsv<SysColumn>(reader,
                        (ColumnName: "OBJECT_ID",       Mapper: (t, v) => t.object_id = int.Parse(v)),
                        (ColumnName: "NAME", Mapper: (t, v) => t.name = v),
                        (ColumnName: "COLUMN_ID",       Mapper: (t, v) => t.column_id = int.Parse(v)),
                        (ColumnName: "USER_TYPE_ID",    Mapper: (t, v) => t.user_type_id = int.Parse(v)),
                        (ColumnName: "MAX_LENGTH",      Mapper: (t, v) => t.max_length = int.Parse(v)),
                        (ColumnName: "IS_NULLABLE",     Mapper: (t, v) => t.is_nullable = v.AsBool()),
                        (ColumnName: "IS_IDENTITY",     Mapper: (t, v) => t.is_identity = v.AsBool())
                        );
                }
            }

            var indexes = new List<SysIndex>();
            using (var stream = new FileStream(Path.Combine(CsvDirectory, "SQL_Schema_Indexes.csv"), FileMode.Open))
            {
                using (var reader = new CsvReader(stream))
                {
                    indexes = SysBuilder.ImportCsv<SysIndex>(reader,
                        (ColumnName: "OBJECT_ID",        Mapper: (t, v) => t.object_id = int.Parse(v)),
                        (ColumnName: "NAME", Mapper: (t, v) => t.name = v),
                        (ColumnName: "INDEX_ID",         Mapper: (t, v) => t.index_id = int.Parse(v)),
                        (ColumnName: "TYPE", Mapper: (t, v) => t.type = int.Parse(v)),
                        (ColumnName: "IS_UNIQUE",        Mapper: (t, v) => t.is_unique = v.AsBool()),
                        (ColumnName: "IS_PRIMARY_KEY",   Mapper: (t, v) => t.is_primary_key = v.AsBool())
                        );
                }
            }

            var indexColumns = new List<SysIndexColumn>();
            using (var stream = new FileStream(Path.Combine(CsvDirectory, "SQL_Schema_IndexColumns.csv"), FileMode.Open))
            {
                using (var reader = new CsvReader(stream))
                {
                    indexColumns = SysBuilder.ImportCsv<SysIndexColumn>(reader,
                        (ColumnName: "OBJECT_ID",   Mapper: (t, v) => t.object_id = int.Parse(v)),
                        (ColumnName: "INDEX_ID",    Mapper: (t, v) => t.index_id = int.Parse(v)),
                        (ColumnName: "COLUMN_ID",   Mapper: (t, v) => t.column_id = int.Parse(v)),
                        (ColumnName: "KEY_ORDINAL", Mapper: (t, v) => t.key_ordinal = byte.Parse(v))
                        );
                }
            }

            AugmentSchema(Schema, tables, types, columns, indexes, indexColumns);
        }

        public static void AugmentSchemaFromSql(string ConnectionString, EduHubSchema Schema)
        {
            var tables = new List<SysTable>();
            var types = new List<SysType>();
            var columns = new List<SysColumn>();
            var indexes = new List<SysIndex>();
            var indexColumns = new List<SysIndexColumn>();

            using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                // Tables
                const string sqlTables = @"SELECT name, object_id FROM sys.tables";
                using (var dbCommand = new SqlCommand(sqlTables, dbConnection))
                {
                    using (var dbReader = dbCommand.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            tables.Add(new SysTable()
                            {
                                name = dbReader.GetString(0),
                                object_id = dbReader.GetInt32(1)
                            });
                        }
                    }
                }

                // Types
                const string sqlTypes = @"SELECT name, user_type_id FROM sys.types";
                using (var dbCommand = new SqlCommand(sqlTypes, dbConnection))
                {
                    using (var dbReader = dbCommand.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            types.Add(new SysType()
                            {
                                name = dbReader.GetString(0),
                                user_type_id = dbReader.GetInt32(1)
                            });
                        }
                    }
                }

                // Columns
                const string sqlColumns = @"SELECT object_id, name, column_id, user_type_id, max_length, is_nullable, is_identity FROM sys.columns";
                using (var dbCommand = new SqlCommand(sqlColumns, dbConnection))
                {
                    using (var dbReader = dbCommand.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            columns.Add(new SysColumn()
                            {
                                object_id = dbReader.GetInt32(0),
                                name = dbReader.GetString(1),
                                column_id = dbReader.GetInt32(2),
                                user_type_id = dbReader.GetInt32(3),
                                max_length = dbReader.GetInt16(4),
                                is_nullable = dbReader.GetBoolean(5),
                                is_identity = dbReader.GetBoolean(6)
                            });
                        }
                    }
                }

                // Indexes
                const string sqlIndexes = @"SELECT object_id, name, index_id, type, is_unique, is_primary_key FROM sys.indexes";
                using (var dbCommand = new SqlCommand(sqlIndexes, dbConnection))
                {
                    using (var dbReader = dbCommand.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            indexes.Add(new SysIndex()
                            {
                                object_id = dbReader.GetInt32(0),
                                name = dbReader.IsDBNull(1) ? null : dbReader.GetString(1),
                                index_id = dbReader.GetInt32(2),
                                type = dbReader.GetByte(3),
                                is_unique = dbReader.GetBoolean(4),
                                is_primary_key = dbReader.GetBoolean(5)
                            });
                        }
                    }
                }

                // Index Columns
                const string sqlIndexColumns = @"SELECT object_id, index_id, column_id, key_ordinal FROM sys.index_columns";
                using (var dbCommand = new SqlCommand(sqlIndexColumns, dbConnection))
                {
                    using (var dbReader = dbCommand.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            indexColumns.Add(new SysIndexColumn()
                            {
                                object_id = dbReader.GetInt32(0),
                                index_id = dbReader.GetInt32(1),
                                column_id = dbReader.GetInt32(2),
                                key_ordinal = dbReader.GetByte(3)
                            });
                        }
                    }
                }

                dbConnection.Close();
            }

            AugmentSchema(Schema, tables, types, columns, indexes, indexColumns);
        }

        private static void AugmentSchema(EduHubSchema Schema, List<SysTable> Tables, List<SysType> Types, List<SysColumn> Columns, List<SysIndex> Indexes, List<SysIndexColumn> IndexColumns)
        {
            var tableLookup = Tables.ToDictionary(t => t.name, t => t.object_id, StringComparer.OrdinalIgnoreCase);
            var typeLookup = Types.ToDictionary(t => t.user_type_id, t => t.name);
            var columnsLookup = Columns
                .GroupBy(c => c.object_id)
                .ToDictionary(g => g.Key, g => g.OrderBy(c => c.column_id).ToList());
            var indexLookup = Indexes
                .GroupBy(i => i.object_id)
                .ToDictionary(g => g.Key, g => g.OrderBy(i => i.index_id).ToList());
            var indexColumnLookup = IndexColumns
                .GroupBy(ic => ic.object_id)
                .ToDictionary(g => g.Key, g => g.GroupBy(ic => ic.index_id).ToDictionary(g2 => g2.Key, g2 => g2.OrderBy(ic => ic.key_ordinal).ToList()));

            foreach (var entity in Schema.Entities)
            {
                // Table ID

                if (!tableLookup.TryGetValue(entity.Name, out int tableObjectId))
                {
                    throw new InvalidOperationException($"Unknown Entity: {entity.Name}");
                }
                else
                {
                    // COLUMNS
                    // Validate schema conformance; determine nullable and identity columns
                    if (columnsLookup.TryGetValue(tableObjectId, out List<SysColumn> entityColumns))
                    {
                        foreach (var column in entityColumns)
                        {
                            var field = entity.Fields.First(f => f.Name.Equals(column.name, StringComparison.OrdinalIgnoreCase));

                            field.SqlType = typeLookup[column.user_type_id];

                            // Check Framework Type
                            if (field.Type != GetFrameworkType(field.SqlType))
                            {
                                // Overrides
                                if (field.Entity.Name == "SPFSTORE" && field.Name == "ASSOCIATION_TYPE" && field.Type == "short" && field.SqlType == "int")
                                {
                                    field.Type = "int";
                                }
                                else
                                {
                                    throw new InvalidOperationException("Entity field type didn't match database schema");
                                }
                            }

                            switch (field.SqlType)
                            {
                                case "varchar":
                                case "varbinary":
                                    if (field.TypeMaxLength == 0)
                                    {
                                        field.TypeMaxLength = column.max_length;
                                    }

                                    // Overrides
                                    if (field.Entity.Name == "SPFSTORE" && field.Name == "PHYSICAL_LOCATION" && field.TypeMaxLength == 255 && column.max_length == 500)
                                    {
                                        field.TypeMaxLength = column.max_length;
                                        break;
                                    }

                                    if (field.TypeMaxLength != column.max_length)
                                    {
                                        throw new InvalidOperationException("Entity field max length didn't match database schema");
                                    }
                                    break;
                            }

                            if (!field.IsNullable && column.is_nullable)
                            {
                                throw new InvalidOperationException("Entity field nullable didn't match database schema");
                            }

                            if (field.IsNullable && !column.is_nullable)
                            {
                                field.IsNullable = false;
                            }

                            if (field.IsIdentity && !column.is_identity)
                            {
                                throw new InvalidOperationException("Entity field identity didn't match database schema");
                            }

                            if (!field.IsIdentity && column.is_identity)
                            {
                                field.IsIdentity = true;
                            }
                        }
                    }

                    // INDEXES
                    // Determine Indexes
                    if (indexLookup.TryGetValue(tableObjectId, out List<SysIndex> entityIndexes))
                    {
                        foreach (var entityIndex in entityIndexes)
                        {
                            List<SysIndexColumn> indexColumns = indexColumnLookup[entityIndex.object_id][entityIndex.index_id];

                            List<EduHubField> fields = indexColumns
                                .Select(ic => entity.Fields.First(f => f.Name.Equals(entityColumns.First(c => c.column_id == ic.column_id).name, StringComparison.OrdinalIgnoreCase)))
                                .ToList();

                            if (fields.Count == 0)
                                throw new InvalidOperationException("Unexpected index with no columns");

                            var indexName = $"Index_{string.Join("_", fields.Select(f => f.Name))}";
                            
                            if (fields.Count > 8)
                            {
                                System.Diagnostics.Debug.WriteLine($"Unsupported Index: [{entity.Name}]:{indexName}");
                                continue;
                            }

                            var index = new EduHubIndex(
                                Entity: entity,
                                Name: indexName,
                                Fields: fields.AsReadOnly(),
                                IsPrimary: entityIndex.is_primary_key,
                                IsUnique: entityIndex.is_unique,
                                IsClustered: entityIndex.type == 1);  // 1 = Clustered, 2 = Non Clustered

                            // Check for existing Index with matching Fields; if matched, add unique or shortest name;
                            var matchingIndex = entity.Indexes.FirstOrDefault(ei => ei.Fields.Count == index.Fields.Count && ei.Fields.All(f => index.Fields.Contains(f)));
                            if (matchingIndex != null)
                            {
                                if ((!matchingIndex.IsUnique && index.IsUnique) || // New Index is unique
                                    (!matchingIndex.IsPrimary && index.IsPrimary) || // New Index is primary
                                    (!matchingIndex.IsClustered && index.IsClustered) || // New Index is clustered
                                    (index.Name.Length < matchingIndex.Name.Length)) // New Index has shorter name
                                {
                                    // Remove existing, add new
                                    entity.RemoveIndex(matchingIndex);
                                    entity.AddIndex(index);
                                }
                            }
                            else
                            {
                                entity.AddIndex(index);
                            }
                        }
                    }

                    // Ensure identity columns have index
                    foreach (var identityField in entity.Fields.Where(f => f.IsIdentity))
                    {
                        var name = $"Index_{identityField.Name}";

                        var index = new EduHubIndex(
                            Entity: entity,
                            Name: name,
                            Fields: new List<EduHubField>() { identityField }.AsReadOnly(),
                            IsPrimary: false,
                            IsUnique: true,
                            IsClustered: false);

                        // Check for existing Index with matching Fields; if matched, add unique or shortest name;
                        var matchingIndex = entity.Indexes.FirstOrDefault(ei => ei.Fields.Count == index.Fields.Count && ei.Fields.All(f => index.Fields.Contains(f)));
                        if (matchingIndex != null)
                        {
                            if ((!matchingIndex.IsUnique && index.IsUnique) || // New Index is unique
                                (index.Name.Length < matchingIndex.Name.Length)) // New Index has shorter name
                            {
                                if (matchingIndex.IsClustered)
                                {
                                    throw new InvalidOperationException("Shouldn't replace clustered indexes");
                                }
                                if (matchingIndex.IsPrimary)
                                {
                                    throw new InvalidOperationException("Shouldn't replace primary indexes");
                                }

                                // Remove existing, add new
                                entity.RemoveIndex(matchingIndex);
                                entity.AddIndex(index);
                            }
                        }
                        else
                        {
                            entity.AddIndex(index);
                        }
                    }

                }


            }
        }

        public static string GetFrameworkType(string FieldType)
        {
            switch (FieldType.ToLowerInvariant())
            {
                case "varchar":
                    return "string";
                case "int":
                    return "int";
                case "float":
                    return "double";
                case "datetime":
                    return "DateTime";
                case "smallint":
                    return "short";
                case "text":
                    return "string";
                case "money":
                    return "decimal";
                case "varbinary":
                case "image":
                    return "byte[]";
                default:
                    throw new ArgumentException("Unknown Sql Type", "SqlType");
            }
        }

        private static bool AsBool(this string Value)
        {
            return !string.IsNullOrWhiteSpace(Value) &&
                (
                "1".Equals(Value, StringComparison.Ordinal) ||
                "True".Equals(Value, StringComparison.OrdinalIgnoreCase)
                );
        }
    }
}

using EduHub.Data.SchemaParser.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace EduHub.Data.SchemaParser.Db
{
    public static class DbParser
    {

        public static void AugmentSchema(string ConnectionString, EduHubSchema Schema)
        {
            const string sqlColumns = @"SELECT c.name, c.max_length, c.is_nullable, c.is_identity, st.name
FROM sys.tables t
JOIN sys.columns c on c.object_id=t.object_id
JOIN sys.systypes st ON c.system_type_id=st.xtype
WHERE t.name=@TableName
ORDER BY c.column_id";
            const string sqlIndexes = @"SELECT t.object_id, i.index_id, i.name, i.is_primary_key, i.is_unique, i.type
FROM sys.tables t
JOIN sys.indexes i ON i.object_id=t.object_id
WHERE t.name=@TableName";
            const string sqlIndex = @"SELECT c.name
FROM sys.indexes i
JOIN sys.index_columns ic ON ic.object_id=i.object_id AND ic.index_id=i.index_id
JOIN sys.columns c ON c.object_id=ic.object_id AND c.column_id=ic.column_id
WHERE i.object_id=@ObjectId AND i.index_id=@IndexId
ORDER BY ic.key_ordinal;";

            using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                foreach (var entity in Schema.Entities)
                {
                    // Validate schema conformance; determine nullable and identity columns
                    using (SqlCommand dbColumnsCommand = new SqlCommand(sqlColumns, dbConnection))
                    {
                        var dbColumnsTableParam = dbColumnsCommand.Parameters.Add("@TableName", SqlDbType.NVarChar, 128);
                        dbColumnsTableParam.Value = entity.Name;

                        using (var dbColumnsReader = dbColumnsCommand.ExecuteReader())
                        {
                            while (dbColumnsReader.Read())
                            {
                                var fieldName = dbColumnsReader.GetString(0);
                                var maxLength = dbColumnsReader.GetInt16(1);
                                var isNullable = dbColumnsReader.GetBoolean(2);
                                var isIdentity = dbColumnsReader.GetBoolean(3);
                                var fieldType = dbColumnsReader.GetString(4);
                                var frameworkType = DetermineFrameworkType(fieldType);

                                var field = entity.Fields.First(f => f.Name.Equals(fieldName, StringComparison.OrdinalIgnoreCase));

                                field.SqlType = fieldType;

                                // Check Framework Type
                                if (field.Type != frameworkType)
                                {
                                    throw new InvalidOperationException("Entity field type didn't match database schema");
                                }
                                if ((field.TypeMaxLength != 0 || field.Type == "string") && field.TypeMaxLength != maxLength && fieldType != "text")
                                {
                                    // Overrides
                                    if (field.Entity.Name == "KERROR" && field.Name == "SPOUTKEY" && field.TypeMaxLength == 100 && maxLength == 40)
                                    {
                                        field.TypeMaxLength = maxLength;
                                    }
                                    else if (field.Entity.Name == "SPOUT" && field.Name == "SPOUTKEY" && field.TypeMaxLength == 100 && maxLength == 40)
                                    {
                                        field.TypeMaxLength = maxLength;
                                    }
                                    else
                                    {
                                        throw new InvalidOperationException("Entity field max length didn't match database schema");
                                    }
                                }
                                if (!field.IsNullable && isNullable)
                                {
                                    throw new InvalidOperationException("Entity field nullable didn't match database schema");
                                }

                                if (field.IsNullable && !isNullable)
                                {
                                    field.IsNullable = false;
                                }

                                if (field.IsIdentity && !isIdentity)
                                {
                                    throw new InvalidOperationException("Entity field identity didn't match database schema");
                                }

                                if (!field.IsIdentity && isIdentity)
                                {
                                    field.IsIdentity = true;
                                }
                            }
                        }

                    }

                    // Determine Indexes
                    using (SqlCommand dbIndexesCommand = new SqlCommand(sqlIndexes, dbConnection))
                    {
                        var dbIndexesTableParam = dbIndexesCommand.Parameters.Add("@TableName", SqlDbType.NVarChar, 128);
                        dbIndexesTableParam.Value = entity.Name;

                        using (var dbIndexesReader = dbIndexesCommand.ExecuteReader())
                        {
                            while (dbIndexesReader.Read())
                            {
                                var objectId = dbIndexesReader.GetInt32(0);
                                var indexId = dbIndexesReader.GetInt32(1);
                                var name = dbIndexesReader.GetString(2);
                                var isPrimary = dbIndexesReader.GetBoolean(3);
                                var isUnique = dbIndexesReader.GetBoolean(4);
                                var isClustered = dbIndexesReader.GetByte(5) == 1; // 1 = Clustered, 2 = Non Clustered
                                List<EduHubField> fields = new List<EduHubField>();

                                using (SqlCommand dbIndexCommand = new SqlCommand(sqlIndex, dbConnection))
                                {
                                    var dbIndexObjectIdParam = dbIndexCommand.Parameters.Add("@ObjectId", SqlDbType.Int);
                                    var dbIndexIdParam = dbIndexCommand.Parameters.Add("@IndexId", SqlDbType.Int);
                                    dbIndexObjectIdParam.Value = objectId;
                                    dbIndexIdParam.Value = indexId;

                                    using (var dbIndexReader = dbIndexCommand.ExecuteReader())
                                    {
                                        while (dbIndexReader.Read())
                                        {
                                            var fieldName = dbIndexReader.GetString(0);
                                            fields.Add(entity.Fields.First(f => f.Name.Equals(fieldName, StringComparison.OrdinalIgnoreCase)));
                                        }
                                    }
                                }

                                if (fields.Count == 0)
                                    throw new InvalidOperationException("Unexpected index with no columns");

                                name = $"Index_{string.Join("_", fields.Select(f => f.Name))}";

                                var index = new EduHubIndex(
                                    Entity: entity,
                                    Name: name,
                                    Fields: fields.AsReadOnly(),
                                    IsPrimary: isPrimary,
                                    IsUnique: isUnique,
                                    IsClustered: isClustered);

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
                dbConnection.Close();
            }
        }

        public static string DetermineSqlType(string SqlType, int MaxLength)
        {
            if (SqlType.Equals("varchar", StringComparison.OrdinalIgnoreCase))
            {
                return $"{SqlType}({MaxLength})";
            }
            else
            {
                return SqlType;
            }
        }

        public static string DetermineFrameworkType(string SqlType)
        {
            switch (SqlType.ToLowerInvariant())
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
                case "image":
                    return "byte[]";
                default:
                    throw new ArgumentException("Unknown Sql Type", "SqlType");
            }
        }

    }
}

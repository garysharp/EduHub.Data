using EduHub.Data.SchemaParser.C7;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.SchemaParser.Models
{
    public static class EduHubSchemaExtensions
    {

        public static IEnumerable<EduHubField> ToEduHubFields(this IC7Entity c7Entity, EduHubEntity Entity)
        {
            foreach (var c7Field in c7Entity.Fields)
            {
                foreach (var field in c7Field.ToEduHubFields(c7Entity, Entity))
                {
                    yield return field;
                }
            }
        }

        public static IEnumerable<EduHubField> ToEduHubFields(this C7Field c7Field, IC7Entity c7Entity, EduHubEntity Entity)
        {
            var type = ParseType(c7Field.Type);
            var isKey = c7Entity.Keys?.Contains(c7Field.Name, StringComparer.OrdinalIgnoreCase) ?? false;
            var isIdentity = c7Field.IsSequence || (c7Entity.IsDbSeq && c7Entity.Fields[0] == c7Field);
            var isNullable = !isIdentity;

            if (type.FieldCount == 1)
            {
                yield return new EduHubField(
                    Entity: Entity,
                    Name: c7Field.Name,
                    Description: c7Field.SchemaComment.Trim(),
                    Type: type.FrameworkType,
                    TypeDescription: type.Description,
                    TypeMaxLength: type.Precision,
                    IsKey: isKey,
                    IsNullable: isNullable,
                    IsIdentity: isIdentity,
                    ForeignParentKey: (c7Field.Relationship.Entity, c7Field.Relationship.Field)
                    );
            }
            else
            {
                for (int i = 0; i < type.FieldCount; i++)
                {
                    yield return new EduHubField(
                        Entity: Entity,
                        Name: $"{c7Field.Name}{i + 1:00}",
                        Description: c7Field.SchemaComment.Trim(),
                        Type: type.FrameworkType,
                        TypeDescription: type.Description,
                        TypeMaxLength: type.Precision,
                        IsKey: isKey,
                        IsNullable: isNullable,
                        IsIdentity: isIdentity,
                        ForeignParentKey: (c7Field.Relationship.Entity, c7Field.Relationship.Field)
                        );
                }
            }
        }

        public static (int FieldCount, string FrameworkType, string Description, int Precision) ParseType(string Type)
        {
            int typeIndex = 0;
            int fieldCount = 1;
            while (typeIndex < Type.Length && char.IsNumber(Type[typeIndex]))
            {
                typeIndex++;
            }
            if (typeIndex > 0)
            {
                fieldCount = int.Parse(Type.Substring(0, typeIndex));
            }

            switch (char.ToUpperInvariant(Type[typeIndex++]))
            {
                case 'A':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "string",
                        Description: "Alphanumeric",
                        Precision: int.Parse(Type.Substring(typeIndex))
                        );
                case 'U':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "string",
                        Description: "Uppercase Alphanumeric",
                        Precision: int.Parse(Type.Substring(typeIndex))
                        );
                case 'T':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "string",
                        Description: "Titlecase",
                        Precision: int.Parse(Type.Substring(typeIndex))
                        );
                case 'I':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "short",
                        Description: "Integer",
                        Precision: 0
                        );
                case 'L':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "int",
                        Description: "Integer",
                        Precision: 0
                        );
                case 'R':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "double",
                        Description: "Floating Point Number",
                        Precision: 0
                        );
                case 'C':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "decimal",
                        Description: "Currency",
                        Precision: 0
                        );
                case 'D':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "DateTime",
                        Description: "Date Time",
                        Precision: 0
                        );
                case 'M':
                    return (
                        FieldCount: fieldCount,
                        FrameworkType: "string",
                        Description: "Memo",
                        Precision: 0
                        );
                case 'B':
                    switch (char.ToUpperInvariant(Type[typeIndex++]))
                    {
                        case 'A':
                            return (
                                FieldCount: fieldCount,
                                FrameworkType: "byte[]",
                                Description: "Avilable",
                                Precision: 0
                                );
                        case 'P':
                            return (
                                FieldCount: fieldCount,
                                FrameworkType: "byte[]",
                                Description: "Picture",
                                Precision: 0
                                );
                        case 'B':
                            return (
                                FieldCount: fieldCount,
                                FrameworkType: "byte[]",
                                Description: "Batch Information",
                                Precision: 0
                                );
                        case 'G':
                            return (
                                FieldCount: fieldCount,
                                FrameworkType: "byte[]",
                                Description: "Grid",
                                Precision: 0
                                );
                        case 'O':
                            return (
                                FieldCount: fieldCount,
                                FrameworkType: "byte[]",
                                Description: "OLE Controls",
                                Precision: 0
                                );
                        case 'F':
                            return (
                                FieldCount: fieldCount,
                                FrameworkType: "byte[]",
                                Description: "OLE Files",
                                Precision: 0
                                );
                        default:
                            throw new InvalidOperationException("Unknown field type");
                    }
                default:
                    throw new InvalidOperationException("Unknown field type");
            }
        }

    }
}

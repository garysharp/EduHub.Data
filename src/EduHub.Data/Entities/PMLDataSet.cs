using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medicare Levy Parameters Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PMLDataSet : EduHubDataSet<PML>
    {
        /// <inheritdoc />
        public override string Name { get { return "PML"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PMLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCALE = new Lazy<Dictionary<short, PML>>(() => this.ToDictionary(i => i.SCALE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PML" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PML" /> fields for each CSV column header</returns>
        internal override Action<PML, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PML, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCALE":
                        mapper[i] = (e, v) => e.SCALE = short.Parse(v);
                        break;
                    case "WEEKLY_EARNING_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_EARNING_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_SHADEIN_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_SHADEIN_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MEDLEVY_FAMILY_THRESHOLD":
                        mapper[i] = (e, v) => e.MEDLEVY_FAMILY_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WFT_DIVISOR":
                        mapper[i] = (e, v) => e.WFT_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ADDITIONAL_CHILD":
                        mapper[i] = (e, v) => e.ADDITIONAL_CHILD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SOP_MULTIPLIER":
                        mapper[i] = (e, v) => e.SOP_MULTIPLIER = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SOP_DIVISOR":
                        mapper[i] = (e, v) => e.SOP_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "WLA_FALCTOR":
                        mapper[i] = (e, v) => e.WLA_FALCTOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MEDICARE_LEVY":
                        mapper[i] = (e, v) => e.MEDICARE_LEVY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="PML" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PML" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PML" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PML}"/> of entities</returns>
        internal override IEnumerable<PML> ApplyDeltaEntities(IEnumerable<PML> Entities, List<PML> DeltaEntities)
        {
            HashSet<short> Index_SCALE = new HashSet<short>(DeltaEntities.Select(i => i.SCALE));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCALE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SCALE.Remove(entity.SCALE);
                            
                            if (entity.SCALE.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<Dictionary<short, PML>> Index_SCALE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <returns>Related PML entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML FindBySCALE(short SCALE)
        {
            return Index_SCALE.Value[SCALE];
        }

        /// <summary>
        /// Attempt to find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <param name="Value">Related PML entity</param>
        /// <returns>True if the related PML entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCALE(short SCALE, out PML Value)
        {
            return Index_SCALE.Value.TryGetValue(SCALE, out Value);
        }

        /// <summary>
        /// Attempt to find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <returns>Related PML entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML TryFindBySCALE(short SCALE)
        {
            PML value;
            if (Index_SCALE.Value.TryGetValue(SCALE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PML table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PML]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PML](
        [SCALE] smallint NOT NULL,
        [WEEKLY_EARNING_THRESHOLD] money NULL,
        [WEEKLY_SHADEIN_THRESHOLD] money NULL,
        [MEDLEVY_FAMILY_THRESHOLD] money NULL,
        [WFT_DIVISOR] float NULL,
        [ADDITIONAL_CHILD] money NULL,
        [SOP_MULTIPLIER] float NULL,
        [SOP_DIVISOR] float NULL,
        [WLA_FALCTOR] float NULL,
        [MEDICARE_LEVY] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PML_Index_SCALE] PRIMARY KEY CLUSTERED (
            [SCALE] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="PMLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="PMLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PML"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PML"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PML> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_SCALE = new List<short>();

            foreach (var entity in Entities)
            {
                Index_SCALE.Add(entity.SCALE);
            }

            builder.AppendLine("DELETE [dbo].[PML] WHERE");


            // Index_SCALE
            builder.Append("[SCALE] IN (");
            for (int index = 0; index < Index_SCALE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCALE
                var parameterSCALE = $"@p{parameterIndex++}";
                builder.Append(parameterSCALE);
                command.Parameters.Add(parameterSCALE, SqlDbType.SmallInt).Value = Index_SCALE[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PML data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PML data set</returns>
        public override EduHubDataSetDataReader<PML> GetDataSetDataReader()
        {
            return new PMLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PML data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PML data set</returns>
        public override EduHubDataSetDataReader<PML> GetDataSetDataReader(List<PML> Entities)
        {
            return new PMLDataReader(new EduHubDataSetLoadedReader<PML>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PMLDataReader : EduHubDataSetDataReader<PML>
        {
            public PMLDataReader(IEduHubDataSetReader<PML> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCALE
                        return Current.SCALE;
                    case 1: // WEEKLY_EARNING_THRESHOLD
                        return Current.WEEKLY_EARNING_THRESHOLD;
                    case 2: // WEEKLY_SHADEIN_THRESHOLD
                        return Current.WEEKLY_SHADEIN_THRESHOLD;
                    case 3: // MEDLEVY_FAMILY_THRESHOLD
                        return Current.MEDLEVY_FAMILY_THRESHOLD;
                    case 4: // WFT_DIVISOR
                        return Current.WFT_DIVISOR;
                    case 5: // ADDITIONAL_CHILD
                        return Current.ADDITIONAL_CHILD;
                    case 6: // SOP_MULTIPLIER
                        return Current.SOP_MULTIPLIER;
                    case 7: // SOP_DIVISOR
                        return Current.SOP_DIVISOR;
                    case 8: // WLA_FALCTOR
                        return Current.WLA_FALCTOR;
                    case 9: // MEDICARE_LEVY
                        return Current.MEDICARE_LEVY;
                    case 10: // LW_DATE
                        return Current.LW_DATE;
                    case 11: // LW_TIME
                        return Current.LW_TIME;
                    case 12: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // WEEKLY_EARNING_THRESHOLD
                        return Current.WEEKLY_EARNING_THRESHOLD == null;
                    case 2: // WEEKLY_SHADEIN_THRESHOLD
                        return Current.WEEKLY_SHADEIN_THRESHOLD == null;
                    case 3: // MEDLEVY_FAMILY_THRESHOLD
                        return Current.MEDLEVY_FAMILY_THRESHOLD == null;
                    case 4: // WFT_DIVISOR
                        return Current.WFT_DIVISOR == null;
                    case 5: // ADDITIONAL_CHILD
                        return Current.ADDITIONAL_CHILD == null;
                    case 6: // SOP_MULTIPLIER
                        return Current.SOP_MULTIPLIER == null;
                    case 7: // SOP_DIVISOR
                        return Current.SOP_DIVISOR == null;
                    case 8: // WLA_FALCTOR
                        return Current.WLA_FALCTOR == null;
                    case 9: // MEDICARE_LEVY
                        return Current.MEDICARE_LEVY == null;
                    case 10: // LW_DATE
                        return Current.LW_DATE == null;
                    case 11: // LW_TIME
                        return Current.LW_TIME == null;
                    case 12: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCALE
                        return "SCALE";
                    case 1: // WEEKLY_EARNING_THRESHOLD
                        return "WEEKLY_EARNING_THRESHOLD";
                    case 2: // WEEKLY_SHADEIN_THRESHOLD
                        return "WEEKLY_SHADEIN_THRESHOLD";
                    case 3: // MEDLEVY_FAMILY_THRESHOLD
                        return "MEDLEVY_FAMILY_THRESHOLD";
                    case 4: // WFT_DIVISOR
                        return "WFT_DIVISOR";
                    case 5: // ADDITIONAL_CHILD
                        return "ADDITIONAL_CHILD";
                    case 6: // SOP_MULTIPLIER
                        return "SOP_MULTIPLIER";
                    case 7: // SOP_DIVISOR
                        return "SOP_DIVISOR";
                    case 8: // WLA_FALCTOR
                        return "WLA_FALCTOR";
                    case 9: // MEDICARE_LEVY
                        return "MEDICARE_LEVY";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCALE":
                        return 0;
                    case "WEEKLY_EARNING_THRESHOLD":
                        return 1;
                    case "WEEKLY_SHADEIN_THRESHOLD":
                        return 2;
                    case "MEDLEVY_FAMILY_THRESHOLD":
                        return 3;
                    case "WFT_DIVISOR":
                        return 4;
                    case "ADDITIONAL_CHILD":
                        return 5;
                    case "SOP_MULTIPLIER":
                        return 6;
                    case "SOP_DIVISOR":
                        return 7;
                    case "WLA_FALCTOR":
                        return 8;
                    case "MEDICARE_LEVY":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

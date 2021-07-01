using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCYDataSet : EduHubDataSet<KCY>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCY"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCYKEY = new Lazy<Dictionary<string, KCY>>(() => this.ToDictionary(i => i.KCYKEY));
            Index_NEXT_YR = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_YR));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TEACHER_B = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER_B));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCY" /> fields for each CSV column header</returns>
        internal override Action<KCY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCYKEY":
                        mapper[i] = (e, v) => e.KCYKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NUM_EQVT":
                        mapper[i] = (e, v) => e.NUM_EQVT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SHORT_DESC":
                        mapper[i] = (e, v) => e.SHORT_DESC = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "NEXT_YR":
                        mapper[i] = (e, v) => e.NEXT_YR = v;
                        break;
                    case "FINAL_YR":
                        mapper[i] = (e, v) => e.FINAL_YR = v;
                        break;
                    case "CSF_REQUIRED":
                        mapper[i] = (e, v) => e.CSF_REQUIRED = v;
                        break;
                    case "HALF_DAY_ABS":
                        mapper[i] = (e, v) => e.HALF_DAY_ABS = v;
                        break;
                    case "PERIOD_ABS":
                        mapper[i] = (e, v) => e.PERIOD_ABS = v;
                        break;
                    case "BIRTHDATE_FROM":
                        mapper[i] = (e, v) => e.BIRTHDATE_FROM = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "BIRTHDATE_TO":
                        mapper[i] = (e, v) => e.BIRTHDATE_TO = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="KCY" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCY" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCY" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCY}"/> of entities</returns>
        internal override IEnumerable<KCY> ApplyDeltaEntities(IEnumerable<KCY> Entities, List<KCY> DeltaEntities)
        {
            HashSet<string> Index_KCYKEY = new HashSet<string>(DeltaEntities.Select(i => i.KCYKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KCYKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KCYKEY.Remove(entity.KCYKEY);
                            
                            if (entity.KCYKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KCY>> Index_KCYKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_NEXT_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_TEACHER_B;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCY FindByKCYKEY(string KCYKEY)
        {
            return Index_KCYKEY.Value[KCYKEY];
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <param name="Value">Related KCY entity</param>
        /// <returns>True if the related KCY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCYKEY(string KCYKEY, out KCY Value)
        {
            return Index_KCYKEY.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCY TryFindByKCYKEY(string KCYKEY)
        {
            KCY value;
            if (Index_KCYKEY.Value.TryGetValue(KCYKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByNEXT_YR(string NEXT_YR)
        {
            return Index_NEXT_YR.Value[NEXT_YR];
        }

        /// <summary>
        /// Attempt to find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEXT_YR(string NEXT_YR, out IReadOnlyList<KCY> Value)
        {
            return Index_NEXT_YR.Value.TryGetValue(NEXT_YR, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByNEXT_YR(string NEXT_YR)
        {
            IReadOnlyList<KCY> value;
            if (Index_NEXT_YR.Value.TryGetValue(NEXT_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<KCY> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<KCY> value;
            if (Index_TEACHER.Value.TryGetValue(TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByTEACHER_B(string TEACHER_B)
        {
            return Index_TEACHER_B.Value[TEACHER_B];
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER_B(string TEACHER_B, out IReadOnlyList<KCY> Value)
        {
            return Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByTEACHER_B(string TEACHER_B)
        {
            IReadOnlyList<KCY> value;
            if (Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCY table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCY](
        [KCYKEY] varchar(4) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [NUM_EQVT] smallint NULL,
        [SHORT_DESC] varchar(10) NULL,
        [TEACHER] varchar(4) NULL,
        [TEACHER_B] varchar(4) NULL,
        [NEXT_YR] varchar(4) NULL,
        [FINAL_YR] varchar(1) NULL,
        [CSF_REQUIRED] varchar(1) NULL,
        [HALF_DAY_ABS] varchar(1) NULL,
        [PERIOD_ABS] varchar(1) NULL,
        [BIRTHDATE_FROM] datetime NULL,
        [BIRTHDATE_TO] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCY_Index_KCYKEY] PRIMARY KEY CLUSTERED (
            [KCYKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCY_Index_NEXT_YR] ON [dbo].[KCY]
    (
            [NEXT_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [KCY_Index_TEACHER] ON [dbo].[KCY]
    (
            [TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [KCY_Index_TEACHER_B] ON [dbo].[KCY]
    (
            [TEACHER_B] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND name = N'KCY_Index_NEXT_YR')
    ALTER INDEX [KCY_Index_NEXT_YR] ON [dbo].[KCY] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND name = N'KCY_Index_TEACHER')
    ALTER INDEX [KCY_Index_TEACHER] ON [dbo].[KCY] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND name = N'KCY_Index_TEACHER_B')
    ALTER INDEX [KCY_Index_TEACHER_B] ON [dbo].[KCY] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND name = N'KCY_Index_NEXT_YR')
    ALTER INDEX [KCY_Index_NEXT_YR] ON [dbo].[KCY] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND name = N'KCY_Index_TEACHER')
    ALTER INDEX [KCY_Index_TEACHER] ON [dbo].[KCY] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND name = N'KCY_Index_TEACHER_B')
    ALTER INDEX [KCY_Index_TEACHER_B] ON [dbo].[KCY] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCY"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCY"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCY> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KCYKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KCYKEY.Add(entity.KCYKEY);
            }

            builder.AppendLine("DELETE [dbo].[KCY] WHERE");


            // Index_KCYKEY
            builder.Append("[KCYKEY] IN (");
            for (int index = 0; index < Index_KCYKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCYKEY
                var parameterKCYKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKCYKEY);
                command.Parameters.Add(parameterKCYKEY, SqlDbType.VarChar, 4).Value = Index_KCYKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCY data set</returns>
        public override EduHubDataSetDataReader<KCY> GetDataSetDataReader()
        {
            return new KCYDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCY data set</returns>
        public override EduHubDataSetDataReader<KCY> GetDataSetDataReader(List<KCY> Entities)
        {
            return new KCYDataReader(new EduHubDataSetLoadedReader<KCY>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCYDataReader : EduHubDataSetDataReader<KCY>
        {
            public KCYDataReader(IEduHubDataSetReader<KCY> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 16; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KCYKEY
                        return Current.KCYKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // NUM_EQVT
                        return Current.NUM_EQVT;
                    case 3: // SHORT_DESC
                        return Current.SHORT_DESC;
                    case 4: // TEACHER
                        return Current.TEACHER;
                    case 5: // TEACHER_B
                        return Current.TEACHER_B;
                    case 6: // NEXT_YR
                        return Current.NEXT_YR;
                    case 7: // FINAL_YR
                        return Current.FINAL_YR;
                    case 8: // CSF_REQUIRED
                        return Current.CSF_REQUIRED;
                    case 9: // HALF_DAY_ABS
                        return Current.HALF_DAY_ABS;
                    case 10: // PERIOD_ABS
                        return Current.PERIOD_ABS;
                    case 11: // BIRTHDATE_FROM
                        return Current.BIRTHDATE_FROM;
                    case 12: // BIRTHDATE_TO
                        return Current.BIRTHDATE_TO;
                    case 13: // LW_DATE
                        return Current.LW_DATE;
                    case 14: // LW_TIME
                        return Current.LW_TIME;
                    case 15: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // NUM_EQVT
                        return Current.NUM_EQVT == null;
                    case 3: // SHORT_DESC
                        return Current.SHORT_DESC == null;
                    case 4: // TEACHER
                        return Current.TEACHER == null;
                    case 5: // TEACHER_B
                        return Current.TEACHER_B == null;
                    case 6: // NEXT_YR
                        return Current.NEXT_YR == null;
                    case 7: // FINAL_YR
                        return Current.FINAL_YR == null;
                    case 8: // CSF_REQUIRED
                        return Current.CSF_REQUIRED == null;
                    case 9: // HALF_DAY_ABS
                        return Current.HALF_DAY_ABS == null;
                    case 10: // PERIOD_ABS
                        return Current.PERIOD_ABS == null;
                    case 11: // BIRTHDATE_FROM
                        return Current.BIRTHDATE_FROM == null;
                    case 12: // BIRTHDATE_TO
                        return Current.BIRTHDATE_TO == null;
                    case 13: // LW_DATE
                        return Current.LW_DATE == null;
                    case 14: // LW_TIME
                        return Current.LW_TIME == null;
                    case 15: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCYKEY
                        return "KCYKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // NUM_EQVT
                        return "NUM_EQVT";
                    case 3: // SHORT_DESC
                        return "SHORT_DESC";
                    case 4: // TEACHER
                        return "TEACHER";
                    case 5: // TEACHER_B
                        return "TEACHER_B";
                    case 6: // NEXT_YR
                        return "NEXT_YR";
                    case 7: // FINAL_YR
                        return "FINAL_YR";
                    case 8: // CSF_REQUIRED
                        return "CSF_REQUIRED";
                    case 9: // HALF_DAY_ABS
                        return "HALF_DAY_ABS";
                    case 10: // PERIOD_ABS
                        return "PERIOD_ABS";
                    case 11: // BIRTHDATE_FROM
                        return "BIRTHDATE_FROM";
                    case 12: // BIRTHDATE_TO
                        return "BIRTHDATE_TO";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCYKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "NUM_EQVT":
                        return 2;
                    case "SHORT_DESC":
                        return 3;
                    case "TEACHER":
                        return 4;
                    case "TEACHER_B":
                        return 5;
                    case "NEXT_YR":
                        return 6;
                    case "FINAL_YR":
                        return 7;
                    case "CSF_REQUIRED":
                        return 8;
                    case "HALF_DAY_ABS":
                        return 9;
                    case "PERIOD_ABS":
                        return 10;
                    case "BIRTHDATE_FROM":
                        return 11;
                    case "BIRTHDATE_TO":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

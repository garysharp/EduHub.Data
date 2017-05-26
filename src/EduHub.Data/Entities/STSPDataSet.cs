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
    /// Suspension Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSPDataSet : EduHubDataSet<STSP>
    {
        /// <inheritdoc />
        public override string Name { get { return "STSP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STSPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_REF_TEACHERA = new Lazy<NullDictionary<string, IReadOnlyList<STSP>>>(() => this.ToGroupedNullDictionary(i => i.REF_TEACHERA));
            Index_REF_TEACHERB = new Lazy<NullDictionary<string, IReadOnlyList<STSP>>>(() => this.ToGroupedNullDictionary(i => i.REF_TEACHERB));
            Index_SPKEY = new Lazy<Dictionary<string, IReadOnlyList<STSP>>>(() => this.ToGroupedDictionary(i => i.SPKEY));
            Index_TID = new Lazy<Dictionary<int, STSP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSP" /> fields for each CSV column header</returns>
        internal override Action<STSP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SPKEY":
                        mapper[i] = (e, v) => e.SPKEY = v;
                        break;
                    case "ENTRY_DATE":
                        mapper[i] = (e, v) => e.ENTRY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUSP_NUMBER":
                        mapper[i] = (e, v) => e.SUSP_NUMBER = v;
                        break;
                    case "REF_TEACHERA":
                        mapper[i] = (e, v) => e.REF_TEACHERA = v;
                        break;
                    case "REF_TEACHERB":
                        mapper[i] = (e, v) => e.REF_TEACHERB = v;
                        break;
                    case "NO_DAYS":
                        mapper[i] = (e, v) => e.NO_DAYS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "FROM_DATE":
                        mapper[i] = (e, v) => e.FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TO_DATE":
                        mapper[i] = (e, v) => e.TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RETURN_DATE":
                        mapper[i] = (e, v) => e.RETURN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NON_COMP":
                        mapper[i] = (e, v) => e.NON_COMP = v;
                        break;
                    case "SCH_AVOID":
                        mapper[i] = (e, v) => e.SCH_AVOID = v;
                        break;
                    case "VERBAL":
                        mapper[i] = (e, v) => e.VERBAL = v;
                        break;
                    case "PHYSICAL":
                        mapper[i] = (e, v) => e.PHYSICAL = v;
                        break;
                    case "MISUSE":
                        mapper[i] = (e, v) => e.MISUSE = v;
                        break;
                    case "SEXUAL":
                        mapper[i] = (e, v) => e.SEXUAL = v;
                        break;
                    case "INTIM":
                        mapper[i] = (e, v) => e.INTIM = v;
                        break;
                    case "VANDAL":
                        mapper[i] = (e, v) => e.VANDAL = v;
                        break;
                    case "STEALING":
                        mapper[i] = (e, v) => e.STEALING = v;
                        break;
                    case "SMOKING":
                        mapper[i] = (e, v) => e.SMOKING = v;
                        break;
                    case "DRUGS":
                        mapper[i] = (e, v) => e.DRUGS = v;
                        break;
                    case "FAIR":
                        mapper[i] = (e, v) => e.FAIR = v;
                        break;
                    case "CONSULT":
                        mapper[i] = (e, v) => e.CONSULT = v;
                        break;
                    case "PROCED":
                        mapper[i] = (e, v) => e.PROCED = v;
                        break;
                    case "COUNSEL":
                        mapper[i] = (e, v) => e.COUNSEL = v;
                        break;
                    case "CURRIC":
                        mapper[i] = (e, v) => e.CURRIC = v;
                        break;
                    case "PARENT":
                        mapper[i] = (e, v) => e.PARENT = v;
                        break;
                    case "DIRECT":
                        mapper[i] = (e, v) => e.DIRECT = v;
                        break;
                    case "APPEAL":
                        mapper[i] = (e, v) => e.APPEAL = v;
                        break;
                    case "OTHER_AGENCIES":
                        mapper[i] = (e, v) => e.OTHER_AGENCIES = v;
                        break;
                    case "POLICE":
                        mapper[i] = (e, v) => e.POLICE = v;
                        break;
                    case "OTHER_REAS":
                        mapper[i] = (e, v) => e.OTHER_REAS = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "OTHER":
                        mapper[i] = (e, v) => e.OTHER = v;
                        break;
                    case "PRINC_DECISION":
                        mapper[i] = (e, v) => e.PRINC_DECISION = v;
                        break;
                    case "PRINC_RECOM":
                        mapper[i] = (e, v) => e.PRINC_RECOM = v;
                        break;
                    case "RECOM_DIRECT":
                        mapper[i] = (e, v) => e.RECOM_DIRECT = v;
                        break;
                    case "SCHOOL_COMM":
                        mapper[i] = (e, v) => e.SCHOOL_COMM = v;
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
        /// Merges <see cref="STSP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STSP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STSP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STSP}"/> of entities</returns>
        internal override IEnumerable<STSP> ApplyDeltaEntities(IEnumerable<STSP> Entities, List<STSP> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SPKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SPKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STSP>>> Index_REF_TEACHERA;
        private Lazy<NullDictionary<string, IReadOnlyList<STSP>>> Index_REF_TEACHERB;
        private Lazy<Dictionary<string, IReadOnlyList<STSP>>> Index_SPKEY;
        private Lazy<Dictionary<int, STSP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSP by REF_TEACHERA field
        /// </summary>
        /// <param name="REF_TEACHERA">REF_TEACHERA value used to find STSP</param>
        /// <returns>List of related STSP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> FindByREF_TEACHERA(string REF_TEACHERA)
        {
            return Index_REF_TEACHERA.Value[REF_TEACHERA];
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERA field
        /// </summary>
        /// <param name="REF_TEACHERA">REF_TEACHERA value used to find STSP</param>
        /// <param name="Value">List of related STSP entities</param>
        /// <returns>True if the list of related STSP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREF_TEACHERA(string REF_TEACHERA, out IReadOnlyList<STSP> Value)
        {
            return Index_REF_TEACHERA.Value.TryGetValue(REF_TEACHERA, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERA field
        /// </summary>
        /// <param name="REF_TEACHERA">REF_TEACHERA value used to find STSP</param>
        /// <returns>List of related STSP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> TryFindByREF_TEACHERA(string REF_TEACHERA)
        {
            IReadOnlyList<STSP> value;
            if (Index_REF_TEACHERA.Value.TryGetValue(REF_TEACHERA, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSP by REF_TEACHERB field
        /// </summary>
        /// <param name="REF_TEACHERB">REF_TEACHERB value used to find STSP</param>
        /// <returns>List of related STSP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> FindByREF_TEACHERB(string REF_TEACHERB)
        {
            return Index_REF_TEACHERB.Value[REF_TEACHERB];
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERB field
        /// </summary>
        /// <param name="REF_TEACHERB">REF_TEACHERB value used to find STSP</param>
        /// <param name="Value">List of related STSP entities</param>
        /// <returns>True if the list of related STSP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREF_TEACHERB(string REF_TEACHERB, out IReadOnlyList<STSP> Value)
        {
            return Index_REF_TEACHERB.Value.TryGetValue(REF_TEACHERB, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERB field
        /// </summary>
        /// <param name="REF_TEACHERB">REF_TEACHERB value used to find STSP</param>
        /// <returns>List of related STSP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> TryFindByREF_TEACHERB(string REF_TEACHERB)
        {
            IReadOnlyList<STSP> value;
            if (Index_REF_TEACHERB.Value.TryGetValue(REF_TEACHERB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSP by SPKEY field
        /// </summary>
        /// <param name="SPKEY">SPKEY value used to find STSP</param>
        /// <returns>List of related STSP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> FindBySPKEY(string SPKEY)
        {
            return Index_SPKEY.Value[SPKEY];
        }

        /// <summary>
        /// Attempt to find STSP by SPKEY field
        /// </summary>
        /// <param name="SPKEY">SPKEY value used to find STSP</param>
        /// <param name="Value">List of related STSP entities</param>
        /// <returns>True if the list of related STSP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPKEY(string SPKEY, out IReadOnlyList<STSP> Value)
        {
            return Index_SPKEY.Value.TryGetValue(SPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by SPKEY field
        /// </summary>
        /// <param name="SPKEY">SPKEY value used to find STSP</param>
        /// <returns>List of related STSP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> TryFindBySPKEY(string SPKEY)
        {
            IReadOnlyList<STSP> value;
            if (Index_SPKEY.Value.TryGetValue(SPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSP</param>
        /// <returns>Related STSP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STSP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSP</param>
        /// <param name="Value">Related STSP entity</param>
        /// <returns>True if the related STSP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STSP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSP</param>
        /// <returns>Related STSP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSP TryFindByTID(int TID)
        {
            STSP value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STSP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STSP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STSP](
        [TID] int IDENTITY NOT NULL,
        [SPKEY] varchar(10) NOT NULL,
        [ENTRY_DATE] datetime NULL,
        [SUSP_NUMBER] varchar(10) NULL,
        [REF_TEACHERA] varchar(4) NULL,
        [REF_TEACHERB] varchar(4) NULL,
        [NO_DAYS] float NULL,
        [FROM_DATE] datetime NULL,
        [TO_DATE] datetime NULL,
        [RETURN_DATE] datetime NULL,
        [NON_COMP] varchar(1) NULL,
        [SCH_AVOID] varchar(1) NULL,
        [VERBAL] varchar(1) NULL,
        [PHYSICAL] varchar(1) NULL,
        [MISUSE] varchar(1) NULL,
        [SEXUAL] varchar(1) NULL,
        [INTIM] varchar(1) NULL,
        [VANDAL] varchar(1) NULL,
        [STEALING] varchar(1) NULL,
        [SMOKING] varchar(1) NULL,
        [DRUGS] varchar(1) NULL,
        [FAIR] varchar(1) NULL,
        [CONSULT] varchar(1) NULL,
        [PROCED] varchar(1) NULL,
        [COUNSEL] varchar(1) NULL,
        [CURRIC] varchar(1) NULL,
        [PARENT] varchar(1) NULL,
        [DIRECT] varchar(1) NULL,
        [APPEAL] varchar(1) NULL,
        [OTHER_AGENCIES] varchar(1) NULL,
        [POLICE] varchar(1) NULL,
        [OTHER_REAS] varchar(MAX) NULL,
        [DETAIL] varchar(MAX) NULL,
        [OTHER] varchar(MAX) NULL,
        [PRINC_DECISION] varchar(1) NULL,
        [PRINC_RECOM] varchar(1) NULL,
        [RECOM_DIRECT] varchar(1) NULL,
        [SCHOOL_COMM] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STSP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STSP_Index_REF_TEACHERA] ON [dbo].[STSP]
    (
            [REF_TEACHERA] ASC
    );
    CREATE NONCLUSTERED INDEX [STSP_Index_REF_TEACHERB] ON [dbo].[STSP]
    (
            [REF_TEACHERB] ASC
    );
    CREATE CLUSTERED INDEX [STSP_Index_SPKEY] ON [dbo].[STSP]
    (
            [SPKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSP]') AND name = N'Index_REF_TEACHERA')
    ALTER INDEX [Index_REF_TEACHERA] ON [dbo].[STSP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSP]') AND name = N'Index_REF_TEACHERB')
    ALTER INDEX [Index_REF_TEACHERB] ON [dbo].[STSP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STSP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSP]') AND name = N'Index_REF_TEACHERA')
    ALTER INDEX [Index_REF_TEACHERA] ON [dbo].[STSP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSP]') AND name = N'Index_REF_TEACHERB')
    ALTER INDEX [Index_REF_TEACHERB] ON [dbo].[STSP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STSP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STSP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STSP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STSP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STSP] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSP data set</returns>
        public override EduHubDataSetDataReader<STSP> GetDataSetDataReader()
        {
            return new STSPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSP data set</returns>
        public override EduHubDataSetDataReader<STSP> GetDataSetDataReader(List<STSP> Entities)
        {
            return new STSPDataReader(new EduHubDataSetLoadedReader<STSP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STSPDataReader : EduHubDataSetDataReader<STSP>
        {
            public STSPDataReader(IEduHubDataSetReader<STSP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 41; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SPKEY
                        return Current.SPKEY;
                    case 2: // ENTRY_DATE
                        return Current.ENTRY_DATE;
                    case 3: // SUSP_NUMBER
                        return Current.SUSP_NUMBER;
                    case 4: // REF_TEACHERA
                        return Current.REF_TEACHERA;
                    case 5: // REF_TEACHERB
                        return Current.REF_TEACHERB;
                    case 6: // NO_DAYS
                        return Current.NO_DAYS;
                    case 7: // FROM_DATE
                        return Current.FROM_DATE;
                    case 8: // TO_DATE
                        return Current.TO_DATE;
                    case 9: // RETURN_DATE
                        return Current.RETURN_DATE;
                    case 10: // NON_COMP
                        return Current.NON_COMP;
                    case 11: // SCH_AVOID
                        return Current.SCH_AVOID;
                    case 12: // VERBAL
                        return Current.VERBAL;
                    case 13: // PHYSICAL
                        return Current.PHYSICAL;
                    case 14: // MISUSE
                        return Current.MISUSE;
                    case 15: // SEXUAL
                        return Current.SEXUAL;
                    case 16: // INTIM
                        return Current.INTIM;
                    case 17: // VANDAL
                        return Current.VANDAL;
                    case 18: // STEALING
                        return Current.STEALING;
                    case 19: // SMOKING
                        return Current.SMOKING;
                    case 20: // DRUGS
                        return Current.DRUGS;
                    case 21: // FAIR
                        return Current.FAIR;
                    case 22: // CONSULT
                        return Current.CONSULT;
                    case 23: // PROCED
                        return Current.PROCED;
                    case 24: // COUNSEL
                        return Current.COUNSEL;
                    case 25: // CURRIC
                        return Current.CURRIC;
                    case 26: // PARENT
                        return Current.PARENT;
                    case 27: // DIRECT
                        return Current.DIRECT;
                    case 28: // APPEAL
                        return Current.APPEAL;
                    case 29: // OTHER_AGENCIES
                        return Current.OTHER_AGENCIES;
                    case 30: // POLICE
                        return Current.POLICE;
                    case 31: // OTHER_REAS
                        return Current.OTHER_REAS;
                    case 32: // DETAIL
                        return Current.DETAIL;
                    case 33: // OTHER
                        return Current.OTHER;
                    case 34: // PRINC_DECISION
                        return Current.PRINC_DECISION;
                    case 35: // PRINC_RECOM
                        return Current.PRINC_RECOM;
                    case 36: // RECOM_DIRECT
                        return Current.RECOM_DIRECT;
                    case 37: // SCHOOL_COMM
                        return Current.SCHOOL_COMM;
                    case 38: // LW_DATE
                        return Current.LW_DATE;
                    case 39: // LW_TIME
                        return Current.LW_TIME;
                    case 40: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ENTRY_DATE
                        return Current.ENTRY_DATE == null;
                    case 3: // SUSP_NUMBER
                        return Current.SUSP_NUMBER == null;
                    case 4: // REF_TEACHERA
                        return Current.REF_TEACHERA == null;
                    case 5: // REF_TEACHERB
                        return Current.REF_TEACHERB == null;
                    case 6: // NO_DAYS
                        return Current.NO_DAYS == null;
                    case 7: // FROM_DATE
                        return Current.FROM_DATE == null;
                    case 8: // TO_DATE
                        return Current.TO_DATE == null;
                    case 9: // RETURN_DATE
                        return Current.RETURN_DATE == null;
                    case 10: // NON_COMP
                        return Current.NON_COMP == null;
                    case 11: // SCH_AVOID
                        return Current.SCH_AVOID == null;
                    case 12: // VERBAL
                        return Current.VERBAL == null;
                    case 13: // PHYSICAL
                        return Current.PHYSICAL == null;
                    case 14: // MISUSE
                        return Current.MISUSE == null;
                    case 15: // SEXUAL
                        return Current.SEXUAL == null;
                    case 16: // INTIM
                        return Current.INTIM == null;
                    case 17: // VANDAL
                        return Current.VANDAL == null;
                    case 18: // STEALING
                        return Current.STEALING == null;
                    case 19: // SMOKING
                        return Current.SMOKING == null;
                    case 20: // DRUGS
                        return Current.DRUGS == null;
                    case 21: // FAIR
                        return Current.FAIR == null;
                    case 22: // CONSULT
                        return Current.CONSULT == null;
                    case 23: // PROCED
                        return Current.PROCED == null;
                    case 24: // COUNSEL
                        return Current.COUNSEL == null;
                    case 25: // CURRIC
                        return Current.CURRIC == null;
                    case 26: // PARENT
                        return Current.PARENT == null;
                    case 27: // DIRECT
                        return Current.DIRECT == null;
                    case 28: // APPEAL
                        return Current.APPEAL == null;
                    case 29: // OTHER_AGENCIES
                        return Current.OTHER_AGENCIES == null;
                    case 30: // POLICE
                        return Current.POLICE == null;
                    case 31: // OTHER_REAS
                        return Current.OTHER_REAS == null;
                    case 32: // DETAIL
                        return Current.DETAIL == null;
                    case 33: // OTHER
                        return Current.OTHER == null;
                    case 34: // PRINC_DECISION
                        return Current.PRINC_DECISION == null;
                    case 35: // PRINC_RECOM
                        return Current.PRINC_RECOM == null;
                    case 36: // RECOM_DIRECT
                        return Current.RECOM_DIRECT == null;
                    case 37: // SCHOOL_COMM
                        return Current.SCHOOL_COMM == null;
                    case 38: // LW_DATE
                        return Current.LW_DATE == null;
                    case 39: // LW_TIME
                        return Current.LW_TIME == null;
                    case 40: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // SPKEY
                        return "SPKEY";
                    case 2: // ENTRY_DATE
                        return "ENTRY_DATE";
                    case 3: // SUSP_NUMBER
                        return "SUSP_NUMBER";
                    case 4: // REF_TEACHERA
                        return "REF_TEACHERA";
                    case 5: // REF_TEACHERB
                        return "REF_TEACHERB";
                    case 6: // NO_DAYS
                        return "NO_DAYS";
                    case 7: // FROM_DATE
                        return "FROM_DATE";
                    case 8: // TO_DATE
                        return "TO_DATE";
                    case 9: // RETURN_DATE
                        return "RETURN_DATE";
                    case 10: // NON_COMP
                        return "NON_COMP";
                    case 11: // SCH_AVOID
                        return "SCH_AVOID";
                    case 12: // VERBAL
                        return "VERBAL";
                    case 13: // PHYSICAL
                        return "PHYSICAL";
                    case 14: // MISUSE
                        return "MISUSE";
                    case 15: // SEXUAL
                        return "SEXUAL";
                    case 16: // INTIM
                        return "INTIM";
                    case 17: // VANDAL
                        return "VANDAL";
                    case 18: // STEALING
                        return "STEALING";
                    case 19: // SMOKING
                        return "SMOKING";
                    case 20: // DRUGS
                        return "DRUGS";
                    case 21: // FAIR
                        return "FAIR";
                    case 22: // CONSULT
                        return "CONSULT";
                    case 23: // PROCED
                        return "PROCED";
                    case 24: // COUNSEL
                        return "COUNSEL";
                    case 25: // CURRIC
                        return "CURRIC";
                    case 26: // PARENT
                        return "PARENT";
                    case 27: // DIRECT
                        return "DIRECT";
                    case 28: // APPEAL
                        return "APPEAL";
                    case 29: // OTHER_AGENCIES
                        return "OTHER_AGENCIES";
                    case 30: // POLICE
                        return "POLICE";
                    case 31: // OTHER_REAS
                        return "OTHER_REAS";
                    case 32: // DETAIL
                        return "DETAIL";
                    case 33: // OTHER
                        return "OTHER";
                    case 34: // PRINC_DECISION
                        return "PRINC_DECISION";
                    case 35: // PRINC_RECOM
                        return "PRINC_RECOM";
                    case 36: // RECOM_DIRECT
                        return "RECOM_DIRECT";
                    case 37: // SCHOOL_COMM
                        return "SCHOOL_COMM";
                    case 38: // LW_DATE
                        return "LW_DATE";
                    case 39: // LW_TIME
                        return "LW_TIME";
                    case 40: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "SPKEY":
                        return 1;
                    case "ENTRY_DATE":
                        return 2;
                    case "SUSP_NUMBER":
                        return 3;
                    case "REF_TEACHERA":
                        return 4;
                    case "REF_TEACHERB":
                        return 5;
                    case "NO_DAYS":
                        return 6;
                    case "FROM_DATE":
                        return 7;
                    case "TO_DATE":
                        return 8;
                    case "RETURN_DATE":
                        return 9;
                    case "NON_COMP":
                        return 10;
                    case "SCH_AVOID":
                        return 11;
                    case "VERBAL":
                        return 12;
                    case "PHYSICAL":
                        return 13;
                    case "MISUSE":
                        return 14;
                    case "SEXUAL":
                        return 15;
                    case "INTIM":
                        return 16;
                    case "VANDAL":
                        return 17;
                    case "STEALING":
                        return 18;
                    case "SMOKING":
                        return 19;
                    case "DRUGS":
                        return 20;
                    case "FAIR":
                        return 21;
                    case "CONSULT":
                        return 22;
                    case "PROCED":
                        return 23;
                    case "COUNSEL":
                        return 24;
                    case "CURRIC":
                        return 25;
                    case "PARENT":
                        return 26;
                    case "DIRECT":
                        return 27;
                    case "APPEAL":
                        return 28;
                    case "OTHER_AGENCIES":
                        return 29;
                    case "POLICE":
                        return 30;
                    case "OTHER_REAS":
                        return 31;
                    case "DETAIL":
                        return 32;
                    case "OTHER":
                        return 33;
                    case "PRINC_DECISION":
                        return 34;
                    case "PRINC_RECOM":
                        return 35;
                    case "RECOM_DIRECT":
                        return 36;
                    case "SCHOOL_COMM":
                        return 37;
                    case "LW_DATE":
                        return 38;
                    case "LW_TIME":
                        return 39;
                    case "LW_USER":
                        return 40;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

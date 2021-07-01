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
    /// STACC Holding Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TRSTACCDataSet : EduHubDataSet<TRSTACC>
    {
        /// <inheritdoc />
        public override string Name { get { return "TRSTACC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TRSTACCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_STACCKEY = new Lazy<Dictionary<int, TRSTACC>>(() => this.ToDictionary(i => i.STACCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TRSTACC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TRSTACC" /> fields for each CSV column header</returns>
        internal override Action<TRSTACC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TRSTACC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "STACCKEY":
                        mapper[i] = (e, v) => e.STACCKEY = int.Parse(v);
                        break;
                    case "FIELD01":
                        mapper[i] = (e, v) => e.FIELD01 = v;
                        break;
                    case "FIELD02":
                        mapper[i] = (e, v) => e.FIELD02 = v;
                        break;
                    case "FIELD03":
                        mapper[i] = (e, v) => e.FIELD03 = v;
                        break;
                    case "FIELD04":
                        mapper[i] = (e, v) => e.FIELD04 = v;
                        break;
                    case "FIELD05":
                        mapper[i] = (e, v) => e.FIELD05 = v;
                        break;
                    case "FIELD06":
                        mapper[i] = (e, v) => e.FIELD06 = v;
                        break;
                    case "FIELD07":
                        mapper[i] = (e, v) => e.FIELD07 = v;
                        break;
                    case "FIELD08":
                        mapper[i] = (e, v) => e.FIELD08 = v;
                        break;
                    case "FIELD09":
                        mapper[i] = (e, v) => e.FIELD09 = v;
                        break;
                    case "FIELD10":
                        mapper[i] = (e, v) => e.FIELD10 = v;
                        break;
                    case "FIELD11":
                        mapper[i] = (e, v) => e.FIELD11 = v;
                        break;
                    case "FIELD12":
                        mapper[i] = (e, v) => e.FIELD12 = v;
                        break;
                    case "FIELD13":
                        mapper[i] = (e, v) => e.FIELD13 = v;
                        break;
                    case "FIELD14":
                        mapper[i] = (e, v) => e.FIELD14 = v;
                        break;
                    case "FIELD15":
                        mapper[i] = (e, v) => e.FIELD15 = v;
                        break;
                    case "FIELD16":
                        mapper[i] = (e, v) => e.FIELD16 = v;
                        break;
                    case "FIELD17":
                        mapper[i] = (e, v) => e.FIELD17 = v;
                        break;
                    case "FIELD18":
                        mapper[i] = (e, v) => e.FIELD18 = v;
                        break;
                    case "FIELD19":
                        mapper[i] = (e, v) => e.FIELD19 = v;
                        break;
                    case "FIELD20":
                        mapper[i] = (e, v) => e.FIELD20 = v;
                        break;
                    case "FIELD21":
                        mapper[i] = (e, v) => e.FIELD21 = v;
                        break;
                    case "FIELD22":
                        mapper[i] = (e, v) => e.FIELD22 = v;
                        break;
                    case "FIELD23":
                        mapper[i] = (e, v) => e.FIELD23 = v;
                        break;
                    case "FIELD24":
                        mapper[i] = (e, v) => e.FIELD24 = v;
                        break;
                    case "FIELD25":
                        mapper[i] = (e, v) => e.FIELD25 = v;
                        break;
                    case "FIELD26":
                        mapper[i] = (e, v) => e.FIELD26 = v;
                        break;
                    case "FIELD27":
                        mapper[i] = (e, v) => e.FIELD27 = v;
                        break;
                    case "FIELD28":
                        mapper[i] = (e, v) => e.FIELD28 = v;
                        break;
                    case "FIELD29":
                        mapper[i] = (e, v) => e.FIELD29 = v;
                        break;
                    case "FIELD30":
                        mapper[i] = (e, v) => e.FIELD30 = v;
                        break;
                    case "FIELD31":
                        mapper[i] = (e, v) => e.FIELD31 = v;
                        break;
                    case "FIELD32":
                        mapper[i] = (e, v) => e.FIELD32 = v;
                        break;
                    case "FIELD33":
                        mapper[i] = (e, v) => e.FIELD33 = v;
                        break;
                    case "ERR_FIELD":
                        mapper[i] = (e, v) => e.ERR_FIELD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_UMKEY":
                        mapper[i] = (e, v) => e.AM_UMKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM_UMKEY":
                        mapper[i] = (e, v) => e.PM_UMKEY = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="TRSTACC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TRSTACC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TRSTACC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TRSTACC}"/> of entities</returns>
        internal override IEnumerable<TRSTACC> ApplyDeltaEntities(IEnumerable<TRSTACC> Entities, List<TRSTACC> DeltaEntities)
        {
            HashSet<int> Index_STACCKEY = new HashSet<int>(DeltaEntities.Select(i => i.STACCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.STACCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_STACCKEY.Remove(entity.STACCKEY);
                            
                            if (entity.STACCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, TRSTACC>> Index_STACCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TRSTACC by STACCKEY field
        /// </summary>
        /// <param name="STACCKEY">STACCKEY value used to find TRSTACC</param>
        /// <returns>Related TRSTACC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRSTACC FindBySTACCKEY(int STACCKEY)
        {
            return Index_STACCKEY.Value[STACCKEY];
        }

        /// <summary>
        /// Attempt to find TRSTACC by STACCKEY field
        /// </summary>
        /// <param name="STACCKEY">STACCKEY value used to find TRSTACC</param>
        /// <param name="Value">Related TRSTACC entity</param>
        /// <returns>True if the related TRSTACC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTACCKEY(int STACCKEY, out TRSTACC Value)
        {
            return Index_STACCKEY.Value.TryGetValue(STACCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TRSTACC by STACCKEY field
        /// </summary>
        /// <param name="STACCKEY">STACCKEY value used to find TRSTACC</param>
        /// <returns>Related TRSTACC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRSTACC TryFindBySTACCKEY(int STACCKEY)
        {
            TRSTACC value;
            if (Index_STACCKEY.Value.TryGetValue(STACCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TRSTACC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TRSTACC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TRSTACC](
        [STACCKEY] int IDENTITY NOT NULL,
        [FIELD01] varchar(60) NULL,
        [FIELD02] varchar(60) NULL,
        [FIELD03] varchar(60) NULL,
        [FIELD04] varchar(60) NULL,
        [FIELD05] varchar(60) NULL,
        [FIELD06] varchar(60) NULL,
        [FIELD07] varchar(60) NULL,
        [FIELD08] varchar(60) NULL,
        [FIELD09] varchar(60) NULL,
        [FIELD10] varchar(60) NULL,
        [FIELD11] varchar(60) NULL,
        [FIELD12] varchar(60) NULL,
        [FIELD13] varchar(60) NULL,
        [FIELD14] varchar(60) NULL,
        [FIELD15] varchar(60) NULL,
        [FIELD16] varchar(60) NULL,
        [FIELD17] varchar(60) NULL,
        [FIELD18] varchar(60) NULL,
        [FIELD19] varchar(60) NULL,
        [FIELD20] varchar(60) NULL,
        [FIELD21] varchar(60) NULL,
        [FIELD22] varchar(60) NULL,
        [FIELD23] varchar(60) NULL,
        [FIELD24] varchar(60) NULL,
        [FIELD25] varchar(60) NULL,
        [FIELD26] varchar(60) NULL,
        [FIELD27] varchar(60) NULL,
        [FIELD28] varchar(60) NULL,
        [FIELD29] varchar(60) NULL,
        [FIELD30] varchar(60) NULL,
        [FIELD31] varchar(60) NULL,
        [FIELD32] varchar(60) NULL,
        [FIELD33] varchar(60) NULL,
        [ERR_FIELD] smallint NULL,
        [AM_UMKEY] int NULL,
        [PM_UMKEY] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TRSTACC_Index_STACCKEY] PRIMARY KEY CLUSTERED (
            [STACCKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="TRSTACCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="TRSTACCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TRSTACC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TRSTACC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TRSTACC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_STACCKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STACCKEY.Add(entity.STACCKEY);
            }

            builder.AppendLine("DELETE [dbo].[TRSTACC] WHERE");


            // Index_STACCKEY
            builder.Append("[STACCKEY] IN (");
            for (int index = 0; index < Index_STACCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STACCKEY
                var parameterSTACCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSTACCKEY);
                command.Parameters.Add(parameterSTACCKEY, SqlDbType.Int).Value = Index_STACCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TRSTACC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TRSTACC data set</returns>
        public override EduHubDataSetDataReader<TRSTACC> GetDataSetDataReader()
        {
            return new TRSTACCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TRSTACC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TRSTACC data set</returns>
        public override EduHubDataSetDataReader<TRSTACC> GetDataSetDataReader(List<TRSTACC> Entities)
        {
            return new TRSTACCDataReader(new EduHubDataSetLoadedReader<TRSTACC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TRSTACCDataReader : EduHubDataSetDataReader<TRSTACC>
        {
            public TRSTACCDataReader(IEduHubDataSetReader<TRSTACC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 40; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // STACCKEY
                        return Current.STACCKEY;
                    case 1: // FIELD01
                        return Current.FIELD01;
                    case 2: // FIELD02
                        return Current.FIELD02;
                    case 3: // FIELD03
                        return Current.FIELD03;
                    case 4: // FIELD04
                        return Current.FIELD04;
                    case 5: // FIELD05
                        return Current.FIELD05;
                    case 6: // FIELD06
                        return Current.FIELD06;
                    case 7: // FIELD07
                        return Current.FIELD07;
                    case 8: // FIELD08
                        return Current.FIELD08;
                    case 9: // FIELD09
                        return Current.FIELD09;
                    case 10: // FIELD10
                        return Current.FIELD10;
                    case 11: // FIELD11
                        return Current.FIELD11;
                    case 12: // FIELD12
                        return Current.FIELD12;
                    case 13: // FIELD13
                        return Current.FIELD13;
                    case 14: // FIELD14
                        return Current.FIELD14;
                    case 15: // FIELD15
                        return Current.FIELD15;
                    case 16: // FIELD16
                        return Current.FIELD16;
                    case 17: // FIELD17
                        return Current.FIELD17;
                    case 18: // FIELD18
                        return Current.FIELD18;
                    case 19: // FIELD19
                        return Current.FIELD19;
                    case 20: // FIELD20
                        return Current.FIELD20;
                    case 21: // FIELD21
                        return Current.FIELD21;
                    case 22: // FIELD22
                        return Current.FIELD22;
                    case 23: // FIELD23
                        return Current.FIELD23;
                    case 24: // FIELD24
                        return Current.FIELD24;
                    case 25: // FIELD25
                        return Current.FIELD25;
                    case 26: // FIELD26
                        return Current.FIELD26;
                    case 27: // FIELD27
                        return Current.FIELD27;
                    case 28: // FIELD28
                        return Current.FIELD28;
                    case 29: // FIELD29
                        return Current.FIELD29;
                    case 30: // FIELD30
                        return Current.FIELD30;
                    case 31: // FIELD31
                        return Current.FIELD31;
                    case 32: // FIELD32
                        return Current.FIELD32;
                    case 33: // FIELD33
                        return Current.FIELD33;
                    case 34: // ERR_FIELD
                        return Current.ERR_FIELD;
                    case 35: // AM_UMKEY
                        return Current.AM_UMKEY;
                    case 36: // PM_UMKEY
                        return Current.PM_UMKEY;
                    case 37: // LW_DATE
                        return Current.LW_DATE;
                    case 38: // LW_TIME
                        return Current.LW_TIME;
                    case 39: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // FIELD01
                        return Current.FIELD01 == null;
                    case 2: // FIELD02
                        return Current.FIELD02 == null;
                    case 3: // FIELD03
                        return Current.FIELD03 == null;
                    case 4: // FIELD04
                        return Current.FIELD04 == null;
                    case 5: // FIELD05
                        return Current.FIELD05 == null;
                    case 6: // FIELD06
                        return Current.FIELD06 == null;
                    case 7: // FIELD07
                        return Current.FIELD07 == null;
                    case 8: // FIELD08
                        return Current.FIELD08 == null;
                    case 9: // FIELD09
                        return Current.FIELD09 == null;
                    case 10: // FIELD10
                        return Current.FIELD10 == null;
                    case 11: // FIELD11
                        return Current.FIELD11 == null;
                    case 12: // FIELD12
                        return Current.FIELD12 == null;
                    case 13: // FIELD13
                        return Current.FIELD13 == null;
                    case 14: // FIELD14
                        return Current.FIELD14 == null;
                    case 15: // FIELD15
                        return Current.FIELD15 == null;
                    case 16: // FIELD16
                        return Current.FIELD16 == null;
                    case 17: // FIELD17
                        return Current.FIELD17 == null;
                    case 18: // FIELD18
                        return Current.FIELD18 == null;
                    case 19: // FIELD19
                        return Current.FIELD19 == null;
                    case 20: // FIELD20
                        return Current.FIELD20 == null;
                    case 21: // FIELD21
                        return Current.FIELD21 == null;
                    case 22: // FIELD22
                        return Current.FIELD22 == null;
                    case 23: // FIELD23
                        return Current.FIELD23 == null;
                    case 24: // FIELD24
                        return Current.FIELD24 == null;
                    case 25: // FIELD25
                        return Current.FIELD25 == null;
                    case 26: // FIELD26
                        return Current.FIELD26 == null;
                    case 27: // FIELD27
                        return Current.FIELD27 == null;
                    case 28: // FIELD28
                        return Current.FIELD28 == null;
                    case 29: // FIELD29
                        return Current.FIELD29 == null;
                    case 30: // FIELD30
                        return Current.FIELD30 == null;
                    case 31: // FIELD31
                        return Current.FIELD31 == null;
                    case 32: // FIELD32
                        return Current.FIELD32 == null;
                    case 33: // FIELD33
                        return Current.FIELD33 == null;
                    case 34: // ERR_FIELD
                        return Current.ERR_FIELD == null;
                    case 35: // AM_UMKEY
                        return Current.AM_UMKEY == null;
                    case 36: // PM_UMKEY
                        return Current.PM_UMKEY == null;
                    case 37: // LW_DATE
                        return Current.LW_DATE == null;
                    case 38: // LW_TIME
                        return Current.LW_TIME == null;
                    case 39: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // STACCKEY
                        return "STACCKEY";
                    case 1: // FIELD01
                        return "FIELD01";
                    case 2: // FIELD02
                        return "FIELD02";
                    case 3: // FIELD03
                        return "FIELD03";
                    case 4: // FIELD04
                        return "FIELD04";
                    case 5: // FIELD05
                        return "FIELD05";
                    case 6: // FIELD06
                        return "FIELD06";
                    case 7: // FIELD07
                        return "FIELD07";
                    case 8: // FIELD08
                        return "FIELD08";
                    case 9: // FIELD09
                        return "FIELD09";
                    case 10: // FIELD10
                        return "FIELD10";
                    case 11: // FIELD11
                        return "FIELD11";
                    case 12: // FIELD12
                        return "FIELD12";
                    case 13: // FIELD13
                        return "FIELD13";
                    case 14: // FIELD14
                        return "FIELD14";
                    case 15: // FIELD15
                        return "FIELD15";
                    case 16: // FIELD16
                        return "FIELD16";
                    case 17: // FIELD17
                        return "FIELD17";
                    case 18: // FIELD18
                        return "FIELD18";
                    case 19: // FIELD19
                        return "FIELD19";
                    case 20: // FIELD20
                        return "FIELD20";
                    case 21: // FIELD21
                        return "FIELD21";
                    case 22: // FIELD22
                        return "FIELD22";
                    case 23: // FIELD23
                        return "FIELD23";
                    case 24: // FIELD24
                        return "FIELD24";
                    case 25: // FIELD25
                        return "FIELD25";
                    case 26: // FIELD26
                        return "FIELD26";
                    case 27: // FIELD27
                        return "FIELD27";
                    case 28: // FIELD28
                        return "FIELD28";
                    case 29: // FIELD29
                        return "FIELD29";
                    case 30: // FIELD30
                        return "FIELD30";
                    case 31: // FIELD31
                        return "FIELD31";
                    case 32: // FIELD32
                        return "FIELD32";
                    case 33: // FIELD33
                        return "FIELD33";
                    case 34: // ERR_FIELD
                        return "ERR_FIELD";
                    case 35: // AM_UMKEY
                        return "AM_UMKEY";
                    case 36: // PM_UMKEY
                        return "PM_UMKEY";
                    case 37: // LW_DATE
                        return "LW_DATE";
                    case 38: // LW_TIME
                        return "LW_TIME";
                    case 39: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "STACCKEY":
                        return 0;
                    case "FIELD01":
                        return 1;
                    case "FIELD02":
                        return 2;
                    case "FIELD03":
                        return 3;
                    case "FIELD04":
                        return 4;
                    case "FIELD05":
                        return 5;
                    case "FIELD06":
                        return 6;
                    case "FIELD07":
                        return 7;
                    case "FIELD08":
                        return 8;
                    case "FIELD09":
                        return 9;
                    case "FIELD10":
                        return 10;
                    case "FIELD11":
                        return 11;
                    case "FIELD12":
                        return 12;
                    case "FIELD13":
                        return 13;
                    case "FIELD14":
                        return 14;
                    case "FIELD15":
                        return 15;
                    case "FIELD16":
                        return 16;
                    case "FIELD17":
                        return 17;
                    case "FIELD18":
                        return 18;
                    case "FIELD19":
                        return 19;
                    case "FIELD20":
                        return 20;
                    case "FIELD21":
                        return 21;
                    case "FIELD22":
                        return 22;
                    case "FIELD23":
                        return 23;
                    case "FIELD24":
                        return 24;
                    case "FIELD25":
                        return 25;
                    case "FIELD26":
                        return 26;
                    case "FIELD27":
                        return 27;
                    case "FIELD28":
                        return 28;
                    case "FIELD29":
                        return 29;
                    case "FIELD30":
                        return 30;
                    case "FIELD31":
                        return 31;
                    case "FIELD32":
                        return 32;
                    case "FIELD33":
                        return 33;
                    case "ERR_FIELD":
                        return 34;
                    case "AM_UMKEY":
                        return 35;
                    case "PM_UMKEY":
                        return 36;
                    case "LW_DATE":
                        return 37;
                    case "LW_TIME":
                        return 38;
                    case "LW_USER":
                        return 39;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

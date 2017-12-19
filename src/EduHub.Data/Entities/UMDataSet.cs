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
    /// Addresses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class UMDataSet : EduHubDataSet<UM>
    {
        /// <inheritdoc />
        public override string Name { get { return "UM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal UMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<UM>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<UM>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_UMKEY = new Lazy<Dictionary<int, UM>>(() => this.ToDictionary(i => i.UMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="UM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="UM" /> fields for each CSV column header</returns>
        internal override Action<UM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<UM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "SILENT":
                        mapper[i] = (e, v) => e.SILENT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DPID":
                        mapper[i] = (e, v) => e.DPID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BARCODE":
                        mapper[i] = (e, v) => e.BARCODE = v;
                        break;
                    case "LATITUDE":
                        mapper[i] = (e, v) => e.LATITUDE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LONGITUDE":
                        mapper[i] = (e, v) => e.LONGITUDE = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="UM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="UM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="UM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{UM}"/> of entities</returns>
        internal override IEnumerable<UM> ApplyDeltaEntities(IEnumerable<UM> Entities, List<UM> DeltaEntities)
        {
            HashSet<int> Index_UMKEY = new HashSet<int>(DeltaEntities.Select(i => i.UMKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.UMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_UMKEY.Remove(entity.UMKEY);
                            
                            if (entity.UMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<UM>>> Index_COUNTRY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<UM>>> Index_LW_DATE;
        private Lazy<Dictionary<int, UM>> Index_UMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <returns>List of related UM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <param name="Value">List of related UM entities</param>
        /// <returns>True if the list of related UM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<UM> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <returns>List of related UM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<UM> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <returns>List of related UM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <param name="Value">List of related UM entities</param>
        /// <returns>True if the list of related UM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<UM> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <returns>List of related UM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<UM> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <returns>Related UM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM FindByUMKEY(int UMKEY)
        {
            return Index_UMKEY.Value[UMKEY];
        }

        /// <summary>
        /// Attempt to find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <param name="Value">Related UM entity</param>
        /// <returns>True if the related UM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByUMKEY(int UMKEY, out UM Value)
        {
            return Index_UMKEY.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <returns>Related UM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM TryFindByUMKEY(int UMKEY)
        {
            UM value;
            if (Index_UMKEY.Value.TryGetValue(UMKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a UM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[UM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[UM](
        [UMKEY] int IDENTITY NOT NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [MOBILE] varchar(20) NULL,
        [SILENT] varchar(1) NULL,
        [FAX] varchar(20) NULL,
        [KAP_LINK] varchar(34) NULL,
        [COUNTRY] varchar(6) NULL,
        [DPID] int NULL,
        [BARCODE] varchar(37) NULL,
        [LATITUDE] float NULL,
        [LONGITUDE] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [UM_Index_UMKEY] PRIMARY KEY CLUSTERED (
            [UMKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [UM_Index_COUNTRY] ON [dbo].[UM]
    (
            [COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [UM_Index_LW_DATE] ON [dbo].[UM]
    (
            [LW_DATE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[UM]') AND name = N'Index_COUNTRY')
    ALTER INDEX [Index_COUNTRY] ON [dbo].[UM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[UM]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[UM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[UM]') AND name = N'Index_COUNTRY')
    ALTER INDEX [Index_COUNTRY] ON [dbo].[UM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[UM]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[UM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="UM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="UM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<UM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_UMKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_UMKEY.Add(entity.UMKEY);
            }

            builder.AppendLine("DELETE [dbo].[UM] WHERE");


            // Index_UMKEY
            builder.Append("[UMKEY] IN (");
            for (int index = 0; index < Index_UMKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // UMKEY
                var parameterUMKEY = $"@p{parameterIndex++}";
                builder.Append(parameterUMKEY);
                command.Parameters.Add(parameterUMKEY, SqlDbType.Int).Value = Index_UMKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the UM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the UM data set</returns>
        public override EduHubDataSetDataReader<UM> GetDataSetDataReader()
        {
            return new UMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the UM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the UM data set</returns>
        public override EduHubDataSetDataReader<UM> GetDataSetDataReader(List<UM> Entities)
        {
            return new UMDataReader(new EduHubDataSetLoadedReader<UM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class UMDataReader : EduHubDataSetDataReader<UM>
        {
            public UMDataReader(IEduHubDataSetReader<UM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 19; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // UMKEY
                        return Current.UMKEY;
                    case 1: // ADDRESS01
                        return Current.ADDRESS01;
                    case 2: // ADDRESS02
                        return Current.ADDRESS02;
                    case 3: // ADDRESS03
                        return Current.ADDRESS03;
                    case 4: // STATE
                        return Current.STATE;
                    case 5: // POSTCODE
                        return Current.POSTCODE;
                    case 6: // TELEPHONE
                        return Current.TELEPHONE;
                    case 7: // MOBILE
                        return Current.MOBILE;
                    case 8: // SILENT
                        return Current.SILENT;
                    case 9: // FAX
                        return Current.FAX;
                    case 10: // KAP_LINK
                        return Current.KAP_LINK;
                    case 11: // COUNTRY
                        return Current.COUNTRY;
                    case 12: // DPID
                        return Current.DPID;
                    case 13: // BARCODE
                        return Current.BARCODE;
                    case 14: // LATITUDE
                        return Current.LATITUDE;
                    case 15: // LONGITUDE
                        return Current.LONGITUDE;
                    case 16: // LW_DATE
                        return Current.LW_DATE;
                    case 17: // LW_TIME
                        return Current.LW_TIME;
                    case 18: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 2: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 3: // ADDRESS03
                        return Current.ADDRESS03 == null;
                    case 4: // STATE
                        return Current.STATE == null;
                    case 5: // POSTCODE
                        return Current.POSTCODE == null;
                    case 6: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 7: // MOBILE
                        return Current.MOBILE == null;
                    case 8: // SILENT
                        return Current.SILENT == null;
                    case 9: // FAX
                        return Current.FAX == null;
                    case 10: // KAP_LINK
                        return Current.KAP_LINK == null;
                    case 11: // COUNTRY
                        return Current.COUNTRY == null;
                    case 12: // DPID
                        return Current.DPID == null;
                    case 13: // BARCODE
                        return Current.BARCODE == null;
                    case 14: // LATITUDE
                        return Current.LATITUDE == null;
                    case 15: // LONGITUDE
                        return Current.LONGITUDE == null;
                    case 16: // LW_DATE
                        return Current.LW_DATE == null;
                    case 17: // LW_TIME
                        return Current.LW_TIME == null;
                    case 18: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // UMKEY
                        return "UMKEY";
                    case 1: // ADDRESS01
                        return "ADDRESS01";
                    case 2: // ADDRESS02
                        return "ADDRESS02";
                    case 3: // ADDRESS03
                        return "ADDRESS03";
                    case 4: // STATE
                        return "STATE";
                    case 5: // POSTCODE
                        return "POSTCODE";
                    case 6: // TELEPHONE
                        return "TELEPHONE";
                    case 7: // MOBILE
                        return "MOBILE";
                    case 8: // SILENT
                        return "SILENT";
                    case 9: // FAX
                        return "FAX";
                    case 10: // KAP_LINK
                        return "KAP_LINK";
                    case 11: // COUNTRY
                        return "COUNTRY";
                    case 12: // DPID
                        return "DPID";
                    case 13: // BARCODE
                        return "BARCODE";
                    case 14: // LATITUDE
                        return "LATITUDE";
                    case 15: // LONGITUDE
                        return "LONGITUDE";
                    case 16: // LW_DATE
                        return "LW_DATE";
                    case 17: // LW_TIME
                        return "LW_TIME";
                    case 18: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "UMKEY":
                        return 0;
                    case "ADDRESS01":
                        return 1;
                    case "ADDRESS02":
                        return 2;
                    case "ADDRESS03":
                        return 3;
                    case "STATE":
                        return 4;
                    case "POSTCODE":
                        return 5;
                    case "TELEPHONE":
                        return 6;
                    case "MOBILE":
                        return 7;
                    case "SILENT":
                        return 8;
                    case "FAX":
                        return 9;
                    case "KAP_LINK":
                        return 10;
                    case "COUNTRY":
                        return 11;
                    case "DPID":
                        return 12;
                    case "BARCODE":
                        return 13;
                    case "LATITUDE":
                        return 14;
                    case "LONGITUDE":
                        return 15;
                    case "LW_DATE":
                        return 16;
                    case "LW_TIME":
                        return 17;
                    case "LW_USER":
                        return 18;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
#if NET452
using System.Data.SqlClient;
#elif NET10_0
using Microsoft.Data.SqlClient;
#endif
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Saving Bonus Vouchers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSSBDataSet : EduHubDataSet<STSSB>
    {
        /// <inheritdoc />
        public override string Name { get { return "STSSB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal STSSBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STSSB>>>(() => this.ToGroupedDictionary(i => i.SKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSSB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSSB" /> fields for each CSV column header</returns>
        internal override Action<STSSB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSSB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "VOUCHER_TYPE":
                        mapper[i] = (e, v) => e.VOUCHER_TYPE = v;
                        break;
                    case "ACTIVITIES_BAL":
                        mapper[i] = (e, v) => e.ACTIVITIES_BAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="STSSB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STSSB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STSSB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STSSB}"/> of entities</returns>
        internal override IEnumerable<STSSB> ApplyDeltaEntities(IEnumerable<STSSB> Entities, List<STSSB> DeltaEntities)
        {

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            if (entity.SKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                yield return entity;
                            }
                            else
                            {
                                yieldEntity = true;
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

        private Lazy<Dictionary<string, IReadOnlyList<STSSB>>> Index_SKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSSB</param>
        /// <returns>List of related STSSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSSB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STSSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSSB</param>
        /// <param name="Value">List of related STSSB entities</param>
        /// <returns>True if the list of related STSSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STSSB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STSSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSSB</param>
        /// <returns>List of related STSSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSSB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STSSB> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STSSB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STSSB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STSSB](
        [SKEY] varchar(10) NOT NULL,
        [VOUCHER_TYPE] varchar(20) NOT NULL,
        [ACTIVITIES_BAL] money NULL
    );
    CREATE CLUSTERED INDEX [STSSB_Index_SKEY] ON [dbo].[STSSB]
    (
            [SKEY] ASC
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="STSSBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="STSSBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STSSB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STSSB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STSSB> Entities)
        {
            throw new NotSupportedException("The STSSB data set does not contain any unique indexes to identity records. Deleting individual entities is not supported.");
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSSB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSSB data set</returns>
        public override EduHubDataSetDataReader<STSSB> GetDataSetDataReader()
        {
            return new STSSBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSSB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSSB data set</returns>
        public override EduHubDataSetDataReader<STSSB> GetDataSetDataReader(List<STSSB> Entities)
        {
            return new STSSBDataReader(new EduHubDataSetLoadedReader<STSSB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STSSBDataReader : EduHubDataSetDataReader<STSSB>
        {
            public STSSBDataReader(IEduHubDataSetReader<STSSB> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 3; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SKEY
                        return Current.SKEY;
                    case 1: // VOUCHER_TYPE
                        return Current.VOUCHER_TYPE;
                    case 2: // ACTIVITIES_BAL
                        return Current.ACTIVITIES_BAL;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ACTIVITIES_BAL
                        return Current.ACTIVITIES_BAL == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SKEY
                        return "SKEY";
                    case 1: // VOUCHER_TYPE
                        return "VOUCHER_TYPE";
                    case 2: // ACTIVITIES_BAL
                        return "ACTIVITIES_BAL";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SKEY":
                        return 0;
                    case "VOUCHER_TYPE":
                        return 1;
                    case "ACTIVITIES_BAL":
                        return 2;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

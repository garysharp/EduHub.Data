#if !EduHubScoped
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
    /// MYLNS Funding Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KMYLNSDataSet : EduHubDataSet<KMYLNS>
    {
        /// <inheritdoc />
        public override string Name { get { return "KMYLNS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KMYLNSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KMYLNSKEY = new Lazy<Dictionary<int, KMYLNS>>(() => this.ToDictionary(i => i.KMYLNSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KMYLNS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KMYLNS" /> fields for each CSV column header</returns>
        internal override Action<KMYLNS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KMYLNS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KMYLNSKEY":
                        mapper[i] = (e, v) => e.KMYLNSKEY = int.Parse(v);
                        break;
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "SCHOOL_NAME":
                        mapper[i] = (e, v) => e.SCHOOL_NAME = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KMYLNS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KMYLNS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KMYLNS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KMYLNS}"/> of entities</returns>
        internal override IEnumerable<KMYLNS> ApplyDeltaEntities(IEnumerable<KMYLNS> Entities, List<KMYLNS> DeltaEntities)
        {
            HashSet<int> Index_KMYLNSKEY = new HashSet<int>(DeltaEntities.Select(i => i.KMYLNSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KMYLNSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KMYLNSKEY.Remove(entity.KMYLNSKEY);
                            
                            if (entity.KMYLNSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KMYLNS>> Index_KMYLNSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KMYLNS by KMYLNSKEY field
        /// </summary>
        /// <param name="KMYLNSKEY">KMYLNSKEY value used to find KMYLNS</param>
        /// <returns>Related KMYLNS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KMYLNS FindByKMYLNSKEY(int KMYLNSKEY)
        {
            return Index_KMYLNSKEY.Value[KMYLNSKEY];
        }

        /// <summary>
        /// Attempt to find KMYLNS by KMYLNSKEY field
        /// </summary>
        /// <param name="KMYLNSKEY">KMYLNSKEY value used to find KMYLNS</param>
        /// <param name="Value">Related KMYLNS entity</param>
        /// <returns>True if the related KMYLNS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKMYLNSKEY(int KMYLNSKEY, out KMYLNS Value)
        {
            return Index_KMYLNSKEY.Value.TryGetValue(KMYLNSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KMYLNS by KMYLNSKEY field
        /// </summary>
        /// <param name="KMYLNSKEY">KMYLNSKEY value used to find KMYLNS</param>
        /// <returns>Related KMYLNS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KMYLNS TryFindByKMYLNSKEY(int KMYLNSKEY)
        {
            KMYLNS value;
            if (Index_KMYLNSKEY.Value.TryGetValue(KMYLNSKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KMYLNS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KMYLNS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KMYLNS](
        [KMYLNSKEY] int IDENTITY NOT NULL,
        [SCHOOL] varchar(8) NULL,
        [SCHOOL_ID] varchar(4) NULL,
        [SCHOOL_NAME] varchar(50) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KMYLNS_Index_KMYLNSKEY] PRIMARY KEY CLUSTERED (
            [KMYLNSKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KMYLNSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KMYLNSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KMYLNS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KMYLNS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KMYLNS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KMYLNSKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KMYLNSKEY.Add(entity.KMYLNSKEY);
            }

            builder.AppendLine("DELETE [dbo].[KMYLNS] WHERE");


            // Index_KMYLNSKEY
            builder.Append("[KMYLNSKEY] IN (");
            for (int index = 0; index < Index_KMYLNSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KMYLNSKEY
                var parameterKMYLNSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKMYLNSKEY);
                command.Parameters.Add(parameterKMYLNSKEY, SqlDbType.Int).Value = Index_KMYLNSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KMYLNS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KMYLNS data set</returns>
        public override EduHubDataSetDataReader<KMYLNS> GetDataSetDataReader()
        {
            return new KMYLNSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KMYLNS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KMYLNS data set</returns>
        public override EduHubDataSetDataReader<KMYLNS> GetDataSetDataReader(List<KMYLNS> Entities)
        {
            return new KMYLNSDataReader(new EduHubDataSetLoadedReader<KMYLNS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KMYLNSDataReader : EduHubDataSetDataReader<KMYLNS>
        {
            public KMYLNSDataReader(IEduHubDataSetReader<KMYLNS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KMYLNSKEY
                        return Current.KMYLNSKEY;
                    case 1: // SCHOOL
                        return Current.SCHOOL;
                    case 2: // SCHOOL_ID
                        return Current.SCHOOL_ID;
                    case 3: // SCHOOL_NAME
                        return Current.SCHOOL_NAME;
                    case 4: // ACTIVE
                        return Current.ACTIVE;
                    case 5: // LW_DATE
                        return Current.LW_DATE;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SCHOOL
                        return Current.SCHOOL == null;
                    case 2: // SCHOOL_ID
                        return Current.SCHOOL_ID == null;
                    case 3: // SCHOOL_NAME
                        return Current.SCHOOL_NAME == null;
                    case 4: // ACTIVE
                        return Current.ACTIVE == null;
                    case 5: // LW_DATE
                        return Current.LW_DATE == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KMYLNSKEY
                        return "KMYLNSKEY";
                    case 1: // SCHOOL
                        return "SCHOOL";
                    case 2: // SCHOOL_ID
                        return "SCHOOL_ID";
                    case 3: // SCHOOL_NAME
                        return "SCHOOL_NAME";
                    case 4: // ACTIVE
                        return "ACTIVE";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KMYLNSKEY":
                        return 0;
                    case "SCHOOL":
                        return 1;
                    case "SCHOOL_ID":
                        return 2;
                    case "SCHOOL_NAME":
                        return 3;
                    case "ACTIVE":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif

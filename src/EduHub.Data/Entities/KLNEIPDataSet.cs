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
    /// LNEIP Non-Participating Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KLNEIPDataSet : EduHubDataSet<KLNEIP>
    {
        /// <inheritdoc />
        public override string Name { get { return "KLNEIP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KLNEIPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KLNEIP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KLNEIP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KLNEIP" /> fields for each CSV column header</returns>
        internal override Action<KLNEIP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KLNEIP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
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
        /// Merges <see cref="KLNEIP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KLNEIP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KLNEIP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KLNEIP}"/> of entities</returns>
        internal override IEnumerable<KLNEIP> ApplyDeltaEntities(IEnumerable<KLNEIP> Entities, List<KLNEIP> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KLNEIP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KLNEIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KLNEIP</param>
        /// <returns>Related KLNEIP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KLNEIP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KLNEIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KLNEIP</param>
        /// <param name="Value">Related KLNEIP entity</param>
        /// <returns>True if the related KLNEIP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KLNEIP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KLNEIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KLNEIP</param>
        /// <returns>Related KLNEIP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KLNEIP TryFindByTID(int TID)
        {
            KLNEIP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KLNEIP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KLNEIP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KLNEIP](
        [TID] int IDENTITY NOT NULL,
        [SCHOOL] varchar(8) NULL,
        [SCHOOL_ID] varchar(4) NULL,
        [SCHOOL_NAME] varchar(100) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KLNEIP_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KLNEIPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KLNEIPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KLNEIP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KLNEIP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KLNEIP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KLNEIP] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the KLNEIP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KLNEIP data set</returns>
        public override EduHubDataSetDataReader<KLNEIP> GetDataSetDataReader()
        {
            return new KLNEIPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KLNEIP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KLNEIP data set</returns>
        public override EduHubDataSetDataReader<KLNEIP> GetDataSetDataReader(List<KLNEIP> Entities)
        {
            return new KLNEIPDataReader(new EduHubDataSetLoadedReader<KLNEIP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KLNEIPDataReader : EduHubDataSetDataReader<KLNEIP>
        {
            public KLNEIPDataReader(IEduHubDataSetReader<KLNEIP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SCHOOL
                        return Current.SCHOOL;
                    case 2: // SCHOOL_ID
                        return Current.SCHOOL_ID;
                    case 3: // SCHOOL_NAME
                        return Current.SCHOOL_NAME;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
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
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
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
                    case 1: // SCHOOL
                        return "SCHOOL";
                    case 2: // SCHOOL_ID
                        return "SCHOOL_ID";
                    case 3: // SCHOOL_NAME
                        return "SCHOOL_NAME";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
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
                    case "SCHOOL":
                        return 1;
                    case "SCHOOL_ID":
                        return 2;
                    case "SCHOOL_NAME":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif

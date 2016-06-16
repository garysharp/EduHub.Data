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
    /// eMaze Calendar Framework Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGCVDataSet : EduHubDataSet<KGCV>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGCV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGCVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_START_TIME = new Lazy<Dictionary<string, KGCV>>(() => this.ToDictionary(i => i.START_TIME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGCV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGCV" /> fields for each CSV column header</returns>
        internal override Action<KGCV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGCV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v;
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v;
                        break;
                    case "VIEW_INCREMENT":
                        mapper[i] = (e, v) => e.VIEW_INCREMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KGCV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGCV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGCV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGCV}"/> of entities</returns>
        internal override IEnumerable<KGCV> ApplyDeltaEntities(IEnumerable<KGCV> Entities, List<KGCV> DeltaEntities)
        {
            HashSet<string> Index_START_TIME = new HashSet<string>(DeltaEntities.Select(i => i.START_TIME));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.START_TIME;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_START_TIME.Remove(entity.START_TIME);
                            
                            if (entity.START_TIME.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGCV>> Index_START_TIME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGCV by START_TIME field
        /// </summary>
        /// <param name="START_TIME">START_TIME value used to find KGCV</param>
        /// <returns>Related KGCV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCV FindBySTART_TIME(string START_TIME)
        {
            return Index_START_TIME.Value[START_TIME];
        }

        /// <summary>
        /// Attempt to find KGCV by START_TIME field
        /// </summary>
        /// <param name="START_TIME">START_TIME value used to find KGCV</param>
        /// <param name="Value">Related KGCV entity</param>
        /// <returns>True if the related KGCV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTART_TIME(string START_TIME, out KGCV Value)
        {
            return Index_START_TIME.Value.TryGetValue(START_TIME, out Value);
        }

        /// <summary>
        /// Attempt to find KGCV by START_TIME field
        /// </summary>
        /// <param name="START_TIME">START_TIME value used to find KGCV</param>
        /// <returns>Related KGCV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCV TryFindBySTART_TIME(string START_TIME)
        {
            KGCV value;
            if (Index_START_TIME.Value.TryGetValue(START_TIME, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGCV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGCV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGCV](
        [START_TIME] varchar(4) NOT NULL,
        [END_TIME] varchar(4) NULL,
        [VIEW_INCREMENT] smallint NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGCV_Index_START_TIME] PRIMARY KEY CLUSTERED (
            [START_TIME] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGCVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGCVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGCV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGCV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGCV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_START_TIME = new List<string>();

            foreach (var entity in Entities)
            {
                Index_START_TIME.Add(entity.START_TIME);
            }

            builder.AppendLine("DELETE [dbo].[KGCV] WHERE");


            // Index_START_TIME
            builder.Append("[START_TIME] IN (");
            for (int index = 0; index < Index_START_TIME.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // START_TIME
                var parameterSTART_TIME = $"@p{parameterIndex++}";
                builder.Append(parameterSTART_TIME);
                command.Parameters.Add(parameterSTART_TIME, SqlDbType.VarChar, 4).Value = Index_START_TIME[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGCV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGCV data set</returns>
        public override EduHubDataSetDataReader<KGCV> GetDataSetDataReader()
        {
            return new KGCVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGCV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGCV data set</returns>
        public override EduHubDataSetDataReader<KGCV> GetDataSetDataReader(List<KGCV> Entities)
        {
            return new KGCVDataReader(new EduHubDataSetLoadedReader<KGCV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGCVDataReader : EduHubDataSetDataReader<KGCV>
        {
            public KGCVDataReader(IEduHubDataSetReader<KGCV> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // START_TIME
                        return Current.START_TIME;
                    case 1: // END_TIME
                        return Current.END_TIME;
                    case 2: // VIEW_INCREMENT
                        return Current.VIEW_INCREMENT;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION;
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
                    case 1: // END_TIME
                        return Current.END_TIME == null;
                    case 2: // VIEW_INCREMENT
                        return Current.VIEW_INCREMENT == null;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION == null;
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
                    case 0: // START_TIME
                        return "START_TIME";
                    case 1: // END_TIME
                        return "END_TIME";
                    case 2: // VIEW_INCREMENT
                        return "VIEW_INCREMENT";
                    case 3: // DESCRIPTION
                        return "DESCRIPTION";
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
                    case "START_TIME":
                        return 0;
                    case "END_TIME":
                        return 1;
                    case "VIEW_INCREMENT":
                        return 2;
                    case "DESCRIPTION":
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

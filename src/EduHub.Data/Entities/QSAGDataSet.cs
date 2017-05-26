﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Audit Group Tables Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSAGDataSet : EduHubDataSet<QSAG>
    {
        /// <inheritdoc />
        public override string Name { get { return "QSAG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal QSAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QSAGKEY = new Lazy<Dictionary<string, QSAG>>(() => this.ToDictionary(i => i.QSAGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QSAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QSAG" /> fields for each CSV column header</returns>
        internal override Action<QSAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QSAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QSAGKEY":
                        mapper[i] = (e, v) => e.QSAGKEY = v;
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
        /// Merges <see cref="QSAG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="QSAG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="QSAG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{QSAG}"/> of entities</returns>
        internal override IEnumerable<QSAG> ApplyDeltaEntities(IEnumerable<QSAG> Entities, List<QSAG> DeltaEntities)
        {
            HashSet<string> Index_QSAGKEY = new HashSet<string>(DeltaEntities.Select(i => i.QSAGKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.QSAGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_QSAGKEY.Remove(entity.QSAGKEY);
                            
                            if (entity.QSAGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, QSAG>> Index_QSAGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QSAG by QSAGKEY field
        /// </summary>
        /// <param name="QSAGKEY">QSAGKEY value used to find QSAG</param>
        /// <returns>Related QSAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAG FindByQSAGKEY(string QSAGKEY)
        {
            return Index_QSAGKEY.Value[QSAGKEY];
        }

        /// <summary>
        /// Attempt to find QSAG by QSAGKEY field
        /// </summary>
        /// <param name="QSAGKEY">QSAGKEY value used to find QSAG</param>
        /// <param name="Value">Related QSAG entity</param>
        /// <returns>True if the related QSAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQSAGKEY(string QSAGKEY, out QSAG Value)
        {
            return Index_QSAGKEY.Value.TryGetValue(QSAGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QSAG by QSAGKEY field
        /// </summary>
        /// <param name="QSAGKEY">QSAGKEY value used to find QSAG</param>
        /// <returns>Related QSAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAG TryFindByQSAGKEY(string QSAGKEY)
        {
            QSAG value;
            if (Index_QSAGKEY.Value.TryGetValue(QSAGKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a QSAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QSAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QSAG](
        [QSAGKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(32) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QSAG_Index_QSAGKEY] PRIMARY KEY CLUSTERED (
            [QSAGKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="QSAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="QSAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="QSAG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="QSAG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<QSAG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_QSAGKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_QSAGKEY.Add(entity.QSAGKEY);
            }

            builder.AppendLine("DELETE [dbo].[QSAG] WHERE");


            // Index_QSAGKEY
            builder.Append("[QSAGKEY] IN (");
            for (int index = 0; index < Index_QSAGKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // QSAGKEY
                var parameterQSAGKEY = $"@p{parameterIndex++}";
                builder.Append(parameterQSAGKEY);
                command.Parameters.Add(parameterQSAGKEY, SqlDbType.VarChar, 10).Value = Index_QSAGKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAG data set</returns>
        public override EduHubDataSetDataReader<QSAG> GetDataSetDataReader()
        {
            return new QSAGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAG data set</returns>
        public override EduHubDataSetDataReader<QSAG> GetDataSetDataReader(List<QSAG> Entities)
        {
            return new QSAGDataReader(new EduHubDataSetLoadedReader<QSAG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QSAGDataReader : EduHubDataSetDataReader<QSAG>
        {
            public QSAGDataReader(IEduHubDataSetReader<QSAG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // QSAGKEY
                        return Current.QSAGKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // LW_DATE
                        return Current.LW_DATE;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_USER
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
                    case 2: // LW_DATE
                        return Current.LW_DATE == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // QSAGKEY
                        return "QSAGKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "QSAGKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

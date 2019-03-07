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
    /// File Store for streaming files to eMaze Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPFSTOREDataSet : EduHubDataSet<SPFSTORE>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPFSTORE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPFSTOREDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FILE_ID = new Lazy<Dictionary<int, SPFSTORE>>(() => this.ToDictionary(i => i.FILE_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPFSTORE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPFSTORE" /> fields for each CSV column header</returns>
        internal override Action<SPFSTORE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPFSTORE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "FILE_ID":
                        mapper[i] = (e, v) => e.FILE_ID = int.Parse(v);
                        break;
                    case "PHYSICAL_LOCATION":
                        mapper[i] = (e, v) => e.PHYSICAL_LOCATION = v;
                        break;
                    case "ROOT_ID":
                        mapper[i] = (e, v) => e.ROOT_ID = v;
                        break;
                    case "DISPLAY_NAME":
                        mapper[i] = (e, v) => e.DISPLAY_NAME = v;
                        break;
                    case "MIME_TYPE":
                        mapper[i] = (e, v) => e.MIME_TYPE = v;
                        break;
                    case "ASSOCIATION_TYPE":
                        mapper[i] = (e, v) => e.ASSOCIATION_TYPE = int.Parse(v);
                        break;
                    case "PAGE_ID":
                        mapper[i] = (e, v) => e.PAGE_ID = v;
                        break;
                    case "FILE_SIZE":
                        mapper[i] = (e, v) => e.FILE_SIZE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FILE_EXTENSION":
                        mapper[i] = (e, v) => e.FILE_EXTENSION = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SPFSTORE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPFSTORE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPFSTORE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPFSTORE}"/> of entities</returns>
        internal override IEnumerable<SPFSTORE> ApplyDeltaEntities(IEnumerable<SPFSTORE> Entities, List<SPFSTORE> DeltaEntities)
        {
            HashSet<int> Index_FILE_ID = new HashSet<int>(DeltaEntities.Select(i => i.FILE_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.FILE_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_FILE_ID.Remove(entity.FILE_ID);
                            
                            if (entity.FILE_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SPFSTORE>> Index_FILE_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPFSTORE by FILE_ID field
        /// </summary>
        /// <param name="FILE_ID">FILE_ID value used to find SPFSTORE</param>
        /// <returns>Related SPFSTORE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPFSTORE FindByFILE_ID(int FILE_ID)
        {
            return Index_FILE_ID.Value[FILE_ID];
        }

        /// <summary>
        /// Attempt to find SPFSTORE by FILE_ID field
        /// </summary>
        /// <param name="FILE_ID">FILE_ID value used to find SPFSTORE</param>
        /// <param name="Value">Related SPFSTORE entity</param>
        /// <returns>True if the related SPFSTORE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFILE_ID(int FILE_ID, out SPFSTORE Value)
        {
            return Index_FILE_ID.Value.TryGetValue(FILE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SPFSTORE by FILE_ID field
        /// </summary>
        /// <param name="FILE_ID">FILE_ID value used to find SPFSTORE</param>
        /// <returns>Related SPFSTORE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPFSTORE TryFindByFILE_ID(int FILE_ID)
        {
            SPFSTORE value;
            if (Index_FILE_ID.Value.TryGetValue(FILE_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPFSTORE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPFSTORE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPFSTORE](
        [FILE_ID] int IDENTITY NOT NULL,
        [PHYSICAL_LOCATION] varchar(500) NOT NULL,
        [ROOT_ID] varchar(255) NULL,
        [DISPLAY_NAME] varchar(50) NOT NULL,
        [MIME_TYPE] varchar(100) NOT NULL,
        [ASSOCIATION_TYPE] int NOT NULL,
        [PAGE_ID] varchar(200) NULL,
        [FILE_SIZE] int NULL,
        [FILE_EXTENSION] varchar(10) NULL,
        [LW_DATE] datetime NOT NULL,
        [LW_USER] varchar(128) NOT NULL,
        CONSTRAINT [SPFSTORE_Index_FILE_ID] PRIMARY KEY CLUSTERED (
            [FILE_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SPFSTOREDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SPFSTOREDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPFSTORE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPFSTORE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPFSTORE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_FILE_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_FILE_ID.Add(entity.FILE_ID);
            }

            builder.AppendLine("DELETE [dbo].[SPFSTORE] WHERE");


            // Index_FILE_ID
            builder.Append("[FILE_ID] IN (");
            for (int index = 0; index < Index_FILE_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // FILE_ID
                var parameterFILE_ID = $"@p{parameterIndex++}";
                builder.Append(parameterFILE_ID);
                command.Parameters.Add(parameterFILE_ID, SqlDbType.Int).Value = Index_FILE_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPFSTORE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPFSTORE data set</returns>
        public override EduHubDataSetDataReader<SPFSTORE> GetDataSetDataReader()
        {
            return new SPFSTOREDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPFSTORE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPFSTORE data set</returns>
        public override EduHubDataSetDataReader<SPFSTORE> GetDataSetDataReader(List<SPFSTORE> Entities)
        {
            return new SPFSTOREDataReader(new EduHubDataSetLoadedReader<SPFSTORE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPFSTOREDataReader : EduHubDataSetDataReader<SPFSTORE>
        {
            public SPFSTOREDataReader(IEduHubDataSetReader<SPFSTORE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // FILE_ID
                        return Current.FILE_ID;
                    case 1: // PHYSICAL_LOCATION
                        return Current.PHYSICAL_LOCATION;
                    case 2: // ROOT_ID
                        return Current.ROOT_ID;
                    case 3: // DISPLAY_NAME
                        return Current.DISPLAY_NAME;
                    case 4: // MIME_TYPE
                        return Current.MIME_TYPE;
                    case 5: // ASSOCIATION_TYPE
                        return Current.ASSOCIATION_TYPE;
                    case 6: // PAGE_ID
                        return Current.PAGE_ID;
                    case 7: // FILE_SIZE
                        return Current.FILE_SIZE;
                    case 8: // FILE_EXTENSION
                        return Current.FILE_EXTENSION;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ROOT_ID
                        return Current.ROOT_ID == null;
                    case 6: // PAGE_ID
                        return Current.PAGE_ID == null;
                    case 7: // FILE_SIZE
                        return Current.FILE_SIZE == null;
                    case 8: // FILE_EXTENSION
                        return Current.FILE_EXTENSION == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // FILE_ID
                        return "FILE_ID";
                    case 1: // PHYSICAL_LOCATION
                        return "PHYSICAL_LOCATION";
                    case 2: // ROOT_ID
                        return "ROOT_ID";
                    case 3: // DISPLAY_NAME
                        return "DISPLAY_NAME";
                    case 4: // MIME_TYPE
                        return "MIME_TYPE";
                    case 5: // ASSOCIATION_TYPE
                        return "ASSOCIATION_TYPE";
                    case 6: // PAGE_ID
                        return "PAGE_ID";
                    case 7: // FILE_SIZE
                        return "FILE_SIZE";
                    case 8: // FILE_EXTENSION
                        return "FILE_EXTENSION";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "FILE_ID":
                        return 0;
                    case "PHYSICAL_LOCATION":
                        return 1;
                    case "ROOT_ID":
                        return 2;
                    case "DISPLAY_NAME":
                        return 3;
                    case "MIME_TYPE":
                        return 4;
                    case "ASSOCIATION_TYPE":
                        return 5;
                    case "PAGE_ID":
                        return 6;
                    case "FILE_SIZE":
                        return 7;
                    case "FILE_EXTENSION":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}

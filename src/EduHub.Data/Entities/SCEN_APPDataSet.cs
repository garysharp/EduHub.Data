#if !EduHubScoped
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
    /// Census Application Message Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_APPDataSet : EduHubDataSet<SCEN_APP>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_APP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_APPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_APP>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_APP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_APP" /> fields for each CSV column header</returns>
        internal override Action<SCEN_APP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_APP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ITEMNAME":
                        mapper[i] = (e, v) => e.ITEMNAME = v;
                        break;
                    case "ITEMVALUE":
                        mapper[i] = (e, v) => e.ITEMVALUE = v;
                        break;
                    case "ITEMTYPE":
                        mapper[i] = (e, v) => e.ITEMTYPE = v;
                        break;
                    case "ITEMMINITYPE":
                        mapper[i] = (e, v) => e.ITEMMINITYPE = v;
                        break;
                    case "ITEMCOMMENTS":
                        mapper[i] = (e, v) => e.ITEMCOMMENTS = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_APP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_APP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_APP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_APP}"/> of entities</returns>
        internal override IEnumerable<SCEN_APP> ApplyDeltaEntities(IEnumerable<SCEN_APP> Entities, List<SCEN_APP> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SCEN_APP>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_APP FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <param name="Value">Related SCEN_APP entity</param>
        /// <returns>True if the related SCEN_APP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_APP Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_APP TryFindByID(int ID)
        {
            SCEN_APP value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_APP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_APP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_APP](
        [ID] int IDENTITY NOT NULL,
        [ITEMNAME] varchar(255) NULL,
        [ITEMVALUE] varchar(255) NULL,
        [ITEMTYPE] varchar(255) NULL,
        [ITEMMINITYPE] varchar(255) NULL,
        [ITEMCOMMENTS] varchar(255) NULL,
        CONSTRAINT [SCEN_APP_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_APPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_APPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_APP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_APP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_APP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_APP] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_APP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_APP data set</returns>
        public override EduHubDataSetDataReader<SCEN_APP> GetDataSetDataReader()
        {
            return new SCEN_APPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_APP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_APP data set</returns>
        public override EduHubDataSetDataReader<SCEN_APP> GetDataSetDataReader(List<SCEN_APP> Entities)
        {
            return new SCEN_APPDataReader(new EduHubDataSetLoadedReader<SCEN_APP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_APPDataReader : EduHubDataSetDataReader<SCEN_APP>
        {
            public SCEN_APPDataReader(IEduHubDataSetReader<SCEN_APP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // ITEMNAME
                        return Current.ITEMNAME;
                    case 2: // ITEMVALUE
                        return Current.ITEMVALUE;
                    case 3: // ITEMTYPE
                        return Current.ITEMTYPE;
                    case 4: // ITEMMINITYPE
                        return Current.ITEMMINITYPE;
                    case 5: // ITEMCOMMENTS
                        return Current.ITEMCOMMENTS;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ITEMNAME
                        return Current.ITEMNAME == null;
                    case 2: // ITEMVALUE
                        return Current.ITEMVALUE == null;
                    case 3: // ITEMTYPE
                        return Current.ITEMTYPE == null;
                    case 4: // ITEMMINITYPE
                        return Current.ITEMMINITYPE == null;
                    case 5: // ITEMCOMMENTS
                        return Current.ITEMCOMMENTS == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // ITEMNAME
                        return "ITEMNAME";
                    case 2: // ITEMVALUE
                        return "ITEMVALUE";
                    case 3: // ITEMTYPE
                        return "ITEMTYPE";
                    case 4: // ITEMMINITYPE
                        return "ITEMMINITYPE";
                    case 5: // ITEMCOMMENTS
                        return "ITEMCOMMENTS";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "ITEMNAME":
                        return 1;
                    case "ITEMVALUE":
                        return 2;
                    case "ITEMTYPE":
                        return 3;
                    case "ITEMMINITYPE":
                        return 4;
                    case "ITEMCOMMENTS":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif

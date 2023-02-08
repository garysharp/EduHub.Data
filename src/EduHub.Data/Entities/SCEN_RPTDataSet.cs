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
    /// Census Report Usage Metadata Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_RPTDataSet : EduHubDataSet<SCEN_RPT>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_RPT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_RPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_RPT>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RPT" /> fields for each CSV column header</returns>
        internal override Action<SCEN_RPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "PROG":
                        mapper[i] = (e, v) => e.PROG = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "REQUIREDPRINCIPALFIELD":
                        mapper[i] = (e, v) => e.REQUIREDPRINCIPALFIELD = v;
                        break;
                    case "ISPRIMARY":
                        mapper[i] = (e, v) => e.ISPRIMARY = v;
                        break;
                    case "ISPRIMARYSECONDARY":
                        mapper[i] = (e, v) => e.ISPRIMARYSECONDARY = v;
                        break;
                    case "ISSECONDARY":
                        mapper[i] = (e, v) => e.ISSECONDARY = v;
                        break;
                    case "ISLANGUAGE":
                        mapper[i] = (e, v) => e.ISLANGUAGE = v;
                        break;
                    case "ISSPECIAL":
                        mapper[i] = (e, v) => e.ISSPECIAL = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_RPT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_RPT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_RPT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_RPT}"/> of entities</returns>
        internal override IEnumerable<SCEN_RPT> ApplyDeltaEntities(IEnumerable<SCEN_RPT> Entities, List<SCEN_RPT> DeltaEntities)
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

        private Lazy<Dictionary<int, SCEN_RPT>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RPT FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <param name="Value">Related SCEN_RPT entity</param>
        /// <returns>True if the related SCEN_RPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_RPT Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RPT TryFindByID(int ID)
        {
            SCEN_RPT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_RPT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_RPT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_RPT](
        [ID] int IDENTITY NOT NULL,
        [TITLE] varchar(255) NULL,
        [PROG] varchar(10) NULL,
        [PERIOD] varchar(1) NULL,
        [REQUIREDPRINCIPALFIELD] varchar(1) NULL,
        [ISPRIMARY] varchar(1) NULL,
        [ISPRIMARYSECONDARY] varchar(1) NULL,
        [ISSECONDARY] varchar(1) NULL,
        [ISLANGUAGE] varchar(1) NULL,
        [ISSPECIAL] varchar(1) NULL,
        CONSTRAINT [SCEN_RPT_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_RPTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_RPTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_RPT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_RPT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_RPT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_RPT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SCEN_RPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_RPT data set</returns>
        public override EduHubDataSetDataReader<SCEN_RPT> GetDataSetDataReader()
        {
            return new SCEN_RPTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_RPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_RPT data set</returns>
        public override EduHubDataSetDataReader<SCEN_RPT> GetDataSetDataReader(List<SCEN_RPT> Entities)
        {
            return new SCEN_RPTDataReader(new EduHubDataSetLoadedReader<SCEN_RPT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_RPTDataReader : EduHubDataSetDataReader<SCEN_RPT>
        {
            public SCEN_RPTDataReader(IEduHubDataSetReader<SCEN_RPT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 10; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // PROG
                        return Current.PROG;
                    case 3: // PERIOD
                        return Current.PERIOD;
                    case 4: // REQUIREDPRINCIPALFIELD
                        return Current.REQUIREDPRINCIPALFIELD;
                    case 5: // ISPRIMARY
                        return Current.ISPRIMARY;
                    case 6: // ISPRIMARYSECONDARY
                        return Current.ISPRIMARYSECONDARY;
                    case 7: // ISSECONDARY
                        return Current.ISSECONDARY;
                    case 8: // ISLANGUAGE
                        return Current.ISLANGUAGE;
                    case 9: // ISSPECIAL
                        return Current.ISSPECIAL;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // PROG
                        return Current.PROG == null;
                    case 3: // PERIOD
                        return Current.PERIOD == null;
                    case 4: // REQUIREDPRINCIPALFIELD
                        return Current.REQUIREDPRINCIPALFIELD == null;
                    case 5: // ISPRIMARY
                        return Current.ISPRIMARY == null;
                    case 6: // ISPRIMARYSECONDARY
                        return Current.ISPRIMARYSECONDARY == null;
                    case 7: // ISSECONDARY
                        return Current.ISSECONDARY == null;
                    case 8: // ISLANGUAGE
                        return Current.ISLANGUAGE == null;
                    case 9: // ISSPECIAL
                        return Current.ISSPECIAL == null;
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
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // PROG
                        return "PROG";
                    case 3: // PERIOD
                        return "PERIOD";
                    case 4: // REQUIREDPRINCIPALFIELD
                        return "REQUIREDPRINCIPALFIELD";
                    case 5: // ISPRIMARY
                        return "ISPRIMARY";
                    case 6: // ISPRIMARYSECONDARY
                        return "ISPRIMARYSECONDARY";
                    case 7: // ISSECONDARY
                        return "ISSECONDARY";
                    case 8: // ISLANGUAGE
                        return "ISLANGUAGE";
                    case 9: // ISSPECIAL
                        return "ISSPECIAL";
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
                    case "TITLE":
                        return 1;
                    case "PROG":
                        return 2;
                    case "PERIOD":
                        return 3;
                    case "REQUIREDPRINCIPALFIELD":
                        return 4;
                    case "ISPRIMARY":
                        return 5;
                    case "ISPRIMARYSECONDARY":
                        return 6;
                    case "ISSECONDARY":
                        return 7;
                    case "ISLANGUAGE":
                        return 8;
                    case "ISSPECIAL":
                        return 9;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif

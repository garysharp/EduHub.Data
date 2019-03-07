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
    /// Stored Procedure Return Values Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPOUTDataSet : EduHubDataSet<SPOUT>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPOUT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPOUTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPOUTKEY = new Lazy<Dictionary<string, SPOUT>>(() => this.ToDictionary(i => i.SPOUTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPOUT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPOUT" /> fields for each CSV column header</returns>
        internal override Action<SPOUT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPOUT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
                        break;
                    case "FILE_NAME":
                        mapper[i] = (e, v) => e.FILE_NAME = v;
                        break;
                    case "ENTITYID":
                        mapper[i] = (e, v) => e.ENTITYID = v;
                        break;
                    case "FLAG01":
                        mapper[i] = (e, v) => e.FLAG01 = v;
                        break;
                    case "FLAG02":
                        mapper[i] = (e, v) => e.FLAG02 = v;
                        break;
                    case "FLAG03":
                        mapper[i] = (e, v) => e.FLAG03 = v;
                        break;
                    case "FLAG04":
                        mapper[i] = (e, v) => e.FLAG04 = v;
                        break;
                    case "TXT01":
                        mapper[i] = (e, v) => e.TXT01 = v;
                        break;
                    case "TXT02":
                        mapper[i] = (e, v) => e.TXT02 = v;
                        break;
                    case "TXT03":
                        mapper[i] = (e, v) => e.TXT03 = v;
                        break;
                    case "TXT04":
                        mapper[i] = (e, v) => e.TXT04 = v;
                        break;
                    case "NUM01":
                        mapper[i] = (e, v) => e.NUM01 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM02":
                        mapper[i] = (e, v) => e.NUM02 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM03":
                        mapper[i] = (e, v) => e.NUM03 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM04":
                        mapper[i] = (e, v) => e.NUM04 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
        /// Merges <see cref="SPOUT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPOUT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPOUT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPOUT}"/> of entities</returns>
        internal override IEnumerable<SPOUT> ApplyDeltaEntities(IEnumerable<SPOUT> Entities, List<SPOUT> DeltaEntities)
        {
            HashSet<string> Index_SPOUTKEY = new HashSet<string>(DeltaEntities.Select(i => i.SPOUTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SPOUTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SPOUTKEY.Remove(entity.SPOUTKEY);
                            
                            if (entity.SPOUTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, SPOUT>> Index_SPOUTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPOUT FindBySPOUTKEY(string SPOUTKEY)
        {
            return Index_SPOUTKEY.Value[SPOUTKEY];
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <param name="Value">Related SPOUT entity</param>
        /// <returns>True if the related SPOUT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPOUTKEY(string SPOUTKEY, out SPOUT Value)
        {
            return Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPOUT TryFindBySPOUTKEY(string SPOUTKEY)
        {
            SPOUT value;
            if (Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPOUT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPOUT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPOUT](
        [SPOUTKEY] varchar(100) NOT NULL,
        [FILE_NAME] varchar(200) NULL,
        [ENTITYID] varchar(10) NULL,
        [FLAG01] varchar(1) NULL,
        [FLAG02] varchar(1) NULL,
        [FLAG03] varchar(1) NULL,
        [FLAG04] varchar(1) NULL,
        [TXT01] varchar(40) NULL,
        [TXT02] varchar(40) NULL,
        [TXT03] varchar(40) NULL,
        [TXT04] varchar(40) NULL,
        [NUM01] int NULL,
        [NUM02] int NULL,
        [NUM03] int NULL,
        [NUM04] int NULL,
        [NOTES] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPOUT_Index_SPOUTKEY] PRIMARY KEY CLUSTERED (
            [SPOUTKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SPOUTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SPOUTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPOUT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPOUT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPOUT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SPOUTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SPOUTKEY.Add(entity.SPOUTKEY);
            }

            builder.AppendLine("DELETE [dbo].[SPOUT] WHERE");


            // Index_SPOUTKEY
            builder.Append("[SPOUTKEY] IN (");
            for (int index = 0; index < Index_SPOUTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SPOUTKEY
                var parameterSPOUTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSPOUTKEY);
                command.Parameters.Add(parameterSPOUTKEY, SqlDbType.VarChar, 100).Value = Index_SPOUTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPOUT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPOUT data set</returns>
        public override EduHubDataSetDataReader<SPOUT> GetDataSetDataReader()
        {
            return new SPOUTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPOUT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPOUT data set</returns>
        public override EduHubDataSetDataReader<SPOUT> GetDataSetDataReader(List<SPOUT> Entities)
        {
            return new SPOUTDataReader(new EduHubDataSetLoadedReader<SPOUT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPOUTDataReader : EduHubDataSetDataReader<SPOUT>
        {
            public SPOUTDataReader(IEduHubDataSetReader<SPOUT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 19; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SPOUTKEY
                        return Current.SPOUTKEY;
                    case 1: // FILE_NAME
                        return Current.FILE_NAME;
                    case 2: // ENTITYID
                        return Current.ENTITYID;
                    case 3: // FLAG01
                        return Current.FLAG01;
                    case 4: // FLAG02
                        return Current.FLAG02;
                    case 5: // FLAG03
                        return Current.FLAG03;
                    case 6: // FLAG04
                        return Current.FLAG04;
                    case 7: // TXT01
                        return Current.TXT01;
                    case 8: // TXT02
                        return Current.TXT02;
                    case 9: // TXT03
                        return Current.TXT03;
                    case 10: // TXT04
                        return Current.TXT04;
                    case 11: // NUM01
                        return Current.NUM01;
                    case 12: // NUM02
                        return Current.NUM02;
                    case 13: // NUM03
                        return Current.NUM03;
                    case 14: // NUM04
                        return Current.NUM04;
                    case 15: // NOTES
                        return Current.NOTES;
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
                    case 1: // FILE_NAME
                        return Current.FILE_NAME == null;
                    case 2: // ENTITYID
                        return Current.ENTITYID == null;
                    case 3: // FLAG01
                        return Current.FLAG01 == null;
                    case 4: // FLAG02
                        return Current.FLAG02 == null;
                    case 5: // FLAG03
                        return Current.FLAG03 == null;
                    case 6: // FLAG04
                        return Current.FLAG04 == null;
                    case 7: // TXT01
                        return Current.TXT01 == null;
                    case 8: // TXT02
                        return Current.TXT02 == null;
                    case 9: // TXT03
                        return Current.TXT03 == null;
                    case 10: // TXT04
                        return Current.TXT04 == null;
                    case 11: // NUM01
                        return Current.NUM01 == null;
                    case 12: // NUM02
                        return Current.NUM02 == null;
                    case 13: // NUM03
                        return Current.NUM03 == null;
                    case 14: // NUM04
                        return Current.NUM04 == null;
                    case 15: // NOTES
                        return Current.NOTES == null;
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
                    case 0: // SPOUTKEY
                        return "SPOUTKEY";
                    case 1: // FILE_NAME
                        return "FILE_NAME";
                    case 2: // ENTITYID
                        return "ENTITYID";
                    case 3: // FLAG01
                        return "FLAG01";
                    case 4: // FLAG02
                        return "FLAG02";
                    case 5: // FLAG03
                        return "FLAG03";
                    case 6: // FLAG04
                        return "FLAG04";
                    case 7: // TXT01
                        return "TXT01";
                    case 8: // TXT02
                        return "TXT02";
                    case 9: // TXT03
                        return "TXT03";
                    case 10: // TXT04
                        return "TXT04";
                    case 11: // NUM01
                        return "NUM01";
                    case 12: // NUM02
                        return "NUM02";
                    case 13: // NUM03
                        return "NUM03";
                    case 14: // NUM04
                        return "NUM04";
                    case 15: // NOTES
                        return "NOTES";
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
                    case "SPOUTKEY":
                        return 0;
                    case "FILE_NAME":
                        return 1;
                    case "ENTITYID":
                        return 2;
                    case "FLAG01":
                        return 3;
                    case "FLAG02":
                        return 4;
                    case "FLAG03":
                        return 5;
                    case "FLAG04":
                        return 6;
                    case "TXT01":
                        return 7;
                    case "TXT02":
                        return 8;
                    case "TXT03":
                        return 9;
                    case "TXT04":
                        return 10;
                    case "NUM01":
                        return 11;
                    case "NUM02":
                        return 12;
                    case "NUM03":
                        return 13;
                    case "NUM04":
                        return 14;
                    case "NOTES":
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

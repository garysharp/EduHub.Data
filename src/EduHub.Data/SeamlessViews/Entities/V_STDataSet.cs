using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Identifies Student Data View Data Set
    /// </summary>
    public class V_STDataSet : SeamlessViewsDataSetBase<V_ST>
    {

        internal V_STDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        protected override List<V_ST> Load()
        {
            return Context.EduHubContext
                .ST
                .Where(st => st.STATUS != "LEFT" &&
                            st.SCHOOL_YEAR != null &&
                            st.FAMILY != null &&
                            st.FAMILY_DF.MAILKEY != null)
                .Select(st => new V_ST(st))
                .ToList();
        }

    }
}

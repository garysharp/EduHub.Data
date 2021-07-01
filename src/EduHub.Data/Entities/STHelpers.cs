using System;

namespace EduHub.Data.Entities
{
    public partial class ST
    {

        /// <summary>
        /// Language Background Other Than English
        /// (Based on usr_fn_LBOTE)
        /// </summary>
        public string LBOTE
        {
            get
            {
                return (LOTE_HOME_CODE != null && LOTE_HOME_CODE != "1201") || // Student LOTE Home Code
                    FAMILY_DF != null && ( // Family Exists
                    (FAMILY_DF.LOTE_HOME_CODE_A != null && FAMILY_DF.LOTE_HOME_CODE_A != "1201") || // Adult A LOTE Home Code
                    (FAMILY_DF.LOTE_HOME_CODE_B != null && FAMILY_DF.LOTE_HOME_CODE_B != "1201")) // Adult B LOTE Home Code
                    ? "Y" : "N";
            }
        }

        /// <summary>
        /// ESL
        /// (Based on usr_fn_ESL)
        /// </summary>
        /// <param name="CutOff">ESL cut off date</param>
        /// <param name="YearSpan">Year span</param>
        /// <returns></returns>
        public string ESL(DateTime CutOff, short YearSpan)
        {
            if (HOME_LANG != "1201" &&
                AUSSIE_SCHOOL.Value.AddYears(YearSpan) >= CutOff &&
                LBOTE == "Y")
            {
                return "Y";
            }
            else
            {
                return "N";
            }
        }

        /// <summary>
        /// Student's Family Occupation
        /// (Based on usr_fn_family_occupation)
        /// </summary>
        public string FAMILY_OCCUPATION
        {
            get
            {
                if (RELATION_A01.Equals("Self", StringComparison.OrdinalIgnoreCase))
                {
                    return "N";
                }
                else if (FAMILY_DF.OCCUP_STATUS_A == null && FAMILY_DF.OCCUP_STATUS_B == null)
                {
                    return "U";
                }
                else if (FAMILY_DF.OCCUP_STATUS_A == null)
                {
                    return FAMILY_DF.OCCUP_STATUS_B;
                }
                else if (FAMILY_DF.OCCUP_STATUS_B == null)
                {
                    return FAMILY_DF.OCCUP_STATUS_A;
                }
                else if (FAMILY_DF.OCCUP_STATUS_A.CompareTo(FAMILY_DF.OCCUP_STATUS_B) <= 0)
                {
                    return FAMILY_DF.OCCUP_STATUS_A;
                }
                else
                {
                    return FAMILY_DF.OCCUP_STATUS_B;
                }
            }
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Student: {STKEY} ({SURNAME}, {FIRST_NAME})";
        }
    }
}

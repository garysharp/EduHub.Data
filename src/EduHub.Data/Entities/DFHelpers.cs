namespace EduHub.Data.Entities
{
    public partial class DF
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Family: {DFKEY} ({BILLINGTITLE ?? MAILTITLE ?? HOMETITLE ?? ($"{TITLE_A} {NAME_A} {SURNAME_A} & {TITLE_B} {NAME_B} {SURNAME_B}")})";
        }
    }
}

namespace EduHub.Data.Entities
{
    public partial class DF
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"Family: {DFKEY} ({BILLINGTITLE ?? MAILTITLE ?? HOMETITLE ?? ($"{TITLE_A} {NAME_A} {SURNAME_A} & {TITLE_B} {NAME_B} {SURNAME_B}")})";
        }
    }
}

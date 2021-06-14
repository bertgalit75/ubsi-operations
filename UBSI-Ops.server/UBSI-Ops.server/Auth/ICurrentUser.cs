namespace UBSI_Ops.server.Auth
{
    public interface ICurrentUser
    {
        public int Id { get; }

        public int? OrganizationId { get; }
    }
}

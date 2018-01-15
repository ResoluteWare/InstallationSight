namespace ResoluteWare.InstallationSight.Domain.Install
{
    public class InstallEvent : BaseEntity
    {
        public int ComponentId { get; set; }

        public decimal InstallQty { get; set; }
    }
}
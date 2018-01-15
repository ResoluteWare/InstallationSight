namespace ResoluteWare.InstallationSight.Domain.Manpower
{
    public class LaborHour : BaseEntity
    {

        public int InstallGroupId { get; set; }

        public decimal Hours { get; set; }
    }
}
namespace ResoluteWare.InstallationSight.DataAccess.DTO
{
    public class ComponentDto : BaseDto
    {
        public string Name { get; set; }

        public string ExternalId { get; set; }

        public int ElevationId { get; set; }

        public int InstallGroupId { get; set; }

        public decimal TotalQty { get; set; }

        public decimal InstallMinutes { get; set; }
    }
}
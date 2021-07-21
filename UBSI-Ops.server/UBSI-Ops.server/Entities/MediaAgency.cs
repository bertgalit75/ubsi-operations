namespace UBSI_Ops.server.Entities
{
    public class MediaAgency
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string ContactNo { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Remarks { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public override string ToString()
        {
            return $"{AddressLine}, {City} {Province}";
        }
    }
}

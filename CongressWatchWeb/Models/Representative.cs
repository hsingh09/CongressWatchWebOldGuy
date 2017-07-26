namespace CongressWatchWeb.Models
{
    public class Representative
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string state { get; set; }
        public string representativeId { get; set; }
        public int chamber { get; set; }
    }

    public class RepresentativeDetail
    {
        public string id{ get; set; }
        public string representativeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int chamber { get; set; }
        public int party { get; set; }
        public string contactUrl { get; set; }
        public string cspanId { get; set; }
        public string facebookAccount { get; set; }
        public string googleEntityId { get; set; }
        public string govtrackId { get; set; }
        public string phone { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }
}

using System;

namespace AkademiPlusSignalR2.DAL
{
    public enum ECity
    {
        İstanbul = 1,
        Bursa = 2,
        İzmir = 3,
        Ankara = 4,
        Tekirdağ = 5,
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}

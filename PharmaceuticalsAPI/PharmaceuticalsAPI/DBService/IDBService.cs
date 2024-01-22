namespace PharmaceuticalsAPI.DBService
{
    public interface IDBService
    {
        public object GetPharmaceuticals(string includes);
        public object GetPharmacies(string pharmaceutical);
    }
}

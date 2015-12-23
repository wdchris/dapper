namespace Core.Models
{
    public class NominalLedgerCode
    {
        public int Id { get; private set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public NominalLedgerCode(int id)
        {
            Id = id;
        }
    }
}

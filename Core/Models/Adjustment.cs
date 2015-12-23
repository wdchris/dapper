namespace Core.Models
{
    public class Adjustment
    {
        public int EntityId { get; private set; }
        public int NominalLedgerCodeId { get; private set; }
        public decimal Value { get; set; }

        public Adjustment(int entityId, int nominalLedgerCodeId)
        {
            EntityId = entityId;
            NominalLedgerCodeId = nominalLedgerCodeId;
        }
    }
}

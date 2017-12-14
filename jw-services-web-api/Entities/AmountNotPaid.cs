namespace jw.services.web.api.Entities
{
    public class AmountNotPaid : EntityBase
    {
        public int AccountSheetId { get; set; }

        public string Reference { get; set; }

        public decimal Amount { get; set; }
    }
}
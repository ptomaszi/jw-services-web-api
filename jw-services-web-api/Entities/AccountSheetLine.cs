using System;

namespace jw.services.web.api.Entities
{
    public class AccountSheetLine : EntityBase
    {
        public DateTime Date { get; set; }

        public TransactionType Type { get; set; }

        public decimal AmountIn { get; set; }

        public decimal AmountOut { get; set; }

        public decimal AccountAmountIn { get; set; }

        public decimal AccountAmountOut { get; set; }

        public decimal OtherAmountIn { get; set; }

        public decimal OtherAmountOut { get; set; }
    }
}
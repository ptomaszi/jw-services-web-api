using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jw.services.web.api.Entities
{
    public class AccountSheet : EntityBase
    {
        public Congregation Congregation { get; set; }

        public DateTime Period { get; set; }

        public decimal BankStatementBalance { get; set; }

        public decimal DepositsNotOnStatement { get; set; }

        public decimal CurrenctAccountBalanceForward { get; set; }

        public decimal OtherBalanceForward { get; set; }

        public List<AmountNotPaid> AmountNotPaid { get; set; }
    }
}

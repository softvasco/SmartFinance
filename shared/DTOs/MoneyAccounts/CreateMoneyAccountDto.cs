namespace shared.DTOs.MoneyAccounts
{
    public class CreateMoneyAccountDto
    {
        public string Code { get; set; } = string.Empty;
        public int TypeOfMoneyAccountId { get; set; }
        
        //public string SmallDescription { get; set; } = string.Empty;
        //public string FullDescription { get; set; } = string.Empty;
        //public decimal Balance { get; set; }
        //public DateTime OpenDate { get; set; }
        //public DateTime? CloseDate { get; set; }
        //public string? Number { get; set; } = string.Empty;
        //public string? Swift { get; set; } = string.Empty;
        //public string? IBAN { get; set; } = string.Empty;
        //public string? NIB { get; set; } = string.Empty;
        //public decimal? StartingCapital { get; set; }
        //public decimal? DebtCapital { get; set; }
        //public decimal? Installment { get; set; }
        //public int? PayDay { get; set; }
        //public decimal? TAN { get; set; }
        //public decimal? Plafon { get; set; }
        //public decimal? PercentageOfPayment { get; set; }
        //public string? EntityNumber { get; set; }
        //public string? RefNumber { get; set; }
        //public int? CloseExtractDay { get; set; }
        //public string? CardNumber { get; set; }

        //public ICollection<User> Users { get; set; } = [];
        //public ICollection<Document> Documents { get; set; } = [];
    }
}

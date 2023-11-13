namespace ProjectWithLogin.Models.DTO
{
    public class ReportViewModel
    {
        public Nullable<DateTime> FromDate { get; set; }

        public Nullable<DateTime> ToDate { get; set; }

        public string? Location { get; set; }

        public string? Status { get; set; }

        public string? Category { get; set; }

        public string? Type { get; set; }
    }
}

namespace Api.ViewModel.GetMovements
{
    public class GetMovements
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string transactionIdentifier { get; set; }
        public string reason { get; set; }
        public Int32 page {  get; set; }
        public Int32 Size { get; set; }



    }
}

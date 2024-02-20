namespace PolicyPatternGetStarted {
    internal sealed class PurchaseHistory {

        PurchaseHistory(int purchaseFrequencyPerMonth, double returnRate, int totalAmount) {
            PurchaseFrequencyPerMonth = purchaseFrequencyPerMonth;
            ReturnRage = returnRate;
            TotalAmount = totalAmount;
        }

        public int PurchaseFrequencyPerMonth { get; }
        public double ReturnRage { get; }
        public int TotalAmount { get; }
    }
}
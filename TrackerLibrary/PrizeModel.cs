namespace TrackerLibrary
{
    /// <summary>
    /// Representrs the prize for a given place
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Unique Identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// reprsents the number value for the placement in the tournament
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// represent the name of the placement in the tournament
        /// </summary>
        /// <example>
        /// first runnerup
        /// </example>
        public string PlaceName { get; set; }

        /// <summary>
        /// represent the prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
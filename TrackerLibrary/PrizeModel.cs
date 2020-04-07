namespace TrackerLibrary
{
    public class PrizeModel
    {
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
    }
}
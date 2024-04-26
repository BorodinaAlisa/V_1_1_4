namespace DB_993.Classes
{
    public class GetRecommendation
    {
        public List<Realty>? listRealty { get; set; }
        public decimal RatingPrice { get; set; }
        public decimal RatingFloоr { get; set; }
        public decimal RatingRooms { get; set; }
        public decimal RatingSquare { get; set; }
        public string? RatingCity { get; set; }
        public string? RatingType { get; set; }
        public string? RatingForWhat { get; set; }
        public GetRecommendation(List<Realty> listRealty)
        {
            this.listRealty = listRealty;
            GetRatingRealty();
        }
        public GetRecommendation()
        {

        }
        public void GetRatingRealty()
        {
            RatingCity = listRealty![0].City;
            RatingType = listRealty[0].Type;
            RatingForWhat = listRealty[0].ForWhat;

            for (int i = 0; i < listRealty.Count; i++)
            {
                RatingPrice += listRealty[i].Price;
                RatingRooms += listRealty[i].Rooms;
                RatingFloоr += listRealty[i].Floor;
                RatingSquare += listRealty[i].Square;
            }
            RatingPrice = RatingPrice / listRealty.Count;
            RatingRooms = RatingRooms / listRealty.Count;
            RatingFloоr = RatingFloоr / listRealty.Count;
            RatingSquare = RatingSquare / listRealty.Count;
        }

    }
}

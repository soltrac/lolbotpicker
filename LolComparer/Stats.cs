namespace LolComparer
{
    public class Stats
    {
        public string _id { get; set; }
        public string key { get; set; }
        public string role { get; set; }
        public string title { get; set; }
        public General general { get; set; }

        public override string ToString()
        {
            return title + "\t\t(" + general.overallPosition + " - " + general.winPercent + ")";
        }
    }
}

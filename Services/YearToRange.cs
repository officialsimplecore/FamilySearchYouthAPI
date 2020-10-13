namespace FamilySearchYouthAPI.Services
{
    public class Period
    {
        public int id { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
    
    public class YearToRange
    {
            public int[] parseYear(int year, Period[] period)
            {
                int[] output = new int[2];
                if ((year < period[0].StartYear) || (year > period[period.Length - 1].EndYear))
                    return output;
                for (int i = 0; i < period.Length; i++)
                {
                    int currentStartYear = period[i].StartYear;
                    int currentEndYear = period[i].EndYear;
                    if (year > currentStartYear )
                        output[0] = currentStartYear;
                    if (year < currentEndYear)
                        output[1] = currentEndYear;
                }
                return output;
            }
    }
}

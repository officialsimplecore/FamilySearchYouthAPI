﻿using System;
using FamilySearchYouthAPI.Models;

namespace FamilySearchYouthAPI.Services
{
    
    public class YearToRange
    {
            public int parseYear(int year, Period[] period)
            {
                int outputId = -1;
                try
                {
                    if ((year < period[0].StartYear) || (year > period[period.Length - 1].EndYear))
                        return outputId;
                    for (int i = 0; i < period.Length; i++)
                    {
                        int currentStartYear = period[i].StartYear;
                        int currentEndYear = period[i].EndYear;
                        if (year >= currentStartYear)
                            outputId = period[i].Id;
                        if (year <= currentEndYear)
                        {
                            outputId = period[i].Id;
                            return outputId;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Year to range parse");
                    return 1; // Defaults to first period on error
                }

                return outputId;
            }
    }
}

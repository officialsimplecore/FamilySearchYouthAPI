using FamilySearchYouthAPI.Data;
using FamilySearchYouthAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FamilySearchYouthAPI.Services
{
    public class CoordinateParser
    {
        public Coordinate[] Parse(string rawCoordinates)
        {
            // Takes input from text file (because of length)
            var input = rawCoordinates;
            string[] fullstringCoordinates = input.Split(" ");
            int amountOfCoordinates = fullstringCoordinates.Length;

            // Initialize size of output
            Coordinate[] coordinates = new Coordinate[amountOfCoordinates];

            int pointer = 0;
            foreach (string coordinate in fullstringCoordinates)
            {
                string[] _coordinate = coordinate.Split(",");

                // Set temporary coordinates to output array
                coordinates[pointer] = new Coordinate
                {
                    Lat = double.Parse(_coordinate[1]),
                    Lng = double.Parse(_coordinate[0])
                };

                Console.WriteLine($"{coordinates[pointer].Lat} {coordinates[pointer].Lng}");

                pointer++;
            }

            return coordinates;
        }
    }
}
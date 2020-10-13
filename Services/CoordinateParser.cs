using FamilySearchYouthAPI.Data;
using FamilySearchYouthAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FamilySearchYouthAPI.Services
{
    public class CoordinateParser
    {
        static readonly HttpClient client = new HttpClient();
        public async Task<Coordinate[]> Parse(string kmlUrl)
        {
            string kmlBody = "";
            try
            {
                HttpResponseMessage response = await client.GetAsync(kmlUrl);
                response.EnsureSuccessStatusCode();
                kmlBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(kmlBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
            
            kmlBody = kmlBody.Replace(" ", "");
            kmlBody = kmlBody.Split(new string[] { "<coordinates>" }, StringSplitOptions.None)[1];
            kmlBody = kmlBody.Split(new string[] { "</coordinates>" }, StringSplitOptions.None)[0];
            string[] fullstringCoordinates = kmlBody.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );
            
            int amountOfCoordinates = fullstringCoordinates.Length;
            Coordinate[] coordinates = new Coordinate[amountOfCoordinates - 2];
            
            for (var i = 1; i < (fullstringCoordinates.Length - 1); i++)
            {
                string coordinate = fullstringCoordinates[i];
                string[] _coordinate = coordinate.Split(",");

                // Set temporary coordinates to output array
                coordinates[i - 1] = new Coordinate
                {
                    Lat = double.Parse(_coordinate[1]),
                    Lng = double.Parse(_coordinate[0])
                };
            }
            return coordinates;
        }
    }
}
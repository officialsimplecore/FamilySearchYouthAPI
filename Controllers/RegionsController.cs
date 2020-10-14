using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FamilySearchYouthAPI.Data;
using FamilySearchYouthAPI.Models;
using FamilySearchYouthAPI.Services;
using KmlToGeoJson;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FamilySearchYouthAPI.Controllers
{

    public class RegionInputDto
    {
        public string Name { get; set; }
        public string KmlUrl { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly YearToRange _yearRangeParse;
        public RegionsController(DataContext context, YearToRange yearRangeParse)
        {
            _context = context;
            _yearRangeParse = yearRangeParse;
        }
        
        // Returns all regions without regional information
        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await _context.Regions
                .Include(c => c.Coordinates)
                .ToListAsync();
            return Ok(regions);
        }
        
        [HttpGet("list")]
        public async Task<IActionResult> ListAllRegions()
        {
            var regions = await _context.Regions
                .ToListAsync();
            return Ok(regions);
        }
        
        // Return regional information from a regionId and timePeriod argument
            // Time period is an input as a date range and must be parsed into an ID
        [HttpGet("{regionId}/{year}")]
        public async Task<IActionResult> GetRegion(int regionId, int year)
        {
            var period = await _context.Periods.ToArrayAsync();
            int periodId = _yearRangeParse.parseYear(year, period);
            
            var region = await _context.RegionalInformation
                .Include(c => c.Food)
                .Include(c => c.Weather)
                .Include(c => c.Sports)
                .Include(c => c.Economy)
                .Include(c => c.Geography)
                .Include(c => c.Government)
                .Include(c => c.Migrations)
                .Include(c => c.Military)
                .Include(c => c.Money).Include(c => c.Weather)
                .Include(c => c.Music)
                .Include(c => c.Occupations)
                .Include(c => c.Religion)
                .Include(c => c.Pioneers)
                .Include(c => c.Technology)
                .Include(c => c.Temples)
                .Include(c => c.Wildlife)
                .Include(c => c.Wars)
                .Include(c => c.HistoricalEvents)
                .Include(c => c.FamousPeople)







                
                .Where(information => information.RegionId == regionId)
                .FirstOrDefaultAsync(c => c.PeriodId == periodId);
            return Ok(region);
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(RegionInputDto regionInput)
        {
            CoordinateParser coordinateParser = new CoordinateParser();
            Coordinate[] parsedCoordinates = await coordinateParser.Parse(regionInput.KmlUrl);
            
            Region region = new Region
            {
                Name = regionInput.Name
            };
            _context.Add(region);
            await _context.SaveChangesAsync();

            foreach (Coordinate coordinate in parsedCoordinates)
            {
                Coordinate coordinateTransition = new Coordinate
                {
                    Lat = coordinate.Lat,
                    Lng = coordinate.Lng,
                    RegionId = region.Id,
                };
                _context.Add(coordinateTransition);
                await _context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpPost("/regionalinformation")]
        public async Task<IActionResult> AddRegionalInformation(RegionalInformation regionalInformation)
        {
            _context.Add(regionalInformation);
            return Ok();
        }
    }
}

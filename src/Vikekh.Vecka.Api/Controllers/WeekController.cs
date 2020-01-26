using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace Vikekh.Vecka.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeekController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            var week = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return new WeekTranslator(week).ToString();
        }
    }
}

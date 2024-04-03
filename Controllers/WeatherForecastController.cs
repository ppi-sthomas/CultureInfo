using System.Globalization;
using System.Text;

using Microsoft.AspNetCore.Mvc;

namespace CT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] CultureCodes = new string[]
            {
            "en-US",
            "en-GB",
            "fr-FR",
            "es-ES",
            "de-DE",
            "it-IT",
            "ja-JP",
            "ko-KR",
            "pt-BR",
            "ru-RU",
            "zh-CN",
            "nl-NL",
            "pl-PL",
            "tr-TR",
            "ar-SA",
            "hi-IN",
            "id-ID",
            "ms-MY",
            "fil-PH",
            "vi-VN",
            "th-TH",
            "sv-SE",
            "da-DK",
            "fi-FI",
            "nb-NO",
            "el-GR",
            "hu-HU",
            "cs-CZ",
            "sk-SK",
            "ro-RO",
            "bg-BG",
            "hr-HR",
            "sl-SI",
            "lt-LT",
            "lv-LV",
            "et-EE",
            "uk-UA",
            "be-BY",
            "sr-RS",
            "bs-BA",
            "mk-MK",
            "sq-AL",
            "af-ZA",
            "zu-ZA",
            "xh-ZA",
            "sw-KE",
            "rw-RW",
            "am-ET",
            "ar-EG",
            "fa-IR",
            "he-IL",
            "ur-PK",
            "ps-AF",
            "ky-KG",
            "kk-KZ",
            "uz-UZ",
            "az-AZ",
            "ka-GE",
            "hy-AM",
            "eu-ES",
            "ca-ES",
            "gl-ES",
            "bn-BD",
            "si-LK",
            "ta-IN",
            "te-IN",
            "kn-IN",
            "ml-IN",
            "gu-IN",
            "pa-IN",
            "or-IN",
            "mr-IN",
            "ne-NP",
            "my-MM",
            "lo-LA",
            "km-KH",
            "bo-CN",
            "dz-BT",
            "ug-CN",
            "mn-MN",
            "tl-PH",
            "jv-ID",
            "su-ID",
            "lb-LU",
            "fy-NL",
            "br-FR",
            "co-FR",
            "oc-FR",
            "rm-CH",
            "gsw-CH",
            "cy-GB",
            "gd-GB",
            "ga-IE",
            "gv-IM",
            "kw-GB",
            "sco-GB",
            "mi-NZ",
            "to-TO",
            "sm-WS",
            "w-US"
            };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> Get()
        {
            var currentLanguageTag = CultureInfo.CurrentCulture.IetfLanguageTag;
            return $"Current Date: {DateTime.Now}\n" +
                $"Twelve FortyNine and a half: {12.495}\n" +
                $"Twelve FortyNine and a halfC: {12.495:c}\n";
            

        }
    }
}

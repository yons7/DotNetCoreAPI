using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DotNetCoreAPI.Controllers
{
    [ApiController]
    [Route("commercial-operations")]
    public class WeatherForecastController : ControllerBase
    {
        private static int testCase;

        /// <summary>
        /// Creates the commercial operation asynchronous.
        /// </summary>
        /// <param name="commercialOperationCreateRequest"></param>
        /// <returns>CommercialOperation</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCommercialOperationAsync([FromBody] CommercialOperationCreateRequest commercialOperationCreateRequest)
        {
            int id = 123456;

            if (testCase == 0)
            {
                testCase++;
                return CreatedAtAction("GetCommercialOperation", new { commercialOperationId = id }, id);
            }

            if (testCase == 1)
            {
                testCase++;
                return StatusCode(StatusCodes.Status400BadRequest, $"\"\\\"Validation error code: 4001, Active period date (startdate and enddate) is not valid.\\\"\"");
            }

            if (testCase == 2)
            {
                testCase++;
                return StatusCode(StatusCodes.Status500InternalServerError, $"<h1>Internal server error</h1><p>The circuit is now open and is not allowing calls.</p>");
            }

            if (testCase == 3)
            {
                testCase++;
                return StatusCode(StatusCodes.Status504GatewayTimeout, $"<html><head><title>504 Gateway Time-out</title></head><body><center>" +
                    $"<h1>504 Gateway Time-out</h1></center><hr><center>nginx/1.19.1</center></body></html>");
            }

            if (testCase == 4)
            {
                testCase++;
                return StatusCode(StatusCodes.Status201Created);
            }

            if (testCase == 5)
            {
                testCase++;
                return StatusCode(StatusCodes.Status401Unauthorized);
            }

            testCase = 0;

            await Task.Delay(TimeSpan.FromSeconds(60));
            return CreatedAtAction("GetCommercialOperation", new { commercialOperationId = id }, id);
        }

        /// <summary>
        /// Gets the commercial operation asynchronous.
        /// </summary>
        /// <param name="commercialOperationId">The commercial operation identifier.</param>
        /// <returns>
        /// CommercialOperation
        /// </returns>
        [HttpGet("{commercialOperationId}", Name = "GetCommercialOperation")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<CommercialOperation> GetCommercialOperationAsync([FromRoute] string commercialOperationId)
        {
            await Task.Yield();
            return new CommercialOperation {
                Id = int.Parse(commercialOperationId)
            };
        }
    }
}

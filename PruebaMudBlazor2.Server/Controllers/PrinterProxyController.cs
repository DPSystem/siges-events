using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using PruebaMudBlazor2.Shared.Models; // Added

namespace PruebaMudBlazor2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrinterProxyController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PrinterProxyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // Proxy endpoint for printer services
        [HttpGet("printers/{targetIp}")]
        public async Task<ActionResult<string>> GetPrinters(string targetIp)
        {
            try
            {
                // Validate targetIp to prevent SSRF or other attacks
                // This is a basic example; more robust validation might be needed depending on your environment
                if (!System.Net.IPAddress.TryParse(targetIp, out _))
                {
                    return BadRequest("Invalid IP address format.");
                }

                // Create HttpClient using the factory
                var httpClient = _httpClientFactory.CreateClient();

                // Build the target URL for the printer server
                string printerServiceUrl = $"http://{targetIp}:8080/ticket/printers";

                // Make the request from the server
                var response = await httpClient.GetAsync(printerServiceUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    // Relay the content back to the client
                    return Ok(content);
                }
                else
                {
                    // Relay error status and content
                    return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
                }
            }
            catch (HttpRequestException ex)
            {
                // Log the exception
                Console.WriteLine($"Error proxying printer request: {ex.Message}");
                return StatusCode(500, $"Error connecting to printer service: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Log other exceptions
                Console.WriteLine($"Unexpected error in PrinterProxyController: {ex.Message}");
                return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
            }
        }

        // New Proxy endpoint for generating tickets
        [HttpPost("generateTicket/{targetIp}")]
        public async Task<ActionResult> GenerateTicket(string targetIp, [FromBody] Reserva reserva) // Use shared Reserva class
        {
            try
            {
                if (!System.Net.IPAddress.TryParse(targetIp, out _))
                {
                    return BadRequest("Invalid IP address format.");
                }

                var httpClient = _httpClientFactory.CreateClient();
                string printerServiceUrl = $"http://{targetIp}:8080/ticket/generar"; // Printer service endpoint for generating tickets

                // Forward the request to the printer service
                var response = await httpClient.PostAsJsonAsync(printerServiceUrl, reserva);

                if (response.IsSuccessStatusCode)
                {
                    // Return the response from the printer service
                    return Ok(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error proxying ticket generation request: {ex.Message}");
                return StatusCode(500, $"Error connecting to printer service for ticket generation: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GenerateTicket proxy: {ex.Message}");
                return StatusCode(500, $"An unexpected error occurred during ticket generation: {ex.Message}");
            }
        }
    }
}

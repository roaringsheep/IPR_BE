using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace IPR_BE.Controllers;

[ApiController]
[Route("[controller]")]
public class IMochaController : ControllerBase {
    private readonly IConfiguration configuration;
    private HttpClient http;
    public IMochaController(IConfiguration iConfig) {
        configuration = iConfig;
        http = new HttpClient();
        http.DefaultRequestHeaders.Add("X-API-KEY", configuration.GetValue<string>("IMocha:ApiKey"));
        http.BaseAddress = new Uri("https://apiv3.imocha.io/v3/");
    }
    [HttpGet]
    public async Task GetAllTests() {
        string str = await http.GetStringAsync("tests");
        Console.WriteLine(str);
    }
}
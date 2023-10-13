using Microsoft.AspNetCore.Mvc;
using OpenAI.Managers;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;
using System.Diagnostics;
using YetgenAkbankJump.MVCClient.Models;
using OpenAI.Interfaces;

namespace YetgenAkbankJump.MVCClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOpenAIService _openAiService;

        public HomeController(ILogger<HomeController> logger, IOpenAIService openAiService)
        {
            _logger = logger;
            _openAiService = openAiService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(HomeIndexViewModel viewModel)
        {
            //var imageResult = await _openAiService.Image.CreateImage(new ImageCreateRequest
            //{
            //    Prompt = viewModel.Prompt,
            //    N = viewModel.ImageCount,
            //    Size = StaticValues.ImageStatics.Size.Size512,
            //    ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url,
            //    User = "KalayMaster"
            //});


            //if (imageResult.Successful)
            //{
            //    viewModel.ImageUrls = imageResult.Results.Select(r => r.Url).ToList();
            //}

            var completionResult = await _openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage>
                {
                    ChatMessage.FromSystem("You are a helpful assistant."),
                    ChatMessage.FromUser("Who won the world series in 2020?"),
                    ChatMessage.FromAssistant("The Los Angeles Dodgers won the World Series in 2020."),
                    ChatMessage.FromUser("Where was it played?")
                },
                Model = OpenAI.ObjectModels.Models.Gpt_3_5_Turbo,
                MaxTokens = 50//optional
            });
            if (completionResult.Successful)
            {
                viewModel.ChatGPTResponse = completionResult.Choices.First().Message.Content;
            }

            return View(viewModel);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
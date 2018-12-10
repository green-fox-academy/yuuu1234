using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using Frontend.Services;

namespace Frontend.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IFrontendService _frontendService;
        private readonly ILogService _logService;
        private readonly ApplicationContext applicationContext;
        public HomeController(IFrontendService frontendService, ILogService logService, ApplicationContext applicationContext)
        {
            this._frontendService = frontendService;
            this._logService = logService;
            this.applicationContext = applicationContext;
        }
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]

        public ActionResult<Doubling> Double(double input)
        {
            if (string.IsNullOrWhiteSpace(input + ""))
            {
                var result = new Doubling() { Error = "Please provide an input!" };
                Log log = new Log()
                {
                    CreatedAt = DateTime.Now,
                    Data = $"received: {result.Received} " + $"result: {result.Error}",
                    Endpoint = "/doubling"
                };
                _logService.Add(log);
                return result;
            }
            else
            {
                var result = new Doubling() { Received = (double)input, Result = (double)input * 2 };
                Log log = new Log()
                {
                    CreatedAt = DateTime.Now,
                    Data = $"received: {result.Received} "
                           + $"result: {result.Result}",
                    Endpoint = "/doubling"
                };
                _logService.Add(log);
                return result;
            }


        }

        [HttpGet("/greeter")]
        public ActionResult<Greeting> Greet(string name, string title)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                var result = new Greeting() { Error = "Please provide a name!" };
                Log log = new Log()
                {
                    CreatedAt = DateTime.Now,
                    Data = $"Name: {result.Name} "
                           + $"Title: {result.Title}+ {result.Error}",
                    Endpoint = "/greeter"
                };
                _logService.Add(log);
                return result;
            }
            else
            {
                var result = new Greeting() { Welcome_Message = $"Oh, hi there {name}, my dear {title}!" }; ;
                Log log = new Log()
                {
                    CreatedAt = DateTime.Now,
                    Data = $"Name: {result.Name} "
                           + $"Title: {result.Title}+ {result.Welcome_Message}",
                    Endpoint = "/greeter"
                };
                _logService.Add(log);
                return result;
            }

        }

        [HttpGet("/appenda/{appendable}")]

        public ActionResult<Appending> Appenda(string appendable)
        {
            if (string.IsNullOrWhiteSpace(appendable))
            {
                var result = BadRequest(404);
                Log log = new Log() { CreatedAt = DateTime.Now, Data = result.ToString(), Endpoint = "/appenda/{appendable}" };
                return result;
            }
            else
            {
                var result = new Appending() { Appenda = appendable };
                Log log = new Log() { CreatedAt = DateTime.Now, Data = $"Appenda: {result.Appenda}", Endpoint = "/appenda/{appendable}" };

                return result;
            }
        }

        [HttpPost("/dountil/{doAction}")]
        public ActionResult<Until> Untill([FromBody]Until doAction)
        {
            Until result;
            if (doAction.Action.ToLower() == "sum")
            {
                result = new Until() { UntilNumber = doAction.UntilNumber, Result = _frontendService.UntilSum(doAction.UntilNumber) };

            }
            else if (doAction.Action.ToLower() == "factor")
            {
                result = new Until() { UntilNumber = doAction.UntilNumber, Result = _frontendService.UntilSum(doAction.UntilNumber) };

            }
            else if (string.IsNullOrWhiteSpace(doAction.Action))
            {
                return new Until() { Error = "Please provide a number" };
            }
            else
            {
                return new Until() { Error = "such action is not supported" };
            }
            Log log = new Log()
            {
                CreatedAt = DateTime.Now,
                Data = $"action: {result.Action}" +
                       $" until number: {result.UntilNumber} +" +
                       $"result: {result.Result}+ error: {result.Error}",
                Endpoint = "/dountil/{doAction}"
            };
            _logService.Add(log);
            return result;
        }

        [HttpPost("/arrays")]
        public ActionResult<ArrayHandler> ArrayHandler([FromBody]ArrayHandler input)
        {
            ArrayHandler result;
            if (input.What.ToLower() == "sum")
            {
                input.Result = _frontendService.ArraySum(input.Numbers).ToString();
            }
            else if (input.What.ToLower() == "multiply")
            {
                input.Result = _frontendService.ArrayMultiply(input.Numbers).ToString();

            }
            else if (input.What.ToLower() == "double")
            {
                input.Result = _frontendService.ArrayDouble(input.Numbers).ToString();

            }
            else
            {
                input.Error = "Please provide what to do with the numbers!";

            }

            Log log = new Log()
            {
                CreatedAt = DateTime.Now,
                Data = $"what: {input.What} " +
                                                               $"numbers: {input.Numbers} result: " +
                                                               $"{input.Result} error: {input.Error}",
                Endpoint = "/arrays"
            };
            _logService.Add(log);
            return input;

        }

        [HttpGet("/log")]
        public ActionResult<LogEntry> Log(long? count, long? page)
        {
            List<Log> logs = new List<Log>();
            foreach (var log in applicationContext.Logs)
            {
                logs.Add(log);
            }
            return new LogEntry() { Entries = logs, Entry_count = _logService.logEntriesCount() };
        }

        [HttpPost("/sith")]
        public ActionResult<Sith> ReverseSith([FromBody]Sith sith)
        {
            if (sith == null)
            {
                sith.Error = "Please provide a text";
                Log log = new Log()
                {
                    CreatedAt = DateTime.Now,
                    Data = $"error: {sith.Error}",
                    Endpoint = "/sith",
                };
                _logService.Add(log);
            }
            else
            {
                string original = sith.Text;
                _frontendService.ReverseSith(sith);
                Log log = new Log()
                {
                    CreatedAt = DateTime.Now,
                    Data = $"original text: {original} sith: {sith.Text}",
                    Endpoint = "/sith",
                };
                _logService.Add(log);
            }

            return sith;
        }

        [HttpPost("/translate")]
        public ActionResult<Translation> Translation(Translation translation)
        {
            _frontendService.HungarianCamelIzerService(translation);
            return translation;
        }



    }


}
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using SampleExtension;

namespace SampleFunctionApp
{
    public static class HttpTriggerSlack
    {
        [FunctionName("HttpTriggerSlack")]
        public static string Run(
            [HttpTrigger] SlackMessage message, 
            [Slack(WebHookUrl = "SlackWebHook")] out SlackMessage slackMessage,
            TraceWriter log)
        {
            slackMessage = message;

            return "Ok";
        }
    }
}
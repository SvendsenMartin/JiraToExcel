using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using RestSharp;

namespace JiraExtractor
{
    class Program
    {
        static int Main(string[] args)
        {
            if (!ValidateArgs(args))
                return 1;

            var username = args[0];
            var password = args[1];

            var client = new TechTalk.JiraRestClient.JiraClient<DrJiraIssueField>("https://jiradrdk.atlassian.net", username, password);
            
            var issues = client.GetIssues("DDC");

            //issues.First().fields.assignee

            //var client = new JiraRestClient.JiraRestClient("https://jiradrdk.atlassian.net", "xpps_test_user", "HejMedDig123");
            //var issue = client.GetIssue("1234");

            Console.WriteLine(".");
            
            return 0;
        }

        private static bool ValidateArgs(string[] args)
        {
            return args.Count() == 2;
        }
    }
}

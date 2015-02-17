using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace JiraExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://jiradrdk.atlassian.net");
            client.Authenticator = new HttpBasicAuthenticator("xpps_test_user","HejMedDig123");
            



            var request = new RestRequest("/rest/api/2/search?jql=assignee=xpps", Method.GET);

            //var response = client.Execute(request);

            var response = client.Execute<RestSharp.Deserializers.JsonDeserializer>(request);

            

            //var issues = response.Data.Deserialize<JiraResult>(response);
            //response

            var content = response.Content;

            Console.WriteLine(".");
        }
    }
}

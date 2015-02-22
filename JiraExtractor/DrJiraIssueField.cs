using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace JiraExtractor
{
    [JsonObject]
    public class DrJiraIssueField : TechTalk.JiraRestClient.IssueFields
    {
        /// <summary>
        /// Epic Link
        /// </summary>
        public string customfield_10008 { get; set; }
    }
}

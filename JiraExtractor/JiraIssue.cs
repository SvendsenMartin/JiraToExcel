using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace JiraExtractor
{
    class JiraIssues
    {
        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        [DeserializeAs(Name = "assignee")]
        public asssignee Assignee { get; set; }

        [DeserializeAs(Name = "customfield_10008")]
        public string EpicLink { get; set; } // epic link?

    }

    class JiraResult
    {
        public int startAt { get; set; }
        public int total { get; set; }

        [DeserializeAs(Name = "issues")]
        public JiraIssues Issues { get; set; }
    }

    class asssignee
    {
        public string name;
        public string displayname;
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Demofolio.Models
{
    public class GitHubAPI
    {
        public int Id { get; set; }
        public string RepoName { get; set; }
        public string RepoUrl { get; set; }

        public static List<GitHubAPI> GetRepos()
        {
            var request = new RestRequest("https://api.github.com/users/jaybojaybojaybo/starred", Method.GET);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(request) as RestResponse;
            }).Wait();
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var repoList = JsonConvert.DeserializeObject<List<GitHubAPI>>(jsonResponse["messages"].ToString());
            return repoList;

        }

        public static Task<IRestResponse> GetResponseContentAsync(RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            return tcs.Task;
        }
    }
}

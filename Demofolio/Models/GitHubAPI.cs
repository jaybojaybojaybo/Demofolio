using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RestSharp;
using RestSharp.Authenticators;

namespace Demofolio.Models
{
    public class GitHubAPI
    {
        public int Id { get; set; }
        public string RepoName { get; set; }
        public string RepoUrl { get; set; }
    }

    var request = new RestRequest("https://api.github.com/users/jaybojaybojaybo/starred.json", Method.GET);

    var response = new RestResponse();

    Task.Run(async =>
		{
			response = await GetResponseContentAsync(request) as RestResponse;
		}).Wait();

	public static Task<IRestResponse> GetResponseContentAsync(RestRequest theRequest)
	{
		var tcs = new TaskCompletionSource<IRestResponse>();
		theClient.ExecuteAsync(theRequest, response => {
			tcs.SetResult(response);
		});
		return tcs.Task;
	}
}

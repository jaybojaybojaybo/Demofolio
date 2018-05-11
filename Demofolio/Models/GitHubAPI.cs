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
    public class Comment
    {
        public int Id { get; set; }
		public string RepoName { get; set; }
		public string RepoUrl { get; set; }
    }
}

﻿using Octokit;
using System.Collections.Generic;

namespace AuthorizeWithGithub.Models
{
    public class GithubModel
    {
        public string GitHubAvatar { get; set; }

        public string GitHubLogin { get; set; }

        public string GitHubName { get; set; }

        public string GitHubUrl { get; set; }

        public IReadOnlyList<Repository> Repositories { get; set; }
    }
}

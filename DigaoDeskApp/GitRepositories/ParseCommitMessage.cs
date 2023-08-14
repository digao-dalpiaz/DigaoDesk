using LibGit2Sharp;
using System;
using System.Collections.Generic;

namespace DigaoDeskApp
{
    public class ParseCommitMessage
    {

        private class Token
        {
            public string Name;
            public Func<string> Function;
        }

        private List<Token> _tokens;        

        private Repository _repository;

        public ParseCommitMessage(Repository repository)
        {
            this._repository = repository;

            _tokens = new()
            {
                new Token { Name = "branch", Function = GetBranch }
            };
        }

        private string GetBranch()
        {
            var branchName = _repository.Head.FriendlyName;
            var x = branchName.LastIndexOf("/");
            if (x > -1) branchName = branchName.Substring(x + 1);

            return branchName;
        }

        public string GetMessage()
        {
            string message = Vars.Config.Repos.GitCommitMessage;
            if (message == null) return string.Empty;

            foreach (var token in _tokens)
            {
                string tokenName = $"[{token.Name}]";
                if (message.Contains(tokenName))
                {
                    message = message.Replace(tokenName, token.Function());
                }
            }

            return message;
        }

    }
}

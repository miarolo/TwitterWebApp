using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToTwitter;
using TWA.Models;

namespace TWA.Interfaces.Services
{
    public interface ITwitterService
    {
        #region Functions

        Task<List<TweetViewModel>> GetTweets();

        #endregion


        #region Context & authentication

        TwitterContext GetContext();

        SingleUserAuthorizer GetAuth();

        #endregion

    }
}

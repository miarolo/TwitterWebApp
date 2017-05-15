using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using LinqToTwitter;
using TWA.Interfaces.Services;
using TWA.Models;


namespace TWA.Business.Services
{
	public class TwitterService : ITwitterService
	{
		public async Task<List<TweetViewModel>> GetTweets()
		{
			var twittercontext = GetContext();

			var searchResponse =
				await
                (from tweet in twittercontext.Status
				 where tweet.Type == StatusType.User &&
					   tweet.ScreenName == "mischarouleaux"
				 select tweet)
				.ToListAsync();
            
			//var searchResponse = await (from search in twittercontext.Search
										//where search.Type == SearchType.Search && search.Query == "\"@Linq2Twitr\""
            //select search).SingleOrDefaultAsync();
            List<TweetViewModel> tweets = (from tweet in searchResponse
										   select new TweetViewModel
										   {
											   ImageUrl = tweet.User.ProfileImageUrl,
											   ScreenName = tweet.User.ScreenNameResponse,
											   Text = tweet.Text
										   })
								   .ToList();

			return tweets;

		}



		public TwitterContext GetContext()
		{
			var auth = GetAuth();

			var twittercontext = new TwitterContext(auth);

			return twittercontext;
		}

		public SingleUserAuthorizer GetAuth()
		{
			var auth = new SingleUserAuthorizer
			{
				CredentialStore = new SingleUserInMemoryCredentialStore
				{
					ConsumerKey = "9p8L0q1nnikQmmdA4YeOU0eQv",
					ConsumerSecret = "dpe085MznGpxefPq24RNC4s2lxcWGzqXeLcmpazvzKmHOb1goC",
					AccessToken = "180772099-M32tIuvzY7CbslJZ4EPdnohS9uawRKhaHYElHC5z",
					AccessTokenSecret = "1SPANUaVxORBbqahrldbbPFFLH7Mscr0ADMujakB75Trq"
				}
			};

			return auth;
		}



					
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;

namespace RedditProject.Interfaces
{
    public interface IPostService
    {
        void UpdateVote(long id, string symbol);
        void AddNewPost(Post post);
        List<Post> RankPosts(List<Post> postsList);

    }
}

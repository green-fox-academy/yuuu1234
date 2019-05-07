using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;

namespace RedditProject.Interfaces
{
    public interface IPostService
    {
        Task UpdateVoteAsync(long id, string symbol);
        Task AddNewPostAsync(Post post);
        Task<IEnumerable<Post>> GetAllPostsAsync();
        List<Post> RankPosts(List<Post> postsList);

    }
}

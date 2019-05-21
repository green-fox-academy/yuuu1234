using System;
using System.Collections.Generic;
using System.Linq;
using BlogApp.Models;
using BlogApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationContext applicationContext;
        private readonly IBlogPostRepository blogPostRepository;

        public BlogService(ApplicationContext applicationContext, IBlogPostRepository blogPostRepository)
        {
            this.applicationContext = applicationContext;
            this.blogPostRepository = blogPostRepository;
        }

        public List<BlogPost> GetAll()
        {
            // Raw SQL
            // applicationContext.BlogPosts.FromSql("SELECT * FROM BlogPosts");

            // return applicationContext.BlogPosts.Include(p => p.Category).ToList();
            return blogPostRepository.FindAll();
        }

        public void Create(BlogPost blogPost)
        {
            applicationContext.BlogPosts.Add(blogPost);

            applicationContext.SaveChanges();
        }

        public void Update(BlogPost blogPost)
        {
            var postFromDb = applicationContext.BlogPosts.Find(blogPost.BlogPostId);

            if (postFromDb == null)
            {
                throw new ArgumentException(nameof(blogPost));
            }

            postFromDb.Title = blogPost.Title;
            postFromDb.Content = blogPost.Content;
            postFromDb.CId = blogPost.CId;

            applicationContext.SaveChanges();
        }

        public BlogPost FindById(long blogPostId)
        {
            return applicationContext.BlogPosts.Find(blogPostId);
        }

        public void Delete(BlogPost blogPost)
        {
            applicationContext.Remove(blogPost);
            applicationContext.SaveChanges();
        }
    }
}
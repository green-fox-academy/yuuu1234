from blogPost import BlogPost


class blog():
    def __init__(self, blogPost: BlogPost, blogPosts=[]):
        self.blogPost = blogPost
        self.blogPosts = blogPosts

    def add_blog(self, blogPost: BlogPost):
        self.blogPosts.append(blogPost)

    def delete_post(self, index: int):
        self.blogPosts.pop(index)

    def update_post(self, index: int, blogPost: BlogPost):
        self.blogPosts[index] = blogPost

using System;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var Post = new Post();
            Console.WriteLine("Would you like to write a post y or n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Post.postCreated = DateTime.Now;
                System.Console.WriteLine("What is the description of your post");
                Post.discription = Console.ReadLine();
                System.Console.WriteLine("Write your post");
                Post.body = Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("You did not write a post");
            }

            System.Console.WriteLine("Do you want to like, dislike to the or neither l, d, or n");
            string like = Console.ReadLine();
            if (like == "l")
            {
                Post.likes += 1;
            }
            else if (like == "d")
            {
                Post.dislikes += 1;
            }
            else
            {
                System.Console.WriteLine("You did not like or dislike the post");
            }
            System.Console.WriteLine("{0}, {1}, likes = {2}, dislikes = {3}, Post create at {4}", Post.discription, Post.body, Post.likes, Post.dislikes, Post.postCreated );
        }
    }
}

using System;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to write a post y or n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                var Post = new Post();
                System.Console.WriteLine("Write your post");
                Post.body = Console.ReadLine();
            }

            System.Console.WriteLine("Do you want to like, dislike to the or neither l, d, or n");
            string like = Console.ReadLine();
            if (like == "l")
            {

            }
            else if (like == "d")
            {

            }
            else
            {

            }
        }
    }
}

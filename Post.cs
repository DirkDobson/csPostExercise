using System;

namespace StackOverFlowPost
{
  public class Post
  {
    public DateTime  postCreated = DateTime.Now;

    public string discription = "";
    public string body = ""; 
    public byte likes = 0;
    public byte dislikes = 0;
  }
}
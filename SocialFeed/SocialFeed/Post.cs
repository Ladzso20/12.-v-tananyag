using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public abstract class Post : IReportable
    {
        private string _author;

        private int _likes;

        private int _reports;
        private List<Comment> _comments;

        public string Author { get { return _author; } set { _author = value; } }

        public int Likes { get { return _likes; } }


        public List<Comment> Comments { get { return _comments; } }
        public Post(string author)
        {
            Author = author;
            _likes = 0;
            _comments = new List<Comment>();

        }




        public virtual bool Like()
        {
            _likes++;
            return true;
        }

        public virtual string GetDescription()
        {
            return $"{Author}, {Like} kedveles" + $"{(_comments.Count > 0 ? $", {_comments.Count} hozzászolás" : "")}" ;
        }
        public abstract int Score();

        public void Report()
        {
            _reports++;
        }

        public int ReportCount()
        {
            return _reports;
        }


        public Comment AddComent(string author, string text)
        {
            Comment comment = new Comment(author, text, this);
            _comments.Add(comment);
            return comment;
        }
    }
}

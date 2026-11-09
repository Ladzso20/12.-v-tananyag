using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class TextPost : Post
    {
        private string _text;

        public string Text { get { return _text; } set { _text = value; } }

        public TextPost(string author, string text) : base(author)
        {
            Text = text;
        }

        public override int Score()
        {
            return Likes;
        }

        public override string GetDescription()
        {
            string descString = Text;
            if (Text.Length > 20)
            {
                descString = Text.Substring(0, 20);
            }
            return base.GetDescription() + $": {descString}...";
        }
    }
}

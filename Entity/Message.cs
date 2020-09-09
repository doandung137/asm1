using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1.Entity
{
    public class Message
    {
        private string email;
        private string title;
        private string content;

        public Message(string email, string title, string content)
        {
            Email = email;
            Title = title;
            Content = content;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public string toString()
        {
            if (Content.Length > 40)
            {
                string Str1 = Content.Substring(0, 40);
                return "Send to " + Email + "\n" + "Title : " + Title + "\n" + Str1 + "...";
            }
            else
            {

                return "-------------------------- \n" + "Send to " + Email + "\n" + "Title : " + Title + "\n" + "Content : " + Content;
            }

        }
    }
}

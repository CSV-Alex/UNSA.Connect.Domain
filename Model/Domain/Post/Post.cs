
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Post{
    public class Post {

        public Post() {
        }

        public int Id;

        public string Title;

        public string Content;

        public DateTime CreatedAt;

        public User Author;



        internal HashSet<Comment> Comments;






        public void Post() {
            // TODO implement here
        }

    }
}
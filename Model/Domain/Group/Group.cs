
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Group{
    public class Group {

        public Group() {
        }

        public int Id;

        public string Name;

        public string Description;

        public ICollection Members;

        public ICollection Posts;

        public User a;

        public HashSet<User> viewers;

        public User admin;

        public HashSet<User> members;

        public HashSet<User> viewers;

        public User admin;

        public HashSet<User> members;

        public HashSet<User> members;

        public User admin;




        public void Group() {
            // TODO implement here
        }

    }
}
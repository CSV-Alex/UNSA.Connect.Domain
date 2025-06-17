
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.User{
    public class User {

        public User() {
        }

        public int Id;

        public string Name;

        public string Email;

        public ICollection Groups;

        public ICollection Notifications;








        public HashSet<Group> admin;

        public HashSet<Group> groups;


        public HashSet<Group> groups;

        public HashSet<Group> groups;



        public HashSet<Group> viewer;

        public HashSet<Group> admin;

        public HashSet<Group> member;

        internal HashSet<Group> member;

        public HashSet<Group> groups;

        public void User() {
            // TODO implement here
        }

    }
}
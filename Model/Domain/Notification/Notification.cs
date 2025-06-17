
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Notification{
    public class Notification {

        public Notification() {
        }

        public int Id;

        public string Message;

        public bool IsRead;

        public DateTime CreatedAt;

        public User Recipient;






        public void Notification() {
            // TODO implement here
        }

    }
}
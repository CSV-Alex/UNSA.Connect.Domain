
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Notification{
    public interface INotificationRepository {


        /// <summary>
        /// @param Notification notification
        /// </summary>
        void Delete(void Notification notification);

        /// <summary>
        /// @param Notification notification 
        /// @param int IdPost
        /// </summary>
        void MovePost(void Notification notification, void int IdPost);

        /// <summary>
        /// @param Notification notification 
        /// @param int IdPost
        /// </summary>
        void MoveComment(void Notification notification, void int IdPost);

    }
}
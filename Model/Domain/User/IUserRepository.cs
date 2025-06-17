
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.User{
    public interface IUserRepository {


        /// <summary>
        /// @param User user
        /// </summary>
        void Add(void User user);

        /// <summary>
        /// @param User user
        /// </summary>
        void Delete(void User user);

        /// <summary>
        /// @param User user
        /// </summary>
        void Modify(void User user);

    }
}
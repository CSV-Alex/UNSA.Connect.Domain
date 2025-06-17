
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Post{
    public interface ICommentRespository {


        /// <summary>
        /// @param Comment comment
        /// </summary>
        void Add(void Comment comment);

        /// <summary>
        /// @param Comment comment
        /// </summary>
        void Delete(void Comment comment);

        /// <summary>
        /// @param Comment comment
        /// </summary>
        void Modify(void Comment comment);

        /// <summary>
        /// @param Comment comment
        /// </summary>
        void Rate(void Comment comment);

        /// <summary>
        /// @param Comment comment
        /// </summary>
        void Reply(void Comment comment);

        /// <summary>
        /// @param Comment comment
        /// </summary>
        void Share(void Comment comment);

    }
}
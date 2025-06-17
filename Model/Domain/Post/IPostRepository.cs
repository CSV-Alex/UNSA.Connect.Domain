
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Post{
    public interface IPostRepository {


        /// <summary>
        /// @param Post post
        /// </summary>
        void Add(void Post post);

        /// <summary>
        /// @param Post post
        /// </summary>
        void Delete(void Post post);

        /// <summary>
        /// @param Post post
        /// </summary>
        void Modify(void Post post);

        /// <summary>
        /// @param int IdPost
        /// </summary>
        void Find(void int IdPost);

        /// <summary>
        /// @param Post post
        /// </summary>
        void Rate(void Post post);

        /// <summary>
        /// @param Post post
        /// </summary>
        void Share(void Post post);

    }
}
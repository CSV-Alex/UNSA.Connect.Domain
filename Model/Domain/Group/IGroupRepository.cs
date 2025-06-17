
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Group{
    public interface IGroupRepository {


        /// <summary>
        /// @param Group group
        /// </summary>
        void Create(void Group group);

        /// <summary>
        /// @param Group group
        /// </summary>
        void Delete(void Group group);

        /// <summary>
        /// @param int IdGroup
        /// </summary>
        void Find(void int IdGroup);

        /// <summary>
        /// @param Group group
        /// </summary>
        void Join(void Group group);

        /// <summary>
        /// @param Group group
        /// </summary>
        void Leave(void Group group);

    }
}
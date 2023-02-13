using System;
using System.Collections.Generic;
using System.Text;

namespace _13._02._2023
{
    internal interface ICourse
    {
        public void AddGroup(Group group);

        public Group GetGroupByNo(string no);

        public Group[] Search(string str);
    }
}

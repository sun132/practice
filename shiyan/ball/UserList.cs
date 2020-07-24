using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ball
{
    class UserList
    {
        private User[] data;
        private int currentIndex;
        public int Count
        {
            get
            {
                return currentIndex;
            }
        }
        public UserList():this(8)
        {
            
        }
        public UserList(int capacity)
        {
            data = new User[capacity];
        }

        public void Add(User value)
        {
            CheckCapacity();
            data[currentIndex++] = value;
        }
        public User GetElement(int index)
        {
            return data[index];
        }

        private void CheckCapacity()
        {
            if (currentIndex>=data.Length)
            {
                User[] newData = new User[data.Length * 2];
                data.CopyTo(newData, 0);
                data = newData;
            }
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyArrayList
{
    public class MyArrayList : ICollection, IEnumerable
    {
        private object[] lstObj;
        private int count;
        private int capacity;
        private const int MAXCOUNT = 100;

        public int Capacity { get => capacity; set => capacity = value; }
        public void CopyTo(Array array, int index)
        {
            this.CopyTo(lstObj, 0);
        }

        public IEnumerator GetEnumerator()
        {
            //return (IEnumerator)GetEnumerator();
        }
        public int Count
        {
            get => count;
            set
            {
                count = value;
                if (count > Capacity)
                {
                    Capacity = (Capacity == 0 ? 4 : Capacity * 2);
                    object[] lstNewOBj = new object[Capacity];

                   
                    this.lstObj = lstNewOBj;
                }
            }
        }
         public bool IsFixedSize
        {
            get { return false; }

        }
        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public object this[int index]
        {
            get
            { // nếu chỉ mục vượt quá phạm vi danh sách thì báo lỗi
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.lstObj[index];
            }
            set
            {
                // nếu danh sách là chỉ đọc thì không cho phép gán giá trị.
                if (IsReadOnly == true)
                {
                    throw new IndexOutOfRangeException();
                }
                this.lstObj[index] = value;
            }
        }
        public int Add(object value)
        {// Nếu danh sách là chỉ đọc hoặc cố định thì không cho thêm.
            if (this.IsReadOnly ==true || this.IsFixedSize == true)
            {
                return -1;
            }
            else
            {
                this.Count++;
                this.lstObj[Count - 1] = value;

                return this.Count - 1;
            }
        }
        public void Clear()
        {
            Count = 0;
        }
        public bool Contains(object value)
        {
            bool IsFound = false;
            for(int i =0; i < Count; i++)
            {
                if (this.lstObj[i].Equals(value))
                {
                    IsFound = true;
                    break;
                }
            }
            return IsFound;

        }
        public int IndexOf(object value)
        {
            int index = -1;
            for(int i =0; i< Count; i++)
            {
                if (this.lstObj[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void Insert(int index , object value)
        {
            if(IsFixedSize == true || IsReadOnly == true)
            {
                throw new NotSupportedException();
            }
            if(index<0|| index >= Count)
            {
                throw new NotSupportedException();
            }
            Count++;
            // Thực hiện dời các phần tử sang phải để dư 1 chỗ cho phần tử cần chèn
            for (int i = Count-1;i> index; i--)
            {
                this.lstObj[i] = this.lstObj[i - 1];
            }
            this.lstObj[index] = value;
        }
        public void RemoveAt(int index)
        {
            if( index >=0 && index < Count)
            {
                for(int i = index; i< Count; i++)
                {
                    this.lstObj[i] = this.lstObj[i + 1];
                }
                Count--;
            }
        }
        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

       
    }
}

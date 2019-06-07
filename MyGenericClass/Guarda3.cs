using System;
using System.Collections.Generic;
using System.Text;

namespace MyGenericClass
{
    class Guarda3<T>
    {
        private T var1;
        private T var2;
        private T var3;

        public Guarda3()
        {
            this.var1 = default(T);
            this.var2 = default(T);
            this.var3 = default(T);
        }

        public T GetItem(int i)
        {
            if (i == 0) return var1;
            if (i == 1) return var2;
            if (i == 2) return var3;
            throw new IndexOutOfRangeException();
        }

        public void SetItem(int i, T item)
        {
            if (i == 0) var1 = item;
            if (i == 1) var2 = item;
            if (i == 2) var3 = item;
            else throw new IndexOutOfRangeException();
        }
    }
}

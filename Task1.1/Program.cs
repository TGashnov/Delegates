using System;

namespace Task1._1
{
    class Class1
    {
        public delegate Class1 GetNewClass1();
        public delegate Class1 TransformClass1(Class1 obj);
        public delegate string GetClass1Description(Class1 obj, string comment);

        public GetNewClass1 generator;
        public TransformClass1 transformer;

        public event GetClass1Description OnDescribe;

        public Class1(GetClass1Description d1, GetClass1Description d2)
        {
            OnDescribe += d1;
            OnDescribe += d2;
        }
    }
}

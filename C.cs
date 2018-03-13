using System;

namespace feature_envy_dotnet
{
    class C
    {
        public int field1;
        public int field2;
        public int field3;
        public void ab(A a, B b ){
            a.a();
            b.a(a);
            b.a(a);
            method();
            method();
            method();
            method();
            method();

            field1 = 1;
            field2 = 2;
            field3 = 3;

            a.field1 = a.field2 + 4;

            b.field1 = b.field2 + 1;
            b.field2 = b.field3 + 1;
            b.field3 = b.field1 + 1;

            String text = "A text";
            text.GetType();
            text.IndexOf("a");
            text.Substring(3);
            text.Split(" ");
            text.Contains(" ");
            text.GetEnumerator();
            text.GetHashCode(0);
            text.GetTypeCode();
            text.Split(" ");
            text.Equals("a");
        }

        public void method() {}
    }
}

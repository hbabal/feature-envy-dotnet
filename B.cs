using System;

namespace feature_envy_dotnet
{
    class B
    {
        public int field1;
        public int field2;
        public int field3;

        public int a(A a) {
            int x = a.field1;
            int y = a.field2;

            a.a();

            String text = "A text";
            x += text.GetHashCode();
            y = text.IndexOf("text");

            return x + y;
        }

        public int b(A a, int g) {
            int x = this.a(a) + this.a(a);
            int y = field1;
            int z = field2;
            int w = field3;

            field1 = w;
            field2 = y;
            field3 = z;

            return w + y + z + g;
        }
    }
}

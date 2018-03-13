using System;

namespace feature_envy_java
{
    class B
    {
        public int b1 = 1;
        public int b2 = 2;
        public int b3 = 3;
        public void a() {
            A a = new A();
            a.a();
            int xValue = a.x;
            int yValue = a.y;
            String b = "test";
            b.GetHashCode();
        }

        public void b() {
            this.c();
            this.c();
            System.Console.Write(this.b1);
            System.Console.Write(this.b1);
            System.Console.Write(this.b2);
            System.Console.Write(this.b2);
            System.Console.Write(this.b3);
            System.Console.Write(this.b3);
            String bLocal = "testLocal";
            bLocal.GetEnumerator();
        }

        public void c() {}
    }
}

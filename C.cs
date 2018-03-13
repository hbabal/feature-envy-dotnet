using System;

namespace feature_envy_dotnet
{
    class C
    {
        public int c1 = 2;
        public int c2 = 4;
        public int c3 = 6;
        public void ab() {
            A a = new A();
            B b = new B();
            a.a();
            b.a();
            b.a();
            this.cc();
            this.cc();
            this.cc();
            this.cc();
            this.cc();
            System.Console.Write(c1);
            System.Console.Write(c2);
            System.Console.Write(c3);
            System.Console.Write(a.x);
            System.Console.Write(a.y);
            System.Console.Write(b.b1);
            System.Console.Write(b.b1);
            System.Console.Write(b.b2);
            System.Console.Write(b.b2);
            System.Console.Write(b.b3);
            System.Console.Write(b.b3);
            String cLocal = "test2";
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
            cLocal.GetType();
        }

        public void cc() {}
    }
}

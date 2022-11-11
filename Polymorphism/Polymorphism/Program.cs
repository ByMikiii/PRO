using Polymorphism;

Calc c = new Calc();
Calc c1 = new Calc(1);
Calc c2 = new Calc(2,3);

c.DoSomething("dsajfhasjkfbjas");
c.DoSomething("fdsajfhasjkfbjas",5);
c.DoSomething(5,3);
c.DoSomething("Ahoj!",true);
c.DoSomething(5,1.23);

Stvorec s = new Stvorec(8);

Console.WriteLine($"Strana a: {s.sideA}, obvod: {s.Obvod()}, obsah: {s.Obsah()}");





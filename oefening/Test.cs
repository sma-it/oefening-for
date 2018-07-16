using NUnit.Framework;
using NUnitLite;

namespace Tests
{
    [TestFixture]
    public class TestOef1_for
    {
        // deze functie is nodig om de testen achteraf via de webinterface uit te voeren
        public static int Run(string resultPath)
        {
            string[] args = { "--work=" + resultPath };
            return new AutoRun().Execute(args);
        }

        //Opmerking: functies van het type void worden niet getest.

        [Test]
        public void TestBerekenSom1()
        {
            Assert.That(First.Oef1_for.BerekenSom1(), Is.EqualTo(5050));
        }

        [Test]
        public void TestBerekenSom2()
        {
            Assert.That(First.Oef1_for.BerekenSom2(65), Is.EqualTo(2145));
        }

        [Test]
        public void TestBerekenFac()
        {
            Assert.That(First.Oef1_for.BerekenFac(13), Is.EqualTo(6227020800));
            Assert.That(First.Oef1_for.BerekenFac(0), Is.EqualTo(1));
            Assert.That(First.Oef1_for.BerekenFac(1), Is.EqualTo(1));
        }



    }

    [TestFixture]
    public class TestOef2_for_if
    {
        // deze functie is nodig om de testen achteraf via de webinterface uit te voeren
        public static int Run(string resultPath)
        {
            string[] args = { "--work=" + resultPath };
            return new AutoRun().Execute(args);
        }


        [Test]
        public void TestIsPriem()
        {
            Assert.That(First.Oef2_for.IsPriem(37), Is.EqualTo(true));
            Assert.That(First.Oef2_for.IsPriem(36), Is.EqualTo(false));
        }

        [Test]
        public void ZoekGgd()
        {
            Assert.That(First.Oef2_for.ZoekGgd(21, 35), Is.EqualTo(7));
            Assert.That(First.Oef2_for.ZoekGgd(15, 45), Is.EqualTo(15));
            Assert.That(First.Oef2_for.ZoekGgd(3, 8), Is.EqualTo(1));
        }




    }
}

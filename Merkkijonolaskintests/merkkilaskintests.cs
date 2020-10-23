using MerkkijonoLaskin;
using NUnit.Framework;
using System;

namespace MerkkijonoLaskinTests
{
    public class MerkkijonoLaskinTests
    {
        MerkkijonoLaskin laskin;
        [SetUp]
        public void Setup()
        {
            laskin = new MerkkijonoLaskin();
        }

        [Test]
        public void TyhjaMerkkijonoPalauttaaNollan()
        {
            Assert.AreEqual(0, laskin.Laske(""));

        }

        [Test]
        public void LaskinPalauttaaAnnetunArvonJosVainYksiNumero()
        {

            Assert.AreEqual(5, laskin.Laske("5"));
        }

        [Test]
        public void LaskinPalauttaaKahdenPilkullaErotetunLuvunSumman()
        {
            Assert.AreEqual(9, laskin.Laske("5,4"));
        }

        [Test]
        public void LaskinPalauttaaUseammanPilkullaErotetunLuvunSumman()
        {
            Assert.AreEqual(30, laskin.Laske("5,4,10,11"));
        }

        [Test]
        public void LaskinPalauttaaLukujenSummanNewlineMerkillaErotettuna()
        {
            Assert.AreEqual(5, laskin.Laske("2\n3"));
            Assert.AreEqual(6, laskin.Laske("1,2\n3"));
            Assert.AreEqual(6, laskin.Laske("1,2\\n3"));
        }

        [Test]
        public void NegatiivinenLukuPienimpiKuinNollaAiheuttaaVirheen()
        {
            Assert.Throws<ArgumentException>(() => {
                laskin.Laske("-1");
            });
        }

        [Test]
        public void LaskinEiHuomioTuhannenYlittaviaLukuja()
        {
            Assert.AreEqual(0, laskin.Laske("1001"));
            Assert.AreEqual(4, laskin.Laske("1,1001\n3"));
        }

    }
}

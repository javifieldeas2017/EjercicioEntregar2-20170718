using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixServiceTest
    {
        private Alimento mAlimento1;
        private Alimento mAlimento2;
        private TurbomixService sut;
        private Receta receta;

        private Alimento mAlimentoReceta1;
        private Alimento mAlimentoReceta2;

        [TestInitialize]
        public void Init()
        {
            IBasculaService basculaService = new BasculaService();
            ICocinaService cocinaService = new CocinaService();

            sut = new TurbomixService(basculaService, cocinaService,null);
            mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Curry";
            mAlimento1.Peso = 1.5F;
            mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Queso";
            mAlimento2.Peso = 5F;

            mAlimentoReceta1 = new Alimento();
            mAlimentoReceta1.Nombre = "Curry";
            mAlimentoReceta1.Peso = 1.4F;
            mAlimentoReceta1.Calentado = true;
            mAlimentoReceta2 = new Alimento();
            mAlimentoReceta2.Nombre = "Queso";
            mAlimentoReceta2.Peso = 3F;
            mAlimentoReceta2.Calentado = true;

            receta = new Receta(mAlimentoReceta1, mAlimentoReceta2);
        }


        [TestMethod]
        public void TestPrepararPlato()
        {
            var mockBasculaService = new Mock<IBasculaService>();
            var mockCocinaService = new Mock<ICocinaService>();
            
            mockBasculaService.Setup( bascula => bascula.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.Peso);

            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.Peso);

            mockCocinaService.Setup(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()))
                .Callback((Alimento p1, Alimento p2) => { p1.Calentado = true; p2.Calentado = true; });
            sut = new TurbomixService(mockBasculaService.Object, mockCocinaService.Object, null);
            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2);

            mAlimentoReceta1.Peso = 1.5F;
            mAlimentoReceta2.Peso = 5F;

            mockBasculaService.Verify(bascula => bascula.Pesar(It.IsAny<Alimento>()), Times.AtLeast(1));
            mockCocinaService.Verify(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()), Times.AtLeast(1));
            Plato mPlato = new Plato(mAlimentoReceta1, mAlimentoReceta2);
       
            Assert.AreEqual(mPlato, resultado);
        }

        [TestMethod]
        public void TestPrepararPlatoConReceta()
        {
            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2, receta);

            Plato mPlato = new Plato(mAlimentoReceta1, mAlimentoReceta2);
            Assert.AreEqual(mPlato, resultado);
        }


    }
}

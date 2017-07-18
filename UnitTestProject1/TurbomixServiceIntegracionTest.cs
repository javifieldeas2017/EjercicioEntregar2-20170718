using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Microsoft.Practices.Unity;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixServiceIntegracionTest
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
            //IBasculaService basculaService = new BasculaService();
            //ICocinaService cocinaService = new CocinaService();
            //IRecetaRepository Recetario = new RecetaRepository();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ITurbomixService, TurbomixService>();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();
            container.RegisterType<IBasculaService, BasculaService>();
            container.RegisterType<ICocinaService, CocinaService>();

            ITurbomixService sut = container.Resolve<ITurbomixService>();
            IRecetaService recetaService = container.Resolve<IRecetaService>();
            IRecetaRepository repo = container.Resolve<IRecetaRepository>();
            IBasculaService basculaService = container.Resolve<IBasculaService>();
            ICocinaService cocinaService = container.Resolve<ICocinaService>();

            //sut = new TurbomixService(basculaService, cocinaService, null);
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

            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2);

            mAlimentoReceta1.Peso = 1.5F;
            mAlimentoReceta2.Peso = 5F;

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

        [TestMethod]
        public void TestConUnity()
        {
            sut.PrepararPlato(mAlimento1, mAlimento2, receta);
        }


    }
}

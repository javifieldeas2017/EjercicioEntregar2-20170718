using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class RecetaServiceIntegrationTest
    {
        
        [TestMethod]
        public void TestGuardar()
        {
            Receta receta = new Receta(null, null);
            IRecetaRepository RecetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(RecetaRepository);
            
            sut.Create(receta);
        }

        [TestMethod]
        public void TestLeer()
        {
            IRecetaRepository RecetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(RecetaRepository);

            sut.Lee("a");
        }

        [TestMethod]
        public void TestLista()
        {
            IRecetaRepository RecetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(RecetaRepository);

            sut.Lista();
        }

        [TestMethod]
        public void TestUpdate()
        {
            IRecetaRepository RecetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(RecetaRepository);

            sut.Update("a","b");
        }

        [TestMethod]
        public void TestDelete()
        {
            IRecetaRepository RecetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(RecetaRepository);

            sut.Delete("a");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiCalculadora.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Sumar4y1_resulta5()
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.sumar(1, 4);
            Assert.AreEqual(5, resultado);

            Calculadora calc2 = new Calculadora();
            int resultadoX = calc2.sumar(10, 50);
            Assert.AreEqual(100, resultadoX);
		
			
        }
        [TestMethod]
        public void Sumar7y10_resulta17()
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.sumar(7, 10);
            Assert.AreEqual(17, resultado);
        }
    }
}

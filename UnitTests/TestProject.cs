using System;
using System.Collections.Generic;
using System.Linq;
using eCommerce.Models;
using Xunit;

namespace eCommerce.UnitTests
{
    public class TestProject
    {
        [Fact]
        public void TestaPegarListaProdutos()
        {
                Banco b = new Banco();
                Catalogo c = b.lista();
                
                foreach(Produto p in c.lista){
                    Console.WriteLine("Produto: {0}", p.nome);
                }
                
                if(c.lista == null || c.lista.Count() == 0){
                    Assert.False(true);
                }
                Assert.True(true);
        }
    }
}
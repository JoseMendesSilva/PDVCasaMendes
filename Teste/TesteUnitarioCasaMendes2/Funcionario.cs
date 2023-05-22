using CasaMendes;
//using System.Windows

namespace TesteUnitarioCasaMendes
{
    [TestClass]
    public class Funcionario
    {
        [TestMethod]
        public void TestFrmLoad()
        {
            // Arrange
            FrmCadFuncionario? frmFuncionario = new FrmCadFuncionario();
            frmFuncionario.Show() = true;
            // Act
            bool res = frmFuncionario.frmLoading;

            // Assert
            //Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
            Assert.IsFalse(res);

        }
    }
}
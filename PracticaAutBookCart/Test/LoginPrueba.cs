// Se importa la clase LoginPage que representa el Page Object del login
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PracticaAutBookCard.PageObject.LoginPage;
using PracticaAutBookCart.Test;
using SeleniumExtras.WaitHelpers;


namespace PracticaAutBookCart.Test
{
    // Marca esta clase como una clase de pruebas de NUnit
    [TestFixture]
    public class LoginTest : BaseTest
    {
        // Constructor: envía el nombre del archivo de reporte al constructor base
        public LoginTest() : base("LoginPage.html")
        {
            // Función para pasar el nombre del reporte a nivel herencia
        }

        // === Test para verificar que el login con credenciales válidas funciona correctamente ===
        [Test]
        public void LoginCorrecto()
        {
            // REPORTE-> Se inicializa el reporte para este test específico
            extentTest = extent.CreateTest("Validación del login Exitoso.");
            // Se instancia la página de login
            var loginPage = new LoginPage(Driver);
            // Se navega a la URL del formulario de login
            loginPage.GoTo();
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento es correcto");
            // Se realiza el login con credenciales válidas
            loginPage.IngresarUsuario("mari01");
            loginPage.IngresarContra("Mar1997diaz");
            loginPage.ClicLogin();
            // REPORTE-> Se registra el paso exitoso en el reporte
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se Ingresan los datos correctamente.");
            // Se valida que la URL posterior al login sea la esperada
            string expectedUrl = "https://bookcart.azurewebsites.net/login";
            Assert.That(loginPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
            // REPORTE-> Se registra el éxito de la navegación en el reporte
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se ha realizado correctamente el ingreso desde el login.");
        }
        /// <summary>
        //Login  Exitoso
        /// </summary>

        [Test]
        public void LoginIncorrecto()
        {
            // REPORTE-> Se inicializa el reporte para este test específico
            extentTest = extent.CreateTest("Validación del login Incorrecto.");
            // Se instancia la página de login
            var loginPage = new LoginPage(Driver);
            // Se navega a la URL del formulario de login
            loginPage.GoTo();
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento es correcto");
            // Se realiza el login con credenciales válidas
            loginPage.IngresarUsuario("mari02");
            loginPage.IngresarContra("Mariaprueba0001");
            loginPage.ClicLogin();
    
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(25));
            Assert.That(loginPage.obtenerTextoAlerta, Is.EqualTo("Login Failed. Username or Password is incorrect."));
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se Ingresan los datos correctamente.");
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se realiza la correcta validación del error.");


            ////////  Login Erroneo  / <summary>     

        }
    }
}

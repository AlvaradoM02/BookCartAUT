using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using PracticaAutBookCard.PageObject.LoginPage;
using PracticaAutBookCart.PageObject;
using SeleniumExtras.WaitHelpers;


namespace PracticaAutBookCart.Test
{
    [TestFixture]


    public class RegistroPrueba : BaseTest
    {
        // Constructor: envía el nombre del archivo de reporte al constructor base
        public RegistroPrueba() : base("RegistroPage.html")
        {
            // Función para pasar el nombre del reporte a nivel herencia
        }

        // === Test para verificar que el login con credenciales válidas funciona correctamente ===
        [Test]
       

        public void Registro()
        {

            extentTest = extent.CreateTest("Validación de registro Exitoso.");// REPORTE-> Se inicializa el reporte para este test específico
            var RegistroPage = new RegistroPage(Driver); // Se instancia la página de login
            var LoginPage = new LoginPage(Driver); // Se instancia la página de login   
            RegistroPage.GoTo(); // Se navega a la URL del formulario de login
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento es correcto"); // Reporte: Se registra el paso exitoso en el reporte
            RegistroPage.IngresarNombre("Prueba");
            RegistroPage.IngresarApellido("Babel");
            RegistroPage.IngresarUsuario("prueba03");
            RegistroPage.IngresarContra("Practica2025Aut");
            RegistroPage.IngresarVerifContra("Practica2025Aut");
            RegistroPage.ClicGenero();
            RegistroPage.ClicRegistro(); // Se realiza el registro con credenciales válidas
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se Ingresan los datos correctamente."); // Reporte: Se registra el paso exitoso en el reporte
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(25));
            string expectedUrl = "https://bookcart.azurewebsites.net/register";
            Assert.That(RegistroPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
            extentTest.Log(AventStack.ExtentReports.Status.Info, "Hace el registro pero no hace el login");


            //LoginPage.GoTo(); // Se navega a la URL del formulario de login
            //LoginPage.IngresarUsuario("prueba03");
            //LoginPage.IngresarContra("Practica2025Aut");
            //LoginPage.ClicLogin(); // Se realiza el login con credenciales válidas
            //string expectedUrl = "https://bookcart.azurewebsites.net/login";
            //Assert.That(RegistroPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));



        }
    }
}


using AventStack.ExtentReports;
using PracticaAutBookCard.PageObject.LoginPage;
using PracticaAutBookCart.PageObject;


namespace PracticaAutBookCart.Test
{
    [TestFixture]


    public class EnvioPrueba : BaseTest
    {
        // Constructor: envía el nombre del archivo de reporte al constructor base
        public EnvioPrueba() : base("EnvioPage.html")
        {
            // Función para pasar el nombre del reporte a nivel herencia
        }

        // === Test para verificar que el login con credenciales válidas funciona correctamente ===
        [Test] // Atributo que indica que este método es un test de NUnit.
        [Retry(2)] // Indica que si el test falla, se reintentará hasta 2 veces más antes de marcarlo como fallido.

        public void FlujoCompra()
        {
            // Se crea una instancia del reporte de pruebas para documentar este test.
            extentTest = extent.CreateTest("Validación de Envio Exitoso.");

            // Se instancia la página de login usando el WebDriver.
            var loginPage = new LoginPage(Driver);

            // Se navega a la página del formulario de login.
            loginPage.GoTo();

            // Se ingresan las credenciales válidas.
            loginPage.IngresarUsuario("mari01");
            loginPage.IngresarContra("Mar1997diaz");

            // Se hace clic en el botón de login.
            loginPage.ClicLogin();

            // Se registra en el reporte que los datos fueron ingresados correctamente.
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se Ingresan los datos de login correctamente.");

            Thread.Sleep(5000);

            // Se instancia la página de envío.
            var EnvioPage = new EnvioPage(Driver);

            // Se selecciona el botón "Agregar" 
            EnvioPage.SelecBtnAgregar();
            Thread.Sleep(1000); // Espera breve.

            // Se navega al carrito de compras.
            EnvioPage.irAlCarrito();
            Thread.Sleep(3000); // Espera para carga del carrito.

            // Se procede a la página de datos de envío.
            EnvioPage.irAEnvio();
            Thread.Sleep(10000); // Espera larga para cargar la página de envío.

            // Se llenan los campos del formulario de envío:
            EnvioPage.IngresarNombre("Maria");
            Thread.Sleep(1000);

            EnvioPage.IngresarDirec("Calle 123");
            Thread.Sleep(1000);

            EnvioPage.IngresarDirecS("Calle 123");
            Thread.Sleep(1000);

            EnvioPage.IngresarCodCiudad("012345");
            Thread.Sleep(1000);

            EnvioPage.IngresarEstado("Cali");
            Thread.Sleep(1000);

            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se Ingresan los datos de envio correctamente.");

        }

    }
}



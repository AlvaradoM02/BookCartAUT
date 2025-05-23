using AventStack.ExtentReports;
using PracticaAutBookCart.PageObject;


namespace PracticaAutBookCart.Test
{
    [TestFixture]


    public class CarritoPrueba : BaseTest
    {
        // Constructor: envía el nombre del archivo de reporte al constructor base
        public CarritoPrueba() : base("CarritoPage.html")
        {
            // Función para pasar el nombre del reporte a nivel herencia
        }

        [Test]

        public void FlujoCarrito()
        {
            // Se crea una entrada en el reporte para este flujo de prueba llamado "Validacion del carrito"
            extentTest = extent.CreateTest("Validacion del carrito");

            // Se instancia la página de inicio, pasando el driver actual
            var InicioPage = new InicioPage(Driver);
            var CarritoPage = new CarritoPage(Driver);
            // Se navega a la página de inicio
            InicioPage.GoTo();
            // Se registra en el reporte que el direccionamiento a la página de inicio fue exitoso
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento a la página es correcto");
            // Se hace clic en el botón para agregar un producto (por ejemplo, un libro) al carrito
            InicioPage.SelecBtnAgregar();
            //Se navega a la página del carrito
            CarritoPage.GoTo();
            // Se realiza la acción de ir al carrito (podría ser hacer clic en el icono del carrito, por ejemplo)
            CarritoPage.irAlCarrito();
            // Se registra en el reporte que se ingresó al carrito correctamente
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se ingreso al carrito de manera correcta");
            // Se realiza la acción de aumentar la cantidad del libro en el carrito
            CarritoPage.SumarLibro();
              // Se registra en el reporte que se pudo aumentar la cantidad del libro exitosamente
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se puede sumar un libro de manera correcta");
            // Se realiza la acción de eliminar el libro del carrito
            CarritoPage.EliminarLibro();
            // Se registra que se ingresó al carrito y se completó la acción correctamente
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se puede eliminar un libro de manera correcta");
        }



    }
}

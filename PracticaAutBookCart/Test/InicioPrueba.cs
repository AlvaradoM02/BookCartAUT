using AventStack.ExtentReports;
using PracticaAutBookCart.PageObject;


namespace PracticaAutBookCart.Test
{
    [TestFixture]


    public class InicioPrueba: BaseTest    {
        // Constructor: env�a el nombre del archivo de reporte al constructor base
        public InicioPrueba() : base("InicioPage.html")
        {
            // Funci�n para pasar el nombre del reporte a nivel herencia
        }

        // === Test para verificar que el login con credenciales v�lidas funciona correctamente ===
        [Test]
        public void BuscarImagen()
        {
           
            extentTest = extent.CreateTest("Buscar imagen de libro"); // Reporte: Se inicializa el reporte para este test espec�fico

           // Se instancia la p�gina de login
            var InicioPage = new InicioPage(Driver);

            InicioPage.GoTo();

             
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento es correcto");// Reporte: Se registra el paso exitoso en el reporte

            InicioPage.BuscarImagen();
            
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se encontro de manera correcta la imagen");// Reporte: Se registra el paso exitoso en el reporte
        }
        [Test]
        public void BuscarTitulo()
        {
           
            extentTest = extent.CreateTest("Busca titulo del libro"); // Reporte: Se inicializa el reporte para este test espec�fico

            // Se instancia la p�gina de login
            var InicioPage = new InicioPage(Driver);

            InicioPage.GoTo();

          
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento es correcto");  // Reporte: Se registra el paso exitoso en el reporte

            InicioPage.BuscarTitulo();
           
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se encontro de manera correcta el Titulo"); // Reporte: Se registra el paso exitoso en el reporte
        }
        [Test]
        public void BuscarPrecio()
        {
            
            extentTest = extent.CreateTest("Busca el precio del libro");// Reporte: Se inicializa el reporte para este test espec�fico

            // Se instancia la p�gina de login
            var InicioPage = new InicioPage(Driver);

            InicioPage.GoTo();

           
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento es correcto"); // Reporte: Se registra el paso exitoso en el reporte

            InicioPage.BuscarPrecio();
            
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se encontro de manera correcta el precio");// Reporte: Se registra el paso exitoso en el reporte
        }
        [Test]
        public void AgregarElementosAlCarrito()
        {
            
            extentTest = extent.CreateTest("Agrega libro al carrito");// Reporte: Se inicializa el reporte para este test espec�fico

            // Se instancia la p�gina de login
            var InicioPage = new InicioPage(Driver);

            InicioPage.GoTo();

            
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento es correcto");// Reporte: Se registra el paso exitoso en el reporte

            InicioPage.SelecBtnAgregar();
            
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "Se encuentra el bot�n de agregar de manera correcta");// Reporte: Se registra el paso exitoso en el reporte
        }



    }
}

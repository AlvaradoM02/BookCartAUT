using AventStack.ExtentReports;
using PracticaAutBookCart.PageObject;


namespace PracticaAutBookCart.Test
{
    [TestFixture]
    public class BusquedaPrueba: BaseTest
    {
        // Constructor: envía el nombre del archivo de reporte al constructor base
        public BusquedaPrueba() : base("BusquedaPage.html")
        {
            // Función para pasar el nombre del reporte a nivel herencia
        }


        
        [Test]
        public void BuscarLibroEnBarra()
        { 
           
            extentTest = extent.CreateTest("Busqueda de libro Exitosa"); // Reporte: Se inicializa el reporte para este test específico

            // Se instancia la página 
            var BusquedaPrueba = new BusquedaPage(Driver);

            // Se navega a la URL 
             BusquedaPrueba.GoTo();
           

           BusquedaPrueba.BuscarEnBarra(); 
            
          
            // Reporte: Se registra el paso exitoso en el reporte
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "El direccionamiento a la página es correcto");

           // Reporte: Se registra el éxito de la navegación en el reporte
            extentTest.Log(AventStack.ExtentReports.Status.Pass, "La búsqueda es correcta");
      
        }

      


    }
}

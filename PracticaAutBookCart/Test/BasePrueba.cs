using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Genericos.DriversConfig;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace PracticaAutBookCart.Test
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver;

        protected string reportTestPage = "";

        
        public static ExtentTest extentTest;// Reporte: Generación de test para crear reportes por cada caso de prueba

        
        public static ExtentReports extent;// Reporte: Herramienta para generar reportes dinámicos por ejecución

        // Constructor que recibe el nombre del reporte
        public BaseTest(string pageContext)
        {
            this.reportTestPage = pageContext;
        }

        // Setup que se ejecuta antes de cada test
        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            Driver = ChromeFactory.CrearDriver(options);
        }

        // TearDown que se ejecuta después de cada test
        [TearDown]
        public void TearDown()
        {
            try
            {
                Driver?.Dispose();
            }
            catch { }
        }

        
        [OneTimeSetUp]// Reporte: Se configura el entorno de reportería antes de ejecutar todos los tests
        public void reportsForTests()
        {
            try
            {
                // Fecha con hora para diferenciar reportes por ejecución
                DateTime today = DateTime.Now;
                string fecha = today.Day + "-" + today.Month + "-" + today.Year + "__" + today.Hour + "" + today.Minute;

                // Inicializa ExtentReports y define el path del archivo de reporte
                extent = new ExtentReports();
                string currectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectRootName = Directory.GetParent(currectDirectory).Parent.Parent.Parent.FullName;
                string reportFolder = Path.Combine(projectRootName, "Reportes");
                string reportPath = Path.Combine(reportFolder, "_" + fecha + "_" + this.reportTestPage);

                ExtentSparkReporter extentSparkReporter = new ExtentSparkReporter(reportPath);
                extent.AttachReporter(extentSparkReporter);
            }
            catch (Exception ex)
            {
                // Reporte:  Registra el error si falla la inicialización del reporte
                extentTest.Log(AventStack.ExtentReports.Status.Fail, "Error al Navegación Error : " + ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        // Reporte:  Finaliza y guarda el reporte después de ejecutar todos los tests
        [OneTimeTearDown]
        public void reportTearDown()
        {
            try
            {
                extent.Flush(); // Genera el archivo final del reporte
            }
            catch (Exception ex)
            {
                // Reporte:  Registra el error si falla el guardado del reporte
                extentTest.Log(AventStack.ExtentReports.Status.Fail, "Error al Navegación Error : " + ex.Message);
                Assert.Fail(ex.Message);
            }
        }
    }
}

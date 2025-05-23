// Importación de librerías necesarias
using OpenQA.Selenium;                  // Interfaz IWebDriver y otros elementos base de Selenium
using OpenQA.Selenium.Chrome;          // Controlador específico para el navegador Google Chrome

namespace Genericos.DriversConfig       // Define el espacio de nombres donde vive esta clase (puede agrupar configuración de drivers)
{
    // Clase encargada de encapsular la creación de un ChromeDriver con opciones personalizadas
    public class ChromeFactory
    {
        // Método público que devuelve una nueva instancia de IWebDriver (ChromeDriver)
        // Recibe como parámetro un objeto ChromeOptions para configurar el navegador (modo headless, extensiones, etc.)
        public static IWebDriver CrearDriver(ChromeOptions options)
        {
            // Crea y retorna un nuevo ChromeDriver con las opciones proporcionadas
            return new ChromeDriver(options);
        }
    }
}

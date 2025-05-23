// Librerías necesarias para WebDriver y espera explícita
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaAutBookCart.PageObject// Clase base para todas las páginas del proyecto
    { 
    
    public abstract class BasePage
    {
        
        protected IWebDriver Driver;// Instancia del navegador


        protected WebDriverWait Wait;// Instancia de espera explícita
       
        protected IWebElement WaitForElement(By locator) // Método protegido que espera hasta que un elemento sea visible y lo devuelve
        {
            return Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }


        protected BasePage(IWebDriver driver)// Constructor que recibe el WebDriver y configura una espera de 10 segundos
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void EsperaElemento(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Espera hasta que un elemento esté visible
            IWebElement miElemento = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("miElementoId")));

            miElemento.Click(); // Se puede interactuar con el elemento después de que está visible
        }

        protected void DarClic(By locator) { Driver.FindElement(locator).Click(); }

        protected void IngresarTexto(By locator, string texto)
        {
            WaitForElement(locator).Clear();
            Driver.FindElement(locator).SendKeys(texto);
        }
        /// <summary>
        /// Espera hasta que el documento esté completamente cargado (document.readyState == "complete").
        /// </summary>
        /// <param name="driver">Instancia del WebDriver.</param>
        /// <param name="timeoutSegundos">Cantidad máxima de segundos a esperar.</param>
        public static void TiempoEspera(IWebDriver driver, int timeoutSegundos = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSegundos));
            wait.Until(d =>
                ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").ToString() == "complete"
            );
        }


    }
}

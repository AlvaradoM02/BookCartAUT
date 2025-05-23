using System;
using OpenQA.Selenium;
using PracticaAutBookCart.Test;
using static System.Net.WebRequestMethods;

namespace PracticaAutBookCart.PageObject
{
    public class CarritoPage : BasePage
    {
        // URL base de la aplicación web que se está automatizando (opcional según el uso)
        private string baseURL = "https://bookcart.azurewebsites.net/shopping-cart/";


        //--Selectores--//
        private By btnCarrito = By.XPath("/html/body/app-root/app-nav-bar/mat-toolbar/mat-toolbar-row/div[3]/button[1]"); //Icono carrito
        private By btnEliminar = By.XPath("/html/body/app-root/div/app-shoppingcart/mat-card/mat-card-content[1]/table/tbody/tr/td[6]/button"); //Boton eliminar libro
        private By btnSumar = By.XPath("/html/body/app-root/div/app-shoppingcart/mat-card/mat-card-content[1]/table/tbody/tr/td[4]/div/div[3]/button"); //Boton sumar libro

        // Constructor de la clase BusquedaPage que recibe una instancia del navegador (IWebDriver)
        public CarritoPage(IWebDriver driver) : base(driver) { }

        // Método público que navega hacia una URL definida en la variable baseURL.
        public void GoTo()
        {
            Driver.Navigate().GoToUrl(baseURL);
            TiempoEspera(Driver); // Espera a que la página esté completamente cargada
        }

        public void irAlCarrito()
        {

            WaitForElement(btnCarrito);
            Driver.FindElement(btnCarrito).Click();

        }


        public void EliminarLibro()
        {
            WaitForElement(btnEliminar);
            Driver.FindElement(btnEliminar).Click();
        }
        //
        public void SumarLibro()
        {
            WaitForElement(btnSumar);
            Driver.FindElement(btnSumar).Click();
        }

    }
}

using System;
using System.Security.Policy;
using OpenQA.Selenium;
using static System.Net.WebRequestMethods;

namespace PracticaAutBookCart.PageObject
{
    public class BusquedaPage : BasePage
    {

       // URL base de la aplicación web que se está automatizando (opcional según el uso)
        private string baseURL = "https://bookcart.azurewebsites.net/"; 


        //--Selectores--//
        private By busquedaLibro = By.XPath("/html/body/app-root/app-nav-bar/mat-toolbar/mat-toolbar-row/div[2]/app-search/form/input");  //Barra de busqueda
        
        // Constructor de la clase BusquedaPage que recibe una instancia del navegador (IWebDriver)
        public BusquedaPage(IWebDriver driver) : base(driver) { }

        // Método público que navega hacia una URL definida en la variable baseURL.
        public void GoTo() { Driver.Navigate().GoToUrl(baseURL); } 

        //metodo que busca un libro en la barra de busqueda
        public void BuscarEnBarra() 

        {

           DarClic(busquedaLibro); //Hace clic en el campo
           IngresarTexto(busquedaLibro, "Harry Potter"); //Escribe el texto en la barra de busqueda
        }

    }
}

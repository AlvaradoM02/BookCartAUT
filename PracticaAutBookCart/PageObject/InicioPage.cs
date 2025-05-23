using System;
using OpenQA.Selenium;

namespace PracticaAutBookCart.PageObject
{
  public class InicioPage : BasePage
    {

       // private IWebDriver driver; // Controlador del navegador que permite interactuar con la página web
        private string baseURL = "https://bookcart.azurewebsites.net/"; // URL base de la aplicación web que se está automatizando (opcional según el uso)


        //--Selectores--//
        private By imgLibro = By.XPath("/html/body/app-root/div/app-home/div/div[2]/div/div[1]/app-book-card/mat-card/a/img");                                              //Imagen
        private By tituloLibro = By.XPath("/html/body/app-root/div/app-home/div/div[2]/div/div[1]/app-book-card/mat-card/mat-card-content/div/a/strong");                                                                           //Título
        private By precioLibro = By.TagName("p");                                                                                          //Precio
        private By btnAgregar = By.XPath("/html/body/app-root/div/app-home/div/div[2]/div/div[1]/app-book-card/mat-card/mat-card-content/app-addtocart/button");    //Botón “Agregar al carrito”

        // Constructor que inicializa la clase con el WebDriver proporcionado
        public InicioPage(IWebDriver driver) : base(driver) { }

        // Método para navegar a la URL base de la página
        public void GoTo()
        {

            Driver.Navigate().GoToUrl(baseURL);
            TiempoEspera(Driver); // Espera a que la página esté completamente cargada  
        }

        // Método que simula una acción de búsqueda o selección sobre la imagen de un libro
        public void BuscarImagen()
        {
            DarClic(imgLibro); // Hace clic en el elemento que representa la imagen de un libro
        }

        // Método que simula una acción de búsqueda o selección sobre el título de un libro
        public void BuscarTitulo()
        {
            DarClic(tituloLibro); // Hace clic en el elemento que representa el título del libro
        }

        // Método que simula una acción de búsqueda o selección sobre el precio del libro
        public void BuscarPrecio()
        {
            DarClic(precioLibro); // Hace clic en el elemento que representa el precio del libro
        }

        // Método que hace clic en el botón "Agregar", presumiblemente para agregar un ítem al carrito
        public void SelecBtnAgregar()
        {
            DarClic(btnAgregar); // Hace clic en el botón para agregar el libro
        }

    }
}

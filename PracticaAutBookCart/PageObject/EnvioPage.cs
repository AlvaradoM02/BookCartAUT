using System;
using OpenQA.Selenium;

namespace PracticaAutBookCart.PageObject
{
    public class EnvioPage : BasePage
    {

        // private IWebDriver driver; // Controlador del navegador que permite interactuar con la página web
        private string baseURL = "https://bookcart.azurewebsites.net/"; // URL base de la aplicación web que se está automatizando (opcional según el uso)


        //--Selectores--//
        private By tbxUsuario = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-form-field[1]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el nombre de usuario
        private By tbxContra = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-form-field[2]/div[1]/div/div[2]/input"); //Campo de texto para ingresar la contraseña
        private By btnIngreso = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-card-actions/button"); // Botón de inicio de sesión
        private By btnAgregar = By.XPath("/html/body/app-root/div/app-home/div/div[2]/div/div[1]/app-book-card/mat-card/mat-card-content/app-addtocart/button");    //Botón “Agregar al carrito”
        private By btnCarrito = By.XPath("/html/body/app-root/app-nav-bar/mat-toolbar/mat-toolbar-row/div[3]/button[2]"); //Icono carrito
        private By btnEnvio = By.XPath("/html/body/app-root/div/app-shoppingcart/mat-card/mat-card-content[2]/td[6]/button"); //Botón “Realizar pedido” en la página del carrito
        private By txtNombre = By.XPath("/html/body/app-root/div/app-checkout/mat-card/mat-card-content/div/div[1]/mat-card-content/form/mat-form-field[1]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el nombre del usuario
        private By txtDirec = By.XPath("/html/body/app-root/div/app-checkout/mat-card/mat-card-content/div/div[1]/mat-card-content/form/mat-form-field[2]/div[1]/div/div[2]/input"); //Campo de texto para ingresar la dirección del usuario
        private By txtDirecS = By.XPath("/html/body/app-root/div/app-checkout/mat-card/mat-card-content/div/div[1]/mat-card-content/form/mat-form-field[3]/div[1]/div/div[2]/input"); //Campo de texto para ingresar la dirección secundaria del usuario
        private By txtCodCiudad = By.XPath("/html/body/app-root/div/app-checkout/mat-card/mat-card-content/div/div[1]/mat-card-content/form/mat-form-field[4]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el código de la ciudad del usuario
        private By txtEstado = By.XPath("/html/body/app-root/div/app-checkout/mat-card/mat-card-content/div/div[1]/mat-card-content/form/mat-form-field[5]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el estado del usuario
        private By btnPedir = By.XPath("/html/body/app-root/div/app-checkout/mat-card/mat-card-content/div/div[1]/mat-card-content/form/mat-card-actions/button[1]"); //Botón “Realizar pedido” en la página de envío
                                                                                                                                                                      // Constructor que recibe una instancia de IWebDriver y la pasa a la clase base
        public EnvioPage(IWebDriver driver) : base(driver) { }

        // Método para navegar a la URL base
        public void GoTo()
        {
            Driver.Navigate().GoToUrl(baseURL);
        }

        // Método para ingresar el nombre de usuario
        public void IngresarUsuario(string username)
        {
            IngresarTexto(tbxUsuario, username); // Ingresa el nombre de usuario
        }

        // Método para ingresar la contraseña
        public void IngresarPassword(string password)
        {
           IngresarTexto(tbxContra, password); // Ingresa la contraseña    
        }

        // Método para hacer clic en el botón de login
        public void ClicLogin()
        {
            WaitForElement(btnIngreso); // Espera que el botón esté disponible
            DarClic(btnIngreso);
        }

        // Método que combina los pasos anteriores para iniciar sesión
        public void Login(string username, string password)
        {
            IngresarUsuario(username);
            IngresarPassword(password);
            DarClic(btnIngreso);
        }

        // Método para hacer clic en el botón "Agregar"
        public void SelecBtnAgregar()
        {
            DarClic(btnAgregar);
        }

        // Método para ir al carrito
        public void irAlCarrito()
        {
            DarClic(btnCarrito); // Hace clic en el botón del carrito
        }

        // Método para ir a la sección de envío
        public void irAEnvio()
        {
            DarClic(btnEnvio);
        }

        // Método para ingresar el nombre del destinatario
        public void IngresarNombre(string nombre)
        {
            WaitForElement(txtNombre);
            Driver.FindElement(txtNombre).Click();
            Driver.FindElement(txtNombre).SendKeys(nombre);
        }

        // Método para ingresar la dirección principal
        public void IngresarDirec(string direccion)
        {
            WaitForElement(txtDirec);
            Driver.FindElement(txtDirec).Click();
            Driver.FindElement(txtDirec).SendKeys(direccion);
        }

        // Método para ingresar la dirección secundaria
        public void IngresarDirecS(string direccionS)
        {
            WaitForElement(txtDirecS);
            Driver.FindElement(txtDirecS).Click();
            Driver.FindElement(txtDirecS).SendKeys(direccionS);
        }

        // Método para ingresar el código postal o código de ciudad
        public void IngresarCodCiudad(string codCiudad)
        {
            WaitForElement(txtCodCiudad);
            Driver.FindElement(txtCodCiudad).Click();
            Driver.FindElement(txtCodCiudad).SendKeys(codCiudad);
        }

        // Método para ingresar el estado o provincia
        public void IngresarEstado(string estado)
        {
            WaitForElement(txtEstado);
            Driver.FindElement(txtEstado).Click();
            Driver.FindElement(txtEstado).SendKeys(estado);
        }

        // Método que agrupa la entrada de todos los datos del formulario de envío
        public void IngresarDatos(string nombre, string direccion, string direccionS, string codCiudad, string estado)
        {
            IngresarNombre(nombre);
            IngresarDirec(direccion);
            IngresarDirecS(direccionS);
            IngresarCodCiudad(codCiudad);
            IngresarEstado(estado);
        }

        // Método para finalizar el pedido
        public void RealizarPedido()
        {
            Driver.FindElement(btnPedir).Click(); // Hace clic en el botón para realizar el pedido
        }


    }
}

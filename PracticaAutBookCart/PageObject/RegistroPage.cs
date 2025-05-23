using System;
using OpenQA.Selenium;

namespace PracticaAutBookCart.PageObject
{
    public class RegistroPage : BasePage
    {

        // private IWebDriver driver; // Controlador del navegador que permite interactuar con la página web
        private string baseURL = "https://bookcart.azurewebsites.net/register"; // URL base de la aplicación web que se está automatizando (opcional según el uso)


        //--Selectores--//
        private By txtNombre = By.XPath("/html/body/app-root/div/app-user-registration/div/mat-card/mat-card-content/form/mat-form-field[1]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el nombre del usuario
        private By txtApellido = By.XPath("/html/body/app-root/div/app-user-registration/div/mat-card/mat-card-content/form/mat-form-field[2]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el apellido del usuario
        private By txtUsuario = By.XPath("/html/body/app-root/div/app-user-registration/div/mat-card/mat-card-content/form/mat-form-field[3]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el nombre de usuario
        private By txtContra = By.XPath("/html/body/app-root/div/app-user-registration/div/mat-card/mat-card-content/form/mat-form-field[4]/div[1]/div/div[2]/input");    //Campo de texto para ingresar la contraseña
        private By txtVerifContra = By.XPath("/html/body/app-root/div/app-user-registration/div/mat-card/mat-card-content/form/mat-form-field[5]/div[1]/div/div[2]/input"); //Campo de texto para ingresar la verificación de la contraseña
        private By btnGenero = By.XPath("/html/body/app-root/div/app-user-registration/div/mat-card/mat-card-content/form/mat-radio-group/mat-radio-button[2]"); //Botón de género
        private By btnRegistro = By.XPath("/html/body/app-root/div/app-user-registration/div/mat-card/mat-card-content/form/mat-card-actions/button"); //Botón de registro
        private By tbxUsuarioLogin = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-form-field[1]/div[1]/div/div[2]/input"); //Campo de texto para ingresar el nombre de usuario
        private By tbxContraLogin = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-form-field[2]/div[1]/div/div[2]/input"); //Campo de texto para ingresar la contraseña
        private By btnIngreso = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-card-actions/button"); // Botón de inicio de sesión

        // Constructor de la clase RegistroPage que recibe un IWebDriver y lo pasa a la clase base.
        public RegistroPage(IWebDriver driver) : base(driver) { }

        // Método para navegar a la URL base de la aplicación.
        public void GoTo()
        {
            Driver.Navigate().GoToUrl(baseURL);
        }

        // Método para ingresar el nombre en el campo correspondiente.
        public void IngresarNombre(string nombre)
        {
            WaitForElement(txtNombre); // Espera a que el elemento esté presente.
            Driver.FindElement(txtNombre).Click(); // Hace clic en el campo.
            Driver.FindElement(txtNombre).SendKeys(nombre); // Escribe el nombre.
        }

        // Método para ingresar el apellido.
        public void IngresarApellido(string apellido)
        {
            WaitForElement(txtApellido);
            Driver.FindElement(txtApellido).Click();
            Driver.FindElement(txtApellido).SendKeys(apellido);
        }

        // Método para ingresar el nombre de usuario.
        public void IngresarUsuario(string usuario)
        {
            WaitForElement(txtUsuario);
            Driver.FindElement(txtUsuario).Click();
            Driver.FindElement(txtUsuario).SendKeys(usuario);
        }

        // Método para ingresar la contraseña.
        public void IngresarContra(string contra)
        {
            WaitForElement(txtContra);
            Driver.FindElement(txtContra).Click();
            Driver.FindElement(txtContra).SendKeys(contra);
        }

        // Método para ingresar la verificación de la contraseña.
        public void IngresarVerifContra(string verifcontra)
        {
            WaitForElement(txtVerifContra);
            Driver.FindElement(txtVerifContra).Click();
            Driver.FindElement(txtVerifContra).SendKeys(verifcontra);
        }

        // Método para hacer clic en el botón de selección de género.
        public void ClicGenero()
        {
            WaitForElement(btnGenero);
            Driver.FindElement(btnGenero).Click();
        }

        // Método para hacer clic en el botón de registro.
        public void ClicRegistro()
        {
            WaitForElement(btnRegistro);
            Driver.FindElement(btnRegistro).Click();
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        // Método para realizar el proceso completo de registro con los datos proporcionados.
        public void IngresarRegistro(string nombre, string apellido, string usuario, string contra, string verifcontra)
        {
            IngresarNombre(nombre);
            IngresarApellido(apellido);
            IngresarUsuario(usuario);
            IngresarContra(contra);
            IngresarVerifContra(verifcontra);
        }

       
        


        // Método que obtiene la URL actual del navegador.
        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

      

    }
}

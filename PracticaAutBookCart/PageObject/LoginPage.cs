using OpenQA.Selenium;
using PracticaAutBookCart.PageObject;
using PracticaAutBookCard.PageObject;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;


namespace PracticaAutBookCard.PageObject.LoginPage
{
    // Representa la página de login, hereda funcionalidades básicas de BasePage
    public class LoginPage : BasePage
    {
        private readonly string loginUrl = "https://bookcart.azurewebsites.net/login";

        private By tbxUsuario = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-form-field[1]/div[1]/div/div[2]/input");
        private By tbxContra = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-form-field[2]/div[1]/div/div[2]/input");
        private By btnIngreso = By.XPath("/html/body/app-root/div/app-login/div/mat-card/mat-card-content/form/mat-card-actions/button");
        private By txtError = By.Id ("mat-mdc-error-0");
        // Constructor de la clase LoginPage que hereda de una clase base (probablemente BasePage)
        public LoginPage(IWebDriver driver) : base(driver) { }

        // Método para navegar a la URL específica de la página de login
        public void GoTo()
        {
            Driver.Navigate().GoToUrl(loginUrl); // Redirige al usuario a la URL de inicio de sesión
        }

        // Método para ingresar el nombre de usuario en el campo correspondiente
        public void IngresarUsuario(string username)
        {
            WaitForElement(tbxUsuario); // Espera que el campo de usuario esté presente en el DOM
            IngresarTexto(tbxUsuario, username); // Llama al método de la clase base para ingresar el texto
        }

        // Método para ingresar la contraseña en el campo correspondiente
        public void IngresarContra(string password)
        {
            WaitForElement(tbxContra); // Espera que el campo de contraseña esté presente
            IngresarTexto(tbxContra, password);  
        }

        // Método para hacer clic en el botón de ingreso (login)
        public void ClicLogin()
        {
            WaitForElement(btnIngreso); // Espera que el botón esté presente
            DarClic(btnIngreso); // Llama al método de la clase base para hacer clic 
        }


        // Método de conveniencia que ejecuta el flujo completo de login con usuario y contraseña
        public void Login(string username, string password)
        {
            IngresarUsuario(username);      // Ingresa el nombre de usuario
            IngresarContra(password);     // Ingresa la contraseña
            ClicLogin();                   // Hace clic en el botón de login
        }

        // Método que obtiene la URL actual del navegador.
        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

        //Método que obtiene el texto de la alerta o mensaje de error en la página.
        public string obtenerTextoAlerta()
        {
            return WaitForElement(txtError).Text;
               
        }

        

    }
}
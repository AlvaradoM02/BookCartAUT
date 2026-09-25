# 🛒 PracticaAutBookCart

Proyecto de automatización de pruebas funcionales para una aplicación web tipo e-commerce (BookCart), desarrollado en **C#** con **Selenium WebDriver**, siguiendo el patrón de diseño **Page Object Model (POM)**.

---

## 📋 Descripción

Este proyecto automatiza los flujos principales de una tienda de libros online, cubriendo los módulos de:

- 🏠 **Inicio** — elementos y navegación de la página principal
- 🔐 **Login** — autenticación de usuarios
- 📝 **Registro** — alta de nuevos usuarios
- 🔍 **Búsqueda** — búsqueda de productos
- 🛒 **Carrito de compra** — agregado y gestión de productos
- 📦 **Envío** — proceso de checkout y envío

---

## 🛠️ Tecnologías utilizadas

- **C#** (.NET)
- **Selenium WebDriver**
- **Page Object Model (POM)** como patrón de diseño
- **ChromeDriver** (gestión centralizada vía factory)

---

## 📂 Estructura del proyecto

```
PracticaAutBookCart/
├── PracticaAutBookCart.sln
└── PracticaAutBookCart/
    ├── Genericos/
    │   └── DriverConfig/
    │       └── ChromeFactory.cs        # Configuración e inicialización del driver
    ├── PageObject/
    │   ├── BasePage.cs                 # Métodos y elementos comunes a todas las páginas
    │   ├── InicioPage.cs
    │   ├── LoginPage.cs
    │   ├── RegistroPage.cs
    │   ├── BusquedaPage.cs
    │   ├── CarritoPage.cs
    │   └── EnvioPage.cs
    ├── PracticaAutBookCart.csproj
    └── Test/
        ├── BasePrueba.cs                # Configuración base de los tests
        ├── InicioPrueba.cs
        ├── LoginPrueba.cs
        ├── RegistroPrueba.cs
        ├── BusquedaPrueba.cs
        ├── CarritoPrueba.cs
        └── EnvioPrueba.cs
```

---

## 🧩 Patrón de diseño: Page Object Model

Cada página de la aplicación tiene su propia clase dentro de `PageObject/`, que encapsula:
- Los localizadores de los elementos web
- Las acciones que se pueden realizar sobre esa página

Los tests, dentro de `Test/`, consumen estas clases para mantener el código de prueba limpio, legible y fácil de mantener — separando la lógica de interacción con la UI de la lógica de validación.

---

## ▶️ Cómo ejecutar el proyecto

1. Cloná el repositorio:
   ```bash
   git clone https://github.com/AlvaradoM02/PracticaAutBookCart.git
   ```
2. Abrí la solución `PracticaAutBookCart.sln` en Visual Studio.
3. Restaurá los paquetes NuGet del proyecto.
4. Ejecutá los tests desde el **Test Explorer** de Visual Studio, o vía consola con:
   ```bash
   dotnet test
   ```

> **Requisitos:** .NET SDK instalado y Google Chrome (el proyecto usa ChromeDriver vía `ChromeFactory`).

---

## ✅ Alcance de las pruebas

Los casos de prueba cubren los flujos funcionales principales de la aplicación: navegación desde la página de inicio, registro y login de usuarios, búsqueda de productos, agregado al carrito y proceso de envío/checkout.

---

## 👩‍💻 Autora

**AlvaradoM02** — QA Specialist | Test Automation

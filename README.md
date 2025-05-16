# ⌚ ASP.NET Core MVC - Individual Assignment

This is an individual assignment for building a simple ASP.NET Core MVC application. The purpose is to demonstrate the use of models, services, views, form handling, and validation in an MVC web application.

## 📌 Assignment Goals

The application is built following the requirements specified in the course material. It demonstrates the core concepts of ASP.NET Core MVC by implementing the following features:

### ✅ Features

1. **ASP.NET Core MVC application**
   - Based on the **"ASP.NET Core Empty"** project template in Visual Studio.

2. **Domain Model**
   - The application revolves around a single entity: for example, **watches** (or cars, bands, etc.).
   - The model contains basic properties (e.g., name, description, price, reference number).

3. **Service Class**
   - All data is stored in-memory using a list inside a **service class**.
   - No database is used in this assignment.

4. **Entity List Page**
   - A page displays a list of all created entities (e.g., all watches).

5. **Create Form**
   - A form allows the user to create and add a new entity to the list.

6. **Server-side Validation**
   - Form validation is implemented using **data annotations** in the model.
   - Validation is enforced with `ModelState.IsValid` in the controller.

7. **Redirection After Submit**
   - Upon successful form submission, the user is redirected back to the list view.

---

## 🛠️ Technologies Used

- ASP.NET Core 8.0 MVC
- C#
- Razor Views
- Bootstrap 5 (for styling)
- Visual Studio 2022+





# ASP.NET Core MVC: Logging, Validation & AutoMapper Demo

## Overview
This is a hands-on ASP.NET Core MVC project designed to demonstrate professional application patterns, including:

- **Structured logging** with [Serilog](https://serilog.net/)
- **Model validation** with [FluentValidation](https://docs.fluentvalidation.net/en/latest/)
- **Object mapping** between layers with [AutoMapper](https://automapper.org/)
- **Dependency Injection** for clean, testable code
- **Separation of concerns** using ViewModels, Entities, and DTOs

The project simulates a **user registration flow** where a user submits a form, the input is validated, mapped to a domain entity, and finally presented as a response DTO.

---

## Project Structure

/Models
/ViewModels
UserRegisterViewModel.cs
/Entities
User.cs
/DTOs
UserResponseDto.cs
/Validators
UserRegisterValidator.cs
/Mappings
UserProfile.cs
/Controllers
AccountController.cs
/Views
/Account
Register.cshtml
Success.cshtml
Program.cs


---

## Features Implemented

1. **Serilog Logging**
   - Logs HTTP requests and custom events
   - Rolling log files stored in `/Logs`

2. **FluentValidation**
   - Validates user registration form fields
   - Automatic server-side validation integrated with MVC

3. **AutoMapper**
   - Maps `UserRegisterViewModel` → `User` → `UserResponseDto`
   - Demonstrates separation of layers and clean architecture

4. **MVC Best Practices**
   - Strongly-typed views
   - ViewModel for input, DTO for output, Entity for domain

---

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/<your-username>/AspNetCore-MVC-Logging-Validation-Mapping.git
cd AspNetCore-MVC-Logging-Validation-Mapping

2. Restore packages:
```bash
dotnet restore

3.Run the project:
```bash
dotnet run

4. Open your browser and navigate to `http://localhost:5000/Account/Register`
5.Submit the form to see logging, validation, and AutoMapper in action.

---

## Acknowledgements

- Serilog for structured logging

- FluentValidation for model validation

- AutoMapper for object-to-object mapping

- Microsoft ASP.NET Core MVC for the web framework

---

## License

This project is for educational and demonstration purposes.
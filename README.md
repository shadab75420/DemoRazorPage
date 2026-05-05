# DemoRazorPage

A simple ASP.NET Core Razor Pages application demonstrating GET and POST form handling.

---

## Overview

This project demonstrates how to:

* Handle GET requests using query parameters
* Handle POST requests using form submission
* Use model binding in Razor Pages
* Display user input dynamically on the same page

---

## Technologies Used

* ASP.NET Core Razor Pages
* C#
* .NET 6/7
* HTML

---

## Features

* GET form example (search functionality)
* POST form example (data submission)
* Model binding using BindProperty
* Clean and simple UI
* Runs on HTTP to avoid SSL certificate issues

---

## Project Structure

```
DemoRazorPage/
│
├── Pages/
│   ├── Index.cshtml
│   ├── Index.cshtml.cs
│   ├── Privacy.cshtml
│   └── Shared/
│
├── wwwroot/
├── appsettings.json
└── Program.cs
```

---

## How to Run

1. Open the project in Visual Studio or VS Code
2. Build the project
3. Run the application
4. Open a browser and navigate to:

```
http://localhost:5000
```

---

## How It Works

### GET Example

* User enters a name in the input field
* Data is sent via URL query string
* Bound using SupportsGet = true
* Displayed on the page

### POST Example

* User submits form data
* Data is sent in request body
* Bound using BindProperty
* Processed in OnPost method
* Displayed on the page

---

## Key Concepts

* Razor Pages lifecycle (OnGet, OnPost)
* Model Binding
* Form handling in ASP.NET Core
* Difference between GET and POST requests

---

## Future Improvements

* Add validation
* Connect to database
* Display submitted data in a table
* Add styling using CSS or Bootstrap



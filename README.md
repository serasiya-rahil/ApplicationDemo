# Height & Temperature Converter

This project is a web application that converts:
- **Height** from centimeters (cm) to meters (m), inches (in), and feet (ft).
- **Temperature** from Celsius (°C) to Fahrenheit (°F).

The application follows the **Model-View-Controller (MVC)** architecture to ensure separation of concerns and maintainable code.

## Features
- **Height Converter**: Input a height in centimeters, and the app will convert it into meters, inches, and feet.
- **Temperature Converter**: Input a temperature in Celsius, and the app will convert it into Fahrenheit.
## Table of Contents
- [Technologies Used](#technologies-used)
- [Architecture (MVC)](#architecture-mvc)

## Technologies Used
- **Frontend**: HTML, CSS, JavaScript
- **Backend**: [Programming Language] (e.g., Python, Node.js)
- **Framework**: [Specify any framework if used, e.g., Flask, Django, Express]
- **Version Control**: Git & GitHub

## Architecture (MVC)

- **Model**: The business logic for height and temperature conversion. The model handles the conversion formulae:
  - Height:
    - 1 cm = 0.01 meters
    - 1 cm = 0.3937 inches
    - 1 cm = 0.0328 feet
  - Temperature:
    - °F = (°C × 9/5) + 32
- **View**: Responsible for the user interface, where users input the values to be converted and see the results.
- **Controller**: Acts as an intermediary between the View and the Model. It processes user inputs and updates the View with the results from the Model.

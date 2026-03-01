# Interest Calculator (C# WinForms)

## Description

This is a simple compound interest calculator developed in C# using Windows Forms.

I built this project independently to practice:
- Variables and data types (double, int)
- Loops (for)
- Methods
- Event handling
- Basic financial calculations

The application allows the user to calculate the final value of an investment based on compound interest.



## How It Works

The program calculates compound interest using the following formula:

Final Value = Initial Amount × (1 + r)^t

Where:
- r = annual interest rate (as decimal)
- t = number of years

Instead of using the power formula directly, the program applies a loop to simulate year-by-year growth:

Each year:
    total += total * interestRate

This approach was chosen to practice loops and iterative logic.


## Inputs

- Initial Amount (€)
- Annual Interest Rate (%)
- Investment Period (years)



## Outputs

- Total Profit
- Final Value

---

## Technologies Used

- C#
- .NET
- Windows Forms


## Purpose

This project was created as part of my learning journey in software development.
It represents my first structured financial application and a step towards more advanced fintech-oriented projects.

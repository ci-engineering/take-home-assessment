# Backend Take-home Asessment

## The Assignment:

One of Coterie's core backend projects is our insurance quote rating engine and API. You'll use an Excel sheet to create a simplified rating engine and quote API.

In this repo is an Excel sheet (Mini_Rater.xlsx) with a simplified insurance rating algorithm. Your job is to translate that into a C# .NET Core API.

The cells shaded blue represent inputs that the API should take in as a JSON payload. Cells B6 through B9 each have a formula to be implemented to calculate their value (or they contain a hardcoded value). The tables to the right show the possible states and business inputs and their associated values. Cell B11 has a formula which is used to calculate the Total Premium, which is the result that the API should return.

## Time:

Carve out 3-4 hours and create an API endpoint. We hope you can spend 3-4 hours on this project. If you can finish faster — great! If not, limit yourself and do not spend longer than 4 hours MAX.

## Assessment Requirements

- Create a new public GitHub repo 
- Create a new controller that will:
    - Accept the payload described below.
    - Return the response model described below.
    - Utilize a service that functions in accordance to the Business rules stated below
- Repo README has instructions for running and testing the API (basic instructions only, nothing too involved)
- Unit tests are required (We have provided some sample tests if you have not used NUnit/Moq before) and provided links to their documentation and usage.

## Business rules:

- State abbreviation and full state name is allowed. 
    - When given full state name, convert to abbreviation in response
- Calculate premium for each state for the given business and revenue amount
- Only Plumber, Architect, and Programmer are supported values for business value
- Only Texas, Florida, and Ohio are supported values for states
    - If one value is not supported, then treat the entire request as invalid.

## Request/Response criteria

Example Request: If the API receives a payload of:

```json
{
  "business": "Plumber",
  "revenue": 6000000,
  "states": [
    "TX",
    "OH",
    "FLORIDA"
  ]
}
```

Example Response: It should respond with a payload of:

```json
{
  "business": "Plumber",
  "revenue": 6000000,
  "premiums": [
    {
      "premium": 11316,
      "state": "TX"
    },
    {
      "premium": 12000,
      "state": "OH"
    },
    {
      "premium": 14400,
      "state": "FL"
    }
  ],
  "isSuccessful": true,
  "transactionId": "27373db4-56c3-4383-a2e1-f55c77b4aa3f"
}
```

## Boiler plate code:

We have provided you with boiler plate code and project set up so you can focus on solving the actual technical challenge. You may start your own, but please ensure to include unit tests.

Boiler plate code is using [****.NET 5.0****](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

A global error handler has been set up in this project. Feel free to use or modify how you see fit.

Note: Test Controller, Service, and Unit Tests are provided as examples only and do not contain any “hints”.


## Evaluation Criteria:

Once your project is submitted to the recruiter, we have an internal team review the code and run the project locally and test via Postman. We are mainly taking into consideration the following criteria:

- If the business rules are implemented correctly and rating is working properly.
- Best practice / industry standards and REST guidelines when building your endpoint.
- The quality of automated unit tests. There is an expectation the code will have some degree of code coverage in your project. The boiler plate project includes the unit test framework and Moq setup.
- Code organization and structure.

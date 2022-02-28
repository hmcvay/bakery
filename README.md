# Pierre's Bakery

#### View Bread and Pastry prices and specials, add them to your order, and see a total price.

#### By Hayley McVay

## Technologies Used

- C#
- .NET 5.0
- MSTest
- dotnet script REPL
- git
- VSCode

## Description

Use the console application to view special pricing for Bread and Pastries at Pierre's Bakery. User is able to input the number of items they wish to purchase and the price is returned.

## Setup/Installation Requirements

- Clone the Repository
- [Install .NET 5 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer)
- Use your terminal to navigate to the top level of this directory
- Run `dotnet restore` to restore all dependencies
- Run `dotnet build`
- Navigate to "Bakery.Tests" directory
- Run `dotnet test` to ensure all code is passing
- Navigate to "Bakery" directory
- Run `dotnet run` to launch console application

## Known Bugs

- There is a warning when you run the app due to an async function that lacks await. This is so that I can have a function, `Start()` that loops through the console app when called, that can *also* access local variables for price to display a Grand Total; when `Start()` was static, it could not access price variables.

The async function lacking await does not interfere with functionality of the code at the present moment, though could prove to be an issue if this project were continued and expanded.

## License

[ISC](https://opensource.org/licenses/ISC)

## Contact Information

Hayley McVay 
https://github.com/hmcvay
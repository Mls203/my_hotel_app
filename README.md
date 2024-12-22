 #HotelApp
 
 The goal is to use a **hotels.json** file to display hotel names and details to users through a web interface.

## Features

- **GET /api/hotels**: Displays a list of hotels.
- **GET /api/hotels/{id}**: Retrieves detailed information about a specific hotel.
- First page: A listing page displaying hotel names (data is fetched from the JSON file via API).
- Second page: A detail page showing detailed information about the selected hotel.

## Technologies Used

This project uses the following technologies and tools:

- **ASP.NET MVC Web API**
- **C#**
- **HTML**
- **CSS**
- **Bootstrap**
- **JavaScript**
- **jQuery (Ajax)**

## Requirements

To run this project locally, you will need the following:

- Visual Studio (or a compatible IDE)
- .NET Framework or .NET Core SDK
- **NuGet Packages** (Included in the project; you can restore missing packages via NuGet Restore)

## About the JSON File

The **hotels.json** file used in this project contains hotel information and is located in the **App_Data** folder. This file is used to fetch hotel names and details via the API.

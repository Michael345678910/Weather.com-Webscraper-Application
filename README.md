# Weather Scraper Application in C#

# Overview:

This project is a weather data scraper developed in C# that displays its results in the console. When the project is run, it extracts the current temperature, weather conditions, and the city/state name from Chicago, IL off Weather.com. The application uses the HtmlAgilityPack library to parse HTML documents from the web, making HTTP requests to fetch the data. This project showcases my ability to programmatically obtain real-time data from the web using web scraping techniques, specifically by fetching current weather details with C#.

# Features:
-	Retrieve specified weather conditions from Weather.com. Including current temperature, weather conditions (such as "Rain", "Sunny", "Cloudy", etc.) and the city name and state abbreviation. outputting both the.
-	Allows the user to easily view the fetched weather data directly in the console.

## Technologies Used:
-	C#
-	HtmlAgilityPack
-	.NET Libraries

# Usage Instructions:

## Installation & Setup:
1.	Clone this repository to your local machine. This project was made using C# 12, thus ensure that is installed inside alongside a runnable IDE (Such as Visual Studio Community 2022).
2.	If not already installed to your IDE, download and add HtmlAgilityPack to your project. This can be done via NuGet Package Manager (see instructions below):
-	Go to Tools -> Then click NuGet Package Manager -> Then click Manage NuGet Packages for Solution.
-	Next search for "HtmlAgilityPack" and wait till it has finished installing to the project.
3.	There are no additional downloads/libraries required; just compile and run the “Program.cs” file directly.

## Running the Main Program:
1.	After the Program.cs file has been ran and compiled, the application will automatically fetch weather details from the specified URL (https://weather.com/weather/today/l/4c9ff75840c6ce23fa10812d0f14b605af47896e9ca3fd59abdb9edd1b9d486a).
2.	The output will then display in the console, and will allow you to view the temperature, weather conditions, and city/state details.

## How It Works:
-	The program utilizes HttpClient to perform a GET request and retrieve the HTML content.
-	Then it parses the HTML document to extract specific elements such as temperature and weather conditions using XPath queries.
-	The extracted weather and location data is then displayed in the console for quick and easy reference.

# Contributing to the Codebase:
Contributions are welcome! Feel free to fork the repository, make improvements, add new features, or submit bug fixes via pull requests. Please ensure your changes align with the project's goals and maintains coding standards.

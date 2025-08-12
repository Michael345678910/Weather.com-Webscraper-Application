using HtmlAgilityPack; // Library for parsing HTML documents
using System;          // Provides basic functionalities
using System.Dynamic;
using System.Net.Http; // Enables HTTP requests

namespace WebScraperApp
{
    class Program
    {
        static void Main(String[] args)
        {
            // URL of the weather page on weather.com for specific location
            string url = "https://weather.com/weather/today/l/4c9ff75840c6ce23fa10812d0f14b605af47896e9ca3fd59abdb9edd1b9d486a";

            // Initialize HttpClient to send HTTP requests
            var httpClient = new HttpClient();

            // Send a GET request asynchronously and wait for the response content as a string
            var html = httpClient.GetStringAsync(url).Result;

            // Load the HTML content into an HtmlDocument object for parsing
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            //Event: Get the temperature from the specific cities URL webpage off of Weather.com:

            // Select the HTML node that contains the current temperature using XPath
            var temperatureElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='CurrentConditions--tempValue--zUBSz']");
            // Extract and trim the temperature text
            var temperature = temperatureElement.InnerText.Trim();

            // Output the temperature to the console
            Console.WriteLine("Temperature: " + temperature);

            //Event: Get the Weather Conditions (Rain, Sunny, Cloudy, ETC.) from the specific cities URL webpage off of Weather.com:

            // Select the HTML node that contains the weather conditions phrase
            var conditionElement = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue---VS-k']");
            // Extract and trim the conditions description
            var conditions = conditionElement.InnerText.Trim();

            // Output the weather conditions to the console
            Console.WriteLine("Weather Conditions: " + conditions);

            //Event: Get the city name and state abbreviation from the specific cities URL webpage off of Weather.com:

            // Select the HTML node that displays the location (city name)
            var cityElement = htmlDocument.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--yub4l']");
            // Extract and trim the city name
            var city = cityElement.InnerText.Trim();

            // Output the city name
            Console.WriteLine("City: " + city);
        }
    }
}
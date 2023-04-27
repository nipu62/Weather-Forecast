# Weather-Forecast
A web MVC (Model-View-Controller) application to check weather forecast of given locations using C# and .Net 6.0 Framework in the backend; HTML, CSS and JavaScript in the Frontend.

**Project Setup**: 
- Step 1: Download the project and go inside the "WeatherForecast" folder and click on the WeatherForecast.sln file to load the full project with dependencies.
- Step 2: Create an account https://www.weatherapi.com/ and collect the API key to use in the program.
- Step 3: Go to WeatherForecast-> WebServices -> WeatherAPI.cs and change the value of **apiKey** with your generated key.
- Step 4: By default the program is running in the ssl port 44383. If you want to change the default port, go to WeatherForecast -> Properties -> launchSettings.json and change with your desired one. 
- Now build and run the program to get the weather forecast for given locations. 

Here are a few snaps of the application. In the homepage, it displays 14 days weather forecast for Austin TX, Reno NV and Tampa FL.

![Austin TX](https://user-images.githubusercontent.com/28857032/234739254-83bb87b2-2ab3-4171-95e1-4414af5bcf7a.jpg)

![Reno NV](https://user-images.githubusercontent.com/28857032/234739314-225142cf-a843-46f4-8f6f-f317ae47bb32.jpg)

![Tampa FL](https://user-images.githubusercontent.com/28857032/234739331-8cfe1f6c-5512-419c-97b8-8120185c2c1a.jpg)

User can search for current weather by providing the city name or zip code in the "Search Weather" page. 

![Search Weather](https://user-images.githubusercontent.com/28857032/234739367-73c081e6-0fdb-4be0-9570-b0a47f7d01a8.jpg)

Detailed weather forecast along with the current weather information for the search location.

![Search Result](https://user-images.githubusercontent.com/28857032/234739397-2ef6ed92-923b-4db0-8270-c8936c0e8a2b.jpg)

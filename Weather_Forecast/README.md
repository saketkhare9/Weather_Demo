# Default-Weather-Forecast-BlazorWasm-WebApi-MudBlazor
- [Defaut Weather Forecast API consumed by Blazor Web Assembly](#Default-Weather-Forecast-BlazorWasm-WebApi-MudBlazor)
  - [WeatherApp.Api](#weatherapp.api)
    - [Weather API response](#weather-api-response)
  - [WeatherApp.Web](#WeatherApp.Web)

## WeatherApp.Api
```js
GET {{host}}/WeatherForecast
```
### Weather API response
```json
[
  {
    "date": "2022-11-27",
    "temperatureC": 20,
    "temperatureF": 67,
    "summary": "Warm"
  },
  {
    "date": "2022-11-28",
    "temperatureC": 27,
    "temperatureF": 80,
    "summary": "Chilly"
  }
 ]
```
## WeatherApp.Web

Default fetch:

<img width="878" alt="weatherapi-default" src="https://user-images.githubusercontent.com/68436256/204088269-5ed7592c-197a-483a-b5bf-e01ffcf29033.png">

Using MudBlazor table:

<img width="1265" alt="weatherapi-tabular" src="https://user-images.githubusercontent.com/68436256/204088291-6a0e8833-353c-4356-a5ba-801cd340a5e4.png">

Using MudBlazor Card (Switch):

<img width="1249" alt="weatherapi-card-1" src="https://user-images.githubusercontent.com/68436256/204088295-6d57f758-fcd1-423d-9167-c31de408c408.png">

<img width="1258" alt="weatherapi-card-2" src="https://user-images.githubusercontent.com/68436256/204088297-2dd3aa3a-b104-415c-b262-00437c70177b.png">

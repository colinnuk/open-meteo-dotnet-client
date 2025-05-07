
# 🌡️🌤️ Open-Meteo Dotnet Cleint SDK Library
[![build and test](https://github.com/colinnuk/open-meteo-dotnet-client/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/colinnuk/open-meteo-dotnet-client/actions/workflows/build-and-test.yml)
[![GitHub license](https://img.shields.io/github/license/colinnuk/open-meteo-dotnet-client)](https://github.com/colinnuk/open-meteo-dotnet-client/blob/master/LICENSE)
[![Nuget](https://img.shields.io/nuget/v/openmeteo.dotnet)](https://www.nuget.org/packages/OpenMeteo.dotnet)

A  dotnet 8 library for the [Open-Meteo](https://open-meteo.com) API.
Forked from [https://github.com/AlienDwarf/open-meteo-dotnet](https://github.com/AlienDwarf/open-meteo-dotnet)

## ❕ Information

Support for:
- Almost all the OpenMeteo weather models (as of May 2025)
- Using OpenMeteo with an API key
- dotnet 8 (and above)
- Specific client lobrary Exceptions can be thrown
- Possible to register any custom logger in the Client SDK via the `IOpenMeteoLogger` interface

## 🔨 Installation/Build

### NuGet
[NuGet Package](https://www.nuget.org/packages/OpenMeteo.dotnet.client.sdk/)

Use NuGet Package Manager GUI. Or use NuGet CLI:

```bash
dotnet add package OpenMeteo.dotnet.client.sdk
```

## 💻 Usage

### Minimal:
```cs
using OpenMeteo;

static void Main()
{
    RunAsync().GetAwaiter().GetResult();
}

static async Task RunAsync()
{
    // Before using the library you have to create a new client. 
    // Once created you can reuse it for every other api call you are going to make. 
    // There is no need to create multiple clients.
    OpenMeteo.OpenMeteoClient client = new OpenMeteo.OpenMeteoClient();

    // Make a new api call to get the current weather in tokyo
    WeatherForecast weatherData = await client.QueryAsync("Tokyo");

    // Output the current weather to console
    Console.WriteLine("Weather in Tokyo: " + weatherData.Current.Temperature + weatherData.CurrentUnits.Temperature);
    
    // Output: "Weather in Tokyo: 28.1°C
}
```

## License

This project is open-source under the [MIT](https://github.com/colinnuk/open-meteo-dotnet-client/blob/master/LICENSE) license.

## Appendix

This library uses the public and free available [Open-Meteo](https://open-meteo.com) API servers.
See also:
- [omgo - Open Meteo SDK written in Go ](https://github.com/HectorMalot/omgo)
- [OpenMeteoPy](https://github.com/m0rp43us/openmeteopy)
- [Open-Meteo Kotlin Library](https://github.com/open-meteo/open-meteo-api-kotlin)
- [https://github.com/AlienDwarf/open-meteo-dotnet](https://github.com/AlienDwarf/open-meteo-dotnet)


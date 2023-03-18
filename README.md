# LogHive.SDK.CSharp
This c# libary is a SDK for the LogHive event and log service. 
LogHive is a log and event service specifically designed for software applications such as apps, websites, or services.
With LogHive, push notifications can be sent to the web browser or to a mobile device, or the log messages can be analyzed in a separate dashboard.

Checkout the NuGet Package: [![NuGet](https://img.shields.io/nuget/v/LogHive.svg)](https://www.nuget.org/packages/LogHive)

Licence: MIT

## Compatibility
The library is written in:
[![.NET Version](https://img.shields.io/badge/.NET6.0-blue)](https://shields.io/)
[![.NET Version](https://img.shields.io/badge/.NETStandard2.1-blue)](https://shields.io/)

# Contents
1. [General](#general)
2. [Requirements](#requirements)
3. [Documentation](#documentation)
4. [Usage](#usage)

## General
Integration is very easy, a simple REST command is all that's needed to store your event in our database.
This libary packs the http client into a nuget package. So you can push an event with just two lines of code.

## Requirements
To use this API you need an API key.  You can register for a free API key at [https://app.loghive.app](https://app.loghive.app).

## Documentation
A full documentation is available under [https://docs.loghive.app/](https://docs.loghive.app/).

## Usage
With the following code, you init the http client with your personal API key:
```c#
var logger = new LogHiveApi("your-api-key");
```

### Push an Event
```c#
var notification = false;
var response = await logger.AddEventAsync("yourprojectname", "yourgroupname", "your-event-name", "descripton", notification);
```

### Set a Insight
```c#
var response = await logger.AddInsightAsync("yourprojectname", "insightname", 10);
```

### Set Online State
```c#
var response = await logger.SetSystemOnlineAsync("yourprojectname", "systemname");
var response = await logger.SetSystemOfflineAsync("yourprojectname", "systemname");
```
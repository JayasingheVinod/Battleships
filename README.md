# Battleship | VOICEIQ #

Simple version of the game Battleships allowing a single human player to play a one-sided game of Battleships against ships placed by the computer.

This is a solution for creating a Single Page App of Battleship Game (SPA) to VOICEIQ with HTML, CSS, Bootstrap, Javascript and ASP.NET Core 3 following the principles of Clean Architecture.

## Technologies
* .NET Core
* ASP .NET Core
* HTML, CSS, Bootsrap
* Javascript, jQuery

## Overview

### Domain

This will contain all entities, exceptions and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### WebUI

This layer is a single page application based on HTML, CSS, Bootsrap, Javascript, jQuery and ASP.NET Core. This layer depends on both the Application layer.


##  Build and run

###  Visual Studio
Visual Studio 2019 If you are using Visual Studio 2019 on a Microsoft environment , open the solution file in the source directory, (Battleships.sln) and run the build. The nuget packages (NUnit,... ext) should auto restore.

###  Visual Studio Code
It is a simple .NET Core app therefore all you have to do to run it locally is to run build
```bash
> dotnet build
```

and then run local web server
```bash
> dotnet run --project Battleships.Web
```


# OSCON 2015 - Introduction to .NET Core & ASP.NET Core

1. Acquire & install (Windows, OS X, VS, VS Code, etc.)
  1. .NET Core SDK
  1. VS Code
  1. OmniSharp plug-in
  1. VS2015 Update 2
  1. VS2015 tools Preview 1
1. Write our first app (Hello World of course!)
  1. mkdir -> dotnet new -> dotnet run
  1. dotnet ./output.dll
  1. demo use of dotnet build/run (e.g. change file, dotnet run, builds, etc.)
1. Turn it into Hello World web app
  1. Add kestrel package
  1. Use WebHostBuilder to boot with inline middleware to reply
1. Add console logging so we can see what we're doing set to debug level
1. Serve static files by adding pre-built middleware
  1. Add static files package
  1. Create wwwroot/hello.html
1. Add an API that returns an object
  1. Add MVC package
  1. Add MVC services
  1. Add MVC middleware
  1. Add Controllers/HelloController.cs
  1. Use POSTMAN to see it come back as JSON
1. Let's build an Attendee List app
1. Build our model: Models/Attendee.cs
1. Add EF for persistance
   1. Add EF in-memory package
   1. Add EF services
   1. Add Data/WorkshopContext.cs
     1. Add Attendee DbSet property
1. Add Controllers/AttendeesApiController.cs
  1. Add Get API
  1. Use POSTMAN to call it, no result yet
  1. Add Create API
  1. Use POSTMAN to call it, create record, then query it again
1. Use POSTMAN to use the API, create and see attendees
1. Let's add some UI to show and delete attendees
  1. Add a TypeScript file: wwwroot/app.ts
  1. Add a tsconfig.json to the root of the project
  1. Add a reference to the
1. Change to SQL Lite
1. Set up configuration to flow the connection string to SQL Lite
  1. Read from appsettings.json
  1. Read from environment variables
  1. Demonstrate overriding the configuration value in the file from the environment variables
1. Add a required attribute to the model
1. Attempt to POST an invalid attendee and see the 500 response
1. Add Diagnostics page middleware to show in Development environment to aid in debugging via response
1. Set the environment to Development: `ASPNETCORE_ENVIRONMENT=true` env var
1. Attempt to POST invalid attendee again and this time see error page
1. Add some code to turn validation errors into 400 responses: `BadRequest(ModelState)`
1. Preparing the app for deployment with `dotnet publish`
1. Modify the app to display details of the current OS on the home page (via an API & JS call)
1. Publish the app to a USB key (from OS X)
1. Run the app from the USB key on another machine (e.g. on Windows)

## Links
- https://microsoft.com/net
- https://docs.asp.net
- https://code.visualstudio.com

## Extra topics if we have time
- Dependency Injection
- Server-side rendering with Razor
- Using `dotnet watch` via `Microsoft.DotNet.Watcher.Tools` (currently broken)
- Deploy to azure

# Secure login with React and .NET Core Rest API

This little project consists in a Login WebApp done in React that comunicates with an API to do some stuff, like reading or deleting user, if you are authenticated.

The .NET Core API uses features like:
* Entity Framework Core
* Migrations
* Authenticate API Methods
* JWT (Json Web Token) Bearer
* AutoMapper with custom profiles
* Custom exceptions
* Secure Hash Algorithm and Salt for stored passwords.
* AppSettings secrets
* Full validation at EF Core level

The React app uses the following features:
* Managed state trough Redux
* WebPack Server
* JWT Storage
* API calls made with fetch()

To run this proyect you need to:
* Create your own migration on the .NET Core proyect trough the PM Console:<br/>
  `Add-Migration {yourMigrationName}`<br/>
  `update-database`<br/>
  Don't forget to update the connection string under app.settings.json !
* A localhost instance with the API running.
* Add the localhost url in WepPack.config:<br/>
  `config: JSON.stringify({
            apiUrl: '{yourUrl}'
        })`
* Run the react app :D

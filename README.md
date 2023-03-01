# BostonOptics(E-Commerce)
A Sample N-layered .NET Core Project demonstrating Clean Architecture and the Generic Repository Pattern.

## Migrations
### Infrastructure
Firstly, set the project "Web" as startup project.
Secondly, choose infrastructure on package manager console.
```
Add-Migration InitialCreate -context ShopContext -o Data/Migrations 
Update-Database -context ShopContext

Add-Migration InitialCreate -context AppIdentityDbContext -o Identity/Migrations 
Update-Database -context AppIdentityDbContext
```

## Packages Installed
### ApplicationCore
```
Install-Package Ardalis.Specification -v 6.1.0
```

### UnitTests
```
Install-Package Moq
```
### Infrastructure
```
Install-Package Microsoft.EntityFrameworkCore -v 6.0.14
Install-Package Microsoft.EntityFrameworkCore.Tools -v 6.0.14
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -v 6.0.8
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.14
Install-Package Ardalis.Specification.EntityFrameworkCore -v 6.1.0
```
### Web
```
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.14
Install-Package Microsoft.AspNetCore.Identity.UI -v 6.0.14
Install-Package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore -v 6.0.14
Install-Package Microsoft.EntityFrameworkCore.Design -v 6.0.14
```

## Useful Links
### Resources
https://codepen.io/yigith/pen/PoOrWjX
https://getbootstrap.com/docs/5.2/examples/checkout/
### Documantation
https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/ 

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-6.0
### Github:https:
//github.com/dotnet-architecture/eShopOnWeb 
### E-book
https://aka.ms/webappebook

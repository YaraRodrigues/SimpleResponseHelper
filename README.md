# SimpleResponseHelper

### Description
Offers a simple interface to manage responses from the domain layer to the presentation layer

### Versions
*  1.0.0 (Latest/Stable)

### When should I use?
Use when you want to handle responses from the domain or application layer of your system and present them in the presentation layer

### How to use (Implementation suggestion)
A suggestion to implement in your application, you should run an instance of the "Response" class at your application tier and perform the necessary handling of your business rules flow. When returning to the presentation layer, you can extend the ApiController controller and use the "SimpleResponse" methods to obtain an "IActionResult" based on the "IsSuccess" parameter, or if you prefer a more elaborate response, use "HttpResponse", which will take taking into account the HTTP status code, entered in the "HttpCode" attribute of the instantiated object of the "Response" class.

### Examples

### How to install
*  Package Manager
      *  `Install-Package BasicResult_SimpleResponse_Helper -Version 1.0.0`
*  .NET CLI
      *  `dotnet add package BasicResult_SimpleResponse_Helper --version 1.0.0`
*  Package Reference (copy this XML node into the project file to reference the package)
      *  `<PackageReference Include="BasicResult_SimpleResponse_Helper" Version="1.0.0" />`

### Depedencies
*  Microsoft.AspNetCore.Mvc.Core (>= 2.2.5)

### See More 
https://www.nuget.org/packages/BasicResult_SimpleResponse_Helper/1.0.0#

### Author 
Henrique Matias

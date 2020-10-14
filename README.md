# SimpleResponseHelper

### Description
Offers a simple interface to manage responses from the domain layer to the presentation layer

### Release Notes
*  1.0.1 - Added class to assist in api controllers

### Versions
*  1.0.1 (Latest/Stable)
*  1.0.1 (Deprecated)

### When should I use?
Use when you want to handle responses from the domain or application layer of your system and present them in the presentation layer

### How to use (Implementation suggestion)
A suggestion to implement in your application, you should run an instance of the "Response" class at your application tier and perform the necessary handling of your business rules flow. When returning to the presentation layer, you can extend the ApiController controller and use the "SimpleResponse" methods to obtain an "IActionResult" based on the "IsSuccess" parameter, or if you prefer a more elaborate response, use "HttpResponse", which will take taking into account the HTTP status code, entered in the "HttpCode" attribute of the instantiated object of the "Response" class.

### Examples
![Success Test](https://github.com/hm-henriquematias/SimpleResponseHelper/blob/main/demo/images/SuccessTest.png?raw=true)  
![Error Test](https://github.com/hm-henriquematias/SimpleResponseHelper/blob/main/demo/images/ErrorTest.png?raw=true)  
![Test basead on http code](https://github.com/hm-henriquematias/SimpleResponseHelper/blob/main/demo/images/BaseadOnHttpCodeTest.png?raw=true)  


### How to install
*  Package Manager
      *  `Install-Package BasicResult_SimpleResponse_Helper -Version 1.0.1`
*  .NET CLI
      *  `dotnet add package BasicResult_SimpleResponse_Helper --version 1.0.1`
*  Package Reference (copy this XML node into the project file to reference the package)
      *  `<PackageReference Include="BasicResult_SimpleResponse_Helper" Version="1.0.1" />`

### Depedencies
*  Microsoft.AspNetCore.Mvc.Core (>= 2.2.5)

### See More 
https://www.nuget.org/packages/BasicResult_SimpleResponse_Helper/1.0.1#

### Author 
Henrique Matias


Medium publication - [ASP.NET Core Token Service Starter Kit](https://medium.com/scrum-and-coke/asp-net-core-token-service-starter-kit-f63bfdc0bbde)

## Install the dotnet new template
dotnet new -i Skoruba.IdentityServer4.Admin.Templates::2.0.1

## Create new project
dotnet new skoruba.is4admin --name TokenService --title TokenService --adminemail "admin@example.com" --adminpassword "Pa$$word123" --adminrole STSAdminRole --adminclientid STSAdminUIClientId --adminclientsecret MyClientSecret --dockersupport true

## Project URL localhost and Azure
### TokenProject.Admin 
https://localhost:44303 
https://cat-token-admin.azurewebsites.net

### TokenProject.Admin.Api
https://localhost:44302
https://cat-token-adminapi.azurewebsites.net

### TokenProject.STS.Identity
https://localhost:44310
https://cat-token-identity.azurewebsites.net
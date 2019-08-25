# net-core-template
Set up for .net core with Visual Studio Code configuration using Docker SQLServer image

# Set Up

## Must have
- Docker
- Visual Studio Core
- .NET Core SDK 2.2

## Create project
`dotnet new webapi -o ${your_proj_name}`

## Adding Packages
- `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.6`
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 2.2.6`
- `dotnet add package MySql.Data.EntityFrameworkCore -v 8.0.17`

## Docker Set Up

### Step 1: Download sql server image
`sudo docker pull mcr.microsoft.com/mssql/server:2017-latest`

### Step 2: Execute the image
`sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong@Passw0rd>" \
   -p 1433:1433 --name sql1 \
   -d mcr.microsoft.com/mssql/server:2017-latest`

checkout if the image was correctly setted up with `docker ps -a` and check the port, make sure it is the same port specified in the file `appsettings.json`

## Run the project

In VSCode: `^ + fn + F5`

On project root: 
`dotnet ef migrations add ${your_db_name}`
`dotnet ef database update`

Check the database if the tables were created

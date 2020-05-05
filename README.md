# sample-windows-forms
Windows forms with dependency injection

## Solution sctruture

```text
1 - Presentation
    Mpc.WinFormsIoC.Presentation                (Windows Forms App - .Net Framework 4.7.1)
    Mpc.WinFormsIoC.WebApi                      (Asp.Net Core Web Application - .Net Core 2.1)
2 - Application
    Mpc.WinFormsIoC.Application.Dto             (Class Library - .Net Standard 2.0)
    Mpc.WinFormsIoC.Application.Services        (Class Library - .Net Standard 2.0)
3 - Domain
    Mpc.WinFormsIoC.Domain.Core                 (Class Library - .Net Standard 2.0)
    Mpc.WinFormsIoC.Domain.Models               (Class Library - .Net Standard 2.0)
4 - Data
    Mpc.WinFormsIoC.Data.Ef                     (Class Library - .Net Standard 2.0)
5 - Infrastructure
    Mpc.WinFormsIoC.Infrastructure.CrossCutting (Class Library - .Net Standard 2.0)
```

## Project configuration

### Mpc.WinFormsIoC.Presentation

File `App.config`

```xml
<configuration>
  ...
  <appSettings>
    <add key="DataBaseConnectionString" value="Server=localhost;Database=MpcWinFormsIoCDataBase;User Id=MpcWinFormsIoCUser;Password=Mpc123" />
  </appSettings>
</configuration>
```

### Mpc.WinFormsIoC.WebApi

File `appsettings.json`

```json
{
  "DataBaseSettings": {
    "ConnectionString": "Server=localhost;Database=MpcWinFormsIoCDataBase;User Id=MpcWinFormsIoCUser;Password=Mpc123"
  }
}
```

## Database

Microsoft SQL Server

Scripts to create database schema: `src/DataBaseMigrations`

### Changelog

| Version | Description                                   |
| --------| --------------------------------------------- |
| 001     | Create Database                               |
| 002     | Create Users Table                            |
| 003     | Create Contries Table                         |

## Run

### SQL Server with docker

```
docker run -e ''ACCEPT_EULA=Y'' -e ''SA_PASSWORD=Adm1nP@ssw0rd'' --name mssql -p 1433:1433 -d microsoft/mssql-server-linux
docker container start mssql
// server:   localhost
// user:     sa
// password: Adm1nP@ssw0rd
```

### Default user to login

```
User:       system
Password:   system_123
```
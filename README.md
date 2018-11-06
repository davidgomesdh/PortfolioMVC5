# PortfolioMVC5
Projeto de Portfolio utilizando Asp.Net MVC 5 com DDD desenvolvido em Code First


# Breve descrição das camadas
- Presentation
  Apenas camada de apresentação, neste caso o asp.net MVC
  
- Service

- Application

  Camada de serviços, workflows e adaptações(DTO´s como ViewModels)

- Domain
  
  Camada de negocios, onde nasce nossa applicação, ela não conhece ninguem e toda camada conhece ela, ela deve estar limpa de tudo possivel, não podemos infectar o dominio com outras libs como DataNotation, Entity framework e etc, Depende exclusivamente do .net framework
  
- Data

  Configuração do Context, Entity Framework e Fluent API


# Tecnologias usadas:
- Asp.net MVC 5
- DDD
- Entity Framework
- FluentAPI
- Padrão Repository
- AutoMapper

# Libs e configurações das camadas
Application

- Install-Package Automapper -Version 4.0.4

Data

- Install-Package entityframework

- Enable-Migrations

- Update-Database -Script

- Update-Database -Verbose







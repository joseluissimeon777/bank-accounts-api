# Bank Accounts API

Este archivo contiene las instrucciones para ejecutar el proyecto y una breve descripción del mismo.


## Descripción
Este proyecto fue construido a modo de ejemplo.
Consta de una API para operaciones con cuentas bancarias. Se implementaron algunos patrones de diseño que se detallan un poco más abajo,
siendo estos no del todo necesarios para este contexto pero sirven para demostrar una implementación.

## Funcionalidades
- **Consulta de saldo**: Permite consultar el saldo de una cuenta bancaria por su ID.
- **Depósitos**: Permite realizar depósitos a una cuenta existente.
- **Retiros**: Debe permitir realizar retiros siempre y cuando haya saldo
suficiente.

## Requisitos
- .NET 8.0 
- Visual Studio
- Git

## Instalación y Ejecución
### 1. Clonar Repositorio
git clone https://github.com/joseluissimeon777/bank-accounts-api.git

### 2.Ingresar a Raíz de la solución
cd BankAccounts

### 3. Restaurar dependencias
dotnet restore

### 4. Ejecutar Pruebas unitarias
dotnet test

### 5. Ejecutar API
dotnet run --project ./BankAccounts.API/BankAccounts.API.csproj

### 6. Api desde swagger
 http://localhost:5091/swagger

	
## Patrones de diseño
    -CQRS
	-Repository patttern
	-Result Pattern
	-Dependency Injection
	-Inversion Of Control




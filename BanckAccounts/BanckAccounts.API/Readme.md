# Bank Accounts API

Este archivo contiene las instrucciones para ejecutar el proyecto y una breve descripción del mismo.


## Descripción
Este proyecto fue construido a modo de ejemplo.
Consta de una API para operaciones con cuentas bancarias. Se implementaron algunos patrones de diseño que se detallan un poco más abajo,
siendo estos no del todo necesarios para este contexto pero sirven a modo de ejemplo de implementación.

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
git clone https://github.com/tu-usuario/bankaccount-api.git
cd bankaccount-api

### 2. Restaurar dependencias
dotnet restore

### 3. Ejecutar API
dotnet run


### 4. Ejecutar Pruebas unitarias
dotnet test
	

## Patrones de diseño
    -CQRS
	-Repository patttern
	-Result Pattern
	-Dependency Injection
	-Inversion Of Control




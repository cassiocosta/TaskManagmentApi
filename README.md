# Task Management API

Welcome to the **Task Management API**! This project is a simple Web API built with C# and .NET 7, showcasing the **Clean Architecture** design pattern. It helps manage tasks with features like creating, listing, updating, and deleting.

## 🚀 Getting Started

### Prerequisites
- .NET 7 SDK
- SQLite (optional, used by default)

### Running the Project
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/TaskManagementAPI.git
   cd TaskManagementAPI

2. If you to need to create migrations
   ```bash
   cd TaskManagement.Infrastructure
   
   dotnet ef migrations add InitialCreate  -s ../TaskManagmnet.API/TaskManagmnet.API.csproj -o Data/Migrations

3. Create a new Database
   ```bash
   dotnet ef database update -s ../TaskManagmnet.API/TaskManagmnet.API.csproj



### I will updating in the next commits...
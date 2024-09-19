# PersonalFinanceBoss

PersonalFinanceBoss is a personal finance management application built using C# and ASP.NET Core. It allows users to manage their income and expenses, generate financial summaries, and visualize their financial data.

## Features

- **Add Income and Expenses**: Track your financial transactions with descriptions and categories.
- **Financial Summary**: View summaries of your financial transactions, including total income, total expenses, and current balance.
- **Responsive Design**: User-friendly interface that adapts to different devices.

## Technologies Used

- **ASP.NET Core**: Framework for building web applications.
- **C#**: Programming language used for backend development.
- **Docker**: Containerization platform for deploying the application.
- **Kubernetes**: Container orchestration platform for managing application deployment.
- **Bootstrap**: Frontend framework for styling and layout.

## Getting Started

### Prerequisites

- **.NET SDK**: Ensure that .NET 8.0 SDK is installed.
- **Docker**: Install Docker Desktop to build and run containers.
- **Kubernetes**: Install and configure Kubernetes (Docker Desktop includes Kubernetes).

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/PersonalFinanceBoss.git
   cd PersonalFinanceBoss

2. **Run Locally**
    ```bash
    dotnet run
4. **Build Docker Image**
   ```bash
   docker build -t personalfinanceboss .
5. **Run Docker Image**
 ```bash
    docker run -p 8080:80 personalfinanceboss

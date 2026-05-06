# Portfolio Backend — ASP.NET Core Web API

Backend API for my personal portfolio website built with ASP.NET Core 8 and MySQL.

## Tech Stack
- ASP.NET Core 8 Web API
- Entity Framework Core
- MySQL 8.0

## API Endpoints
| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/api/contact` | Contact form save karo |
| GET | `/api/contact` | Saare messages dekho |
| GET | `/api/projects` | Saare projects dekho |
| POST | `/api/projects` | Naya project add karo |

## Local Setup
1. MySQL mein `PortfolioDB` database banao
2. `appsettings.json` mein password daalo
3. Package Manager Console mein run karo:
```bash
Update-Database
```
4. F5 dabao — API start ho jayegi

## Frontend Repo
[portfolio-frontend](https://github.com/sourabh0907/portfolio-frontend)

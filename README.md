# TODO-CLI

![.NET](https://img.shields.io/badge/.NET-10-blue)

---

## Overview

A simple, local-first command-line TODO application built with C# and .NET.

TODO-CLI is designed to provide a fast terminal-based workflow for managing tasks, with Git-inspired commands and
project discovery.

## Project Status

TODO-CLI is currently in early development as a personal portfolio and learning project.

The initial task domain model and unit tests have been implemented. Core CLI commands, persistence, and project-aware
task management are still under development.

## Goals

- Create a simple and intuitive CLI for managing TODO tasks.
- Provide short, Git-inspired commands for common task operations.
- Support adding, editing, completing, removing, and listing tasks.
- Support Git-inspired project discovery for organizing tasks by project.
- Add task priorities and due dates.
- Keep task management local-first and fast.
- Build the project using a clean, maintainable architecture.

## Tech Stack

- **Framework**: .NET 10
- **Language**: C#
- **CLI Framework**: System.CommandLine
- **Database**: SQLite (planned)
- **ORM**: Entity Framework Core (planned)
- **Testing Framework**: xUnit

## Project Structure

The solution is divided into separate projects to keep responsibilities clearly separated.

```text
TODO-CLI/
├── src/
│ ├── Todo.Cli/
│ ├── Todo.Application/
│ ├── Todo.Core/
│ └── Todo.Infrastructure/
├── tests/
│ ├── Todo.UnitTests/
│ └── Todo.IntegrationTests/
├── Todo.slnx
└── README.md
```

##### Todo.Cli

Handles command definitions, command-line parsing, user input, and terminal output.

##### Todo.Application

Contains application use cases and coordinates operations between the CLI, domain, and infrastructure layers.

##### Todo.Core

Contains the core domain models, business rules, and behavior for TODO tasks.

This project remains independent of CLI and persistence concerns.

##### Todo.Infrastructure

Handles external concerns such as data persistence and, once implemented, the SQLite database.

##### Todo.UnitTests

Contains unit tests for domain and application behavior.

##### Todo.IntegrationTests

Contains integration tests for interactions between the application and infrastructure layers.

## Getting Started

### Prerequisites

To build the project, you will need:

- .NET 10 SDK
- Git
- A terminal or command prompt

### Installation

Clone the repository:

```bash
git clone  https://github.com/JamesDirr1/TODO-CLI.git
```

- Navigate to the project directory:

```bash
cd TODO-CLI
```

- Build the project:

```bash
dotnet build
```

Run the tests:

```bash
dotnet test
```

- Run the CLI:

```bash
dotnet run --project src/Todo.Cli
```

View the currently available CLI commands:

```bash
dotnet run --project src/Todo.Cli -- --help
```

## Planned Commands

The following represents the intended command-line experience as the project develops:

``todo add "Fix: login bug"``

``todo ls``

``todo done <id>``

``todo edit <id>``

``todo rm <id>``

``todo init``

``todo status``

``todo top``

These commands are a part of the project's roadmap and may be subject to change as development progresses.

## Roadmap

- [x] Set up the .NET solution and project architecture.
- [x] Set up unit and integration test projects.
- [x] Add initial unit tests.

- [ ] Implement core task management commands.
- [ ] Add SQLite persistence.
- [ ] Add project initialization and discovery.
- [ ] Add project-aware task management.
- [ ] Add task priorities and due dates.
- [ ] Implement todo top priority ranking.
- [ ] Add search and filtering.
- [ ] Add additional CLI features and configuration.

## License

A license has not yet been selected for this project.

# Antivirus Software

## Description

This is a comprehensive antivirus software project implemented in C#. It includes a variety of features such as file scanning, quarantine management, database updates, logging, user management, and scheduling. This README file provides detailed instructions on how to set up, run, and use the software.

## Table of Contents

- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [Features](#features)
- [File Structure](#file-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Installation

### Prerequisites

- [.NET SDK 7.0 or higher](https://dotnet.microsoft.com/download)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/downloads/) (optional, but recommended for development)

### Clone the Repository

1. Open your terminal or command prompt.
2. Clone the repository using the following command:

    ```sh
    git clone https://github.com/yourusername/antivirus.git
    ```

3. Navigate to the project directory:

    ```sh
    cd antivirus
    ```

### Build the Project

1. To build the project, run:

    ```sh
    scripts\build.bat
    ```

2. This will compile the project and create the necessary binaries.

## Configuration

### Configuration File

The application uses a `config.json` file for configuration settings. Ensure that the `config.json` file is correctly set up in the root directory of the project. Here’s a sample configuration:

```json
{
    "EnableAutoScan": true,
    "ScanIntervalHours": 24,
    "EmailSettings": {
        "SmtpServer": "smtp.example.com",
        "Port": 587,
        "Username": "your-email@example.com",
        "Password": "your-email-password"
    },
    "QuarantinePath": "C:\\Quarantine",
    "LogFilePath": "C:\\Logs\\log.txt",
    "ReportPath": "C:\\Reports\\report.txt"
}

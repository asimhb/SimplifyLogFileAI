# Simplify Logs App

Simplify Logs App is a tool designed to process log files and create concise summaries of their content. This project utilizes **Ollama** and **Microsoft.Extensions.AI** to parse, simplify, and save logs in a readable format.

---

## Features

- **Log Simplification**: Removes unnecessary details from log files, focusing on key information.
- **AI-powered Parsing**: Uses Ollama's AI model to process and simplify log data.
- **File Handling**: Reads input logs and saves the simplified version in the specified output directory.

---

## Setup

### Prerequisites

1. **.NET 6.0+ SDK**  
   Download and install the .NET SDK from [here](https://dotnet.microsoft.com/download).

2. **Ollama AI Engine**  
   Download and install Ollama AI from [Ollama's official site](https://ollama.com).

3. **Microsoft.Extensions.AI Package**  
   Add the NuGet package for Microsoft.Extensions.AI using the following command:
   ```bash
   dotnet add package Microsoft.Extensions.AI
   ```

---

### Installation and Configuration

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/simplify-logs.git
   cd simplify-logs
   ```

2. Install project dependencies:
   ```bash
   dotnet restore
   ```

3. Install and configure **Ollama**:
   - Ensure the Ollama server is running locally:
     ```bash
     ollama serve
     ```
   - Verify the service is running at `http://localhost:11434`.

4. Build and run the application:
   ```bash
   dotnet run
   ```

---

### Using the Application

1. **Prepare the Log File**:
   - Save the log file you want to simplify in a directory accessible by the application.
   - Update the `logFilePath` variable in `Program.cs` with the full path to your log file.

2. **Run the Application**:
   - The app reads the log file, sends it to Ollama for processing, and saves the simplified output to a new file.

3. **Access the Simplified Log**:
   - The simplified log will be saved in the specified `simplifiedFilePath`.

---

## Using Microsoft.Extensions.AI

### Overview

The `Microsoft.Extensions.AI` package simplifies integration with AI models for .NET applications. It provides easy-to-use abstractions for AI-based services like text completion, chat, and more.

### Adding the Package

Install the `Microsoft.Extensions.AI` NuGet package:
```bash
dotnet add package Microsoft.Extensions.AI
```

### Configuration

1. **Add the necessary namespaces** in your code:
   ```csharp
   using Microsoft.Extensions.AI;
   ```

2. **Initialize the AI Client**:
   Configure the `OllamaChatClient` or other client types in your application:
   ```csharp
   var client = new OllamaChatClient(new Uri("http://localhost:11434/"), "codellama");
   ```

3. **Send a Prompt**:
   Pass the input data to the AI service and receive the processed output:
   ```csharp
   var prompt = "Simplify this text: \n...";
   var response = await client.CompleteAsync(prompt);
   Console.WriteLine(response.Message);
   ```

4. **Error Handling**:
   Handle exceptions gracefully to ensure the application remains stable during AI service communication:
   ```csharp
   try
   {
       var response = await client.CompleteAsync(prompt);
       Console.WriteLine(response.Message);
   }
   catch (Exception ex)
   {
       Console.WriteLine("An error occurred: " + ex.Message);
   }
   ```

### Resources

- [Microsoft.Extensions.AI GitHub Repository](https://github.com/microsoft/extensions)
- [Microsoft.Extensions.AI NuGet Package](https://www.nuget.org/packages/Microsoft.Extensions.AI)

---

## How Ollama Works

### Overview

Ollama is a lightweight AI server designed to host and run language models locally. It allows developers to integrate advanced AI capabilities into their applications without requiring constant internet connectivity.

### Key Features

1. **Local Model Hosting**: Run language models like Code Llama directly on your local machine.
2. **Offline Processing**: Perform AI operations without relying on external APIs or cloud services.
3. **Customizable**: Supports fine-tuning and integrating various models based on your needs.

### Installation

Download and install Ollama from their [official website](https://ollama.com). Follow the installation instructions for your platform (Windows, macOS, or Linux).

### Starting the Server

1. Launch the Ollama server using the command:
   ```bash
   ollama serve
   ```

2. By default, the server runs on `http://localhost:11434`. Ensure this address is accessible for your application.

### Using Ollama in Your Application

1. **Set up the Client**:
   Configure your application to interact with the Ollama server:
   ```csharp
   var client = new OllamaChatClient(new Uri("http://localhost:11434/"), "codellama");
   ```

2. **Send a Prompt**:
   Create a prompt to process data and pass it to the client:
   ```csharp
   var prompt = "Summarize this text: \n...";
   var response = await client.CompleteAsync(prompt);
   Console.WriteLine(response.Message);
   ```

3. **Receive and Handle Responses**:
   Retrieve the AI-generated response and use it in your application workflow.

### Resources

- [Ollama Documentation](https://ollama.com/docs)
- [Supported Models](https://ollama.com/models)

---

## Example

- **Input Log File**:
  ```
  [INFO] 2025-01-16 10:23:45 Connection established to server X.
  [DEBUG] 2025-01-16 10:23:47 User authenticated successfully.
  [WARN] 2025-01-16 10:24:10 Disk usage exceeded 80%.
  [ERROR] 2025-01-16 10:25:00 Unable to access database Y.
  ```

- **Output Simplified File**:
  ```
  - Connection established to server X.
  - User authenticated successfully.
  - Disk usage exceeded 80%.
  - Unable to access database Y.
  ```

---

## References

- [Ollama AI Documentation](https://ollama.com/docs)
- [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI)

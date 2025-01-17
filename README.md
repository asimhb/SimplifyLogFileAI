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

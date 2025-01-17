# SimplifyLogFileAI
 SimplifyLogFileAI is a tool designed to process log files and create concise summaries of their content. This project utilizes Ollama and Microsoft.Extensions.AI to parse, simplify, and save logs in a readable format.

Features
Log Simplification: Removes unnecessary details from log files, focusing on key information.
AI-powered Parsing: Uses Ollama's AI model to process and simplify log data.
File Handling: Reads input logs and saves the simplified version in the specified output directory.
Setup
Prerequisites
.NET 6.0+ SDK
Download and install the .NET SDK from here.

Ollama AI Engine
Download and install Ollama AI from Ollama's official site.

Microsoft.Extensions.AI Package
Add the NuGet package for Microsoft.Extensions.AI using the following command:

bash
Copy
Edit
dotnet add package Microsoft.Extensions.AI
Installation and Configuration
Clone this repository:

bash
Copy
Edit
git clone https://github.com/your-username/simplify-logs.git
cd simplify-logs
Install project dependencies:

bash
Copy
Edit
dotnet restore
Install and configure Ollama:

Ensure the Ollama server is running locally:
bash
Copy
Edit
ollama serve
Verify the service is running at http://localhost:11434.
Build and run the application:

bash
Copy
Edit
dotnet run
Using the Application
Prepare the Log File:

Save the log file you want to simplify in a directory accessible by the application.
Update the logFilePath variable in Program.cs with the full path to your log file.
Run the Application:

The app reads the log file, sends it to Ollama for processing, and saves the simplified output to a new file.
Access the Simplified Log:

The simplified log will be saved in the specified simplifiedFilePath.
Example
Input Log File:

csharp
Copy
Edit
[INFO] 2025-01-16 10:23:45 Connection established to server X.
[DEBUG] 2025-01-16 10:23:47 User authenticated successfully.
[WARN] 2025-01-16 10:24:10 Disk usage exceeded 80%.
[ERROR] 2025-01-16 10:25:00 Unable to access database Y.
Output Simplified File:

diff
Copy
Edit
- Connection established to server X.
- User authenticated successfully.
- Disk usage exceeded 80%.
- Unable to access database Y.
References
Ollama AI Documentation
Microsoft.Extensions.AI
Would you like any specific sections added or modified?

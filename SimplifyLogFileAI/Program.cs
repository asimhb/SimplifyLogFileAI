using Microsoft.Extensions.AI;
using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        // Define the log file path
        string logFilePath = "C:\\Users\\asimb\\Downloads\\fake_log_file.log";

        try
        {
            // Read the log file content
            if (!File.Exists(logFilePath))
            {
                Console.WriteLine($"Error: Log file not found at {logFilePath}");
                return;
            }

            var logLines = File.ReadAllText(logFilePath);

            // Get the current date and time for the prompt
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // Define the path to save the simplified log
            string simplifiedFilePath = "C:\\Users\\asimb\\Downloads\\simplified_log.txt";

            // Delete the existing file if it exists
            if (File.Exists(simplifiedFilePath))
            {
                Console.WriteLine("Existing simplified log file found. Deleting...");
                File.Delete(simplifiedFilePath);
            }

            // Initialize and use the Ollama chat client within a using statement
            using (var client = new OllamaChatClient(new Uri("http://localhost:11434/"), "codellama"))
            {
                // Define the prompt with a strict output format including dates
                string prompt = $"Summarize this log file as short as possible\n\n {logLines}";
                //string prompt = $"As of {currentDate} at {currentTime}, analyze and simplify the following log file by removing unnecessary details and focusing only on the important entries. " +
                //                $"**Follow this output format exactly and do not deviate**:\n\n" +
                //                $"### Simplified Log Output\n" +
                //                $"#### Date of Analysis: {currentDate}\n" +
                //                $"#### Time of Analysis: {currentTime}\n\n" +
                //                $"#### Reasons for the errors observed in the log file:\n" +
                //                $"1. [Reason #1: Concise explanation of the first error]\n" +
                //                $"2. [Reason #2: Concise explanation of the second error]\n" +
                //                $"3. [Reason #3: Concise explanation of the third error]\n\n" +
                //                $"#### Troubleshooting steps to resolve the issues:\n" +
                //                $"1. [Step #1: Description of the first troubleshooting step]\n" +
                //                $"2. [Step #2: Description of the second troubleshooting step]\n" +
                //                $"3. [Step #3: Description of the third troubleshooting step]\n\n" +
                //                $"#### Key Log Events:\n" +
                //                $"- [Event #1: Description of the first key log event]\n" +
                //                $"- [Event #2: Description of the second key log event]\n" +
                //                $"- [Event #3: Description of the third key log event]\n\n" +
                //                $"### Original Log Content:\n\n{logLines}";

                // Get the response from the AI
                Console.WriteLine("Processing log file with AI...");
                var response = await client.CompleteAsync(prompt);

                // Get the simplified log content
                string simplifiedLog = response.Message.ToString();



                // Write the simplified log to the file
                File.WriteAllText(simplifiedFilePath, simplifiedLog);

                // Display success message
                Console.WriteLine("Simplified log saved to: " + simplifiedFilePath);
                Console.WriteLine("\nSimplified Log Output:\n");
                Console.WriteLine(simplifiedLog);
                GC.Collect();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while processing the log file:");
            Console.WriteLine(ex.Message);
        }
    }
}

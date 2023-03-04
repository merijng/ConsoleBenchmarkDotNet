# ConsoleBenchmarkDotNet

This is an example project demonstrating how to use the BenchmarkDotNet NuGet package to benchmark C# code in a console application.

## Prerequisites

To run this benchmark, you will need to have .NET 7 or later installed on your machine. You can download the latest version of .NET from the official Microsoft website.

## Running the benchmark

**Console**
- Navigate to the solution
- Execute the command in release configuration

```dotnet run --configuration Release --project ConsoleBenchmarkDotNet```

**Visual Studio**
- Open the project in Visual studio (**ConsoleBenchmarkDotNet.sln**)
- Change the configuration from Debug to Release
- Run the project, without debugging.

## Example result
Below an example result, of the benchmark

![image](https://user-images.githubusercontent.com/6886678/222903955-1c59c539-7173-462f-aea5-51a7bccff53c.png)

# Automation Test Script for CloudQA Practice Form

This repository contains a Selenium WebDriver test automation project using C# and NUnit to test the form at app.cloudqa.io/home/AutomationPracticeForm. The tests are designed to be robust against changes in element positioning or other properties.

## Getting Started

### Prerequisites

- .NET SDK 9.0 or higher
- Google Chrome browser
- Basic knowledge of C# and Selenium

### Installation

1. Clone this repository:
   ```
   git clone https://github.com/yourusername/automation-test-script.git
   cd automation-test-script
   ```

2. Restore the NuGet packages:
   ```
   dotnet restore
   ```

3. Build the project:
   ```
   dotnet build
   ```

### Running Tests

To run all the tests:
```
dotnet test
```

To run a specific test:
```
dotnet test --filter "Name=TestFirstNameField"
```

## Project Structure

- **BaseTest.cs**: Sets up and tears down the WebDriver for each test
- **AutomationPracticeFormPage.cs**: Page Object Model for the form page with methods to interact with the form elements
- **AutomationPracticeFormTests.cs**: Contains the actual test cases
- **automation-test-script.csproj**: Project configuration file with required package references

## Features

1. **Robust Element Location**: Tests use CSS selectors and explicit waits to locate elements, making them resilient to changes in page structure
2. **Clean Page Object Model**: Separation of page interaction logic from test logic
3. **Error Handling**: Appropriate error handling and timeouts to handle edge cases
4. **Cross-platform**: Works on Windows, macOS, and Linux

## Known Issues with the Target Website

During testing, we encountered several service-side issues with the target website (app.cloudqa.io/home/AutomationPracticeForm):

### Issue: TinyMCE Editor in Read-only Mode

the TinyMCE editor on the form displays the following error message:


```
TinyMCE is in read-only mode because you have no more editor loads available this month.
Please request that the admin upgrade your plan or add a valid payment method for additional editor load charges.
```

This indicates a licensing or quota issue with the form's text editor component. This does not affect our test scripts for the basic input fields (First Name, Last Name, Email) that we're testing.

### Connection Issues

We encountered intermittent "Connection refused" errors when attempting to connect to the ChromeDriver server. These are often related to:
- Network connectivity issues
- Firewall settings
- Chrome browser version compatibility with ChromeDriver

Our test script is configured with appropriate timeouts and retry mechanisms to handle these situations when possible.

### Browser Compatibility

The website was tested with Chrome version 135.0.7049.42. If you're using a different version, you may need to update the ChromeDriver version in the project file to match your Chrome version.

## Troubleshooting

If you encounter test failures, try the following:

1. **Update ChromeDriver**: Make sure the ChromeDriver version matches your Chrome browser version:
   ```xml
   <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="135.0.7049.4200" />
   ```

2. **Disable Headless Mode**: For debugging, you can modify BaseTest.cs to comment out the headless mode:
   ```csharp
   // chromeOptions.AddArgument("--headless");
   ```

3. **Increase Timeouts**: If the page loads slowly, increase the timeout values in BaseTest.cs.

## Conclusion

Our automation test scripts are designed to work correctly with the target website when it's functioning properly. The issues documented here are service-side problems that would need to be addressed by the administrators of app.cloudqa.io.

Despite these challenges, our test framework provides a solid foundation for testing web forms and can be easily adapted to work with other web applications.

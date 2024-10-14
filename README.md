**ST10203137
ReadMe file**

# Municipal Services Application - User Guide

Welcome to the Municipal Services Application! This application allows users to report municipal issues, track their submissions, view previously reported issues, manage local events, and access additional features like settings and reviews. Below is a detailed guide on how to use the software, including the functionality of every form and button, as well as instructions on how to compile and run the program.

## Table of Contents

1. [System Requirements](#system-requirements)
2. [Installation Instructions](#installation-instructions)
3. [How to Run the Application](#how-to-run-the-application)
4. [Application Features](#application-features)
   - [Main Menu](#main-menu)
   - [Reporting an Issue](#reporting-an-issue)
   - [Viewing Reported Issues](#viewing-reported-issues)
   - [Local Events Management](#local-events-management)
   - [Additional Features](#additional-features)
   - [Returning to the Main Menu](#returning-to-the-main-menu)
5. [How to Compile the Application](#how-to-compile-the-application)
6. [Contributing](#contributing)
7. [License](#license)

## System Requirements

- Operating System: Windows 7 or higher
- .NET Framework: Version 4.7.2 or higher
- IDE: Visual Studio 2019 or higher
- Memory: 4 GB or more
- Storage: At least 50 MB of free space

## Installation Instructions

1. Download the project folder from the repository.
2. Open the project in Visual Studio.
3. Ensure that all necessary dependencies are installed and that your system meets the requirements mentioned above.

## How to Run the Application

1. Once you have the project loaded in Visual Studio, build the solution by selecting Build > Build Solution from the toolbar.
2. After the build is complete, run the application by clicking Start or pressing F5.
3. The application will open in full-screen mode.

Alternatively, for non-developer users:

1. Build the project in release mode.
2. Navigate to the bin/Release folder in the project directory.
3. Locate and run the program.exe file.

Note: An installer may be provided for easier installation and running of the application.

## Application Features

### Main Menu

- Navigation Buttons: The main menu provides buttons that let you navigate to the following features:
  - Report an Issue: Opens the form where you can submit a municipal issue.
  - View Reported Issues: Allows you to view all previously submitted issues.
  - Local Events: Opens the Local Events management form.
  - Settings: Opens the Settings form with additional options.

### Reporting an Issue

1. Location: Enter the location of the issue. This is required for submission.
   - Click the Save Location button to save your location input. The progress bar will update to 20% to indicate this step is complete.

2. Category: Select the category of the issue from the dropdown (e.g., Road, Water, Electricity).
   - The progress bar will update to 40% after selecting a category.

3. Description: Provide a detailed description of the issue.
   - Click the Save Description button after entering the description. The progress bar will update to 60%.

4. Attachment: You can attach an image related to the issue (optional).
   - Click the Attach Media button to upload an image file from your device. Accepted file formats include JPG, JPEG, and PNG. The progress bar will update to 80%.

5. Submit: Once all fields are complete, click the Submit button to submit the issue.
   - If all required fields are completed, the issue will be added to the list of reported issues and the progress bar will update to 100%. A confirmation message will appear, and the form will reset for a new submission.

6. Engagement Progress: The progress bar at the bottom of the form reflects your progress through the issue-reporting process.

### Viewing Reported Issues

- View Issues Button: Click the View Reported Issues button to open the form that displays a list of previously reported issues.
- The issues are presented in a list format, showing their location, category, description, and any attached media.
- You can use this form to view all issues that have been submitted.

### Local Events Management

The Local Events form allows users to manage and view local community events.

1. Search Functionality:
   - Enter event name in the search box.
   - Select a date using the date picker.
   - Choose a category from the dropdown menu.
   - Click the Search button to find events based on your criteria.

2. Event List:
   - View events in a list format showing event name, date, and category.
   - Click on an event to view its details in the Event Details text box.

3. Event Details:
   - Displays detailed information about the selected event.

4. Recommendations:
   - View recommended events based on your search history and selected categories.

5. Create Event:
   - Click the Create Event button to open a form for adding a new event.
   - Fill in the event details (name, date, category, description) and click Create.

### Additional Features

#### Settings Form

The Settings form provides access to additional features and information:

1. Review: Opens the Review form where users can provide feedback on the application.
2. Terms and Conditions: Opens the Terms and Conditions form.
3. Back: Returns to the previous form.

#### Terms and Conditions Form

This form displays the terms and conditions for using the application:

1. Agree: Clicking this button prompts the user to confirm their agreement to the terms and conditions.
2. Back: Returns to the Settings form.

#### Review Form

The Review form allows users to provide feedback on the application:

1. Rating: Users can select a rating (Excellent, Good, Fair, or Poor).
2. Feedback: Users can enter detailed feedback in a text box.
3. Submit Review: Submits the review. All fields must be filled out for successful submission.
4. Back: Returns to the Settings form.

### Returning to the Main Menu

- Back to Menu Button: After using any feature, you can return to the main menu by clicking the Back to Menu button.

## How to Compile the Application

1. Open the project in Visual Studio.
2. Select Build > Build Solution from the toolbar.
3. If there are no errors, Visual Studio will compile the application, creating the necessary executable files in the bin folder.

Running the Compiled Application:
1. Navigate to the bin folder inside your project directory.
2. Locate the executable file (e.g., MunicipalServicesApp.exe).
3. Double-click the executable to run the application.

## Contributing

If you would like to contribute to this project, feel free to fork the repository and submit a pull request. Contributions are welcome, including bug fixes, feature additions, and documentation improvements.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.

Thank you for using the Municipal Services Application! We hope this guide helps you make the most out of the app. If you have any questions or encounter any issues, please don't hesitate to reach out.

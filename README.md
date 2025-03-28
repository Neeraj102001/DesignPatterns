# Design Patterns in C#

## Overview
This project demonstrates the implementation of key **design patterns** in C#, focusing on a **notification system**. The system allows users to send notifications via **Email** or **SMS**, utilizing various design patterns to ensure maintainability and scalability.

## Implemented Design Patterns
1. **Singleton Pattern** → Ensures a single instance of the `UserList` class, managing a shared user list.
2. **Factory Pattern** → Dynamically creates notification senders (`Email` or `SMS`).
3. **Facade Pattern** → Provides a simple interface (`NotificationFacade`) to handle complex notification logic.
4. **Observer Pattern** → Notifies multiple users when a message is sent.

## Project Structure
```
📂 DesignPatterns-main
 ├── 📄 Program.cs          # Main entry point of the application
 ├── 📄 Singleton.cs        # Singleton pattern implementation
 ├── 📄 FactoryDesign.cs    # Factory pattern implementation
 ├── 📄 FacadeDesign.cs     # Facade pattern implementation
 ├── 📄 ObserverDesign.cs   # Observer pattern implementation
 ├── 📄 NotificationApp.csproj # Project file
 ├── 📄 NotifucationApp.sln # Solution file
```

## Installation & Usage
### Prerequisites
- .NET SDK installed (version 6 or later)

### Steps to Run
1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/DesignPatterns.git
   cd DesignPatterns-main
   ```
2. Build the project:
   ```sh
   dotnet build
   ```
3. Run the project:
   ```sh
   dotnet run
   ```
4. Enter the notification mode (`email` or `sms`), then provide a subject and body.

## How It Works
1. **User Input**: The program asks the user to select a notification mode (`email` or `sms`).
2. **Factory Pattern**: The system dynamically creates the required sender (Email/SMS) using `FactoryofNotificationSendType`.
3. **Facade Pattern**: `NotificationFacade` simplifies the process of fetching user data (via Singleton) and sending notifications.
4. **Observer Pattern**: The system notifies all subscribed users when a message is sent.

## Example Output
```sh
Enter Notification sending mode (email/sms): email
Enter Subject: Meeting Reminder
Enter Body: Meeting at 5 PM

Selected Mode is Email and is sent to: Neeraj Yadav - Meeting Reminder - Meeting at 5 PM
Selected Mode is Email and is sent to: Ajeet Kumar - Meeting Reminder - Meeting at 5 PM
...
```

## Contributing
Feel free to fork this repository and submit pull requests with improvements.

## License
This project is licensed under the MIT License. See `LICENSE` for details.

---


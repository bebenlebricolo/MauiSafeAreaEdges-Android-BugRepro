# Maui Android SafeAreaEdges bug repro project
This small template MAUI Android project showcases a strange placement Bug due to recent SafeAreaEdge property introduction in MAUI (10+).
This behavior can be observed from MAUI 10.0.20 up until 10.0.90.

## How to reproduce the bug
Open the solution (Visual Studio, Rider, VSCode ?) and build the project in Debug.
Then, launch (debug) the app on an Android Emulator (I used a Pixel 9 emulated device with Android Apis 37.1).

When the app launches, it displays the landing home page.
Go to the top left corner and open the Flyout menu, then go to the Test page.
Use the top left button (the ugly blue circle at the top left corner), this will reopen the flyout menu without the help of the default Shell navbar (this is intentional).
Click on Main Page and go back to the Test page, via the Flyout path.

After one or two round trips, the blue header of the TestPage should be placed at the very top of the screen, hidden behind the Android status bar!
That's the reproduction: the header has moved and buttons are now behind the Android Status bar.

Rotate the phone in landscape mode => header is reset to a properly working position.
Rotate back to the portrait mode => header is now at the right spot again.

# Bug ticket
Here is the bug ticket I wrote to track this issue:
[MAUI Issue 36728](https://github.com/dotnet/maui/issues/36728).

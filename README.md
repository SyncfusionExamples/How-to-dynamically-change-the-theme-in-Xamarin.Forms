# How-to-dynamically-change-the-theme-in-Xamarin.Forms

This Xamarin.Forms sample demonstrates how to dynamically change application themes using Syncfusion theme resources. Dynamic theme switching allows developers to modify the appearance of controls and layouts at runtime without recreating the user interface. This approach helps applications support multiple visual styles such as light and dark themes while providing a consistent user experience across all pages.

The sample uses Syncfusion Theme support to apply predefined themes through resource dictionaries. Theme resources are merged into the page's resource collection, allowing compatible Syncfusion controls to automatically adapt their appearance according to the active theme. By updating the active theme at runtime, developers can instantly refresh the application's visual presentation without manually changing individual control properties.

The page contains a Syncfusion `SfNumericTextBox` hosted inside an `SfTextInputLayout`, demonstrating how Syncfusion input controls automatically inherit theme settings. A button is provided to trigger theme switching. When the button is clicked, the application can replace the current theme resource dictionary with another theme resource dictionary, causing all supported controls on the page to update their styles dynamically.

The sample initially loads the Light Theme through merged resource dictionaries. Along with the theme resources, style resources for Syncfusion Button, NumericTextBox, and TextInputLayout controls are included. These resources ensure that all supported controls maintain a consistent appearance based on the currently selected theme.

Dynamic theme switching is useful in modern applications that provide user-selectable appearance settings. For example, users may prefer a light theme during daytime and a dark theme during nighttime. By implementing runtime theme updates, developers can improve user comfort, personalization, and accessibility.

## Features

- Dynamic theme switching at runtime.
- Syncfusion Theme integration for Xamarin.Forms.
- Centralized theme management using ResourceDictionary.
- Automatic styling of Syncfusion controls.
- Light theme initialization through merged dictionaries.
- Runtime appearance updates without recreating pages.
- Consistent styling across multiple Syncfusion controls.
- Simple implementation using XAML and resource management.

## Sample Behavior

1. The application loads with the Light Theme applied.
2. Theme resources are merged into the page resource dictionary.
3. Syncfusion controls automatically inherit the active theme styles.
4. The NumericTextBox and TextInputLayout display themed appearances.
5. The user taps the theme selection button.
6. The application replaces the active theme resource dictionary.
7. All supported controls update their appearance dynamically.
8. The new theme is applied immediately without restarting the application.

## Theme Implementation

The page uses merged resource dictionaries to load Syncfusion theme resources and control styles. This approach allows developers to manage application themes from a central location while ensuring a consistent appearance throughout the application.

The following theme-related resources are included:

- Light Theme
- SfButton Styles
- SfNumericTextBox Styles
- SfTextInputLayout Styles

These resources work together to ensure that Syncfusion controls automatically adapt to the selected theme.

## Controls Used

### SfNumericTextBox

The Syncfusion NumericTextBox control is used to demonstrate how input controls automatically respond to theme changes. The control inherits colors, borders, and visual styles from the active theme resources.

### SfTextInputLayout

The Syncfusion TextInputLayout provides a modern container for input controls and automatically updates its appearance when the theme changes.

### Button

A standard button is used to initiate the theme-changing process. When clicked, the application can replace the current theme with another predefined theme.

## Benefits of Dynamic Theme Switching

- Improves application personalization.
- Enhances user experience.
- Supports light and dark appearance modes.
- Provides consistent control styling.
- Reduces maintenance by centralizing visual resources.
- Allows runtime customization without page recreation.

## Requirements

- Visual Studio 2019 or later
- Xamarin.Forms
- Syncfusion Xamarin Themes
- Syncfusion Xamarin Buttons
- Syncfusion Xamarin NumericTextBox
- Syncfusion Xamarin TextInputLayout

## NuGet Packages

```text
Syncfusion.Xamarin.Core
Syncfusion.Xamarin.Buttons
Syncfusion.Xamarin.SfNumericTextBox
```

## Running the Sample

1. Clone or download the repository.
2. Restore all required NuGet packages.
3. Build the Xamarin.Forms solution.
4. Deploy the application to Android, iOS, or UWP.
5. Launch the application and observe the applied theme.
6. Select the theme change option to dynamically update the visual appearance.

## Use Cases

This sample can be used as a reference for:

- Light and dark theme implementations.
- User-selectable application appearance settings.
- Enterprise applications with branding requirements.
- Accessibility-focused applications.
- Runtime style customization.
- Xamarin.Forms applications using Syncfusion controls.

## Conclusion

This sample demonstrates how to dynamically change themes in Xamarin.Forms applications using Syncfusion theme resources. By leveraging ResourceDictionary merging and Syncfusion theme support, developers can implement runtime theme switching with minimal effort while maintaining a consistent and professional user interface across their applications.
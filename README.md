# UWPDesign

UWPDesign is a collection of helpers for making pretty Windows Store apps.
It contains the entire Material Design color palette along with several extensions methods and converters.
You can find the Material Design colors here: https://material.io/guidelines/style/color.html

I used this library in several of my games:

## Contents

* **PortableColor** is a color representation that can be serialized.
* **MaterialColor** contains a static dictionary of Material Design colors and all their variations.

## Usage

### PortableColor
Creating a PortableColor is easy:
```
var color = new PortableColor(255, 150, 150, 150);
```

### MaterialColor

Material Design colors are organized in a dictionary structure to make it easier to access the colors and variations:

```
var color = return MaterialColor.Colors[MaterialColorName.Red].Variations[MaterialColorVariation.Variation700];
```

### Extensions
For converting between the built in classes and Portable color, several extension are available:

```
var systemColor = MaterialColor.Colors[MaterialColorName.Brown].Variations[MaterialColorVariation.Variation50].ToColor()
```
and
```
var systemColor = "#66000000".ToColor()
```

### Converters

A PortableColor can easily be converter in XAML to a SolidColorBrush using a converter

ViewModel
```
public PortableColor ContainerColor { get; set;}
```

XAML
```
Background="{Binding ContainerColor, Converter={StaticResource portableColorToBrushConverter}}"
```


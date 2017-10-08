# UWPDesign

UWPDesign is a collection of helpers for making pretty Windows Store apps.
It contains the entire Material Design color palette along with several extensions methods and converters.
You can find the Material Design colors here: https://material.io/guidelines/style/color.html

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
var systemColor = "#77000000".ToColor()
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

## Apps using this library

I used this library in several of my games, check them out in Windows Store:

* Jigsaw Puzzle Frenzy https://www.microsoft.com/store/apps/9wzdncrddqbm
* Hexa Word Search https://www.microsoft.com/store/apps/9mtxw2nrnjf1
* Quiz for Geeks https://www.microsoft.com/store/apps/9wzdncrddqbg
* Fun with Words https://www.microsoft.com/store/apps/9nblgggzpgrt
* Easy Peasy Puzzles https://www.microsoft.com/store/apps/9wzdncrddj8g
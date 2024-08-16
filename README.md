# Ni-Extensions

Ni-Extensions is a large set of extension methods for convenient work with different data types.

## Features

* Extension methods for all vectors, colors.
* Additional `GameObject` methods for working with components.
* Methods for `Transform`, `RectTransform`.
* Extensions to interact with objects using monads.

## Requirements

* Unity 2021.2 or later

## Installation

### Manual

1. Clone this repository or download the source files.
2. Copy the `Ni-Extensions` folder into your Unity project's `Assets` directory.

### UPM

1. Open Package Manager from Window > Package Manager.
2. Click the "+" button > Add package from git URL.
3. Enter the following URL:

```
https://github.com/HoSHIZA/Ni-Extensions.git
```

### Manual with `manifest.json`

1. Open `manifest.json`.
2. Add the following line to the file:

```
"com.ni-games.extensions" : "https://github.com/HoSHIZA/Ni-Extensions.git"
```

## Usage

### Object Extensions


```csharp
bool @object = true;

@object
    .If(predicate => predicate, value => Debug.Log(value)) // If i == true, call Debug.Log.
    .Map(value => value.ToString()) // Mapping the `bool` value to the `string` type.
    .ThrowIf(value => string.IsNullOrEmpty(value)) // If the value is null, an exception is thrown.
    .With(value => Debug.LogWarning(value)); // Call Debug.LogWarning.
```

### List & Array Extensions

```csharp
// Check code to details.
```

### Vector Extensions (`Vector2`, `Vector2Int`, `Vector3`, `Vector3Int`, `Vector4`)

```csharp
var vector = new Vector3(1, 2, 3);

// With
var vectorNew = vector.WithX(8); // Vector3(8, 2, 3)
var vectorNew = vector.WithYZ(33); // Vector3(1, 33, 33)

// Get
var vectorNew = vector.GetYZX(); // Vector3(2, 3, 1)
var vectorNew = vector.GetYX(); // Vector2(2, 1)

// Math operations
var vectorNew = vector.Sum(); // 6
var vectorNew = vector.Add(10); // Vector3(11, 12, 13)
```

### Color Extensions (`Color`, `Color32`)

```csharp
var color = Color.red;

// With
var colorNew = color.WithG(0.75f); // Color(1f, 0.75f, 0f)
```

## License

This project is licensed under the [MIT License](LICENSE).
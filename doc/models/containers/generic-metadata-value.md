
# Generic Metadata Value

Allowed values for metadata properties.

## Class Name

`GenericMetadataValue`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | GenericMetadataValue.FromString(string mString) |
| `double` | GenericMetadataValue.FromPrecision(double precision) |
| `bool` | GenericMetadataValue.FromBoolean(bool boolean) |

## string

### Initialization Code

#### Example

```csharp
GenericMetadataValue value = GenericMetadataValue.FromString("sale");
```

## double

### Initialization Code

#### Example

```csharp
GenericMetadataValue value = GenericMetadataValue.FromPrecision(10);
```

## bool

### Initialization Code

#### Example

```csharp
GenericMetadataValue value = GenericMetadataValue.FromBoolean(true);
```


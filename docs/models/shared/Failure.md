# Failure

Validation error


## Fields

| Field                                          | Type                                           | Required                                       | Description                                    |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| `Code`                                         | *string*                                       | :heavy_minus_sign:                             | Failure code                                   |
| `Description`                                  | *string*                                       | :heavy_minus_sign:                             | Failure description                            |
| `Path`                                         | *string*                                       | :heavy_minus_sign:                             | JSON path of the failing element if applicable |
| `Type`                                         | *string*                                       | :heavy_minus_sign:                             | Type of the validation error, e.g. NotNull     |
# User

Operations about user

```csharp
UserController userController = client.UserController;
```

## Class Name

`UserController`

## Methods

* [Create User](../../doc/controllers/user.md#create-user)
* [Create Users with List Input](../../doc/controllers/user.md#create-users-with-list-input)
* [Login User](../../doc/controllers/user.md#login-user)
* [Logout User](../../doc/controllers/user.md#logout-user)
* [Get User by Name](../../doc/controllers/user.md#get-user-by-name)
* [Update User](../../doc/controllers/user.md#update-user)
* [Delete User](../../doc/controllers/user.md#delete-user)


# Create User

This can only be done by the logged in user.

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateUserAsync(
    long? id = null,
    string username = null,
    string firstName = null,
    string lastName = null,
    string email = null,
    string password = null,
    string phone = null,
    int? userStatus = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `long?` | Form, Optional | - |
| `username` | `string` | Form, Optional | - |
| `firstName` | `string` | Form, Optional | - |
| `lastName` | `string` | Form, Optional | - |
| `email` | `string` | Form, Optional | - |
| `password` | `string` | Form, Optional | - |
| `phone` | `string` | Form, Optional | - |
| `userStatus` | `int?` | Form, Optional | User Status |

## Response Type

**200**: successful operation

[`Task<Models.User>`](../../doc/models/user.md)

## Example Usage

```csharp
long? id = 10L;
string username = "theUser";
string firstName = "John";
string lastName = "James";
string email = "john@email.com";
string password = "12345";
string phone = "12345";
int? userStatus = 1;
try
{
    User result = await userController.CreateUserAsync(
        id,
        username,
        firstName,
        lastName,
        email,
        password,
        phone,
        userStatus
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error | `ApiException` |


# Create Users with List Input

Creates list of users with given input array.

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateUsersWithListInputAsync(
    List<Models.User> body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<User>`](../../doc/models/user.md) | Body, Optional | - |

## Response Type

**200**: Successful operation

[`Task<Models.User>`](../../doc/models/user.md)

## Example Usage

```csharp
List<User> body = new List<User>
{
    new User
    {
    },
};

try
{
    User result = await userController.CreateUsersWithListInputAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error | `ApiException` |


# Login User

Log into the system.

:information_source: **Note** This endpoint does not require authentication.

```csharp
LoginUserAsync(
    string username = null,
    string password = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `username` | `string` | Query, Optional | The user name for login |
| `password` | `string` | Query, Optional | The password for login in clear text |

## Response Type

**200**: successful operation

`Task<string>`

## Example Usage

```csharp
try
{
    string result = await userController.LoginUserAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid username/password supplied | `ApiException` |
| Default | Unexpected error | `ApiException` |


# Logout User

Log user out of the system.

:information_source: **Note** This endpoint does not require authentication.

```csharp
LogoutUserAsync()
```

## Response Type

**200**: successful operation

`Task`

## Example Usage

```csharp
try
{
    await userController.LogoutUserAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error | `ApiException` |


# Get User by Name

Get user detail based on username.

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetUserByNameAsync(
    string currentUsername)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `currentUsername` | `string` | Template, Required | The username that needs to be processed |

## Response Type

**200**: successful operation

[`Task<Models.User>`](../../doc/models/user.md)

## Example Usage

```csharp
string currentUsername = "currentUsername2";
try
{
    User result = await userController.GetUserByNameAsync(currentUsername);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid username supplied | `ApiException` |
| 404 | User not found | `ApiException` |
| Default | Unexpected error | `ApiException` |


# Update User

This can only be done by the logged in user.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateUserAsync(
    string currentUsername,
    long? id = null,
    string username = null,
    string firstName = null,
    string lastName = null,
    string email = null,
    string password = null,
    string phone = null,
    int? userStatus = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `currentUsername` | `string` | Template, Required | The username that needs to be processed |
| `id` | `long?` | Form, Optional | - |
| `username` | `string` | Form, Optional | - |
| `firstName` | `string` | Form, Optional | - |
| `lastName` | `string` | Form, Optional | - |
| `email` | `string` | Form, Optional | - |
| `password` | `string` | Form, Optional | - |
| `phone` | `string` | Form, Optional | - |
| `userStatus` | `int?` | Form, Optional | User Status |

## Response Type

**200**: successful operation

`Task`

## Example Usage

```csharp
string currentUsername = "currentUsername2";
long? id = 10L;
string username = "theUser";
string firstName = "John";
string lastName = "James";
string email = "john@email.com";
string password = "12345";
string phone = "12345";
int? userStatus = 1;
try
{
    await userController.UpdateUserAsync(
        currentUsername,
        id,
        username,
        firstName,
        lastName,
        email,
        password,
        phone,
        userStatus
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | bad request | `ApiException` |
| 404 | user not found | `ApiException` |
| Default | Unexpected error | `ApiException` |


# Delete User

This can only be done by the logged in user.

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteUserAsync(
    string currentUsername)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `currentUsername` | `string` | Template, Required | The username that needs to be processed |

## Response Type

**200**: User deleted

`Task`

## Example Usage

```csharp
string currentUsername = "currentUsername2";
try
{
    await userController.DeleteUserAsync(currentUsername);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid username supplied | `ApiException` |
| 404 | User not found | `ApiException` |
| Default | Unexpected error | `ApiException` |


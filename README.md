# Squiggle - the C# library for the Squiggle API

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 0.0.1
- SDK version: 0.2.12
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var data = new Address(); // Address | 

            try
            {
                Address result = apiInstance.AddAddress(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddAddress: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.squigglesignatures.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**AddAddress**](docs/DefaultApi.md#addaddress) | **POST** /addresses | 
*DefaultApi* | [**AddAddressBatch**](docs/DefaultApi.md#addaddressbatch) | **POST** /addresses/batch | 
*DefaultApi* | [**AddClient**](docs/DefaultApi.md#addclient) | **POST** /clients | 
*DefaultApi* | [**AddFile**](docs/DefaultApi.md#addfile) | **POST** /files | 
*DefaultApi* | [**AddGlobalTemplate**](docs/DefaultApi.md#addglobaltemplate) | **POST** /global-templates | 
*DefaultApi* | [**AddSnippet**](docs/DefaultApi.md#addsnippet) | **POST** /snippets | 
*DefaultApi* | [**AddTemplate**](docs/DefaultApi.md#addtemplate) | **POST** /templates | 
*DefaultApi* | [**AddUser**](docs/DefaultApi.md#adduser) | **POST** /users | 
*DefaultApi* | [**DeleteAddress**](docs/DefaultApi.md#deleteaddress) | **DELETE** /addresses/{id} | 
*DefaultApi* | [**DeleteFile**](docs/DefaultApi.md#deletefile) | **DELETE** /files/{id} | 
*DefaultApi* | [**DeleteGlobalTemplate**](docs/DefaultApi.md#deleteglobaltemplate) | **DELETE** /global-templates/{id} | 
*DefaultApi* | [**DeleteSnippet**](docs/DefaultApi.md#deletesnippet) | **DELETE** /snippets/{id} | 
*DefaultApi* | [**DeleteTemplate**](docs/DefaultApi.md#deletetemplate) | **DELETE** /templates/{id} | 
*DefaultApi* | [**DeleteUser**](docs/DefaultApi.md#deleteuser) | **DELETE** /users/{id} | 
*DefaultApi* | [**EditAddress**](docs/DefaultApi.md#editaddress) | **PATCH** /addresses/{id} | 
*DefaultApi* | [**EditFile**](docs/DefaultApi.md#editfile) | **PATCH** /files/{id} | 
*DefaultApi* | [**EditGlobalTemplate**](docs/DefaultApi.md#editglobaltemplate) | **PATCH** /global-templates/{id} | 
*DefaultApi* | [**EditSnippet**](docs/DefaultApi.md#editsnippet) | **PATCH** /snippets/{id} | 
*DefaultApi* | [**EditTemplate**](docs/DefaultApi.md#edittemplate) | **PATCH** /templates/{id} | 
*DefaultApi* | [**EditUser**](docs/DefaultApi.md#edituser) | **PATCH** /users/{id} | 
*DefaultApi* | [**FindAddresses**](docs/DefaultApi.md#findaddresses) | **GET** /addresses | 
*DefaultApi* | [**FindFiles**](docs/DefaultApi.md#findfiles) | **GET** /files | 
*DefaultApi* | [**FindGlobalTemplates**](docs/DefaultApi.md#findglobaltemplates) | **GET** /global-templates | 
*DefaultApi* | [**FindSignatures**](docs/DefaultApi.md#findsignatures) | **GET** /signatures | 
*DefaultApi* | [**FindSnippets**](docs/DefaultApi.md#findsnippets) | **GET** /snippets | 
*DefaultApi* | [**FindTemplates**](docs/DefaultApi.md#findtemplates) | **GET** /templates | 
*DefaultApi* | [**FindUsers**](docs/DefaultApi.md#findusers) | **GET** /users | 
*DefaultApi* | [**GenerateAddressAuthCode**](docs/DefaultApi.md#generateaddressauthcode) | **POST** /addresses/generate-auth-code | 
*DefaultApi* | [**GenerateAddressAuthCodeById**](docs/DefaultApi.md#generateaddressauthcodebyid) | **POST** /addresses/generate-auth-code/{id} | 
*DefaultApi* | [**GetAddress**](docs/DefaultApi.md#getaddress) | **GET** /addresses/{id} | 
*DefaultApi* | [**GetAddressToken**](docs/DefaultApi.md#getaddresstoken) | **POST** /token/address | 
*DefaultApi* | [**GetFile**](docs/DefaultApi.md#getfile) | **GET** /files/{id} | 
*DefaultApi* | [**GetGlobalTemplate**](docs/DefaultApi.md#getglobaltemplate) | **GET** /global-templates/{id} | 
*DefaultApi* | [**GetImage**](docs/DefaultApi.md#getimage) | **GET** /image/{id} | 
*DefaultApi* | [**GetSignature**](docs/DefaultApi.md#getsignature) | **GET** /signatures/{id} | 
*DefaultApi* | [**GetSnippet**](docs/DefaultApi.md#getsnippet) | **GET** /snippets/{id} | 
*DefaultApi* | [**GetTemplate**](docs/DefaultApi.md#gettemplate) | **GET** /templates/{id} | 
*DefaultApi* | [**GetUser**](docs/DefaultApi.md#getuser) | **GET** /users/{id} | 
*DefaultApi* | [**GetUserToken**](docs/DefaultApi.md#getusertoken) | **POST** /token/user | 
*DefaultApi* | [**Render**](docs/DefaultApi.md#render) | **POST** /render | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.AddressTemplate](docs/AddressTemplate.md)
 - [Model.AuthCode](docs/AuthCode.md)
 - [Model.AuthCodeRequest](docs/AuthCodeRequest.md)
 - [Model.BatchErrorResponse](docs/BatchErrorResponse.md)
 - [Model.FileObject](docs/FileObject.md)
 - [Model.FileTemplate](docs/FileTemplate.md)
 - [Model.GlobalTemplate](docs/GlobalTemplate.md)
 - [Model.ImageInfo](docs/ImageInfo.md)
 - [Model.JSONWebToken](docs/JSONWebToken.md)
 - [Model.JsonApiResponse](docs/JsonApiResponse.md)
 - [Model.LoginDetails](docs/LoginDetails.md)
 - [Model.ModelClient](docs/ModelClient.md)
 - [Model.RenderOptions](docs/RenderOptions.md)
 - [Model.ResponseLinks](docs/ResponseLinks.md)
 - [Model.Signature](docs/Signature.md)
 - [Model.Snippet](docs/Snippet.md)
 - [Model.SnippetTemplate](docs/SnippetTemplate.md)
 - [Model.Template](docs/Template.md)
 - [Model.UnexpectedErrorResponse](docs/UnexpectedErrorResponse.md)
 - [Model.User](docs/User.md)
 - [Model.UserTemplate](docs/UserTemplate.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="jwt"></a>
### jwt

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header


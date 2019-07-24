# Squiggle.Api.DefaultApi

All URIs are relative to *http://api.squigglesignatures.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAddress**](DefaultApi.md#addaddress) | **POST** /addresses | 
[**AddAddressBatch**](DefaultApi.md#addaddressbatch) | **POST** /addresses/batch | 
[**AddFile**](DefaultApi.md#addfile) | **POST** /files | 
[**AddGlobalTemplate**](DefaultApi.md#addglobaltemplate) | **POST** /global-templates | 
[**AddSnippet**](DefaultApi.md#addsnippet) | **POST** /snippets | 
[**AddTemplate**](DefaultApi.md#addtemplate) | **POST** /templates | 
[**AddUser**](DefaultApi.md#adduser) | **POST** /users | 
[**DeleteAddress**](DefaultApi.md#deleteaddress) | **DELETE** /addresses/{id} | 
[**DeleteFile**](DefaultApi.md#deletefile) | **DELETE** /files/{id} | 
[**DeleteGlobalTemplate**](DefaultApi.md#deleteglobaltemplate) | **DELETE** /global-templates/{id} | 
[**DeleteSnippet**](DefaultApi.md#deletesnippet) | **DELETE** /snippets/{id} | 
[**DeleteTemplate**](DefaultApi.md#deletetemplate) | **DELETE** /templates/{id} | 
[**DeleteUser**](DefaultApi.md#deleteuser) | **DELETE** /users/{id} | 
[**EditAddress**](DefaultApi.md#editaddress) | **PATCH** /addresses/{id} | 
[**EditFile**](DefaultApi.md#editfile) | **PATCH** /files/{id} | 
[**EditGlobalTemplate**](DefaultApi.md#editglobaltemplate) | **PATCH** /global-templates/{id} | 
[**EditSnippet**](DefaultApi.md#editsnippet) | **PATCH** /snippets/{id} | 
[**EditTemplate**](DefaultApi.md#edittemplate) | **PATCH** /templates/{id} | 
[**EditUser**](DefaultApi.md#edituser) | **PATCH** /users/{id} | 
[**FindAddresses**](DefaultApi.md#findaddresses) | **GET** /addresses | 
[**FindFiles**](DefaultApi.md#findfiles) | **GET** /files | 
[**FindGlobalTemplates**](DefaultApi.md#findglobaltemplates) | **GET** /global-templates | 
[**FindSignatures**](DefaultApi.md#findsignatures) | **GET** /signatures | 
[**FindSnippets**](DefaultApi.md#findsnippets) | **GET** /snippets | 
[**FindTemplates**](DefaultApi.md#findtemplates) | **GET** /templates | 
[**FindUsers**](DefaultApi.md#findusers) | **GET** /users | 
[**GenerateAddressAuthCode**](DefaultApi.md#generateaddressauthcode) | **POST** /addresses/generate-auth-code | 
[**GenerateAddressAuthCodeById**](DefaultApi.md#generateaddressauthcodebyid) | **POST** /addresses/generate-auth-code/{id} | 
[**GetAddress**](DefaultApi.md#getaddress) | **GET** /addresses/{id} | 
[**GetAddressToken**](DefaultApi.md#getaddresstoken) | **POST** /token/address | 
[**GetFile**](DefaultApi.md#getfile) | **GET** /files/{id} | 
[**GetGlobalTemplate**](DefaultApi.md#getglobaltemplate) | **GET** /global-templates/{id} | 
[**GetSignature**](DefaultApi.md#getsignature) | **GET** /signatures/{id} | 
[**GetSnippet**](DefaultApi.md#getsnippet) | **GET** /snippets/{id} | 
[**GetTemplate**](DefaultApi.md#gettemplate) | **GET** /templates/{id} | 
[**GetUser**](DefaultApi.md#getuser) | **GET** /users/{id} | 
[**GetUserToken**](DefaultApi.md#getusertoken) | **POST** /token/user | 


<a name="addaddress"></a>
# **AddAddress**
> Address AddAddress (Address data)



Creates a new address

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class AddAddressExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Address**](Address.md)|  | 

### Return type

[**Address**](Address.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addaddressbatch"></a>
# **AddAddressBatch**
> Dictionary<string, Address> AddAddressBatch (List<Address> data)



Creates multiple new addresses

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class AddAddressBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var data = new List<Address>(); // List<Address> | 

            try
            {
                Dictionary&lt;string, Address&gt; result = apiInstance.AddAddressBatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**List<Address>**](Address.md)|  | 

### Return type

[**Dictionary<string, Address>**](Address.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfile"></a>
# **AddFile**
> FileObject AddFile (System.IO.Stream file, string name = null)



Upload a new file

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class AddFileExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var file = new System.IO.Stream(); // System.IO.Stream | 
            var name = name_example;  // string |  (optional) 

            try
            {
                FileObject result = apiInstance.AddFile(file, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**|  | 
 **name** | **string**|  | [optional] 

### Return type

[**FileObject**](FileObject.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addglobaltemplate"></a>
# **AddGlobalTemplate**
> GlobalTemplate AddGlobalTemplate (GlobalTemplate data)



Creates a new global template

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class AddGlobalTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var data = new GlobalTemplate(); // GlobalTemplate | 

            try
            {
                GlobalTemplate result = apiInstance.AddGlobalTemplate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddGlobalTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**GlobalTemplate**](GlobalTemplate.md)|  | 

### Return type

[**GlobalTemplate**](GlobalTemplate.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsnippet"></a>
# **AddSnippet**
> Snippet AddSnippet (Snippet data)



Creates a new snippet

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class AddSnippetExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var data = new Snippet(); // Snippet | 

            try
            {
                Snippet result = apiInstance.AddSnippet(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddSnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Snippet**](Snippet.md)|  | 

### Return type

[**Snippet**](Snippet.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtemplate"></a>
# **AddTemplate**
> Template AddTemplate (Template data)



Creates a new template

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class AddTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var data = new Template(); // Template | 

            try
            {
                Template result = apiInstance.AddTemplate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Template**](Template.md)|  | 

### Return type

[**Template**](Template.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adduser"></a>
# **AddUser**
> User AddUser (User data)



Creates a new user

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class AddUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var data = new User(); // User | 

            try
            {
                User result = apiInstance.AddUser(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**User**](User.md)|  | 

### Return type

[**User**](User.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaddress"></a>
# **DeleteAddress**
> void DeleteAddress (long? id, bool? force = null)



Deletes an address with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class DeleteAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of address to delete
            var force = true;  // bool? | Disables soft-delete when true, completely removing the row (use with caution!) (optional) 

            try
            {
                apiInstance.DeleteAddress(id, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of address to delete | 
 **force** | **bool?**| Disables soft-delete when true, completely removing the row (use with caution!) | [optional] 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefile"></a>
# **DeleteFile**
> void DeleteFile (long? id)



Deletes a file with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class DeleteFileExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of file to delete

            try
            {
                apiInstance.DeleteFile(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of file to delete | 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteglobaltemplate"></a>
# **DeleteGlobalTemplate**
> void DeleteGlobalTemplate (long? id, bool? force = null)



Deletes a global template with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class DeleteGlobalTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of global template to delete
            var force = true;  // bool? | Disables soft-delete when true, completely removing the row (use with caution!) (optional) 

            try
            {
                apiInstance.DeleteGlobalTemplate(id, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteGlobalTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of global template to delete | 
 **force** | **bool?**| Disables soft-delete when true, completely removing the row (use with caution!) | [optional] 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesnippet"></a>
# **DeleteSnippet**
> void DeleteSnippet (long? id, bool? force = null)



Deletes a snippet with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class DeleteSnippetExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of snippet to delete
            var force = true;  // bool? | Disables soft-delete when true, completely removing the row (use with caution!) (optional) 

            try
            {
                apiInstance.DeleteSnippet(id, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of snippet to delete | 
 **force** | **bool?**| Disables soft-delete when true, completely removing the row (use with caution!) | [optional] 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplate"></a>
# **DeleteTemplate**
> void DeleteTemplate (long? id, bool? force = null)



Deletes a template with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class DeleteTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of template to delete
            var force = true;  // bool? | Disables soft-delete when true, completely removing the row (use with caution!) (optional) 

            try
            {
                apiInstance.DeleteTemplate(id, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of template to delete | 
 **force** | **bool?**| Disables soft-delete when true, completely removing the row (use with caution!) | [optional] 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (long? id, bool? force = null)



Deletes a user with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of user to delete
            var force = true;  // bool? | Disables soft-delete when true, completely removing the row (use with caution!) (optional) 

            try
            {
                apiInstance.DeleteUser(id, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of user to delete | 
 **force** | **bool?**| Disables soft-delete when true, completely removing the row (use with caution!) | [optional] 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editaddress"></a>
# **EditAddress**
> Address EditAddress (long? id, Address data)



Updates an existing address with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class EditAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of address to update
            var data = new Address(); // Address | 

            try
            {
                Address result = apiInstance.EditAddress(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EditAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of address to update | 
 **data** | [**Address**](Address.md)|  | 

### Return type

[**Address**](Address.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editfile"></a>
# **EditFile**
> FileObject EditFile (long? id, System.IO.Stream file = null, string name = null)



Updates an existing file with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class EditFileExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of file to update
            var file = new System.IO.Stream(); // System.IO.Stream |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                FileObject result = apiInstance.EditFile(id, file, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EditFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of file to update | 
 **file** | **System.IO.Stream**|  | [optional] 
 **name** | **string**|  | [optional] 

### Return type

[**FileObject**](FileObject.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editglobaltemplate"></a>
# **EditGlobalTemplate**
> GlobalTemplate EditGlobalTemplate (long? id, GlobalTemplate data)



Updates an existing global template with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class EditGlobalTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of global template to update
            var data = new GlobalTemplate(); // GlobalTemplate | 

            try
            {
                GlobalTemplate result = apiInstance.EditGlobalTemplate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EditGlobalTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of global template to update | 
 **data** | [**GlobalTemplate**](GlobalTemplate.md)|  | 

### Return type

[**GlobalTemplate**](GlobalTemplate.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editsnippet"></a>
# **EditSnippet**
> Snippet EditSnippet (long? id, Snippet data)



Updates an existing snippet with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class EditSnippetExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of snippet to update
            var data = new Snippet(); // Snippet | 

            try
            {
                Snippet result = apiInstance.EditSnippet(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EditSnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of snippet to update | 
 **data** | [**Snippet**](Snippet.md)|  | 

### Return type

[**Snippet**](Snippet.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittemplate"></a>
# **EditTemplate**
> Template EditTemplate (long? id, Template data)



Updates an existing template with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class EditTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of template to update
            var data = new Template(); // Template | 

            try
            {
                Template result = apiInstance.EditTemplate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EditTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of template to update | 
 **data** | [**Template**](Template.md)|  | 

### Return type

[**Template**](Template.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edituser"></a>
# **EditUser**
> User EditUser (long? id, User data)



Updates an existing user with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class EditUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of user to update
            var data = new User(); // User | 

            try
            {
                User result = apiInstance.EditUser(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EditUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of user to update | 
 **data** | [**User**](User.md)|  | 

### Return type

[**User**](User.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findaddresses"></a>
# **FindAddresses**
> List<Address> FindAddresses (string filter = null, string sort = null, int? offset = null, int? limit = null)



Gets addresses

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class FindAddressesExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string | A list of fields and values to filter by, in query string format eg. 'type=order&status=1' (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by (optional) 
            var offset = 56;  // int? | The start offset of the result set (optional) 
            var limit = 56;  // int? | Max records to return (optional) 

            try
            {
                List&lt;Address&gt; result = apiInstance.FindAddresses(filter, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FindAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| A list of fields and values to filter by, in query string format eg. &#39;type&#x3D;order&amp;status&#x3D;1&#39; | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by | [optional] 
 **offset** | **int?**| The start offset of the result set | [optional] 
 **limit** | **int?**| Max records to return | [optional] 

### Return type

[**List<Address>**](Address.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findfiles"></a>
# **FindFiles**
> List<FileObject> FindFiles (string filter = null, string sort = null, int? offset = null, int? limit = null)



Gets files

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class FindFilesExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string | A list of fields and values to filter by, in query string format eg. 'type=order&status=1' (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by (optional) 
            var offset = 56;  // int? | The start offset of the result set (optional) 
            var limit = 56;  // int? | Max records to return (optional) 

            try
            {
                List&lt;FileObject&gt; result = apiInstance.FindFiles(filter, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FindFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| A list of fields and values to filter by, in query string format eg. &#39;type&#x3D;order&amp;status&#x3D;1&#39; | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by | [optional] 
 **offset** | **int?**| The start offset of the result set | [optional] 
 **limit** | **int?**| Max records to return | [optional] 

### Return type

[**List<FileObject>**](FileObject.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findglobaltemplates"></a>
# **FindGlobalTemplates**
> List<GlobalTemplate> FindGlobalTemplates (string filter = null, string sort = null, int? offset = null, int? limit = null)



Gets global templates

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class FindGlobalTemplatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string | A list of fields and values to filter by, in query string format eg. 'type=order&status=1' (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by (optional) 
            var offset = 56;  // int? | The start offset of the result set (optional) 
            var limit = 56;  // int? | Max records to return (optional) 

            try
            {
                List&lt;GlobalTemplate&gt; result = apiInstance.FindGlobalTemplates(filter, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FindGlobalTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| A list of fields and values to filter by, in query string format eg. &#39;type&#x3D;order&amp;status&#x3D;1&#39; | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by | [optional] 
 **offset** | **int?**| The start offset of the result set | [optional] 
 **limit** | **int?**| Max records to return | [optional] 

### Return type

[**List<GlobalTemplate>**](GlobalTemplate.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsignatures"></a>
# **FindSignatures**
> List<Signature> FindSignatures (string filter = null, string sort = null, int? offset = null, int? limit = null)



Gets signatures

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class FindSignaturesExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string | A list of fields and values to filter by, in query string format eg. 'type=order&status=1' (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by (optional) 
            var offset = 56;  // int? | The start offset of the result set (optional) 
            var limit = 56;  // int? | Max records to return (optional) 

            try
            {
                List&lt;Signature&gt; result = apiInstance.FindSignatures(filter, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FindSignatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| A list of fields and values to filter by, in query string format eg. &#39;type&#x3D;order&amp;status&#x3D;1&#39; | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by | [optional] 
 **offset** | **int?**| The start offset of the result set | [optional] 
 **limit** | **int?**| Max records to return | [optional] 

### Return type

[**List<Signature>**](Signature.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsnippets"></a>
# **FindSnippets**
> List<Snippet> FindSnippets (string filter = null, string sort = null, int? offset = null, int? limit = null)



Gets snippets

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class FindSnippetsExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string | A list of fields and values to filter by, in query string format eg. 'type=order&status=1' (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by (optional) 
            var offset = 56;  // int? | The start offset of the result set (optional) 
            var limit = 56;  // int? | Max records to return (optional) 

            try
            {
                List&lt;Snippet&gt; result = apiInstance.FindSnippets(filter, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FindSnippets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| A list of fields and values to filter by, in query string format eg. &#39;type&#x3D;order&amp;status&#x3D;1&#39; | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by | [optional] 
 **offset** | **int?**| The start offset of the result set | [optional] 
 **limit** | **int?**| Max records to return | [optional] 

### Return type

[**List<Snippet>**](Snippet.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtemplates"></a>
# **FindTemplates**
> List<Template> FindTemplates (string filter = null, string sort = null, int? offset = null, int? limit = null)



Gets templates

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class FindTemplatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string | A list of fields and values to filter by, in query string format eg. 'type=order&status=1' (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by (optional) 
            var offset = 56;  // int? | The start offset of the result set (optional) 
            var limit = 56;  // int? | Max records to return (optional) 

            try
            {
                List&lt;Template&gt; result = apiInstance.FindTemplates(filter, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FindTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| A list of fields and values to filter by, in query string format eg. &#39;type&#x3D;order&amp;status&#x3D;1&#39; | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by | [optional] 
 **offset** | **int?**| The start offset of the result set | [optional] 
 **limit** | **int?**| Max records to return | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findusers"></a>
# **FindUsers**
> List<User> FindUsers (string filter = null, string sort = null, int? offset = null, int? limit = null)



Gets users

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class FindUsersExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string | A list of fields and values to filter by, in query string format eg. 'type=order&status=1' (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by (optional) 
            var offset = 56;  // int? | The start offset of the result set (optional) 
            var limit = 56;  // int? | Max records to return (optional) 

            try
            {
                List&lt;User&gt; result = apiInstance.FindUsers(filter, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FindUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| A list of fields and values to filter by, in query string format eg. &#39;type&#x3D;order&amp;status&#x3D;1&#39; | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by | [optional] 
 **offset** | **int?**| The start offset of the result set | [optional] 
 **limit** | **int?**| Max records to return | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateaddressauthcode"></a>
# **GenerateAddressAuthCode**
> void GenerateAddressAuthCode (AuthCodeRequest data)



Generates a one-time auth code for an address

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GenerateAddressAuthCodeExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var data = new AuthCodeRequest(); // AuthCodeRequest | 

            try
            {
                apiInstance.GenerateAddressAuthCode(data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GenerateAddressAuthCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**AuthCodeRequest**](AuthCodeRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateaddressauthcodebyid"></a>
# **GenerateAddressAuthCodeById**
> AuthCode GenerateAddressAuthCodeById (long? id)



Generates a one-time auth code for an address

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GenerateAddressAuthCodeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of address

            try
            {
                AuthCode result = apiInstance.GenerateAddressAuthCodeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GenerateAddressAuthCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of address | 

### Return type

[**AuthCode**](AuthCode.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddress"></a>
# **GetAddress**
> Address GetAddress (long? id)



Gets an address with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of address to get

            try
            {
                Address result = apiInstance.GetAddress(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of address to get | 

### Return type

[**Address**](Address.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddresstoken"></a>
# **GetAddressToken**
> JSONWebToken GetAddressToken (LoginDetails data)



Request JWT for Address

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetAddressTokenExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var data = new LoginDetails(); // LoginDetails | 

            try
            {
                JSONWebToken result = apiInstance.GetAddressToken(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAddressToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**LoginDetails**](LoginDetails.md)|  | 

### Return type

[**JSONWebToken**](JSONWebToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfile"></a>
# **GetFile**
> FileObject GetFile (long? id)



Gets a file with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetFileExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of file to get

            try
            {
                FileObject result = apiInstance.GetFile(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of file to get | 

### Return type

[**FileObject**](FileObject.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getglobaltemplate"></a>
# **GetGlobalTemplate**
> GlobalTemplate GetGlobalTemplate (long? id)



Gets a global template with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetGlobalTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of global template to get

            try
            {
                GlobalTemplate result = apiInstance.GetGlobalTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGlobalTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of global template to get | 

### Return type

[**GlobalTemplate**](GlobalTemplate.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsignature"></a>
# **GetSignature**
> Signature GetSignature (long? id)



Gets a signature with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetSignatureExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of signature to get

            try
            {
                Signature result = apiInstance.GetSignature(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of signature to get | 

### Return type

[**Signature**](Signature.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsnippet"></a>
# **GetSnippet**
> Snippet GetSnippet (long? id)



Gets a snippet with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetSnippetExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of snippet to get

            try
            {
                Snippet result = apiInstance.GetSnippet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of snippet to get | 

### Return type

[**Snippet**](Snippet.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplate"></a>
# **GetTemplate**
> Template GetTemplate (long? id)



Gets a template with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of template to get

            try
            {
                Template result = apiInstance.GetTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of template to get | 

### Return type

[**Template**](Template.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> User GetUser (long? id)



Gets a user with the specified ID

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 789;  // long? | ID of user to get

            try
            {
                User result = apiInstance.GetUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of user to get | 

### Return type

[**User**](User.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertoken"></a>
# **GetUserToken**
> JSONWebToken GetUserToken (LoginDetails data)



Request JWT for User

### Example
```csharp
using System;
using System.Diagnostics;
using Squiggle.Api;
using Squiggle.Client;
using Squiggle.Model;

namespace Example
{
    public class GetUserTokenExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var data = new LoginDetails(); // LoginDetails | 

            try
            {
                JSONWebToken result = apiInstance.GetUserToken(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUserToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**LoginDetails**](LoginDetails.md)|  | 

### Return type

[**JSONWebToken**](JSONWebToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


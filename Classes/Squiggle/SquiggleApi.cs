using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using Squiggle.Client;
using Squiggle.Model;

namespace Squiggle
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISquiggleApi
    {
        
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>AddressResponseMultiple</returns>
        AddressResponseMultiple FindAddresses (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>AddressResponseSingle</returns>
        AddressResponseSingle AddAddress (Address data);
        
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param>
        /// <returns>AddressResponseSingle</returns>
        AddressResponseSingle GetAddress (long? id);
        
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param>
        /// <returns></returns>
        void DeleteAddress (long? id);
        
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>AddressResponseSingle</returns>
        AddressResponseSingle EditAddress (long? id, Address data);
        
        /// <summary>
        ///  Gets files
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>FileResponseMultiple</returns>
        FileResponseMultiple FindFiles (int? offset, int? limit);
        
        /// <summary>
        ///  Upload a new file
        /// </summary>
        /// <param name="file"></param>
        /// <param name="name"></param>
        /// <returns>FileResponseSingle</returns>
        FileResponseSingle AddFile (Stream file, string name);
        
        /// <summary>
        ///  Gets a file with the specified ID
        /// </summary>
        /// <param name="id">ID of file to get</param>
        /// <returns>FileResponseSingle</returns>
        FileResponseSingle GetFile (long? id);
        
        /// <summary>
        ///  Deletes a file with the specified ID
        /// </summary>
        /// <param name="id">ID of file to delete</param>
        /// <returns></returns>
        void DeleteFile (long? id);
        
        /// <summary>
        ///  Updates an existing file with the specified ID
        /// </summary>
        /// <param name="id">ID of file to update</param>
        /// <param name="file"></param>
        /// <param name="name"></param>
        /// <returns>FileResponseSingle</returns>
        FileResponseSingle EditFile (long? id, Stream file, string name);
        
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>GlobalTemplateResponseMultiple</returns>
        GlobalTemplateResponseMultiple FindGlobalTemplates (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>GlobalTemplateResponseSingle</returns>
        GlobalTemplateResponseSingle AddGlobalTemplate (GlobalTemplate data);
        
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param>
        /// <returns>GlobalTemplateResponseSingle</returns>
        GlobalTemplateResponseSingle GetGlobalTemplate (long? id);
        
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param>
        /// <returns></returns>
        void DeleteGlobalTemplate (long? id);
        
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>GlobalTemplateResponseSingle</returns>
        GlobalTemplateResponseSingle EditGlobalTemplate (long? id, GlobalTemplate data);
        
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>SnippetResponseMultiple</returns>
        SnippetResponseMultiple FindSnippets (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param>
        /// <returns>SnippetResponseSingle</returns>
        SnippetResponseSingle AddSnippet (Snippet data);
        
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>SnippetResponseSingle</returns>
        SnippetResponseSingle GetSnippet (long? id);
        
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns></returns>
        void DeleteSnippet (long? id);
        
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>SnippetResponseSingle</returns>
        SnippetResponseSingle EditSnippet (long? id, Snippet data);
        
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>TemplateResponseMultiple</returns>
        TemplateResponseMultiple FindTemplates (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>TemplateResponseSingle</returns>
        TemplateResponseSingle AddTemplate (Template data);
        
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param>
        /// <returns>TemplateResponseSingle</returns>
        TemplateResponseSingle GetTemplate (long? id);
        
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param>
        /// <returns></returns>
        void DeleteTemplate (long? id);
        
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>TemplateResponseSingle</returns>
        TemplateResponseSingle EditTemplate (long? id, Template data);
        
        /// <summary>
        ///  Request JWT for Address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>JSONWebTokenResponse</returns>
        JSONWebTokenResponse GetAddressToken (LoginDetails data);
        
        /// <summary>
        ///  Request JWT for User
        /// </summary>
        /// <param name="data"></param>
        /// <returns>JSONWebTokenResponse</returns>
        JSONWebTokenResponse GetUserToken (LoginDetails data);
        
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>UserResponseMultiple</returns>
        UserResponseMultiple FindUsers (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns>UserResponseSingle</returns>
        UserResponseSingle AddUser (User data);
        
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param>
        /// <returns>UserResponseSingle</returns>
        UserResponseSingle GetUser (long? id);
        
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param>
        /// <returns></returns>
        void DeleteUser (long? id);
        
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>UserResponseSingle</returns>
        UserResponseSingle EditUser (long? id, User data);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SquiggleApi : ISquiggleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SquiggleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SquiggleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SquiggleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SquiggleApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>AddressResponseMultiple</returns>            
        public AddressResponseMultiple FindAddresses (int? offset, int? limit)
        {
            
    
            var path = "/addresses";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindAddresses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindAddresses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AddressResponseMultiple) ApiClient.Deserialize(response.Content, typeof(AddressResponseMultiple), response.Headers);
        }
    
        
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>AddressResponseSingle</returns>            
        public AddressResponseSingle AddAddress (Address data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddAddress");
            
    
            var path = "/addresses";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AddressResponseSingle) ApiClient.Deserialize(response.Content, typeof(AddressResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param> 
        /// <returns>AddressResponseSingle</returns>            
        public AddressResponseSingle GetAddress (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAddress");
            
    
            var path = "/addresses/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AddressResponseSingle) ApiClient.Deserialize(response.Content, typeof(AddressResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param> 
        /// <returns></returns>            
        public void DeleteAddress (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAddress");
            
    
            var path = "/addresses/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param> 
        /// <param name="data"></param> 
        /// <returns>AddressResponseSingle</returns>            
        public AddressResponseSingle EditAddress (long? id, Address data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditAddress");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditAddress");
            
    
            var path = "/addresses/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AddressResponseSingle) ApiClient.Deserialize(response.Content, typeof(AddressResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets files
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>FileResponseMultiple</returns>            
        public FileResponseMultiple FindFiles (int? offset, int? limit)
        {
            
    
            var path = "/files";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindFiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindFiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponseMultiple) ApiClient.Deserialize(response.Content, typeof(FileResponseMultiple), response.Headers);
        }
    
        
        /// <summary>
        ///  Upload a new file
        /// </summary>
        /// <param name="file"></param> 
        /// <param name="name"></param> 
        /// <returns>FileResponseSingle</returns>            
        public FileResponseSingle AddFile (Stream file, string name)
        {
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling AddFile");
            
    
            var path = "/files";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponseSingle) ApiClient.Deserialize(response.Content, typeof(FileResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets a file with the specified ID
        /// </summary>
        /// <param name="id">ID of file to get</param> 
        /// <returns>FileResponseSingle</returns>            
        public FileResponseSingle GetFile (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetFile");
            
    
            var path = "/files/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponseSingle) ApiClient.Deserialize(response.Content, typeof(FileResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Deletes a file with the specified ID
        /// </summary>
        /// <param name="id">ID of file to delete</param> 
        /// <returns></returns>            
        public void DeleteFile (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteFile");
            
    
            var path = "/files/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        
        /// <summary>
        ///  Updates an existing file with the specified ID
        /// </summary>
        /// <param name="id">ID of file to update</param> 
        /// <param name="file"></param> 
        /// <param name="name"></param> 
        /// <returns>FileResponseSingle</returns>            
        public FileResponseSingle EditFile (long? id, Stream file, string name)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditFile");
            
    
            var path = "/files/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponseSingle) ApiClient.Deserialize(response.Content, typeof(FileResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>GlobalTemplateResponseMultiple</returns>            
        public GlobalTemplateResponseMultiple FindGlobalTemplates (int? offset, int? limit)
        {
            
    
            var path = "/global-templates";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindGlobalTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindGlobalTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalTemplateResponseMultiple) ApiClient.Deserialize(response.Content, typeof(GlobalTemplateResponseMultiple), response.Headers);
        }
    
        
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>GlobalTemplateResponseSingle</returns>            
        public GlobalTemplateResponseSingle AddGlobalTemplate (GlobalTemplate data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddGlobalTemplate");
            
    
            var path = "/global-templates";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalTemplateResponseSingle) ApiClient.Deserialize(response.Content, typeof(GlobalTemplateResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param> 
        /// <returns>GlobalTemplateResponseSingle</returns>            
        public GlobalTemplateResponseSingle GetGlobalTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalTemplateResponseSingle) ApiClient.Deserialize(response.Content, typeof(GlobalTemplateResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param> 
        /// <returns></returns>            
        public void DeleteGlobalTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param> 
        /// <param name="data"></param> 
        /// <returns>GlobalTemplateResponseSingle</returns>            
        public GlobalTemplateResponseSingle EditGlobalTemplate (long? id, GlobalTemplate data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditGlobalTemplate");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalTemplateResponseSingle) ApiClient.Deserialize(response.Content, typeof(GlobalTemplateResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>SnippetResponseMultiple</returns>            
        public SnippetResponseMultiple FindSnippets (int? offset, int? limit)
        {
            
    
            var path = "/snippets";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindSnippets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindSnippets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SnippetResponseMultiple) ApiClient.Deserialize(response.Content, typeof(SnippetResponseMultiple), response.Headers);
        }
    
        
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>SnippetResponseSingle</returns>            
        public SnippetResponseSingle AddSnippet (Snippet data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddSnippet");
            
    
            var path = "/snippets";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SnippetResponseSingle) ApiClient.Deserialize(response.Content, typeof(SnippetResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param> 
        /// <returns>SnippetResponseSingle</returns>            
        public SnippetResponseSingle GetSnippet (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSnippet");
            
    
            var path = "/snippets/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SnippetResponseSingle) ApiClient.Deserialize(response.Content, typeof(SnippetResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param> 
        /// <returns></returns>            
        public void DeleteSnippet (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSnippet");
            
    
            var path = "/snippets/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param> 
        /// <param name="data"></param> 
        /// <returns>SnippetResponseSingle</returns>            
        public SnippetResponseSingle EditSnippet (long? id, Snippet data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditSnippet");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditSnippet");
            
    
            var path = "/snippets/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SnippetResponseSingle) ApiClient.Deserialize(response.Content, typeof(SnippetResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>TemplateResponseMultiple</returns>            
        public TemplateResponseMultiple FindTemplates (int? offset, int? limit)
        {
            
    
            var path = "/templates";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResponseMultiple) ApiClient.Deserialize(response.Content, typeof(TemplateResponseMultiple), response.Headers);
        }
    
        
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>TemplateResponseSingle</returns>            
        public TemplateResponseSingle AddTemplate (Template data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddTemplate");
            
    
            var path = "/templates";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResponseSingle) ApiClient.Deserialize(response.Content, typeof(TemplateResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param> 
        /// <returns>TemplateResponseSingle</returns>            
        public TemplateResponseSingle GetTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTemplate");
            
    
            var path = "/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResponseSingle) ApiClient.Deserialize(response.Content, typeof(TemplateResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param> 
        /// <returns></returns>            
        public void DeleteTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTemplate");
            
    
            var path = "/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param> 
        /// <param name="data"></param> 
        /// <returns>TemplateResponseSingle</returns>            
        public TemplateResponseSingle EditTemplate (long? id, Template data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditTemplate");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditTemplate");
            
    
            var path = "/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResponseSingle) ApiClient.Deserialize(response.Content, typeof(TemplateResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Request JWT for Address
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>JSONWebTokenResponse</returns>            
        public JSONWebTokenResponse GetAddressToken (LoginDetails data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling GetAddressToken");
            
    
            var path = "/token/address";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddressToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddressToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JSONWebTokenResponse) ApiClient.Deserialize(response.Content, typeof(JSONWebTokenResponse), response.Headers);
        }
    
        
        /// <summary>
        ///  Request JWT for User
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>JSONWebTokenResponse</returns>            
        public JSONWebTokenResponse GetUserToken (LoginDetails data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling GetUserToken");
            
    
            var path = "/token/user";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JSONWebTokenResponse) ApiClient.Deserialize(response.Content, typeof(JSONWebTokenResponse), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>UserResponseMultiple</returns>            
        public UserResponseMultiple FindUsers (int? offset, int? limit)
        {
            
    
            var path = "/users";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResponseMultiple) ApiClient.Deserialize(response.Content, typeof(UserResponseMultiple), response.Headers);
        }
    
        
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>UserResponseSingle</returns>            
        public UserResponseSingle AddUser (User data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddUser");
            
    
            var path = "/users";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResponseSingle) ApiClient.Deserialize(response.Content, typeof(UserResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param> 
        /// <returns>UserResponseSingle</returns>            
        public UserResponseSingle GetUser (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUser");
            
    
            var path = "/users/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResponseSingle) ApiClient.Deserialize(response.Content, typeof(UserResponseSingle), response.Headers);
        }
    
        
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param> 
        /// <returns></returns>            
        public void DeleteUser (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUser");
            
    
            var path = "/users/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param> 
        /// <param name="data"></param> 
        /// <returns>UserResponseSingle</returns>            
        public UserResponseSingle EditUser (long? id, User data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditUser");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditUser");
            
    
            var path = "/users/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);
    
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResponseSingle) ApiClient.Deserialize(response.Content, typeof(UserResponseSingle), response.Headers);
        }
    
        
    }
    
}

/*
 * Planera Resa
 *
 * Sök och planera resor med Västtrafik
 *
 * The version of the OpenAPI document: v4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPositionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns journey positions within a bounding box
        /// </summary>
        /// <remarks>
        /// Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;</returns>
        List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel> PositionsGet(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0);

        /// <summary>
        /// Returns journey positions within a bounding box
        /// </summary>
        /// <remarks>
        /// Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;</returns>
        ApiResponse<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>> PositionsGetWithHttpInfo(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPositionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns journey positions within a bounding box
        /// </summary>
        /// <remarks>
        /// Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;</returns>
        System.Threading.Tasks.Task<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>> PositionsGetAsync(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns journey positions within a bounding box
        /// </summary>
        /// <remarks>
        /// Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>>> PositionsGetWithHttpInfoAsync(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPositionsApi : IPositionsApiSync, IPositionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PositionsApi : IPositionsApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PositionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PositionsApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PositionsApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PositionsApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Returns journey positions within a bounding box Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;</returns>
        public List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel> PositionsGet(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>> localVarResponse = PositionsGetWithHttpInfo(lowerLeftLat, lowerLeftLong, upperRightLat, upperRightLong, transportModes, detailsReferences, lineDesignations, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns journey positions within a bounding box Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>> PositionsGetWithHttpInfo(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "lowerLeftLat", lowerLeftLat));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "lowerLeftLong", lowerLeftLong));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "upperRightLat", upperRightLat));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "upperRightLong", upperRightLong));
            if (transportModes != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "transportModes", transportModes));
            }
            if (detailsReferences != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "detailsReferences", detailsReferences));
            }
            if (lineDesignations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "lineDesignations", lineDesignations));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "PositionsApi.PositionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (auth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>>("/positions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PositionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns journey positions within a bounding box Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>> PositionsGetAsync(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>> localVarResponse = await PositionsGetWithHttpInfoAsync(lowerLeftLat, lowerLeftLong, upperRightLat, upperRightLong, transportModes, detailsReferences, lineDesignations, limit, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns journey positions within a bounding box Sample request:                    GET /positions?lowerLeftLat&#x3D;57.721723&amp;lowerLeftLong&#x3D;12.011882&amp;upperRightLat&#x3D;57.737549&amp;upperRightLong&#x3D;12.039268&amp;limit&#x3D;100
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowerLeftLat">Lower left latitude of bounding box.</param>
        /// <param name="lowerLeftLong">Lower left longitude of bounding box.</param>
        /// <param name="upperRightLat">Upper right latitude of bounding box.</param>
        /// <param name="upperRightLong">Upper right longitude of bounding box.</param>
        /// <param name="transportModes">The transport modes to include when searching for journeys, if none specified all transport modes are included. (optional)</param>
        /// <param name="detailsReferences">Filter journeys by one or more journey details reference. (optional)</param>
        /// <param name="lineDesignations">Only journeys running the given lineDesignations (case sensitive) are part of the result. (optional)</param>
        /// <param name="limit">Maximum number of journeys in response. Range from 1 to 200. Defaults to 100 (optional, default to 100)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>>> PositionsGetWithHttpInfoAsync(double lowerLeftLat, double lowerLeftLong, double upperRightLat, double upperRightLong, List<VTApiPlaneraResaCoreModelsPositionTransportMode>? transportModes = default(List<VTApiPlaneraResaCoreModelsPositionTransportMode>?), List<string>? detailsReferences = default(List<string>?), List<string>? lineDesignations = default(List<string>?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "lowerLeftLat", lowerLeftLat));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "lowerLeftLong", lowerLeftLong));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "upperRightLat", upperRightLat));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "upperRightLong", upperRightLong));
            if (transportModes != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "transportModes", transportModes));
            }
            if (detailsReferences != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "detailsReferences", detailsReferences));
            }
            if (lineDesignations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "lineDesignations", lineDesignations));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "PositionsApi.PositionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (auth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>>("/positions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PositionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

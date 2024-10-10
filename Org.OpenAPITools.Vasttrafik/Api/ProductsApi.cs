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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Client.Auth;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns least expensive ticket products between origin and destination for adult and youth.
        /// </summary>
        /// <remarks>
        /// A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;</returns>
        List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel> ProductsJourneyticketGet(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0);

        /// <summary>
        /// Returns least expensive ticket products between origin and destination for adult and youth.
        /// </summary>
        /// <remarks>
        /// A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;</returns>
        ApiResponse<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>> ProductsJourneyticketGetWithHttpInfo(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns least expensive ticket products between origin and destination for adult and youth.
        /// </summary>
        /// <remarks>
        /// A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;</returns>
        System.Threading.Tasks.Task<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>> ProductsJourneyticketGetAsync(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns least expensive ticket products between origin and destination for adult and youth.
        /// </summary>
        /// <remarks>
        /// A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>>> ProductsJourneyticketGetWithHttpInfoAsync(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductsApi : IProductsApiSync, IProductsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductsApi : IProductsApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProductsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductsApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProductsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProductsApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Returns least expensive ticket products between origin and destination for adult and youth. A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;</returns>
        public List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel> ProductsJourneyticketGet(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>> localVarResponse = ProductsJourneyticketGetWithHttpInfo(originGid, originLatitude, originLongitude, destinationGid, destinationLatitude, destinationLongitude);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns least expensive ticket products between origin and destination for adult and youth. A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>> ProductsJourneyticketGetWithHttpInfo(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0)
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

            if (originGid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "originGid", originGid));
            }
            if (originLatitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "originLatitude", originLatitude));
            }
            if (originLongitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "originLongitude", originLongitude));
            }
            if (destinationGid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "destinationGid", destinationGid));
            }
            if (destinationLatitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "destinationLatitude", destinationLatitude));
            }
            if (destinationLongitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "destinationLongitude", destinationLongitude));
            }

            localVarRequestOptions.Operation = "ProductsApi.ProductsJourneyticketGet";
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
            var localVarResponse = this.Client.Get<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>>("/products/journeyticket", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductsJourneyticketGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns least expensive ticket products between origin and destination for adult and youth. A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>> ProductsJourneyticketGetAsync(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>> localVarResponse = await ProductsJourneyticketGetWithHttpInfoAsync(originGid, originLatitude, originLongitude, destinationGid, destinationLatitude, destinationLongitude, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns least expensive ticket products between origin and destination for adult and youth. A position reference for origin can be originGid or a LatLong specified by both originLatitude and originLongitude                A position reference for destination can be destinationGid or a LatLong specified by both destinationLatitude and destinationLongitude                For an origin or destination to be valid, either a gid or a combination of latitude and longitude must be specified. A Gid takes precedence over latitude/longitude.                Sample request:                    GET /products/journeyticket?originGid&#x3D;9021014001760000&amp;destinationGid&#x3D;9021014003980000                or                    GET /products/journeyticket?originLongitude&#x3D;12.63308&amp;originLatitude&#x3D;58.028237&amp;destinationLongitude&#x3D;11.930897&amp;destinationLatitude&#x3D;57.586085
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Vasttrafik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="originGid">The 16-digit Västtrafik gid of the origin location (which could be either a stop area (e.g. &#39;9021014001760000&#39;), a stop point (e.g. &#39;9022014001760004&#39;) or meta-station (e.g. &#39;0000000800000022&#39;)). (optional)</param>
        /// <param name="originLatitude">The latitude of the origin location. (optional)</param>
        /// <param name="originLongitude">The longitude of the origin location. (optional)</param>
        /// <param name="destinationGid">The 16-digit Västtrafik gid of the destination location (which could be either a stop area, stop point or meta-station). (optional)</param>
        /// <param name="destinationLatitude">The latitude of the destination location. (optional)</param>
        /// <param name="destinationLongitude">The longitude of the destination location. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>>> ProductsJourneyticketGetWithHttpInfoAsync(string? originGid = default(string?), double? originLatitude = default(double?), double? originLongitude = default(double?), string? destinationGid = default(string?), double? destinationLatitude = default(double?), double? destinationLongitude = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (originGid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "originGid", originGid));
            }
            if (originLatitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "originLatitude", originLatitude));
            }
            if (originLongitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "originLongitude", originLongitude));
            }
            if (destinationGid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "destinationGid", destinationGid));
            }
            if (destinationLatitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "destinationLatitude", destinationLatitude));
            }
            if (destinationLongitude != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "destinationLongitude", destinationLongitude));
            }

            localVarRequestOptions.Operation = "ProductsApi.ProductsJourneyticketGet";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<VTApiPlaneraResaWebV4ModelsProductsTicketSpecificationApiModel>>("/products/journeyticket", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductsJourneyticketGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

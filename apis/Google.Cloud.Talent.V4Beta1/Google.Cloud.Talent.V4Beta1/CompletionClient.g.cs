// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Settings for <see cref="CompletionClient"/> instances.</summary>
    public sealed partial class CompletionSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CompletionSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CompletionSettings"/>.</returns>
        public static CompletionSettings GetDefault() => new CompletionSettings();

        /// <summary>Constructs a new <see cref="CompletionSettings"/> object with default settings.</summary>
        public CompletionSettings()
        {
        }

        private CompletionSettings(CompletionSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CompleteQuerySettings = existing.CompleteQuerySettings;
            OnCopy(existing);
        }

        partial void OnCopy(CompletionSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompletionClient.CompleteQuery</c> and <c>CompletionClient.CompleteQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CompleteQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CompletionSettings"/> object.</returns>
        public CompletionSettings Clone() => new CompletionSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CompletionClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CompletionClientBuilder : gaxgrpc::ClientBuilderBase<CompletionClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CompletionSettings Settings { get; set; }

        /// <inheritdoc/>
        public override CompletionClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CompletionClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<CompletionClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CompletionClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => CompletionClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CompletionClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CompletionClient.ChannelPool;
    }

    /// <summary>Completion client wrapper, for convenient use.</summary>
    public abstract partial class CompletionClient
    {
        /// <summary>
        /// The default endpoint for the Completion service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>The default Completion scopes.</summary>
        /// <remarks>
        /// The default Completion scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/jobs</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CompletionClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CompletionSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CompletionClient"/>.</returns>
        public static async stt::Task<CompletionClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CompletionSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CompletionClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CompletionSettings"/>.</param>
        /// <returns>The created <see cref="CompletionClient"/>.</returns>
        public static CompletionClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CompletionSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CompletionClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CompletionSettings"/>.</param>
        /// <returns>The created <see cref="CompletionClient"/>.</returns>
        public static CompletionClient Create(grpccore::Channel channel, CompletionSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CompletionClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CompletionSettings"/>.</param>
        /// <returns>The created <see cref="CompletionClient"/>.</returns>
        public static CompletionClient Create(grpccore::CallInvoker callInvoker, CompletionSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Completion.CompletionClient grpcClient = new Completion.CompletionClient(callInvoker);
            return new CompletionClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,CompletionSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,CompletionSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,CompletionSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,CompletionSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC Completion client</summary>
        public virtual Completion.CompletionClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified prefix with keyword suggestions.
        /// Intended for use by a job search auto-complete search box.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompleteQueryResponse CompleteQuery(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified prefix with keyword suggestions.
        /// Intended for use by a job search auto-complete search box.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompleteQueryResponse> CompleteQueryAsync(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified prefix with keyword suggestions.
        /// Intended for use by a job search auto-complete search box.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompleteQueryResponse> CompleteQueryAsync(CompleteQueryRequest request, st::CancellationToken cancellationToken) =>
            CompleteQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Completion client wrapper implementation, for convenient use.</summary>
    public sealed partial class CompletionClientImpl : CompletionClient
    {
        private readonly gaxgrpc::ApiCall<CompleteQueryRequest, CompleteQueryResponse> _callCompleteQuery;

        /// <summary>
        /// Constructs a client wrapper for the Completion service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CompletionSettings"/> used within this client.</param>
        public CompletionClientImpl(Completion.CompletionClient grpcClient, CompletionSettings settings)
        {
            GrpcClient = grpcClient;
            CompletionSettings effectiveSettings = settings ?? CompletionSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCompleteQuery = clientHelper.BuildApiCall<CompleteQueryRequest, CompleteQueryResponse>(grpcClient.CompleteQueryAsync, grpcClient.CompleteQuery, effectiveSettings.CompleteQuerySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCompleteQuery);
            Modify_CompleteQueryApiCall(ref _callCompleteQuery);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CompleteQueryApiCall(ref gaxgrpc::ApiCall<CompleteQueryRequest, CompleteQueryResponse> call);

        partial void OnConstruction(Completion.CompletionClient grpcClient, CompletionSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Completion client</summary>
        public override Completion.CompletionClient GrpcClient { get; }

        partial void Modify_CompleteQueryRequest(ref CompleteQueryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Completes the specified prefix with keyword suggestions.
        /// Intended for use by a job search auto-complete search box.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompleteQueryResponse CompleteQuery(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteQueryRequest(ref request, ref callSettings);
            return _callCompleteQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Completes the specified prefix with keyword suggestions.
        /// Intended for use by a job search auto-complete search box.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompleteQueryResponse> CompleteQueryAsync(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteQueryRequest(ref request, ref callSettings);
            return _callCompleteQuery.Async(request, callSettings);
        }
    }
}
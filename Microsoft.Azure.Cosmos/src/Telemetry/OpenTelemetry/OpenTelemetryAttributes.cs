﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.Telemetry.OpenTelemetry
{
    using System.Net;

    internal class OpenTelemetryAttributes
    {
        internal const string NotAvailable = "NA";
        
        internal OpenTelemetryAttributes(RequestMessage requestMessage)
        {
            this.RequestContentLength = requestMessage?.Headers?.ContentLength ?? OpenTelemetryAttributes.NotAvailable;
            this.ContainerName = requestMessage?.ContainerId ?? OpenTelemetryAttributes.NotAvailable;
            this.DatabaseName = requestMessage?.DatabaseId ?? OpenTelemetryAttributes.NotAvailable;
        }

        /// <summary>
        /// StatusCode
        /// </summary>
        internal HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// RequestCharge
        /// </summary>
        internal double? RequestCharge { get; set; }

        /// <summary>
        /// RequestLength
        /// </summary>
        internal string RequestContentLength { get; set; }

        /// <summary>
        /// ResponseLength
        /// </summary>
        internal string ResponseContentLength { get; set; }

        /// <summary>
        /// DatabaseName
        /// </summary>
        internal string DatabaseName { get; set; }

        /// <summary>
        /// ContainerName
        /// </summary>
        internal string ContainerName { get; set; }

        /// <summary>
        /// ItemCount
        /// </summary>
        internal string ItemCount { get; set; }

        /// <summary>
        /// ItemCount
        /// </summary>
        internal CosmosDiagnostics Diagnostics { get; set; }
    }
}

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.SignalR
{
    public partial class JsonHubProtocolOptions
    {
        public JsonHubProtocolOptions() { }
        public bool AllowTrailingCommas { get { throw null; } set { } }
        public bool IgnoreNullValues { get { throw null; } set { } }
        public bool UseCamelCase { get { throw null; } set { } }
        public bool WriteIndented { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.SignalR.Protocol
{
    public sealed partial class JsonHubProtocol : Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol
    {
        public JsonHubProtocol() { }
        public JsonHubProtocol(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions> options) { }
        public int MinorVersion { get { throw null; } }
        public string Name { get { throw null; } }
        public Microsoft.AspNetCore.Connections.TransferFormat TransferFormat { get { throw null; } }
        public int Version { get { throw null; } }
        public System.ReadOnlyMemory<byte> GetMessageBytes(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message) { throw null; }
        public bool IsVersionSupported(int version) { throw null; }
        public bool TryParseMessage(ref System.Buffers.ReadOnlySequence<byte> input, Microsoft.AspNetCore.SignalR.IInvocationBinder binder, out Microsoft.AspNetCore.SignalR.Protocol.HubMessage message) { throw null; }
        public void WriteMessage(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message, System.Buffers.IBufferWriter<byte> output) { }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class JsonProtocolDependencyInjectionExtensions
    {
        public static TBuilder AddJsonProtocol<TBuilder>(this TBuilder builder) where TBuilder : Microsoft.AspNetCore.SignalR.ISignalRBuilder { throw null; }
        public static TBuilder AddJsonProtocol<TBuilder>(this TBuilder builder, System.Action<Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions> configure) where TBuilder : Microsoft.AspNetCore.SignalR.ISignalRBuilder { throw null; }
    }
}

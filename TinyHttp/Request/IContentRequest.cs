﻿namespace Tiny.Http
{
    /// <summary>
    /// Interface IContentRequest
    /// </summary>
    /// <seealso cref="Tiny.Http.ICommonResquest" />
    /// <seealso cref="Tiny.Http.IExecutableRequest" />
    public interface IContentRequest : ICommonResquest, IExecutableRequest
    {
        /// <summary>
        /// Withes the byte array response.
        /// </summary>
        /// <returns>IOctectStreamRequest.</returns>
        IOctectStreamRequest WithByteArrayResponse();

        /// <summary>
        /// Withes the stream response.
        /// </summary>
        /// <returns>The current request</returns>
        IStreamRequest WithStreamResponse();

        /// <summary>
        /// Serializes the with.
        /// </summary>
        /// <param name="serializer">The serializer.</param>
        /// <returns>The current request</returns>
        IRequest SerializeWith(ISerializer serializer);

        /// <summary>
        /// Deserializes the with.
        /// </summary>
        /// <param name="deserializer">The deserializer.</param>
        /// <returns>The current request</returns>
        IRequest DeserializeWith(IDeserializer deserializer);
    }
}
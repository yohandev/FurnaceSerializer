using System;

namespace FurnaceSerializer
{
    /// <summary>
    /// Serializer interface for all non-collection types
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// The type this writer supports
        /// </summary>
        Type Type { get; }
        
        /// <summary>
        /// Get the size in bytes of the value to initialize the buffer with a correct length
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns>Size in bytes or -1 for error cases</returns>
        int SizeOf(object value);
        
        /// <summary>
        /// Write the value into the buffer
        /// </summary>
        /// <param name="value">Value being written</param>
        /// <param name="buffer">Buffer to write the value into</param>
        /// <returns>Success or if buffer ran out of space</returns>
        bool Write(object value, ByteBuffer buffer);

        /// <summary>
        /// Read this serializer type from the buffer
        /// </summary>
        /// <param name="buffer">The read buffer</param>
        /// <param name="peek">Read without incrementing position</param>
        /// <returns>The read object</returns>
        object Read(ByteBuffer buffer, bool peek = false);
    }
}
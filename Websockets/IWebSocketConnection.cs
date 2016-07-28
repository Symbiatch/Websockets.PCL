using System;

namespace Websockets
{
    /// <summary>
    /// WebSocket contract.
    /// </summary>
    public interface IWebSocketConnection : IDisposable
    {
        bool IsOpen { get; }

        void Open(string url, string protocol = null);

        void Close();

        void Send(string message);
        
        void Send(byte[] message, int offset, int length);
        
        event Action OnOpened;

        event Action OnClosed;

        event Action<IWebSocketConnection> OnDispose;

        event Action<string> OnError;

        event Action<string> OnMessage;

        event Action<byte[]> OnData;
        
        event Action<string> OnLog;
    }
}

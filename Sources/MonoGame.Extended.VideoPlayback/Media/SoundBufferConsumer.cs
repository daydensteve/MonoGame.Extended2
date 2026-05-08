using System;

namespace MonoGame.Extended.VideoPlayback.Media
{
    /// <summary>
    /// Used to transfer ffmpeg audio output samples to an external consumer
    /// rather than rendering them with the native XNA/Monogame audio engine.
    /// </summary>
    internal class SoundBufferConsumer
    {
        private Action<byte[]> _callback;

        internal SoundBufferConsumer(Action<byte[]> SubmitBufferCb)
        {
            _callback = SubmitBufferCb;
        }

        public void SubmitBuffer(byte[] buffer)
        {
            _callback(buffer);
        }
    }
}

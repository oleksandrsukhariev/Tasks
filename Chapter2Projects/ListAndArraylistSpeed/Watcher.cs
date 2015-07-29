using System;
using System.Diagnostics;

namespace ListAndArraylistSpeed
{
    internal sealed class Watcher : IDisposable
    {
        private readonly Stopwatch m_stopwatch;
        private readonly string m_text;

        public Watcher(string text)
        {
            m_text = text;
            m_stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            Console.WriteLine("{0} {1}", (m_stopwatch.Elapsed), m_text);
        }

    }
}

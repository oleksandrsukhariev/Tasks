using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter5Task
{
    public class SecondProducer
    {
        public SecondProducer(Queue<string> q, SyncEvents e)
        {
            _queue = q;
            _syncEvents = e;
        }
        
        /// <summary>
        /// Generate exception and add it to queue as formated string
        /// </summary>
        public void ThreadRun()
        {
            Thread.CurrentThread.Name = "secondConsumerThread";
            var exceptions = new Exception[] { new ArgumentNullException(), new OutOfMemoryException(), new FileNotFoundException() };

            Random r = new Random();
            while (!_syncEvents.ExitThreadEvent.WaitOne(0, false))
            {
                lock (((ICollection)_queue).SyncRoot)
                {
                    while (_queue.Count < 1)
                    {
                        _queue.Enqueue(ConvertExceptionToString(exceptions));
                        _syncEvents.NewItemEvent.Set();
                        Thread.Sleep(200);
                    }
                }
            }
        }

        /// <summary>
        /// Returns formatted string with name of exception thrown and thread name
        /// </summary>
        /// <param name="exeptions"></param>
        /// <returns></returns>
        private string ConvertExceptionToString(Exception[] exeptions)
        {
            while (true)
            {
                try
                {
                    throw exeptions[new Random().Next(0, exeptions.Length)];
                }
                catch (ArgumentNullException e)
                {
                    return String.Format("Thread : {0}, throws {1}!", Thread.CurrentThread.Name, e.GetType().FullName);
                }
                catch (OutOfMemoryException e)
                {
                    return String.Format("Thread : {0}, throws {1}!", Thread.CurrentThread.Name, e.GetType().FullName);
                }
                catch (FileNotFoundException e)
                {
                    return String.Format("Thread : {0}, throws {1}!", Thread.CurrentThread.Name, e.GetType().FullName);
                }
                catch (Exception e)
                {
                    return String.Format("Thread : {0}, throws {1}!", Thread.CurrentThread.Name, e.GetType().FullName);
                }

            }
        }

        private Queue<string> _queue;
        private SyncEvents _syncEvents;
    }
}

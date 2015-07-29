﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter5Task
{
     public class SyncEvents
    {
        public SyncEvents()
        {
            _newItemEvent = new AutoResetEvent(false);
            _exitThreadEvent = new ManualResetEvent(false);
            _eventArray = new WaitHandle[2];
            _eventArray[0] = _newItemEvent;
            _eventArray[1] = _exitThreadEvent;
        }
         /// <summary>
         /// Terminate thread
         /// </summary>
        public EventWaitHandle ExitThreadEvent
        {
            get { return _exitThreadEvent; }
        }
         /// <summary>
         /// Set this event on new item create
         /// </summary>
        public EventWaitHandle NewItemEvent
        {
            get { return _newItemEvent; }
        }
        public WaitHandle[] EventArray
        {
            get { return _eventArray; }
        }

        private EventWaitHandle _newItemEvent;
        private EventWaitHandle _exitThreadEvent;
        private WaitHandle[] _eventArray;
    }
}

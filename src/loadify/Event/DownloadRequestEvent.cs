﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loadify.Spotify;

namespace loadify.Event
{
    public class DownloadRequestEvent : SessionEvent
    {
        public DownloadRequestEvent(LoadifySession session)
            : base(session)
        { }
    }
}

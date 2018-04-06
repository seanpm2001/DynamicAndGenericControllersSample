﻿using System;

namespace DynamicAndGenericControllersSample
{
    [GeneratedController("api/v1/album")]
    public class Album
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }
    }
}
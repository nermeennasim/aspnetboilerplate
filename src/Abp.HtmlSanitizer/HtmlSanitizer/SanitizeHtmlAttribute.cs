﻿using System;

namespace Abp.HtmlSanitizer.HtmlSanitizer
{
    /// <summary>
    /// Can be added to a method to enable auto sanitize html.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = true)]
    public class SanitizeHtmlAttribute : Attribute
    {
        public bool KeepChildNodes { get; set; }
        
        public bool IsDisabled { get; set; }
    }
}


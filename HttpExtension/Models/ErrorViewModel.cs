using System;
using System.Collections.Generic;

namespace HttpExtension.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class card
    {
        public int UserId { get; set; }
        public List<cardLine> lines { get; set; }
    }
    public class cardLine 
    {
        public string ProductName { get; set; }
        public int count { get; set; }
    }
}

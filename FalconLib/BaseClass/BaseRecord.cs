using System;

namespace FalconLib.BaseClass
{
    public class BaseRecord {
        public string Id { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime DeleteDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
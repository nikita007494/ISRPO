using System;

namespace ConverterApp
{
    public class Conversion
    {
        public int Id { get; set; }
        public string InputNumber { get; set; }
        public int InputBase { get; set; }
        public string OutputNumber { get; set; }
        public int OutputBase { get; set; }
        public DateTime ConversionDate { get; set; }
    }
}
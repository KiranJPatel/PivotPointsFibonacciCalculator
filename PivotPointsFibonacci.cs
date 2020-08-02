using System.ComponentModel.DataAnnotations;

namespace PivotPointsFibonacciCalculator
{
    public class PivotPoints
    {
        [Display(Name = "High Price")]
        public decimal HighPrice { get; set; }

        [Display(Name = "Low Price")]
        public decimal LowPrice { get; set; }

        [Display(Name = "Opening Price")]
        public decimal OpeningPrice { get; set; }

        [Display(Name = "Closing Price")]
        public decimal ClosingPrice { get; set; }

        [Display(Name = "Classic Resistance 1")]
        public decimal ClassicResistance1 { get; set; }

        [Display(Name = "Classic Resistance 2")]
        public decimal ClassicResistance2 { get; set; }

        [Display(Name = "Classic Resistance 3")]
        public decimal ClassicResistance3 { get; set; }

        [Display(Name = "Classic Pivot Point")]
        public decimal ClassicPivotPoint { get; set; }

        [Display(Name = "Classic Support 1")]
        public decimal ClassicSupport1 { get; set; }

        [Display(Name = "Classic Support 2")]
        public decimal ClassicSupport2 { get; set; }

        [Display(Name = "Classic Support 3")]
        public decimal ClassicSupport3 { get; set; }

        [Display(Name = "Woodie Resistance 1")]
        public decimal WoodieResistance1 { get; set; }

        [Display(Name = "Woodie Resistance 2")]
        public decimal WoodieResistance2 { get; set; }

        [Display(Name = "Woodie Pivot Point")]
        public decimal WoodiePivotPoint { get; set; }

        [Display(Name = "Woodie Support 1")]
        public decimal WoodieSupport1 { get; set; }

        [Display(Name = "Woodie Support 2")]
        public decimal WoodieSupport2 { get; set; }

        [Display(Name = "Camarilla Resistance 1")]
        public decimal CamarillaResistance1 { get; set; }

        [Display(Name = "Camarilla Resistance 2")]
        public decimal CamarillaResistance2 { get; set; }

        [Display(Name = "Camarilla Resistance 3")]
        public decimal CamarillaResistance3 { get; set; }

        [Display(Name = "Camarilla Resistance 4")]
        public decimal CamarillaResistance4 { get; set; }

        [Display(Name = "Camarilla Support 1")]
        public decimal CamarillaSupport1 { get; set; }

        [Display(Name = "Camarilla Support 2")]
        public decimal CamarillaSupport2 { get; set; }

        [Display(Name = "Camarilla Support 3")]
        public decimal CamarillaSupport3 { get; set; }

        [Display(Name = "Camarilla Support 4")]
        public decimal CamarillaSupport4 { get; set; }

        [Display(Name = "DeMark Resistance")]
        public decimal DeMarkResistance { get; set; }

        [Display(Name = "DeMark Support")]
        public decimal DeMarkSupport { get; set; }
    }

    public class FibonacciRetracements
    {
        [Display(Name = "High Price")]
        public decimal HighPrice { get; set; }

        [Display(Name = "Low Price")]
        public decimal LowPrice { get; set; }

        [Display(Name = "Target High Price")]
        public decimal TargetHighPrice { get; set; }

        [Display(Name = "Target Low Price")]
        public decimal TargetLowPrice { get; set; }

        [Display(Name = "Uptrend Retracements1 (23.6%)")]
        public decimal UptrendRetracements1 { get; set; }

        [Display(Name = "Uptrend Retracements2 (38.2%)")]
        public decimal UptrendRetracements2 { get; set; }

        [Display(Name = "Uptrend Retracements3 (50%)")]
        public decimal UptrendRetracements3 { get; set; }

        [Display(Name = "Uptrend Retracements4 (61.8%)")]
        public decimal UptrendRetracements4 { get; set; }

        [Display(Name = "Uptrend Retracement5 (76.4%)")]
        public decimal UptrendRetracements5 { get; set; }

        [Display(Name = "Uptrend Retracements6 (100%)")]
        public decimal UptrendRetracements6 { get; set; }

        [Display(Name = "Uptrend Retracements7 (138.2%)")]
        public decimal UptrendRetracements7 { get; set; }

        [Display(Name = "Uptrend Extentions1 (261.8%)")]
        public decimal UptrendExtentions1 { get; set; }

        [Display(Name = "Uptrend Extentions2 (200%)")]
        public decimal UptrendExtentions2 { get; set; }

        [Display(Name = "Uptrend Extentions3 (161.8%)")]
        public decimal UptrendExtentions3 { get; set; }

        [Display(Name = "Uptrend Extentions4 (138.2%)")]
        public decimal UptrendExtentions4 { get; set; }

        [Display(Name = "Uptrend Extentions5 (100%)")]
        public decimal UptrendExtentions5 { get; set; }

        [Display(Name = "Uptrend Extentions6 (61.8%)")]
        public decimal UptrendExtentions6 { get; set; }

        [Display(Name = "Uptrend Extentions7 (50%)")]
        public decimal UptrendExtentions7 { get; set; }

        [Display(Name = "Uptrend Extentions8 (38.2%)")]
        public decimal UptrendExtentions8 { get; set; }

        [Display(Name = "Uptrend Extentions9 (23.6%)")]
        public decimal UptrendExtentions9 { get; set; }

        [Display(Name = "Downtrend Retracements1 (23.6%)")]
        public decimal DowntrendRetracements1 { get; set; }

        [Display(Name = "Downtrend Retracements2 (38.2%)")]
        public decimal DowntrendRetracements2 { get; set; }

        [Display(Name = "Downtrend Retracements3 (50%)")]
        public decimal DowntrendRetracements3 { get; set; }

        [Display(Name = "Downtrend Retracements4 (61.8%)")]
        public decimal DowntrendRetracements4 { get; set; }

        [Display(Name = "Downtrend Retracements5 (76.4%)")]
        public decimal DowntrendRetracements5 { get; set; }

        [Display(Name = "Downtrend Retracements6 (100%)")]
        public decimal DowntrendRetracements6 { get; set; }

        [Display(Name = "Downtrend Retracements7 (138.2%)")]
        public decimal DowntrendRetracements7 { get; set; }

        [Display(Name = "Downtrend Extentions1 (261.8%)")]
        public decimal DowntrendExtentions1 { get; set; }

        [Display(Name = "Downtrend Extentions2 (200%)")]
        public decimal DowntrendExtentions2 { get; set; }

        [Display(Name = "Downtrend Extentions3 (161.8%)")]
        public decimal DowntrendExtentions3 { get; set; }

        [Display(Name = "Downtrend Extentions4 (138.2%)")]
        public decimal DowntrendExtentions4 { get; set; }

        [Display(Name = "Downtrend Extentions5 (100%)")]
        public decimal DowntrendExtentions5 { get; set; }

        [Display(Name = "Downtrend Extentions6 (61.8%)")]
        public decimal DowntrendExtentions6 { get; set; }

        [Display(Name = "Downtrend Extentions7 (50%)")]
        public decimal DowntrendExtentions7 { get; set; }

        [Display(Name = "Downtrend Extentions8 (38.2%)")]
        public decimal DowntrendExtentions8 { get; set; }

        [Display(Name = "Downtrend Extentions9 (23.6%)")]
        public decimal DowntrendExtentions9 { get; set; }
    }
}

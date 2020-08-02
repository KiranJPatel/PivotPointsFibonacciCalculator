using System;
using System.ComponentModel;

namespace PivotPointsFibonacciCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dcOpeningPrice = 0;
            decimal dcHighPrice = 0;
            decimal dcLowPrice = 0;
            decimal dcClosingPrice = 0;
            Console.WriteLine("Please Enter Opening Price:");
            if (!(decimal.TryParse(Console.ReadLine(), out dcOpeningPrice)))
            {
                Console.WriteLine("Invalid Opening Price; please try again!");
            }
            Console.WriteLine("Please Enter High Price:");
            if (!(decimal.TryParse(Console.ReadLine(), out dcHighPrice)))
            {
                Console.WriteLine("Invalid High Price; please try again!");
            }
            Console.WriteLine("Please Enter Low Price:");
            if (!(decimal.TryParse(Console.ReadLine(), out dcLowPrice)))
            {
                Console.WriteLine("Invalid Low Price; please try again!");
            }
            Console.WriteLine("Please Enter Closing Price:");
            if (!(decimal.TryParse(Console.ReadLine(), out dcClosingPrice)))
            {
                Console.WriteLine("Invalid Closing Price; please try again!");
            }


            Console.WriteLine("\n#########################################################################");
            Console.WriteLine("\nCalculated Pivot Points are:");
            PivotPoints objPivotPoints = CalculatePivotPoints(dcOpeningPrice, dcHighPrice, dcLowPrice, dcClosingPrice);
            string sPropertyName = string.Empty;
            object objPropertyValue = null;
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(objPivotPoints))
            {
                sPropertyName = descriptor.Name;
                objPropertyValue = descriptor.GetValue(objPivotPoints);
                Console.WriteLine("{0}: {1}", sPropertyName, Math.Round(Convert.ToDecimal(objPropertyValue), 2));
            }

            Console.WriteLine("\n#########################################################################");
            Console.WriteLine("\nCalculated Fibonacci Retracements are:");
           FibonacciRetracements objFibonacciRetracements = CalculateFibonacciRetracements(dcHighPrice, dcLowPrice);
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(objPivotPoints))
            {
                sPropertyName = descriptor.Name;
                objPropertyValue = descriptor.GetValue(objPivotPoints);
                Console.WriteLine("{0}: {1}", sPropertyName, Math.Round(Convert.ToDecimal(objPropertyValue), 2));
            }

            Console.WriteLine("\n#########################################################################");

            Console.ReadKey();
        }

        static PivotPoints CalculatePivotPoints(decimal dcOpeningPrice, decimal dcHighPrice, decimal dcLowPrice, decimal dcClosingPrice)
        {
            PivotPoints objPivotPoints = new PivotPoints();
            try
            {
                objPivotPoints.OpeningPrice = dcOpeningPrice;
                objPivotPoints.HighPrice = dcHighPrice;
                objPivotPoints.LowPrice = dcLowPrice;
                objPivotPoints.ClosingPrice = dcClosingPrice;


                decimal dcAveragePrice = ((objPivotPoints.HighPrice + objPivotPoints.LowPrice + objPivotPoints.ClosingPrice) / 3);
                objPivotPoints.ClassicResistance1 = ((2 * dcAveragePrice) - objPivotPoints.LowPrice);
                objPivotPoints.ClassicSupport1 = ((2 * dcAveragePrice) - objPivotPoints.HighPrice);
                objPivotPoints.ClassicResistance2 = dcAveragePrice + (objPivotPoints.HighPrice - objPivotPoints.LowPrice);
                objPivotPoints.ClassicSupport2 = dcAveragePrice - (objPivotPoints.HighPrice - objPivotPoints.LowPrice);
                objPivotPoints.ClassicResistance3 = objPivotPoints.HighPrice + 2 * (dcAveragePrice - objPivotPoints.LowPrice);
                objPivotPoints.ClassicSupport3 = objPivotPoints.LowPrice - 2 * (objPivotPoints.HighPrice - dcAveragePrice);
                objPivotPoints.ClassicPivotPoint = dcAveragePrice;

                objPivotPoints.WoodiePivotPoint = (objPivotPoints.HighPrice + objPivotPoints.LowPrice + (2 * objPivotPoints.ClosingPrice)) / 4;
                objPivotPoints.WoodieResistance1 = (2 * objPivotPoints.WoodiePivotPoint) - objPivotPoints.LowPrice;
                objPivotPoints.WoodieSupport1 = (2 * objPivotPoints.WoodiePivotPoint) - objPivotPoints.HighPrice;
                objPivotPoints.WoodieResistance2 = objPivotPoints.WoodiePivotPoint + (objPivotPoints.HighPrice - objPivotPoints.LowPrice);
                objPivotPoints.WoodieSupport2 = objPivotPoints.WoodiePivotPoint - (objPivotPoints.HighPrice - objPivotPoints.LowPrice);

                objPivotPoints.CamarillaResistance1 = objPivotPoints.ClosingPrice + ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.0833));
                objPivotPoints.CamarillaSupport1 = objPivotPoints.ClosingPrice - ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.0833));
                objPivotPoints.CamarillaResistance2 = objPivotPoints.ClosingPrice + ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.1666));
                objPivotPoints.CamarillaSupport2 = objPivotPoints.ClosingPrice - ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.1666));
                objPivotPoints.CamarillaResistance3 = objPivotPoints.ClosingPrice + ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.2500));
                objPivotPoints.CamarillaSupport3 = objPivotPoints.ClosingPrice - ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.2500));
                objPivotPoints.CamarillaResistance4 = objPivotPoints.ClosingPrice + ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.5000));
                objPivotPoints.CamarillaSupport4 = objPivotPoints.ClosingPrice - ((objPivotPoints.HighPrice - objPivotPoints.LowPrice) * Convert.ToDecimal(1.5000));
                decimal dcDeMarkFactor = 0;
                if (objPivotPoints.ClosingPrice < objPivotPoints.OpeningPrice)
                {
                    dcDeMarkFactor = (objPivotPoints.HighPrice + (objPivotPoints.LowPrice * 2) + objPivotPoints.ClosingPrice);
                }
                else if (objPivotPoints.ClosingPrice > objPivotPoints.OpeningPrice)
                {
                    dcDeMarkFactor = ((objPivotPoints.HighPrice * 2) + objPivotPoints.LowPrice + objPivotPoints.ClosingPrice);
                }
                else if (objPivotPoints.ClosingPrice == objPivotPoints.OpeningPrice)
                {
                    dcDeMarkFactor = (objPivotPoints.HighPrice + objPivotPoints.LowPrice + (objPivotPoints.ClosingPrice * 2));
                }
                objPivotPoints.DeMarkResistance = (dcDeMarkFactor / 2) - objPivotPoints.LowPrice;
                objPivotPoints.DeMarkSupport = (dcDeMarkFactor / 2) - objPivotPoints.HighPrice;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error occurred while calculating pivot points:" + ex.Message);
            }

            return objPivotPoints;
        }

        static FibonacciRetracements CalculateFibonacciRetracements(decimal dcHighPrice, decimal dcLowPrice, decimal dbPercentageAdjustment = 0)
        {
            decimal dcHighLowDiff = 0;
            FibonacciRetracements objFibonacciRetracements = new FibonacciRetracements();
            try
            {
                objFibonacciRetracements.HighPrice = dcHighPrice;
                objFibonacciRetracements.LowPrice = dcLowPrice;

                dcHighLowDiff = objFibonacciRetracements.HighPrice - objFibonacciRetracements.LowPrice;
                objFibonacciRetracements.UptrendRetracements1 = objFibonacciRetracements.HighPrice - (dcHighLowDiff * Convert.ToDecimal(0.236));
                objFibonacciRetracements.UptrendRetracements2 = objFibonacciRetracements.HighPrice - (dcHighLowDiff * Convert.ToDecimal(0.382));
                objFibonacciRetracements.UptrendRetracements3 = objFibonacciRetracements.HighPrice - (dcHighLowDiff * Convert.ToDecimal(0.5));
                objFibonacciRetracements.UptrendRetracements4 = objFibonacciRetracements.HighPrice - (dcHighLowDiff * Convert.ToDecimal(0.618));
                objFibonacciRetracements.UptrendRetracements5 = objFibonacciRetracements.HighPrice - (dcHighLowDiff * Convert.ToDecimal(0.764));
                objFibonacciRetracements.UptrendRetracements6 = objFibonacciRetracements.HighPrice - dcHighLowDiff;
                objFibonacciRetracements.UptrendRetracements7 = objFibonacciRetracements.HighPrice - (dcHighLowDiff * Convert.ToDecimal(1.382));

                objFibonacciRetracements.TargetHighPrice = dbPercentageAdjustment != 0 ? objFibonacciRetracements.HighPrice + (objFibonacciRetracements.HighPrice + Convert.ToDecimal(dbPercentageAdjustment / 100)) : 0;
                decimal dcExtentionsBase = (objFibonacciRetracements.TargetHighPrice > 0 && objFibonacciRetracements.HighPrice != objFibonacciRetracements.TargetHighPrice ? objFibonacciRetracements.TargetHighPrice : objFibonacciRetracements.HighPrice);
                objFibonacciRetracements.UptrendExtentions1 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(2.618));
                objFibonacciRetracements.UptrendExtentions2 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(2));
                objFibonacciRetracements.UptrendExtentions3 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(1.618));
                objFibonacciRetracements.UptrendExtentions4 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(1.382));
                objFibonacciRetracements.UptrendExtentions5 = dcExtentionsBase + dcHighLowDiff;
                objFibonacciRetracements.UptrendExtentions6 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(0.618));
                objFibonacciRetracements.UptrendExtentions7 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(0.5));
                objFibonacciRetracements.UptrendExtentions8 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(0.382));
                objFibonacciRetracements.UptrendExtentions9 = dcExtentionsBase + (dcHighLowDiff * Convert.ToDecimal(0.236));

                objFibonacciRetracements.DowntrendRetracements1 = objFibonacciRetracements.LowPrice + (dcHighLowDiff * Convert.ToDecimal(0.236));
                objFibonacciRetracements.DowntrendRetracements2 = objFibonacciRetracements.LowPrice + (dcHighLowDiff * Convert.ToDecimal(0.382));
                objFibonacciRetracements.DowntrendRetracements3 = objFibonacciRetracements.LowPrice + (dcHighLowDiff * Convert.ToDecimal(0.5));
                objFibonacciRetracements.DowntrendRetracements4 = objFibonacciRetracements.LowPrice + (dcHighLowDiff * Convert.ToDecimal(0.618));
                objFibonacciRetracements.DowntrendRetracements5 = objFibonacciRetracements.LowPrice + (dcHighLowDiff * Convert.ToDecimal(0.764));
                objFibonacciRetracements.DowntrendRetracements6 = objFibonacciRetracements.LowPrice + dcHighLowDiff;
                objFibonacciRetracements.DowntrendRetracements7 = objFibonacciRetracements.LowPrice + (dcHighLowDiff * Convert.ToDecimal(1.382));

                objFibonacciRetracements.TargetLowPrice = dbPercentageAdjustment != 0 ? objFibonacciRetracements.LowPrice - (objFibonacciRetracements.LowPrice * Convert.ToDecimal(dbPercentageAdjustment / 100)) : 0;
                dcExtentionsBase = (objFibonacciRetracements.TargetLowPrice > 0 && objFibonacciRetracements.LowPrice != objFibonacciRetracements.TargetLowPrice ? objFibonacciRetracements.TargetLowPrice : objFibonacciRetracements.LowPrice);
                objFibonacciRetracements.DowntrendExtentions1 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(2.618));
                objFibonacciRetracements.DowntrendExtentions2 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(2));
                objFibonacciRetracements.DowntrendExtentions3 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(1.618));
                objFibonacciRetracements.DowntrendExtentions4 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(1.382));
                objFibonacciRetracements.DowntrendExtentions5 = dcExtentionsBase - dcHighLowDiff;
                objFibonacciRetracements.DowntrendExtentions6 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(0.618));
                objFibonacciRetracements.DowntrendExtentions7 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(0.5));
                objFibonacciRetracements.DowntrendExtentions8 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(0.382));
                objFibonacciRetracements.DowntrendExtentions9 = dcExtentionsBase - (dcHighLowDiff * Convert.ToDecimal(0.236));
            }
            catch (Exception ex)
            {
                Console.WriteLine("error occurred while calculating pivot points:" + ex.Message);
            }
            return objFibonacciRetracements;
        }
    }
}

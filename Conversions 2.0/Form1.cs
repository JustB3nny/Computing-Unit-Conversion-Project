using System;
using System.Windows.Forms;

namespace Conversions_2._0
{
    public partial class Form1 : Form
    {
        // Enums that act as indexes for the conversions.

        // Distance
        public enum DistanceUnit
        {
            Metres,
            Decimetres,
            Centimetres,
            Millimetres,
            Kilometres,
            Feet,
            Inches,
            Leagues,
            NauticalLeagues,
            Microinches,
            Miles,
            Yards
        }
        // Weight
        public enum WeightUnit
        {
            Kilograms,
            Grams,
            Milligrams,
            Metric_Tons,
            Long_Tons,
            Short_Tons,
            Pounds,
            Ounces,
            Carats
        }
        // Time
        public enum TimeUnit
        {
            Minutes,
            Hours,
            Days,
            Seconds,
            Milliseconds

        }
        public Form1()
        {
            InitializeComponent();
            // Fills the listboxes using the enums.

            // Distance
            foreach (var name in Enum.GetNames(typeof(DistanceUnit)))
            {
                _fromUnit.Items.Add(name);
                _toUnit.Items.Add(name);
            }

            // Weight
            foreach (var name in Enum.GetNames(typeof(WeightUnit)))
            {
                _listWeightFrom.Items.Add(name);
                _listWeightTo.Items.Add(name);
            }

            // Time
            foreach (var name in Enum.GetNames(typeof(TimeUnit)))
            {
                _listTimeFrom.Items.Add(name);
                _listTimeTo.Items.Add(name);
            }
        }
        // Makes all textboxes numbers only
        private void _keyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Allows 1 '.' so that they an enter a decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        // Conversions

        // Distance
        public static double[] Conversions = new double[]
        {
            1,                 //Meter  
            10,                //Decimeter  
            100,               //Centimeter  
            1000,              //Millimeter  
            0.001,             //Kilometer  
            3.280839895,       //Feet  
            39.37007874,       //Inches  
            0.00020712331461,  //Leagues  
            0.00017998560115,  //Nautical leagues  
            39370078.74,       //Microinches  
            0.00062137119224,  //Miles  
            1.0936132983       //Yards  
        };
        // Weight
        public static double[] WeightConversions = new double[]
        {
            1,                 //Kilogram  
            1000,              //Gram  
            1000000,           //Milligram 
            0.001,             //Metric Ton  
            0.00098421,        //Long Ton  
            0.00110231,        //Short Ton  
            2.20462262,        //Pound  
            35.27396198,       //Ounce  
            5000,              //Carat     
        };
        // Time
        public static double[] TimeConversions = new double[]
        {
            1,                 //Minute 
            0.01666667,        //Hour
            0.00069444,        //Days 
            60,                //Seconds  
            60000              //Milliseconds     
        };

        // Converters - Converts the inputted value to meters, kilograms, minutes and uses that to convert to the final answer. Uses the enums as indexing.

        // Distance
        public static double Convert(double fromValue, DistanceUnit fromUnit, DistanceUnit toUnit)
        {
            double workingValue;

            if (fromUnit == DistanceUnit.Metres)
                workingValue = fromValue;
            else
                workingValue = fromValue / Conversions[(int)fromUnit];

            if (toUnit != DistanceUnit.Metres)
                workingValue = workingValue * Conversions[(int)toUnit];

            return workingValue;
        }
        // Weight
        public static double WeightConvert(double fromValue, WeightUnit fromUnit, WeightUnit toUnit)
        {
            double workingValue;

            if (fromUnit == WeightUnit.Kilograms)
                workingValue = fromValue;
            else
                workingValue = fromValue / WeightConversions[(int)fromUnit];

            if (toUnit != WeightUnit.Kilograms)
                workingValue = workingValue * WeightConversions[(int)toUnit];

            return workingValue;
        }
        // Time
        public static double TimeConvert(double fromValue, TimeUnit fromUnit, TimeUnit toUnit)
        {
            double workingValue;

            if (fromUnit == TimeUnit.Minutes)
                workingValue = fromValue;
            else
                workingValue = fromValue / TimeConversions[(int)fromUnit];

            if (toUnit != TimeUnit.Minutes)
                workingValue = workingValue * TimeConversions[(int)toUnit];

            return workingValue;
        }

        // Converter & validation

        // Distance
        private void _buttConvert_Click(object sender, EventArgs e)
        {
            // There isn't much point to this because they can only enter numbers anyway.
            bool _try = float.TryParse(_textFromUnit.Text, out float from);
            // Trys to do conversion. If there is an error, it catches the error and tells the user why it failed.
            try
            {
                var fromUnit = (DistanceUnit)Enum.Parse(typeof(DistanceUnit), _fromUnit.GetItemText(_fromUnit.SelectedItem));
                var toUnit = (DistanceUnit)Enum.Parse(typeof(DistanceUnit), _toUnit.GetItemText(_toUnit.SelectedItem));
                _textToUnit.Text = Convert(from, fromUnit, toUnit).ToString();
            }
            catch
            {
                MessageBox.Show("Please ensure that you select an item in each list box & have a number to convert.");
            }
        }
        // Weight
        private void _buttWeightConvert_Click(object sender, EventArgs e)
        {
            // There isn't much point to this because they can only enter numbers anyway.
            bool _try = float.TryParse(_textWeightFrom.Text, out float from);
            // Trys to do conversion. If there is an error, it catches the error and tells the user why it failed.
            try
            {
                var fromUnit = (WeightUnit)Enum.Parse(typeof(WeightUnit), _listWeightFrom.GetItemText(_listWeightFrom.SelectedItem));
                var toUnit = (WeightUnit)Enum.Parse(typeof(WeightUnit), _listWeightTo.GetItemText(_listWeightTo.SelectedItem));
                _textWeightTo.Text = WeightConvert(from, fromUnit, toUnit).ToString();
            }
            catch
            {
                MessageBox.Show("Please ensure that you select an item in each list box & have a number to convert.");
            }
        }
        // Time
        private void _buttTimeConvert_Click(object sender, EventArgs e)
        {
            // There isn't much point to this because they can only enter numbers anyway.
            bool _try = float.TryParse(_textTimeFrom.Text, out float from);
            // Trys to do conversion. If there is an error, it catches the error and tells the user why it failed.
            try
            {
                var fromUnit = (TimeUnit)Enum.Parse(typeof(TimeUnit), _listTimeFrom.GetItemText(_listTimeFrom.SelectedItem));
                var toUnit = (TimeUnit)Enum.Parse(typeof(TimeUnit), _listTimeTo.GetItemText(_listTimeTo.SelectedItem));
                _textTimeTo.Text = TimeConvert(from, fromUnit, toUnit).ToString();
            }
            catch
            {
                MessageBox.Show("Please ensure that you select an item in each list box & have a number to convert.");
            }
        }
    }
}

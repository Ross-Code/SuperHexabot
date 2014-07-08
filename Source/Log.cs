using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHexabot
{
    /// <summary>
    /// Simplistic logging class that outputs to a TextBox.
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// Target TextBox for output.
        /// </summary>
        public static TextBox Output = null;

        public static void Info( string message )
        {
            if( Output != null )
            {
                Output.Text += "Info: " + message + Environment.NewLine;
            }
        }

        public static void Warning( string message )
        {
            if (Output != null)
            {
                Output.Text += "Warning: " + message + Environment.NewLine;
            }
        }

        public static void Error( string message )
        {
            if (Output != null)
            {
                Output.Text += "Error: " + message + Environment.NewLine;
            }
        }
    }
}

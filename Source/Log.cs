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
        #region Members
        /// <summary>
        /// Target TextBox for output.
        /// </summary>
        public static TextBox Output = null;
        #endregion

        #region Methods
        /// <summary>
        /// Log an string with "Info" prepended.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Info( string message )
        {
            if( Output != null )
                Output.Text += "Info: " + message + Environment.NewLine;
        }

        /// <summary>
        /// Log an string with "Warning" prepended.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Warning( string message )
        {
            if( Output != null )
                Output.Text += "Warning: " + message + Environment.NewLine;
        }

        /// <summary>
        /// Log an string with "Error" prepended.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Error( string message )
        {
            if( Output != null )
                Output.Text += "Error: " + message + Environment.NewLine;
        }

        /// <summary>
        /// Completely clears the output TextBox.
        /// </summary>
        public static void Clear()
        {
            if( Output != null )
                Output.Text = "";
        }
        #endregion
    }
}

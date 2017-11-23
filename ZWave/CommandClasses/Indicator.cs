using System;
using System.Collections.Generic;
using System.Text;
using ZWave.Channel;

namespace ZWave.CommandClasses
{
    /// <summary>
    /// Indicator class
    /// </summary>
    public class Indicator : CommandClassBase
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="node">The z-wave node</param>
        public Indicator(Node node): base(node, CommandClass.Indicator)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ZWave.Devices.LogicHome
{
    /// <summary>
    /// LogicHome ZHC5010 switch module for FUGA® installations
    /// </summary>
    public class SwitchModule : Device
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="node">The z-wave node</param>
        public SwitchModule(Node node) : base(node)
        {
        }
    }
}

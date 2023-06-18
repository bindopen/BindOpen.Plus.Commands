﻿using BindOpen.System.Data.Meta;
using System.Collections.Generic;
using System.Linq;

namespace BindOpen.Labs.Commands
{
    /// <summary>
    /// This class represents an option specification.
    /// </summary>
    public class Option : BdoSpec, IOption
    {
        // -------------------------------------------------------------
        // CONSTRUCTORS
        // -------------------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the OptionSpec class.
        /// </summary>
        public Option()
        {
        }

        #endregion

        // -------------------------------------------------------------
        // IOption Implementation
        // -------------------------------------------------------------

        #region IOption

        /// <summary>
        /// 
        /// </summary>
        public new List<IOption> SubSpecs => base.SubSpecs.Cast<IOption>().ToList();

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LocalPIData
{
    /// <summary>
    /// PI History Data
    /// </summary>
    public class PIHisData
    {
        /// <summary>
        /// constructor
        /// </summary>
        public PIHisData()
        {
            new PI.PIFunc2("10.136.36.42", "piadmin", "");
        }

        /// <summary>
        /// Get PI History Value
        /// </summary>
        /// <param name="pn"></param>
        /// <param name="ts"></param>
        /// <returns></returns>
        public double? GetHisValue(string pn, DateTime ts)
        {
            PI.RetVal rv = (new PI.PIFunc2("10.136.36.42", "piadmin", "")).GetPointHisValue(pn, ts);
            return rv == null ? (double?)null : rv.pvalue;
        }
    }
}

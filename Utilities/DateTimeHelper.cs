﻿using System;
using System.ComponentModel;

namespace Utilities
{
    public static class DateTimeHelper
    {
        /// <summary>  
        /// 获取当前时间戳  
        /// </summary>  
        /// <param name="bflag">为真时获取10位时间戳,为假时获取13位时间戳.</param>  
        /// <returns></returns>  
        public static string GetTimeStamp(bool bflag = true)
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var ret = bflag ? Convert.ToInt64(ts.TotalSeconds).ToString() : Convert.ToInt64(ts.TotalMilliseconds).ToString();
            return ret;
        }

        public static string ToFormat(this DateTime that, DateTimeFormat format)
        {
            return that.ToString(format.ToDescription());
        }
    }

    public enum DateTimeFormat
    {
        /// <summary>
        /// 2018-01-01 下午 4:16:16
        /// </summary>
        [Description("yyyy-MM-dd tt hh:mm:ss")]
        // ReSharper disable once InconsistentNaming
        yyyy_MM_dd_tt_hh_mm_ss,
        /// <summary>
        /// 2018-01-01 16:16:16
        /// </summary>
        [Description("yyyy-MM-dd HH:mm:ss")]
        // ReSharper disable once InconsistentNaming
        yyyy_MM_dd_HH_mm_ss,
        /// <summary>
        /// 2018-01-01 星期三
        /// </summary>
        [Description("yyyy-MM-dd ddddd")]
        // ReSharper disable once InconsistentNaming
        yyyy_MM_dd_dddd,
        /// <summary>
        /// 2018-01-01
        /// </summary>
        [Description("yyyy-MM-dd")]
        // ReSharper disable once InconsistentNaming
        yyyy_MM_dd,
        /// <summary>
        /// 2018-1-1
        /// </summary>
        [Description("yyyy-M-d")]
        // ReSharper disable once InconsistentNaming
        yyyy_M_d,
        /// <summary>
        /// 18-1-1
        /// </summary>
        [Description("yy-M-d")]
        // ReSharper disable once InconsistentNaming
        yy_M_d
    }
}

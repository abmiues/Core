﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using System;

namespace CatLib
{
    /// <summary>
    /// 调试等级
    /// </summary>
    public enum DebugLevels
    {
        /// <summary>
        /// 生产环境
        /// </summary>
        [Obsolete("Please use Production")]
        Prod,

        /// <summary>
        /// 生产环境
        /// </summary>
        Production,

        /// <summary>
        /// 仿真环境
        /// </summary>
        Staging,

        /// <summary>
        /// 开发者模式
        /// </summary>
        [Obsolete("Please use Development")]
        Dev,

        /// <summary>
        /// 开发者模式
        /// </summary>
        Development,
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raysist
{
    public class Positioner
    {
        /// <summary>
        /// @brief ローカル座標
        /// </summary>
        public Vector3 LocalPosition { set; get; }

        /// <summary>
        /// @brief 行列
        /// </summary>
        public Matrix  Transform { set; get; }
    }
}

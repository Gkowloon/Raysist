﻿using System;
using DxLibDLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raysist
{
    class Player : GameContainer
    {
        /// <summary>
        /// @brief コンストラクタ
        /// </summary>
        public Player() : base()
        {
            AddComponent(new SpriteRenderer(this, "dummy.png"));
        }

        /// <summary>
        /// @brief 更新
        /// </summary>
        public override void Update()
        {
            if (DX.CheckHitKey(DX.KEY_INPUT_W) == 1)
            {
                Position.LocalPosition = new Vector3 { x = Position.LocalPosition.x, y = Position.LocalPosition.y + 1.0f, z = Position.LocalPosition.z };
            }
            else if (DX.CheckHitKey(DX.KEY_INPUT_S) == 1)
            {
                Position.LocalPosition.y += 1.0f;
            }

            if (DX.CheckHitKey(DX.KEY_INPUT_A) == 1)
            {
                Position.LocalPosition.x -= 1.0f;
            }
            else if (DX.CheckHitKey(DX.KEY_INPUT_D) == 1)
            {
                Position.LocalPosition.x += 1.0f;
            }

            base.Update();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raysist
{
    /// <summary>
    /// @brief コンテナを生成するファクトリクラス
    /// </summary>
    class ContainerFactory
    {
        /// <summary>
        /// @brief コンテナの初期化をするプロパティ
        /// </summary>
        private Action<GameContainer> CreateFunction
        {
            set;
            get;
        }

        /// <summary>
        /// @brief デフォルトコンストラクタ
        /// </summary>
        protected ContainerFactory()
        {
        }

        /// <summary>
        /// @brief コンストラクタ
        /// </summary>
        /// <param name="createFunction"></param>
        public ContainerFactory(Action<GameContainer> createFunction)
        {
            CreateFunction = createFunction;
        }

        /// <summary>
        /// @brief コンテナを生成する
        /// </summary>
        /// <returns>生成されたコンテナ</returns>
        public virtual GameContainer Create()
        {
            var ret = new GameContainer();
            CreateFunction(ret);
            return ret;
        }

        /// <summary>
        /// @brief 親が設定されたコンテナを生成する
        /// </summary>
        /// <param name="parent">親</param>
        /// <returns>生成されたコンテナ</returns>
        public virtual GameContainer Create(GameContainer parent)
        {
            var ret = new GameContainer(parent);
            CreateFunction(ret);
            return ret;
        }
    }
}

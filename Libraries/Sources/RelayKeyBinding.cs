/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
using System.Windows;
using System.Windows.Input;

namespace Cube.Xui
{
    /* --------------------------------------------------------------------- */
    ///
    /// RelayKeyBinding
    ///
    /// <summary>
    /// KeyBinding の補助クラスです。
    /// </summary>
    ///
    /// <remarks>
    /// .NET Framework 3.5 では KeyBinding.Command に Binding できない
    /// ため、補助クラスを通じて設定します。
    /// </remarks>
    ///
    /* --------------------------------------------------------------------- */
    public class RelayKeyBinding : KeyBinding
    {
        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// CommandEx
        ///
        /// <summary>
        /// ICommand オブジェクトを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public ICommand CommandEx
        {
            get => (ICommand)GetValue(CommandExProperty);
            set => SetValue(CommandExProperty, value);
        }

        /* ----------------------------------------------------------------- */
        ///
        /// CommandExProperty
        ///
        /// <summary>
        /// CommandEx の添付プロパティです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static readonly DependencyProperty CommandExProperty =
            DependencyProperty.Register(
                nameof(CommandEx),
                typeof(ICommand),
                typeof(RelayKeyBinding),
                new FrameworkPropertyMetadata((s, e) =>
                {
                    if (s is RelayKeyBinding rkb) rkb.Command = e.NewValue as ICommand;
                })
            );

        #endregion
    }
}

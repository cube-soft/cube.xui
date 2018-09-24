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
using System.Windows.Interactivity;

namespace Cube.Xui.Behaviors
{
    /* --------------------------------------------------------------------- */
    ///
    /// InvokeCommandAction
    ///
    /// <summary>
    /// Command を実行するための TriggerAction です。
    /// </summary>
    ///
    /// <remarks>
    /// .NET Framework 3.5 の InvokeActionCommand は Command の Binding が
    /// できないため、代替クラスを用意しています。
    /// </remarks>
    ///
    /* --------------------------------------------------------------------- */
    public class InvokeCommandAction : TriggerAction<DependencyObject>
    {
        #region Properties

        #region Command

        /* ----------------------------------------------------------------- */
        ///
        /// Command
        ///
        /// <summary>
        /// 実行されるコマンドを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public ICommand Command
        {
            get => _command;
            set => _command = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// CommandProperty
        ///
        /// <summary>
        /// Commad を保持するための DependencyProperty です。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached(
                nameof(Command),
                typeof(ICommand),
                typeof(InvokeCommandAction),
                new PropertyMetadata((s, e) =>
                {
                    if (s is InvokeCommandAction a) a.Command = e.NewValue as ICommand;
                })
            );

        #endregion

        #region Command

        /* ----------------------------------------------------------------- */
        ///
        /// CommandParameter
        ///
        /// <summary>
        /// コマンドのパラメータを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public object CommandParameter
        {
            get => _commandParameter;
            set => _commandParameter = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// CommandParameterProperty
        ///
        /// <summary>
        /// CommandParameter を保持するための DependencyProperty です。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.RegisterAttached(
                nameof(CommandParameter),
                typeof(object),
                typeof(InvokeCommandAction),
                new PropertyMetadata((s, e) =>
                {
                    if (s is InvokeCommandAction a) a.CommandParameter = e.NewValue;
                })
            );

        #endregion

        #endregion

        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// Invoke
        ///
        /// <summary>
        /// 処理を実行します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected override void Invoke(object notused)
        {
            if (Command != null && Command.CanExecute(CommandParameter))
            {
                Command.Execute(CommandParameter);
            }
        }

        #endregion

        #region Fields
        private ICommand _command;
        private object _commandParameter;
        #endregion
    }
}

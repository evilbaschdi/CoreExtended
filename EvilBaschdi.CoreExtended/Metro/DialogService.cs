﻿using System;
using System.Threading.Tasks;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace EvilBaschdi.CoreExtended.Metro
{
    /// <inheritdoc />
    public class DialogService : IDialogService
    {
        private readonly MetroWindow _mainWindow;

        /// <summary>
        ///     Constructor of the class
        /// </summary>
        /// <param name="mainWindow"></param>
        public DialogService(MetroWindow mainWindow)
        {
            if (mainWindow == null)
            {
                throw new ArgumentNullException(nameof(mainWindow));
            }

            _mainWindow = mainWindow ?? throw new ArgumentNullException(nameof(mainWindow));
        }

        /// <inheritdoc />
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<MessageDialogResult> ShowMessage(string title, string message)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            var options = new MetroDialogSettings
                          {
                              ColorScheme = MetroDialogColorScheme.Accented
                          };

            _mainWindow.MetroDialogOptions = options;
            return await _mainWindow.ShowMessageAsync(title, message, MessageDialogStyle.Affirmative, options);
        }

        /// <inheritdoc />
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="dialogStyle"></param>
        /// <returns></returns>
        public async Task<MessageDialogResult> ShowMessage(string title, string message, MessageDialogStyle dialogStyle)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            _mainWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;
            return await _mainWindow.ShowMessageAsync(title, message, dialogStyle, _mainWindow.MetroDialogOptions);
        }
    }
}
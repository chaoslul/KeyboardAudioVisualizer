﻿using System;
using System.Diagnostics;
using System.Reflection;
using KeyboardAudioVisualizer.Helper;
using RGB.NET.Core;

namespace KeyboardAudioVisualizer.UI
{
    public class ConfigurationViewModel : AbstractBindable
    {
        #region Properties & Fields

        public Version Version => Assembly.GetEntryAssembly().GetName().Version;

        #endregion

        #region Commands

        private ActionCommand _openHomepageCommand;
        public ActionCommand OpenHomepageCommand => _openHomepageCommand ?? (_openHomepageCommand = new ActionCommand(OpenHomepage));

        #endregion

        #region Constructors

        #endregion

        #region Methods

        private void OpenHomepage() => Process.Start("https://github.com/DarthAffe/KeyboardAudioVisualizer");

        #endregion
    }
}

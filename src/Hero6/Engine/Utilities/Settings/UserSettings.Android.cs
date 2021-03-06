﻿// <copyright file="UserSettings.Android.cs" company="Late Start Studio">
// Copyright (C) Late Start Studio
// This file is subject to the terms and conditions of the MIT license specified in the file
// 'LICENSE.CODE.md', which is a part of this source code package.
// </copyright>

#if ANDROID
namespace LateStartStudio.Hero6.Engine.Utilities.Settings
{
    using Android.App;
    using Android.Content;

    public class UserSettings : IUserSettings
    {
        private readonly ISharedPreferences preferences;
        private readonly ISharedPreferencesEditor preferencesEditor;

        public UserSettings()
        {
            this.preferences = Application.Context.GetSharedPreferences("Hero6", FileCreationMode.Private);
            this.preferencesEditor = this.preferences.Edit();
        }

        public bool IsFullScreen
        {
            get { return this.preferences.GetBoolean(nameof(this.IsFullScreen), true); }
            set { this.preferencesEditor.PutBoolean(nameof(this.IsFullScreen), value); }
        }

        public int WindowWidth
        {
            get { return this.preferences.GetInt(nameof(this.WindowWidth), 320); }
            set { this.preferencesEditor.PutInt(nameof(this.WindowWidth), value); }
        }

        public int WindowHeight
        {
            get { return this.preferences.GetInt(nameof(this.WindowHeight), 240); }
            set { this.preferencesEditor.PutInt(nameof(this.WindowHeight), value); }
        }

        public void Save()
        {
            this.preferencesEditor.Commit();
        }
    }
}
#endif

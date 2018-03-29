﻿using Crestron.SimplSharp;
using Crestron.SimplSharp.CrestronDataStore;
using Crestron.SimplSharpPro;

//using PepperDash.Essentials.Core.Http;
using PepperDash.Essentials.License;



namespace PepperDash.Essentials.Core
{
	public static class Global
	{
		public static CrestronControlSystem ControlSystem { get; set; }

		public static LicenseManager LicenseManager { get; set; }

        public static string FilePathPrefix { get; private set; }

        public static char DirectorySeparator
        {
            get
            {
                return System.IO.Path.DirectorySeparatorChar;
            }
        }

        /// <summary>
        /// Sets the file path prefix
        /// </summary>
        /// <param name="prefix"></param>
        public static void SetFilePathPrefix(string prefix)
        {
            FilePathPrefix = prefix;
        }

		static Global()
		{
			// Fire up CrestronDataStoreStatic
			var err = CrestronDataStoreStatic.InitCrestronDataStore();
			if (err != CrestronDataStore.CDS_ERROR.CDS_SUCCESS)
			{
				CrestronConsole.PrintLine("Error starting CrestronDataStoreStatic: {0}", err);
				return;
			}
		}

	}
}
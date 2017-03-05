﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace BrickYardTC
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile("BrickYard.apk")
				.StartApp();
		}

		[Test]
		public void AppLaunches()
		{
			app.WaitForElement(x => x.Id("race_cell"));
			app.Flash(x => x.Id("race_cell").Index(0));
			app.Tap(x => x.Id("race_cell").Index(0));

			app.WaitForElement(june => june.Id("tab_title").Text("TICKETS"));
			app.Tap(june => june.Id("tab_title").Text("TICKETS"));
		}
	}
}

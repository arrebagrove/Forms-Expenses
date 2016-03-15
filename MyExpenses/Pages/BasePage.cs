﻿using System;

using Xamarin.Forms;

using MyExpenses.ViewModels;

namespace MyExpenses.Pages
{
	public class BasePage : ContentPage
	{
		protected BasePage ()
		{
			BackgroundColor = Color.FromHex ("#2980b9");
			ConstructUI ();
			AddChildrenToParentLayout ();
		}

		public virtual void ConstructUI ()
		{
		}

		public virtual void AddChildrenToParentLayout ()
		{
		}

		public virtual void AddConditionalUI ()
		{
		}
	}
}
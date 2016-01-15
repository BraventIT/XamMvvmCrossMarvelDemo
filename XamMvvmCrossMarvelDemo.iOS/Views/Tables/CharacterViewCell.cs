using System;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Foundation;
using UIKit;
using XamMvvmCorssMarvelDemo.Core.Models;
using Cirrious.MvvmCross.Binding.BindingContext;
using CoreGraphics;
using XamMvvmCrossMarvelDemo.Core.ViewModels;

namespace XamMvvmCrossMarvelDemo.iOS.Tables
{
	public class CharacterViewCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("CharcaterViewCell");
		//public static nfloat RowHeight = 60f;


		MvxImageView thumbnail;
		UILabel name;

		public CharacterViewCell (IntPtr handle): base(handle)
		{
			InitCell ();

			// TODO: 8. Set the cell binding
//			this.DelayBind(() => {
//				var set = this.CreateBindingSet<CharacterViewCell, CharacterItemViewModel> ();
//				set.Bind(name).To (item => item.Name);
//				set.Bind (thumbnail).To (item => item.Thumbnail); 
//				set.Apply();
//			});

			// TODO: 9. Try to execute the first view
		}


		public static float GetCellHeight()
		{
			return 80f;
		}

		private void InitCell()
		{
			Frame = new CGRect(0, 0, ContentView.Bounds.Width, GetCellHeight());
			BackgroundColor = UIColor.Clear;

			thumbnail = new MvxImageView (new CGRect (0, 0, 80, GetCellHeight()));
			this.AddSubview (thumbnail);

			name = new UILabel (new CGRect (85, 0, ContentView.Bounds.Width - 85, GetCellHeight()));
			name.Font = UIFont.BoldSystemFontOfSize (17);
			name.Lines = 0;
			name.LineBreakMode = UILineBreakMode.WordWrap;
			this.AddSubview (name);

		}
	}
}


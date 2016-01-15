using System;
using Cirrious.MvvmCross.Binding.Touch.Views;
using UIKit;

namespace XamMvvmCrossMarvelDemo.iOS.Tables
{
	public class CharacterTableViewSource : MvxSimpleTableViewSource
	{
		public CharacterTableViewSource (UITableView tableView) : base(tableView, typeof(CharacterViewCell), CharacterViewCell.Key)
		{
		}

		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return CharacterViewCell.GetCellHeight ();
		}
	}
}


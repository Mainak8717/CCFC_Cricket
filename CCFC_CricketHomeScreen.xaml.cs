using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketHomeScreen : ContentPage
	{
		public CCFC_CricketHomeScreen()
		{
			InitializeComponent();
			ObservableCollection<CommitteeMembers> membersList = new ObservableCollection<CommitteeMembers>();
			membersList.Add(new CommitteeMembers() { imageSource = "irfan.jpg", designation = "Captain", displayName = "Mr. Irfan Ahmed"});
			membersList.Add(new CommitteeMembers() { imageSource = "irfan.jpg", designation = "Vice Captain", displayName = "Mr. Wasim Aziz"});
			membersList.Add(new CommitteeMembers() { imageSource = "mainak.jpg", designation = "Joint Secy", displayName = "Mr. Mainak Choudhury"});
			membersList.Add(new CommitteeMembers() { imageSource = "Zaffy.jpg", designation = "Joint Secy", displayName = "Mr. Zafar Aziz Khan"});

			ObservableCollection<CommitteMemberWrapper> membersListWrapper = new ObservableCollection<CommitteMemberWrapper>();
			for (int i = 0; i < membersList.Count; i++)
			{
				if (membersList.Count % 2 >= 1 )
				{
					if (i == membersList.Count - 1)
						membersListWrapper.Add(new CommitteMemberWrapper() { memberOne = membersList[i] });
					else
					{
						membersListWrapper.Add(new CommitteMemberWrapper() { memberOne = membersList[i], memberTwo = membersList[i + 1] });
						i = i + 1;
					}
				}
				else
				{
					membersListWrapper.Add(new CommitteMemberWrapper() { memberOne = membersList[i], memberTwo = membersList[i + 1] });
					i = i + 1;
				}
			}
			myList.ItemsSource = membersListWrapper;
		}

	}
}

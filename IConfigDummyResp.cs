using System;
namespace CCFC_Cricket
{
	public interface IConfigDummyResp
	{
		string ReadJsonCalendarDetailsLocalFile();
		string ReadJsonPlayerListLocalFile();
		string ReadJsonContactsLocalFile();
		string ReadJsonResultsLocalFile();
		string ReadJsonPastCaptainsLocalFile();
		string ReadJsonGalleryLocalFile();
	}
}

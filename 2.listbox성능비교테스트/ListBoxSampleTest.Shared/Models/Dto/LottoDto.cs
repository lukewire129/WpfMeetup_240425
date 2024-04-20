namespace ListBoxSampleTest.Shared.Models.Dto;

public class LottoDto
{
    public string returnValue { get; set; }
	public string drwNoDate { get; set; }
	public long totSellamnt { get; set; }
	public long firstWinamnt { get; set; }
	public long firstPrzwnerCo { get; set; }
	public long firstAccumamnt { get; set; }
	public int drwtNo1 { get; set; }
	public int drwtNo2 { get; set; }
	public int drwtNo3 { get; set; }
	public int drwtNo4{ get; set; }
	public int drwtNo5{ get; set; }
	public int drwtNo6{ get; set; }
	public int bnusNo { get; set; }
	public int drwNo { get; set; }
}

//{
//	"returnValue":"success",			// 요청결과
//	"drwNoDate":"2004-10-30",			// 날짜
//	"totSellamnt":56561977000,			// 총상금액
//	"firstWinamnt":3315315525,			// 1등 상금액
//	"firstPrzwnerCo":4,				// 1등 당첨인원
//	"firstAccumamnt":0,				// ???
//	"drwtNo1":1,					// 로또번호 1
//	"drwtNo2":7,					// 로또번호 2
//	"drwtNo3":11,					// 로또번호 3
//	"drwtNo4":23,					// 로또번호 4
//	"drwtNo5":37,					// 로또번호 5
//	"drwtNo6":42,					// 로또번호 6
//	"bnusNo":6,					// 로또 보너스 번호
//	"drwNo":100					// 로또회차
//}

using ListBoxSampleTest.Shared.Models.Dto;
using ListBoxSampleTest.Shared.Models.UI;
using RestSharp;
using System.Text.Json;

namespace ListBoxSampleTest.Shared.Services;

public class LottoService 
{
    public LottoService()
    {
    }

    public async IAsyncEnumerable<LottoModel> GetLottoNumbersAsync(int reqNo)
    {
        for (int i = 0; i < reqNo; i++)
        {
            RestClient client = new RestClient ($"https://www.dhlottery.co.kr");
            var request = new RestRequest ($"common.do?method=getLottoNumber&drwNo={i+1}");
            var response = await client.ExecuteAsync (request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                yield break;

            var data = JsonSerializer.Deserialize<LottoDto> (response.Content)!;

            if (data.returnValue == "fail")
                yield break;

            yield return new LottoModel ()
            {
                No = data.drwNo.ToString (),
                Date = data.drwNoDate,
                Numbers = new List<LottoNumber> ()
            {
                new LottoNumber(data.drwtNo1),
                new LottoNumber(data.drwtNo2),
                new LottoNumber(data.drwtNo3),
                new LottoNumber(data.drwtNo4),
                new LottoNumber(data.drwtNo5),
                new LottoNumber(data.drwtNo6),
            },
                bonusNumber = new LottoNumber (data.bnusNo)
            };
        }
    }

    public async IAsyncEnumerable<LottoModel> GetLottoNumbersAsync(int startreqNo, int endreqNo)
    {
        for (int i = startreqNo; i < endreqNo; i++)
        {
            RestClient client = new RestClient ($"https://www.dhlottery.co.kr");
            var request = new RestRequest ($"common.do?method=getLottoNumber&drwNo={i + 1}");
            var response = await client.ExecuteAsync (request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                yield break;

            var data = JsonSerializer.Deserialize<LottoDto> (response.Content)!;

            if (data.returnValue == "fail")
                yield break;

            yield return new LottoModel ()
            {
                No = data.drwNo.ToString (),
                Date = data.drwNoDate,
                Numbers = new List<LottoNumber> ()
            {
                new LottoNumber(data.drwtNo1),
                new LottoNumber(data.drwtNo2),
                new LottoNumber(data.drwtNo3),
                new LottoNumber(data.drwtNo4),
                new LottoNumber(data.drwtNo5),
                new LottoNumber(data.drwtNo6),
            },
                bonusNumber = new LottoNumber (data.bnusNo)
            };
        }
    }
}

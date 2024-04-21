namespace ListBoxSampleTest.Shared.Models.UI;

public class LottoModel
{
    public string No { get; set; }
    public string Date { get; set; }
    public List<LottoNumber> Numbers { get; set; }
    public LottoNumber bonusNumber { get; set; }
}

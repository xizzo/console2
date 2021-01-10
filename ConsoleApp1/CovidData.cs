using Newtonsoft.Json;

public class CovidData
{
    [JsonProperty("NIS5")]
    public string NIS5 { get; set; }

    [JsonProperty("DATE")]
    public string DATE { get; set; }

    [JsonProperty("TX_DESCR_NL")]
    public string TXDESCRNL { get; set; }

    [JsonProperty("TX_DESCR_FR")]
    public string TXDESCRFR { get; set; }

    [JsonProperty("TX_ADM_DSTR_DESCR_NL")]
    public string TXADMDSTRDESCRNL { get; set; }

    [JsonProperty("TX_ADM_DSTR_DESCR_FR")]
    public string TXADMDSTRDESCRFR { get; set; }

    [JsonProperty("PROVINCE")]
    public string PROVINCE { get; set; }

    [JsonProperty("REGION")]
    public string REGION { get; set; }

    [JsonProperty("CASES")]
    public string CASES { get; set; }
}






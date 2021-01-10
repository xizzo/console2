using System;

public class Class1
{
	public Class1()
	{
	}

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Root
    {
        public string NIS5 { get; set; }
        public string DATE { get; set; }
        public string TX_DESCR_NL { get; set; }
        public string TX_DESCR_FR { get; set; }
        public string TX_ADM_DSTR_DESCR_NL { get; set; }
        public string TX_ADM_DSTR_DESCR_FR { get; set; }
        public string PROVINCE { get; set; }
        public string REGION { get; set; }
        public string CASES { get; set; }
    }


}

using System.Collections.Generic;

namespace ftdCruncher.Templates.ApiResponses
{
    public class Oil
    {
        public string id { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string eiti_production_volumes { get; set; }
        public string production_volumes_units { get; set; }
        public string indep_source_production_volume { get; set; }
        public string prod_volumes_sources { get; set; }
        public string eiti_report_price { get; set; }
        public string indep_ref_price { get; set; }
        public string price_source { get; set; }
        public string total_company_payments { get; set; }
        public string total_government_receipts { get; set; }
        public string notes { get; set; }
        public string country_id { get; set; }
    }

    public class Gas
    {
        public string id { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string eiti_production_volumes { get; set; }
        public string production_volumes_units { get; set; }
        public string indep_source_production_volume { get; set; }
        public string prod_volumes_sources { get; set; }
        public string eiti_report_price { get; set; }
        public string indep_ref_price { get; set; }
        public string price_source { get; set; }
        public string total_company_payments { get; set; }
        public string total_government_receipts { get; set; }
        public string notes { get; set; }
        public string country_id { get; set; }
    }

    public class Country
    {
        public List<Oil> Oil { get; set; }
        public string countryname { get; set; }
        public List<Gas> Gas { get; set; }
    }

    public class CountryResponseRootObject
    {
        public List<Country> countries { get; set; }
    }
}

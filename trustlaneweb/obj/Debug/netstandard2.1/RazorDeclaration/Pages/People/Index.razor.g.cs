#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a38a367f9749f592ae6da4fb4643b94804d934b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace trustlaneweb.Pages.People
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 225 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/Index.razor"
       
    SfTab Tab;

    public bool EmptyField { get; set; } = false;
    public bool SameField { get; set; } = false;

    public void TabCreate()
    {
        // Tab.EnableTab(1, false);
        // Tab.EnableTab(2, false);
        // Tab.EnableTab(3, false);
    }

    public void SearchButtonClick()
    {
        //if ((StartPoint.Value == null) || (EndPoint.Value == null) || (Quota.Value == null))
        //{
        //    EmptyField = true;
        //}
        //else if (StartPoint.Value == EndPoint.Value)
        //{
        //    SameField = true;
        //}
        //else
        //{
        //    EmptyField = false;
        //    SameField = false;
        //    GridData = new List<GridFields>() {
        //    new GridFields
        //    {
        //        TrainNo = 1000,
        //        Name = "Train" + "1",
        //        Departure = StartPoint.Value,
        //        Arrival = EndPoint.Value,
        //        Availability = 30
        //    },
        //    new GridFields
        //    {
        //        TrainNo = 1002,
        //        Name = "Train" + "2",
        //        Departure = StartPoint.Value,
        //        Arrival = EndPoint.Value,
        //        Availability = 28
        //    }
        //};
        //    Tab.EnableTab(1, true);
        //    Tab.EnableTab(2, false);
        //    Tab.EnableTab(3, false);
        //    Tab.Select(1);
        //    StateHasChanged();
        //}
    }
    public void Search()
    {
        Tab.Select(0);
    }

    ///
    public int[] FilterSelected = { 1, 3 };


    public bool EnableStateDropDown = false;
    public bool EnableCitytDropDown = false;
    public string StateValue { get; set; } = null;
    public Query StateQuery { get; set; } = null;
    public string CityValue { get; set; } = null;
    public Query CityQuery { get; set; } = null;
    public void ChangeCountry(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        this.EnableStateDropDown = true;
        this.StateQuery = new Query().Where(new WhereFilter() { Field = "CountryId", Operator = "equal", value = args.Value, IgnoreCase = false, IgnoreAccent = false });
        this.StateValue = null;
        this.CityValue = null;
    }
    public void ChangeState(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        this.EnableCitytDropDown = true;
        this.CityQuery = new Query().Where(new WhereFilter() { Field = "StateId", Operator = "equal", value = args.Value, IgnoreCase = false, IgnoreAccent = false });
        this.CityValue = null;
    }
    public class State
    {
        public string StateName { get; set; }
        public string CountryId { get; set; }
        public string StateId { get; set; }
    }
    public class Countries
    {
        public string CountryName { get; set; }
        public string CountryId { get; set; }
    }
    public class city
    {
        public string CityName { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
    }
    public List<Countries> Country = new List<Countries>() {
        new Countries(){ CountryName= "Australia", CountryId= "2" },
        new Countries(){ CountryName= "United States", CountryId= "1" },
    };
    public List<State> States = new List<State>() {
        new State() { StateName= "New York", CountryId= "1", StateId= "101" },
        new State() { StateName= "Queensland", CountryId= "2", StateId= "104" },
        new State() { StateName= "Tasmania ", CountryId= "2", StateId= "105" },
        new State() { StateName= "Victoria", CountryId= "2", StateId= "106" },
        new State() { StateName= "Virginia", CountryId= "1", StateId= "102" },
        new State() { StateName= "Washington", CountryId= "1", StateId= "103" }
    };
    public List<city> cites = new List<city>()
{
         new city() { CityName = "Aberdeen", StateId= "103", CityId= "207" },
         new city() { CityName = "Albany", StateId= "101", CityId= "201" },
         new city() { CityName = "Brisbane ", StateId="104", CityId= "211" },
         new city() { CityName = "Colville ", StateId= "103", CityId= "208" },
         new city() { CityName ="Emporia", StateId= "102", CityId= "206" },
         new city() { CityName = "Hampton ", StateId= "102", CityId= "205" },
         new city() { CityName ="Hobart", StateId= "105", CityId= "213" },
         new city() { CityName ="Lockport", StateId= "101", CityId= "203" },
         new city() { CityName =  "Pasco", StateId= "103", CityId= "209" },
         new city() { CityName= "Alexandria", StateId= "102", CityId= "204" },
         new city() { CityName= "Beacon ", StateId= "101", CityId= "202" },
         new city() { CityName= "Cairns", StateId= "104", CityId= "212" },
         new city() { CityName= "Devonport", StateId= "105", CityId= "215" },
         new city() { CityName= "Geelong", StateId= "106", CityId= "218" },
         new city() { CityName= "Healesville ", StateId="106", CityId= "217" },
         new city() { CityName= "Launceston ", StateId= "105", CityId= "214" },
         new city() { CityName= "Melbourne", StateId= "106", CityId="216" },
         new city() { CityName= "Townsville", StateId= "104", CityId= "210" }
    };

    public class PrivacyRights
    {
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
    }

    public List<PrivacyRights> privacyRights = new List<PrivacyRights>()
{
         new PrivacyRights() { Language = "en-us", Summary = "The right of access to personal information collected", Description = "The right for a consumer to access from a business/data controller the information collected or categories of information collected about the consumer; right may only exist if a business sells information to a third party."},
         new PrivacyRights() { Language = "en-us", Summary = "The right of access to personal information shared with a third party", Description = "The right for a consumer to access personal information shared with third parties."},
         new PrivacyRights() { Language = "en-us", Summary = "The right to rectification", Description = "The right for a consumer to request that incorrect or outdated personal information be corrected but not deleted."},
         new PrivacyRights() { Language = "en-us", Summary = "The right to deletion", Description = "The right for a consumer to request deletion of personal information about the consumer under certain conditions."},
         new PrivacyRights() { Language = "en-us", Summary = "The right to restriction of processing ", Description = "The right for a consumer to restrict a business' ability to process personal information about the consumer."},
         new PrivacyRights() { Language = "en-us", Summary = "The right to data portability", Description = "The right for a consumer to request personal information about the consumer be disclosed in a common file format."},
         new PrivacyRights() { Language = "en-us", Summary = "The right to opt out of the sale of personal information", Description = "The right for a consumer to opt out of the sale of personal information about the consumer to third parties."},
         new PrivacyRights() { Language = "en-us", Summary = "The right against solely automated decision making", Description = "A prohibition against a business making decisions about a consumer based solely on an automated process without human input."},
         new PrivacyRights() { Language = "en-us", Summary = "A consumer private right of action", Description = "The right for a consumer to seek civil damages from a business for violations of a statute."},
         new PrivacyRights() { Language = "en-us", Summary = "A strict opt-in for the sale of personal information of a consumer less than a certain age", Description = "A restriction placed on a business to treat consumers under a certain age with an opt-in default for the sale of their personal information."},
         new PrivacyRights() { Language = "en-us", Summary = "Notice/transparency requirements ", Description = "An obligation placed on a business to provide notice to consumers about certain data practices, privacy operations, and/or privacy programs."},
         new PrivacyRights() { Language = "en-us", Summary = "Data breach notification", Description = "An obligation placed on a business to notify consumers and/or enforcement authorities about a privacy or security breach."},
         new PrivacyRights() { Language = "en-us", Summary = "Mandated risk assessment", Description = "An obligation placed on a business to conduct formal risk assessments of privacy and/or security projects or procedures."},
         new PrivacyRights() { Language = "en-us", Summary = "A prohibition on discrimination against a consumer for exercising a right", Description = "A prohibition against a business treating a consumer who exercises a consumer right differently than a consumer who does not exercise a right."},
         new PrivacyRights() { Language = "en-us", Summary = "A purpose limitation", Description = "An EU General Data Protection Regulation–style restrictive structure that prohibits the collection of personal information except for a specific purpose."},
         new PrivacyRights() { Language = "en-us", Summary = "A processing limitation", Description = "A GDPR-style restrictive structure that prohibits the processing of personal information except for a specific purpose."},
    };

    public class ComplianceList
    {
        public string Category { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public string Title { get; set; }
        public string URL { get; set; }
    }
    public List<ComplianceList> complianceList = new List<ComplianceList>()
{
         new ComplianceList() { Category = "Global", Title = "CIS Benchmark", URL = ""},
         new ComplianceList() { Category = "Global", Title = "CSA-STAR attestation", URL = ""},
         new ComplianceList() { Category = "Global", Title = "CSA-STAR certification", URL = ""},
         new ComplianceList() { Category = "Global", Title = "CSA-STAR self assessment", URL = ""},
         new ComplianceList() { Category = "Global", Title = "ISO 20000-1:2011", URL = ""},
         new ComplianceList() { Category = "Global", Title = "ISO 22301", URL = ""},
         new ComplianceList() { Category = "Global", Title = "ISO 27001", URL = ""},
         new ComplianceList() { Category = "Global", Title = "ISO 27017", URL = ""},
         new ComplianceList() { Category = "Global", Title = "ISO 27018", URL = ""},
         new ComplianceList() { Category = "Global", Title = "ISO 27701", URL = ""},
         new ComplianceList() { Category = "Global", Title = "ISO 9001", URL = ""},
         new ComplianceList() { Category = "Global", Title = "SOC", URL = ""},
         new ComplianceList() { Category = "Global", Title = "WCAG", URL = ""},

        new ComplianceList() { Category = "US Government", Title = "CJIS", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "CNSSI 1253", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "DFARS", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "DoD DISA L2, L4, L5", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "DoE 10 CFR Part 810", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "EAR (US Export Adm. Reg.)", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "FedRAMP", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "FIPS 140-2", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "IRS 1075", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "ITAR", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "NIST 800-171", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "NIST CSF", URL = "" },
        new ComplianceList() { Category = "US Government", Title = "Section 508 VPATS", URL = "" },


        new ComplianceList() { Category = "Industry", Title = "23 NYCRR Part 500", URL = "" },
        new ComplianceList() { Category = "Industry", Country = "Netherlands", Title = "AFM + DNB (Netherlands)", URL = "" },
        new ComplianceList() { Category = "Industry", Country = "Australia", Region="Australia / Pacific", Title = "APRA (Australia)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "France", Title = "AMF and ACPR (France)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "CDSA", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "US", Title = "CFTC 1.31 (US)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "UK", Title = "DPP (UK)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "EU", Title = "EBA (EU)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "UK", Title = "FACT (UK)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "UK", Title = "FCA (UK)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "FDA CFR Title 21 Part 11", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "FERPA", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "US", Title = "FFIEC (US)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Switzerland", Title = "FINMA (Switzerland)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "FINRA 4511", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Japan", Title = "FISC (Japan)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Denmark", Title = "FSA (Denmark)", URL = "" },
        new ComplianceList() { Category = "Industry",  State = "Federal Laws", Region = "North America", Country="United States", Title = "GLBA", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "GxP", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "France", Title = "HDS (France)", URL = "" },
        new ComplianceList() { Category = "Industry", State = "Federal Laws", Region = "North America", Country="United States", Title = "HIPAA / HITECH", URL = "" },
        new ComplianceList() { Category = "Industry", State = "Federal Laws", Region = "North America", Country="United States", Title = "COPPA", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "HITRUST", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Poland", Title = "KNF (Poland)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "MARS-E", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Singapor", Title = "MAS + ABS (Singapore)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "MPAA", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Belgium", Title = "NBB + FSMA (Belgium)", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Netherlands", Title = "NEN-7510 (Netherlands)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "NERC", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Canada", Title = "OSFI (Canada)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "PCI DSS", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "India", Title = "RBI + IRDAI (India)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "SEC 17a-4", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "SEC Regulation SCI", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "Shared assessments", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "SOX", URL = "" },
        new ComplianceList() { Category = "Industry",  Country = "Germany", Title = "TISAX (Germany)", URL = "" },
        new ComplianceList() { Category = "Industry", Title = "TruSight", URL = "" },

        new ComplianceList() { Category = "Regional",  Country = "Netherlands", Region="Europe", Title = "BIR 2012 (Netherlands)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "Germany", Region="Europe", Title = "C5 (Germany)", URL = "" },
        new ComplianceList() { Category = "Regional", State="North Dakota", Country = "US", Region="North America", Title = "HB 1485", URL = "" },
        new ComplianceList() { Category = "Regional", State="Maryland", Country = "US", Region="North America", Title = "SB613", URL = "" },
        new ComplianceList() { Category = "Regional", State="Massachusetts", Country = "US", Region="North America", Title = "S-120", URL = "" },
        new ComplianceList() { Category = "Regional", State="Hawaii", Country = "US", Region="North America", Title = "SB418", URL = "" },
        new ComplianceList() { Category = "Regional", State="New York", Country = "US", Region="North America", Title = "S5642", URL = "" },
        new ComplianceList() { Category = "Regional", State="California", Country = "US", Region="North America", Title = "CCPA (US-California)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "Australia", Region="Australia / Pacific", Title = "IRAP / CCSL (Australia)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "Japan", Region="Asia", Title = "CS Mark Gold (Japan)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "UK", Region="Europe", Title = "Cyber Essentials Plus (UK)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "Canada", Region="North America", Title = "Canadian Privacy Laws", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "China", Region="Asia",Title = "DJCP (China)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "EU", Region="Europe", Title = "EN 301 549 (EU)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "Spain",  Region="Europe", Title = "ENS (Spain)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "EU", Region="Europe", Title = "ENISA IAF (EU)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "EU", Region="Europe", Title = "EU Model Clauses", URL = "" },
        new ComplianceList() { Category = "Regional",Country = "EU", Region="Europe", Title = "EU-US Privacy Shield", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "China", Region="Asia", Title = "GB 18030 (China)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "EU", Region="Europe", Title = "GDPR (EU)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "UK ",Region="Europe", Title = "G-Cloud (UK)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "Germany", Region="Europe", Title = "IDW PS 951 (Germany)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "Korea", Region="Asia", Title = "ISMS (Korea)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "Germany", Region="Europe", Title = "IT Grundschutz Workbook (Germany)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "Spain", Region="Europe", Title = "LOPD (Spain)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "India", Region="Asia",Title = "MeitY (India)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "Singapore", Region="Asia",Title = "MTCS (Singapore)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "Japan", Region="Asia",Title = "My Number (Japan)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "New Zealand", Region="Australia / Pacific", Title = "NZ CC Framework (New Zealand)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "UK", Region="Europe", Title = "PASF (UK)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "Argentina", Region="South America", Title = "PDPA (Argentina)", URL = "" },
        new ComplianceList() { Category = "Regional",  Country = "Russia", Region="Europe", Title = "Personal Data Localization (Russia)", URL = "" },
        new ComplianceList() { Category = "Regional", Country = "China",Region="Asia",Title = "TRUCS (China)", URL = "" },
   };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591

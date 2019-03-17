using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Services
{
    public class MultiColumnDropDownModel
    {
        public List<DropDownRows> data { get; set; }
        public List<DropDownHeaders> fields { get; set; }

        public bool autoOpen = true;
        public bool headShow = true;
        public string fieldText = "text";
        public string fieldValue = "value";
        public string listBackgroundColor = "#f5f8fa";
        public string listBorderColor = "#34495e";
        public string filterType = "";
        public bool filterOpen = true;
        //public string filterField = "text";


    }
    public class DropDownRows
    {
        public string value { get; set; }
        public string text { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }

    }
    public class DropDownHeaders
    {
        public string name { get; set; }
        public string text { get; set; }
    }

    public class Select2Dropdown
    {
        public string id { get; set; }
        public string text { get; set; }

    }
}

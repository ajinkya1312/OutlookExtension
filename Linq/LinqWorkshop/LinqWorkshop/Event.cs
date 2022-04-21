using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkshop
{
    [Table("events")]
    public class Event
    {
        [Column("number")]
        public int Number { get; set; }
        [Column("time")]
        public DateTime Time { get; set; }
        [Column("trimmed_exe")]
        public string TrimmedExe { get; set; }
        [Column("domain")]
        public string Domain { get; set; }
        [Column("typing")]
        public bool Typing { get; set; }
        [Column("channel")]
        public string Channel { get; set; }
        [Column("context")]
        public string Context { get; set; }
        [Column("element_name")]
        public string ElementName { get; set; }
        [Column("element_type")]
        public string ElementType { get; set; }
        [Column("product_version")]
        public string ProductVersion { get; set; }
        [Column("application_context")]
        public string ApplicationContext { get; set; }
        [Column("missing_context_reason")]
        public string MissingContextReason { get; set; }
        [Column("missing_application_context_reason")]
        public string MissingApplicationContextReason { get; set; }
        [Column("extra_fields")]
        public string ExtraFields { get; set; }
        [Column("product_name")]
        public string ProductName { get; set; }
        [Column("sap_connection_string")]
        public string SapConnectionString { get; set; }
        [Column("sap_username")]
        public string SapUsername { get; set; }
        [Column("regex_replace_count")]
        public int RegexReplaceCount { get; set; }
        [Column("type_of_action")]
        public string TypeOfAction { get; set; }
        [Column("data_agent_version")]
        public string DataAgentVersion { get; set; }
        [Column("extension_version")]
        public string ExtensionVersion { get; set; }
        [Column("interval_s")]
        public double Interval_s { get; set; }
    }
}

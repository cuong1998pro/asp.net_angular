﻿namespace TeduShop.Web.Models
{
    public class MenuViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        public int GroupID { get; set; }

        public virtual MenuGroupViewModel MenuGroup { get; set; }

        public string Target { get; set; }

        public bool Status { get; set; }
    }
}
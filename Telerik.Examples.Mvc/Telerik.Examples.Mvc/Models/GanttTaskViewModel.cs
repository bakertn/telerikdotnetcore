﻿using System;
using Kendo.Mvc.UI;
using System.ComponentModel.DataAnnotations;

namespace Telerik.Examples.Mvc.Models
{
    public class GanttTaskViewModel : IGanttTask
    {
        public string TaskID { get; set; }
        public string ParentID { get; set; }

        public string Title { get; set; }

        private DateTime start;
        [Display(Name = "Start Time")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value.ToUniversalTime();
            }
        }

        private DateTime end;
        [Display(Name = "End Time")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime End
        {
            get
            {
                return end;
            }
            set
            {
                end = value.ToUniversalTime();
            }
        }

        public bool Summary { get; set; }
        public bool Expanded { get; set; }
        public decimal PercentComplete { get; set; }
        public int OrderId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evaluation.Models
{
    public enum TypeStatus { Aprovedd, Reprobated }
    public class Note
    {
        [Key]
        public string Subject { get; set; }

        public int Prom { get; set; }

        public TypeStatus Status { get; set; }

    }
}
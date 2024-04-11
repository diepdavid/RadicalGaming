using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RadicalGaming.Model
{
    public class Comment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }
    }
}

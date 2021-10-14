﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint.TagHelpers
{
    public class FeedbackTagHelper : TagHelper
    {
        public bool IsError { get; set; }

        public string Texto { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            if (!string.IsNullOrEmpty(Texto))
            {
                output.TagName = "div";

                output.Content.SetHtmlContent($@"<h5 class='text-center'>{Texto}</h5>");

                output.Attributes.SetAttribute("class", IsError == true ? "alert alert-danger" : "alert alert-success");
            }

        }

    }
}

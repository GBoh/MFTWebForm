﻿using MFTWebForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MFTWebForm.Services {
    public class TermDTO {

        //[Required(ErrorMessage = "Must enter a term name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public IList<MFTFormSubmissionDTO> MFTForms { get; set; }
        public string UserName { get; set; }
    }
}
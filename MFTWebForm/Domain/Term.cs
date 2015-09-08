using MFTWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Domain {
    public class Term {

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<MFTFormSubmission> MFTForms { get; set; }
        public string UserName { get; set; }

    }
}
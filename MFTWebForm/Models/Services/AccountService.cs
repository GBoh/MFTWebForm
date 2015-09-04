using AutoMapper;
using MFTWebForm.Models.Domain;
using MFTWebForm.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models.Services {
    public class AccountService {

        private IRepository _repo;

        public AccountService(IRepository repo) {
            _repo = repo;
        }

        public IList<MFTFormSubmissionDTO> ListMFTFormSubmissions() {
            var dtoList = new List<MFTFormSubmissionDTO>();
            var mftForms = _repo.Query<MFTFormSubmission>().ToList();

            foreach (MFTFormSubmission mft in mftForms) {
                dtoList.Add(Mapper.Map<MFTFormSubmissionDTO>(mft));
            }

            return dtoList;
        }
    }
}
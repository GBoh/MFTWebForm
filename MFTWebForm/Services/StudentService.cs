using AutoMapper;
using MFTWebForm.Domain;
using MFTWebForm.Infrastructure;
using MFTWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Services {
    public class StudentService {

        private IRepository _repo;

        public StudentService(IRepository repo) {
            _repo = repo;
        }

        public MFTFormInputViewModel ReturnDropdowns() {
            var dropDown = new MFTFormInputViewModel();

            var eventDto = new List<EventDTO>();
            var events = _repo.Query<Event>().ToList();
            foreach (var item in events) {
                eventDto.Add(Mapper.Map<EventDTO>(item));
            }

            var groupDto = new List<GroupDTO>();
            var groups = _repo.Query<Group>().ToList();
            foreach (var item in groups) {
                groupDto.Add(Mapper.Map<GroupDTO>(item));
            }

            var supervisorDto = new List<SupervisorDTO>();
            var supervisors = _repo.Query<Supervisor>().ToList();
            foreach (var item in supervisors) {
                supervisorDto.Add(Mapper.Map<SupervisorDTO>(item));
            }

            var observableDataDto  = new List<ObservableDataDTO>();
            var data = _repo.Query<ObservableData>().ToList();
            foreach (var item in data) {
                observableDataDto.Add(Mapper.Map<ObservableDataDTO>(item));
            }

            dropDown.Events = eventDto;
            dropDown.Groups = groupDto;
            dropDown.Supervisors = supervisorDto ;
            dropDown.ObservableData = observableDataDto;

            /*_repo.Query<Event>().ToList() as IList<EventDTO>;*/
            //dropDown.Groups = _repo.Query<Group>().ToList();
            //dropDown.ObservableData = _repo.Query<ObservableData>().ToList();
            //dropDown.Supervisors = _repo.Query<Supervisor>().ToList();

            return dropDown;

        }


        public IList<MFTFormSubmissionDTO> ListMFTFormSubmissions() {
            var dtoList = new List<MFTFormSubmissionDTO>();
            var mftForms = _repo.Query<MFTFormSubmission>().ToList();

            foreach (MFTFormSubmission form in mftForms) {
                dtoList.Add(Mapper.Map<MFTFormSubmissionDTO>(form));
            }

            return dtoList;
        }

        public IList<TermDTO> ListTerms(string user) {

            //var list = (from t in _repo.Query<Term>().Include(t => t.UserName)
            //        where t.UserName == user
            //        select t).ToList() as IList<TermDTO>;

            //return list;

            var dtoList = new List<TermDTO>();
            var terms = _repo.Query<Term>().ToList();

            var userList = (from t in terms where t.UserName == user select t);

            foreach (Term term in userList) {
                dtoList.Insert(0, Mapper.Map<TermDTO>(term));
            }
            return dtoList;

        }

        public void AddTerm(TermDTO term, string userName) {
            Term newTerm = new Term {
                Name = term.Name,
                UserName = userName,
            };
            _repo.Add<Term>(newTerm);
            _repo.SaveChanges();
        }

        public MFTFormSubmissionDTO AddMFTForm(MFTFormInputViewModel newInput) {
            return null;
        }
    }
}
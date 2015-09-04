using AutoMapper;
using MFTWebForm.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models.Services {
    public class AutoMapperConfig {
        public static void RegisterMaps() {
            Mapper.CreateMap<EventDTO, Event>();
            Mapper.CreateMap<GroupDTO, Group>();
            Mapper.CreateMap<MFTFormSubmissionDTO, MFTFormSubmission>();
            Mapper.CreateMap<SupervisorDTO, Supervisor>();
            Mapper.CreateMap<ObservableDataDTO, ObservableData>();

            Mapper.CreateMap<Event, EventDTO>();
            Mapper.CreateMap<Group, GroupDTO>();
            Mapper.CreateMap<MFTFormSubmission, MFTFormSubmissionDTO>();
            Mapper.CreateMap<Supervisor, SupervisorDTO>();
            Mapper.CreateMap<ObservableData, ObservableDataDTO>();
        }
    }
}
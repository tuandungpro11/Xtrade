using AutoMapper;
using TVSI.XTRADE.BO.API.Models.Model.Request.Logging;
using TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

namespace TVSI.XTRADE.BO.API.Models.AutoMapper;

public class MapperProfiles : Profile
{
    public MapperProfiles()
    {
        //LogLoginPasiot
        CreateMap<LogLoginPasiotExportRequest, LogLoginPasiotRequest>()
            .ForMember(dest =>
                    dest.PageIndex,
                opt => opt.MapFrom(src => 1))
            .ForMember(dest =>
                    dest.PageSize,
                opt => opt.MapFrom(src => int.MaxValue));

        //InsideOrder
        CreateMap<OrderListExportRequest, OrderListRequest>()
            .ForMember(dest =>
                    dest.PageIndex,
                opt => opt.MapFrom(src => 1))
            .ForMember(dest =>
                    dest.PageSize,
                opt => opt.MapFrom(src => int.MaxValue));

        //OrderHist
        CreateMap<OrderHistExportRequest, OrderHistRequest>()
            .ForMember(dest =>
                    dest.PageIndex,
                opt => opt.MapFrom(src => 1))
            .ForMember(dest =>
                    dest.PageSize,
                opt => opt.MapFrom(src => int.MaxValue));

        //OrderConditionGTD
        CreateMap<OrderConditionGTDExportRequest, OrderConditionGTDRequest>()
            .ForMember(dest =>
                    dest.PageIndex,
                opt => opt.MapFrom(src => 1))
            .ForMember(dest =>
                    dest.PageSize,
                opt => opt.MapFrom(src => int.MaxValue));

        //OrderConditionST
        CreateMap<OrderConditionSTExportRequest, OrderConditionSTRequest>()
            .ForMember(dest =>
                    dest.PageIndex,
                opt => opt.MapFrom(src => 1))
            .ForMember(dest =>
                    dest.PageSize,
                opt => opt.MapFrom(src => int.MaxValue));
    }
}